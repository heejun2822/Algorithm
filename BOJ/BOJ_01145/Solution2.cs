namespace Algorithm.BOJ.BOJ_01145
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01145/input1.txt",
            "BOJ/BOJ_01145/input2.txt",
            "BOJ/BOJ_01145/input3.txt",
            "BOJ/BOJ_01145/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int minLcm = int.MaxValue;

            for (int i = 0; i < 3; i++)
                for (int j = i + 1; j < 4; j++)
                    for (int k = j + 1; k < 5; k++)
                        minLcm = Math.Min(minLcm, LCM(LCM(numbers[i], numbers[j]), numbers[k]));

            Console.WriteLine(minLcm);

            int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
            int LCM(int a, int b) => a * b / GCD(a, b);
        }
    }
}
