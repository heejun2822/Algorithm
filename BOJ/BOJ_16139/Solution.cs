namespace Algorithm.BOJ.BOJ_16139
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16139/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string S = sr.ReadLine()!;
            int[][] acc = new int[26][];

            int q = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < q; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                char a = char.Parse(input[0]);
                int l = int.Parse(input[1]);
                int r = int.Parse(input[2]);

                int idx = a - 'a';
                if (acc[idx] == null)
                {
                    acc[idx] = new int[S.Length + 1];
                    for (int i = 1; i <= S.Length; i++)
                    {
                        acc[idx][i] = acc[idx][i - 1];
                        if (S[i - 1] == a) acc[idx][i]++;
                    }
                }

                sw.WriteLine(acc[idx][r + 1] - acc[idx][l]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
