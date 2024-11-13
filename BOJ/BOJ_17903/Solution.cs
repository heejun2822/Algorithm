namespace Algorithm.BOJ.BOJ_17903
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17903/input1.txt",
            "BOJ/BOJ_17903/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int m = int.Parse(Console.ReadLine()!.Split()[0]);
            Console.WriteLine(m < 8 ? "unsatisfactory" : "satisfactory");
        }
    }
}
