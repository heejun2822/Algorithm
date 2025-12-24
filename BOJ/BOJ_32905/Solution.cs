namespace Algorithm.BOJ.BOJ_32905
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32905/input1.txt",
            "BOJ/BOJ_32905/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            bool isCorrect = true;

            for (int _ = 0; _ < n; _++)
            {
                string[] row = Console.ReadLine()!.Split();

                int cnt = 0;

                for (int i = 0; i < m; i++)
                    if (row[i] == "A" && cnt++ > 0)
                        break;

                if (cnt != 1)
                {
                    isCorrect = false;
                    break;
                }
            }

            Console.WriteLine(isCorrect ? "Yes" : "No");
        }
    }
}
