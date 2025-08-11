namespace Algorithm.BOJ.BOJ_29714
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_29714/input1.txt",
            "BOJ/BOJ_29714/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            Dictionary<int, int> beads = new(N);

            for (int _ = 0; _ < N; _++)
            {
                int color = ReadInt(sr);
                if (!beads.TryAdd(color, 1)) beads[color]++;
            }

            int M = N;
            int Q = ReadInt(sr);

            for (int i = 0; i < Q; i++)
            {
                int a = ReadInt(sr);
                Dictionary<int, int> beadsToEat = new(a);
                bool skip = false;

                for (int _ = 0; _ < a; _++)
                {
                    int color = ReadInt(sr);
                    if (skip) continue;
                    if (!beadsToEat.TryAdd(color, 1)) beadsToEat[color]++;
                    if (!beads.TryGetValue(color, out int cnt) || cnt < beadsToEat[color]) skip = true;
                }

                if (skip)
                {
                    sr.ReadLine();
                    continue;
                }

                foreach (int color in beadsToEat.Keys)
                    beads[color] -= beadsToEat[color];

                int b = ReadInt(sr);

                for (int _ = 0; _ < b; _++)
                {
                    int color = ReadInt(sr);
                    if (!beads.TryAdd(color, 1)) beads[color]++;
                }

                M += b - a;
            }

            if (M == 0)
            {
                sw.WriteLine(0);
            }
            else
            {
                System.Text.StringBuilder output = new($"{M}\n");

                foreach (int color in beads.Keys)
                    for (int _ = 0; _ < beads[color]; _++)
                        output.Append(color).Append(' ');

                sw.WriteLine(output);
            }

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
