namespace Algorithm.BOJ.BOJ_14043
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14043/input1.txt",
            "BOJ/BOJ_14043/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[] chars = new int[26];

            foreach (char c in Console.ReadLine()!)
                chars[c - 'a']++;

            foreach (char c in Console.ReadLine()!)
                if (c != '*' && --chars[c - 'a'] < 0)
                {
                    Console.WriteLine("N");
                    return;
                }

            Console.WriteLine("A");
        }
    }
}
