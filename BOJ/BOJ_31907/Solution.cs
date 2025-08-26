namespace Algorithm.BOJ.BOJ_31907
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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
            {
                for (int j = 0; j < K; j++) banner.Append('G');
                for (int j = 0; j < K; j++) banner.Append("...");
                banner.AppendLine();
            }
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++) banner.Append('.');
                for (int j = 0; j < K; j++) banner.Append('I');
                for (int j = 0; j < K; j++) banner.Append('.');
                for (int j = 0; j < K; j++) banner.Append('T');
                banner.AppendLine();
            }
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++) banner.Append("..");
                for (int j = 0; j < K; j++) banner.Append('S');
                for (int j = 0; j < K; j++) banner.Append('.');
                banner.AppendLine();
            }

            Console.Write(banner);
        }
    }
}
