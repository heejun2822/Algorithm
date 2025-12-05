namespace Algorithm.BOJ.BOJ_04889
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04889/input.txt",
        ];

        public static void Run(string[] args)
        {
            int tc = 1;
            string input;
            Stack<char> stack = new();
            System.Text.StringBuilder output = new();

            while ((input = Console.ReadLine()!)[0] != '-')
            {
                foreach (char c in input)
                {
                    if (c == '}' && stack.TryPeek(out char r) && r == '{')
                        stack.Pop();
                    else
                        stack.Push(c);
                }

                int cnt = 0;
                char expected = '}';

                while (stack.Count > 0)
                {
                    if (stack.Pop() != expected)
                        cnt++;
                    expected = expected == '{' ? '}' : '{';
                }

                output.AppendLine($"{tc++}. {cnt}");
            }

            Console.Write(output);
        }
    }
}
