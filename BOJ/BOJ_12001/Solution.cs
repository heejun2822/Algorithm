namespace Algorithm.BOJ.BOJ_12001
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_12001/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), B = ReadInt(sr);

            (int x, int y)[] cows = new (int, int)[N];
            HashSet<int> setA = new() { 0 };
            HashSet<int> setB = new() { 0 };

            for (int i = 0; i < N; i++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);
                cows[i] = (x, y);
                setA.Add(x + 1);
                setB.Add(y + 1);
            }

            int[] counts = new int[4];
            int minM = N;

            foreach (int a in setA)
            {
                foreach (int b in setB)
                {
                    Array.Fill(counts, 0);

                    foreach ((int x, int y) in cows)
                    {
                        if (x > a)
                        {
                            if (y > b) counts[0]++;
                            else counts[1]++;
                        }
                        else
                        {
                            if (y > b) counts[2]++;
                            else counts[3]++;
                        }
                    }

                    int M = counts.Max();
                    minM = Math.Min(minM, M);
                }
            }

            sw.WriteLine(minM);

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
