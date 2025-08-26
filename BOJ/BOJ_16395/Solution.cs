namespace Algorithm.BOJ.BOJ_16395
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16395/input1.txt",
            "BOJ/BOJ_16395/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            bool[] numbers = new bool[k];
            int answer = 1;
            for (int i = n - 1; i > n - k; i--)
            {
                answer *= i;
                for (int j = 2; j < k; j++)
                {
                    if (numbers[j]) continue;
                    if (answer % j != 0) continue;
                    answer /= j;
                    numbers[j] = true;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
