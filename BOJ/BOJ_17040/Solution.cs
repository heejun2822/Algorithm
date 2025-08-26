namespace Algorithm.BOJ.BOJ_17040
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17040/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();
            int M = ReadInt();

            List<int>[] relativePastures = new List<int>[N];
            for (int i = 0; i < N; i++) relativePastures[i] = new(3);

            for (int _ = 0; _ < M; _++)
            {
                int pasture1 = ReadInt() - 1;
                int pasture2 = ReadInt() - 1;
                if (pasture1 < pasture2) (pasture1, pasture2) = (pasture2, pasture1);
                relativePastures[pasture1].Add(pasture2);
            }

            int[] grassTypes = new int[N];
            bool[] isAvailable = new bool[5];

            for (int p = 0; p < N; p++)
            {
                Array.Fill(isAvailable, true);
                foreach (int rp in relativePastures[p])
                    isAvailable[grassTypes[rp]] = false;

                for (int t = 1; t <= 4; t++)
                    if (isAvailable[t])
                    {
                        grassTypes[p] = t;
                        break;
                    }
            }

            Console.WriteLine(string.Join("", grassTypes));
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
