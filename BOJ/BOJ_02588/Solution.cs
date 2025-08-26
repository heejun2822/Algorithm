namespace Algorithm.BOJ.BOJ_02588
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02588/input.txt",
        ];

        public static void Run(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine() ?? "");
            int num2 = int.Parse(Console.ReadLine() ?? "");
            int[] numbers = new int[4];
            numbers[3] = num2;
            numbers[2] = num2 / 100;
            num2 %= 100;
            numbers[1] = num2 / 10;
            numbers[0] = num2 % 10;
            foreach (int n in numbers)
            {
                Console.WriteLine(num1 * n);
            }
        }
    }
}
