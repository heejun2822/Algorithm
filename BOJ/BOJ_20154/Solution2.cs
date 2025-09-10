namespace Algorithm.BOJ.BOJ_20154
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20154/input1.txt",
            "BOJ/BOJ_20154/input2.txt",
        ];

        public static void Run(string[] args)
        {
            bool[] isOddStroke =
            {
                true, false, true, false, true, true, true, true, true, true, true, true, true,
                true, true, false, false, false, true, false, true, true, false, false, false, true
            };

            string S = Console.ReadLine()!;

            bool isOdd = false;

            foreach (char c in S)
                isOdd ^= isOddStroke[c - 'A'];

            Console.WriteLine(isOdd ? "I'm a winner!" : "You're the winner?");
        }
    }
}
