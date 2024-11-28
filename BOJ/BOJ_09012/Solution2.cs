namespace Algorithm.BOJ.BOJ_09012
{
    public class Solution2
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
            Stack<bool> stack = new();
            foreach (char c in str)
            {
                if (c == '(') stack.Push(true);
                else if (!stack.TryPop(out bool b)) return false;
            }
            return stack.Count == 0;
        }
    }
}
