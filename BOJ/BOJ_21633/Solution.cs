namespace Algorithm.BOJ.BOJ_21633
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_21633/input1.txt",
            "BOJ/BOJ_21633/input2.txt",
            "BOJ/BOJ_21633/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int k = int.Parse(Console.ReadLine()!);
            double commission = Math.Clamp(25 + k / 100.0, 100, 2000);
            Console.WriteLine(commission.ToString("0.00"));
        }
    }
}
