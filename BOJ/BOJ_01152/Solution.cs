namespace Algorithm.BOJ.BOJ_01152
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01152/input1.txt",
            "BOJ/BOJ_01152/input2.txt",
            "BOJ/BOJ_01152/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!.Trim();
            int cnt = str.Length == 0 ? 0 : 1;
            foreach (char c in str)
            {
                if (c == ' ') cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
