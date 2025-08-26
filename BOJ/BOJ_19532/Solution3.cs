namespace Algorithm.BOJ.BOJ_19532
{
    public class Solution3 : SolutionBOJ<Solution3>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19532/input1.txt",
            "BOJ/BOJ_19532/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);
            int f = int.Parse(numbers[5]);
            for (int x = -999; x <= 999; x++)
            {
                for (int y = -999; y <= 999; y++)
                {
                    if (a * x + b * y == c && d * x + e * y == f)
                    {
                        Console.WriteLine($"{x} {y}");
                        return;
                    }
                }
            }
        }
    }
}
