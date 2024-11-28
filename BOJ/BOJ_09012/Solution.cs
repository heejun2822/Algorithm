namespace Algorithm.BOJ.BOJ_09012
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09012/input1.txt",
            "BOJ/BOJ_09012/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int T = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                sw.WriteLine(IsVPS(sr.ReadLine()!) ? "YES" : "NO");
            }

            sr.Close();
            sw.Close();
        }

        private static bool IsVPS(string str)
        {
            int nesting = 0;
            foreach (char c in str)
            {
                if (c == '(') nesting++;
                else if (--nesting < 0) return false;
            }
            return nesting == 0;
        }
    }
}
