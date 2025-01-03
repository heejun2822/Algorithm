namespace Algorithm.BOJ.BOJ_02052
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02052/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(Math.Pow(0.5, N).ToString($"N{N}"));
        }
    }
}
