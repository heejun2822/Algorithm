namespace Algorithm.BOJ.BOJ_09324
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09324/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            int[] counts = new int[26];

            for (int _ = 0; _ < T; _++)
            {
                string M = Console.ReadLine()!;

                Array.Fill(counts, 0);

                bool isReal = true;
                int idx = -1;
                while (++idx < M.Length)
                {
                    if (++counts[M[idx] - 'A'] % 3 == 0 && (++idx >= M.Length || M[idx] != M[idx - 1]))
                    {
                        isReal = false;
                        break;
                    }
                }

                Console.WriteLine(isReal ? "OK" : "FAKE");
            }
        }
    }
}
