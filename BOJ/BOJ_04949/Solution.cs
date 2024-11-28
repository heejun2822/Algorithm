namespace Algorithm.BOJ.BOJ_04949
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04949/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            while (true)
            {
                string str = sr.ReadLine()!;
                if (str == ".") break;
                sw.WriteLine(IsBalanced(str) ? "yes" : "no");
            }

            sr.Close();
            sw.Close();
        }

        private static bool IsBalanced(string str)
        {
            Stack<char> stack = new();
            foreach (char c in str)
            {
                if (c == '(' || c == '[') stack.Push(c);
                else if (c == ')' && (!stack.TryPop(out char p) || p != '(')) return false;
                else if (c == ']' && (!stack.TryPop(out char b) || b != '[')) return false;
            }
            return stack.Count == 0;
        }
    }
}
