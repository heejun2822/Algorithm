namespace Algorithm.BOJ.BOJ_10784
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10784/input1.txt",
            "BOJ/BOJ_10784/input2.txt",
            "BOJ/BOJ_10784/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int p = input[0];
            int a = input[1], b = input[2], c = input[3], d = input[4];
            int n = input[5];

            double maxPrice = 0;
            double maxDecline = 0;
            for (int k = 1; k <= n; k++)
            {
                double price = p * (Math.Sin(a * k + b) + Math.Cos(c * k + d) + 2);

                maxPrice = Math.Max(maxPrice, price);
                maxDecline = Math.Max(maxDecline, maxPrice - price);
            }

            Console.WriteLine(maxDecline);
        }
    }
}
