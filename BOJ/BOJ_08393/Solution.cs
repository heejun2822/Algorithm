namespace Algorithm.BOJ.BOJ_08393
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_08393/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int answer = (1 + n) * n / 2;
            Console.WriteLine(answer);
        }
    }
}
