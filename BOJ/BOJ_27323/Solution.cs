namespace Algorithm.BOJ.BOJ_27323
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_27323/input1.txt",
            "BOJ/BOJ_27323/input2.txt",
            "BOJ/BOJ_27323/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int A = int.Parse(Console.ReadLine()!);
            int B = int.Parse(Console.ReadLine()!);
            Console.WriteLine(A * B);
        }
    }
}
