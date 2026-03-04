namespace Algorithm.BOJ.BOJ_06603
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06603/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder output = new();

            int k;
            int[] S = new int[12];
            int[] C = new int[6];

            while ((k = ReadInt()) != 0)
            {
                for (int i = 0; i < k; i++)
                    S[i] = ReadInt();

                MakeCombination(0, 0);
                output.AppendLine();
            }

            Console.Write(output);

            void MakeCombination(int idxS, int idxC)
            {
                if (idxC == 6)
                {
                    for (int i = 0; i < 6; i++)
                        output.Append(C[i]).Append(' ');
                    output.AppendLine();
                    return;
                }

                if (idxS == k)
                    return;

                C[idxC] = S[idxS];
                MakeCombination(idxS + 1, idxC + 1);
                MakeCombination(idxS + 1, idxC);
            }
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
