namespace Algorithm.BOJ.BOJ_25625
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25625/input1.txt",
            "BOJ/BOJ_25625/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] inputs = Console.ReadLine()!.Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            Console.WriteLine(y < x ? y + x : y - x);
        }
    }
}
