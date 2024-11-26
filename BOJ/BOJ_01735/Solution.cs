namespace Algorithm.BOJ.BOJ_01735
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01735/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] num1 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] num2 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int A = num1[0] * num2[1] + num2[0] * num1[1];
            int B = num1[1] * num2[1];
            int gcd = Gcd(A, B);
            Console.WriteLine($"{A / gcd} {B / gcd}");
        }

        // 유클리드 호제법
        private static int Gcd(int a, int b)
        {
            return a % b == 0 ? b : Gcd(b, a % b);
        }
    }
}
