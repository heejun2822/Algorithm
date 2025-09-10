namespace Algorithm.BOJ.BOJ_20154
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20154/input1.txt",
            "BOJ/BOJ_20154/input2.txt",
        ];

        public static void Run(string[] args)
        {
            HashSet<char> evenStrokes = new() { 'B', 'D', 'P', 'Q', 'R', 'T', 'W', 'X', 'Y' };

            string S = Console.ReadLine()!;

            bool isOdd = false;

            foreach (char c in S)
                isOdd ^= !evenStrokes.Contains(c);

            Console.WriteLine(isOdd ? "I'm a winner!" : "You're the winner?");
        }
    }
}
