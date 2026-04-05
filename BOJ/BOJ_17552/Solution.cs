namespace Algorithm.BOJ.BOJ_17552
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17552/input1.txt",
            "BOJ/BOJ_17552/input2.txt",
            "BOJ/BOJ_17552/input3.txt",
            "BOJ/BOJ_17552/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);

            SortedDictionary<int, int> weightCounts = new();

            for (int _ = 1 << n; _ > 0; _--)
            {
                int w = ReadInt(sr);
                if (!weightCounts.TryAdd(w, 1))
                    weightCounts[w]++;
            }

            int[] a = new int[n];
            int[] currWeights = new int[1 << n];
            int idx = 0;
            bool isImpossible = false;

            if (weightCounts.First(x => x.Value > 0).Key == 0)
            {
                weightCounts[0]--;
                currWeights[idx++] = 0;
            }
            else
            {
                isImpossible = true;
            }

            for (int i = 0; i < n; i++)
            {
                if (isImpossible) break;

                a[i] = weightCounts.First(x => x.Value > 0).Key;

                int size = 1 << i;
                for (int j = 0; j < size; j++)
                {
                    int newW = currWeights[j] + a[i];

                    if (!weightCounts.TryGetValue(newW, out int cnt) || cnt == 0)
                    {
                        isImpossible = true;
                        break;
                    }

                    weightCounts[newW]--;
                    currWeights[idx++] = newW;
                }
            }

            if (isImpossible)
                sw.WriteLine("impossible");
            else
                for (int i = 0; i < n; i++)
                    sw.WriteLine(a[i]);

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
