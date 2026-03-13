namespace Algorithm.BOJ.BOJ_01887
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01887/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int T = int.Parse(input[0]), N = int.Parse(input[1]);

            int[] constraints = new int[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine()!.Split();
                int Z = int.Parse(input[0]);
                for (int j = 1; j <= Z; j++)
                    constraints[i] |= 1 << int.Parse(input[j]);
            }

            int cnt = 0;
            TestCombination(1, 0);

            Console.WriteLine(cnt);

            void TestCombination(int ingredientNum, int combination)
            {
                if (ingredientNum > T)
                {
                    cnt++;
                    return;
                }

                TestCombination(ingredientNum + 1, combination);

                combination |= 1 << ingredientNum;

                for (int i = 0; i < N; i++)
                    if ((combination & constraints[i]) == constraints[i])
                        return;

                TestCombination(ingredientNum + 1, combination);
            }
        }
    }
}
