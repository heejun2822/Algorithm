namespace Algorithm.BOJ.BOJ_22967
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_22967/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            HashSet<int>[] bridges = new HashSet<int>[N + 1];
            for (int i = 1; i <= N; i++) bridges[i] = new();

            for (int _ = 0; _ < N - 1; _++)
            {
                int building1 = ReadInt(), building2 = ReadInt();
                bridges[building1].Add(building2);
                bridges[building2].Add(building1);
            }

            System.Text.StringBuilder answer = new();

            if (N <= 4)
            {
                int K = N * (N - 1) / 2 - (N - 1);
                int R = 1;
                answer.AppendLine(K.ToString()).AppendLine(R.ToString());

                for (int i = 1; i <= N; i++)
                    for (int j = i + 1; j <= N; j++)
                        if (!bridges[i].Contains(j))
                            answer.AppendLine($"{i} {j}");
            }
            else
            {
                int K = N - 1 - bridges[1].Count;
                int R = 2;
                answer.AppendLine(K.ToString()).AppendLine(R.ToString());

                for (int i = 2; i <= N; i++)
                    if (!bridges[1].Contains(i))
                        answer.AppendLine($"1 {i}");
            }

            Console.Write(answer);
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
