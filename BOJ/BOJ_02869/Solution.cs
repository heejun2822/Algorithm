namespace Algorithm.BOJ.BOJ_02869
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02869/input1.txt",
            "BOJ/BOJ_02869/input2.txt",
            "BOJ/BOJ_02869/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int V = int.Parse(input[2]);
            Console.WriteLine(Math.Ceiling((double)(V - A) / (A - B)) + 1);
        }
    }
}
