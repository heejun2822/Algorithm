namespace Algorithm.BOJ.BOJ_31867
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31867/input1.txt",
            "BOJ/BOJ_31867/input2.txt",
            "BOJ/BOJ_31867/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int diff = 0;

            for (int i = 0; i < N; i++)
            {
                int K_i = Console.Read();

                if ((K_i - '0') % 2 == 1) diff++;
                else diff--;
            }

            Console.WriteLine(diff < 0 ? "0" : diff > 0 ? "1" : "-1");
        }
    }
}
