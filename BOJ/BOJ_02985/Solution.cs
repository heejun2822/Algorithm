namespace Algorithm.BOJ.BOJ_02985
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02985/input1.txt",
            "BOJ/BOJ_02985/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Console.WriteLine(MakeEquation(numbers[0], numbers[1], numbers[2]));
        }

        private static string MakeEquation(int a, int b, int c)
        {
            if (a + b == c) return $"{a}+{b}={c}";
            if (a - b == c) return $"{a}-{b}={c}";
            if (a * b == c) return $"{a}*{b}={c}";
            if (a / b == c) return $"{a}/{b}={c}";
            if (a == b + c) return $"{a}={b}+{c}";
            if (a == b - c) return $"{a}={b}-{c}";
            if (a == b * c) return $"{a}={b}*{c}";
            return $"{a}={b}/{c}";
        }
    }
}
