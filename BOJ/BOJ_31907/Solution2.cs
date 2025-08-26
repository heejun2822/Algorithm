namespace Algorithm.BOJ.BOJ_31907
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31907/input1.txt",
            "BOJ/BOJ_31907/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder banner = new();

            for (int i = 0; i < K; i++)
                banner.Append(new string('G', K)).Append(new string('.', K * 3)).AppendLine();
            for (int i = 0; i < K; i++)
                banner.Append(new string('.', K)).Append(new string('I', K)).Append(new string('.', K)).Append(new string('T', K)).AppendLine();
            for (int i = 0; i < K; i++)
                banner.Append(new string('.', K * 2)).Append(new string('S', K)).Append(new string('.', K)).AppendLine();

            Console.Write(banner);
        }
    }
}
