namespace Algorithm.BOJ.BOJ_04696
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04696/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                float num = float.Parse(Console.ReadLine()!);
                if (num == 0) break;

                if (num == 1) Console.WriteLine("5.00");
                else Console.WriteLine((((float)Math.Pow(num, 5) - 1) / (num - 1)).ToString("0.00"));
            }
        }
    }
}
