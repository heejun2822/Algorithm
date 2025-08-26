namespace Algorithm.BOJ.BOJ_11656
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11656/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string S = sr.ReadLine()!;

            string[] suffixes = new string[S.Length];

            for (int i = 0; i < S.Length; i++)
                suffixes[i] = S[i..];

            Array.Sort(suffixes);

            for (int i = 0; i < S.Length; i++)
                sw.WriteLine(suffixes[i]);

            sr.Close();
            sw.Close();
        }
    }
}
