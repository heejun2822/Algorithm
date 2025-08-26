namespace Algorithm.BOJ.BOJ_28278
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28278/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            Stack<string> stack = new();

            for (int _ = 0; _ < N; _++)
            {
                string[] commands = sr.ReadLine()!.Split();
                switch (commands[0])
                {
                    case "1":
                        stack.Push(commands[1]);
                        break;
                    case "2":
                        sw.WriteLine(stack.TryPop(out string? poped) ? poped : "-1");
                        break;
                    case "3":
                        sw.WriteLine(stack.Count);
                        break;
                    case "4":
                        sw.WriteLine(stack.Count == 0 ? "1" : "0");
                        break;
                    case "5":
                        sw.WriteLine(stack.TryPeek(out string? peeked) ? peeked : "-1");
                        break;
                    default:
                        break;
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
