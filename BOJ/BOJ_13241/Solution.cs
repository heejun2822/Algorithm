namespace Algorithm.BOJ.BOJ_13241
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13241/input1.txt",
            "BOJ/BOJ_13241/input2.txt",
            "BOJ/BOJ_13241/input3.txt",
            "BOJ/BOJ_13241/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            long L = (long)A * B;
            int G = 1;
            while (B > 0)
            {
                (A, B) = (B, A % B);
                G = A;
            }
            L /= G;
            Console.WriteLine(L);
        }
    }
}
