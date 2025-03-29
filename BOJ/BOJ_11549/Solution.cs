namespace Algorithm.BOJ.BOJ_11549
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11549/input1.txt",
            "BOJ/BOJ_11549/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            int[] answers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Console.WriteLine(answers.Count(ans => ans == T));
        }
    }
}
