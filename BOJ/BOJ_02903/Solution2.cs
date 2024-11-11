namespace Algorithm.BOJ.BOJ_02903
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02903/input1.txt",
            "BOJ/BOJ_02903/input2.txt",
            "BOJ/BOJ_02903/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int sideDots = (int)Math.Pow(2, N) + 1;
            Console.WriteLine(sideDots * sideDots);
        }
    }
}
