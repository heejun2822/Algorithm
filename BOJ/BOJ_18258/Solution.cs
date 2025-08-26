namespace Algorithm.BOJ.BOJ_18258
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18258/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            Queue<int> queue = new();
            int last = -1;

            for (int _ = 0; _ < N; _++)
            {
                string[] commands = sr.ReadLine()!.Split();
                switch (commands[0])
                {
                    case "push":
                        queue.Enqueue(last = int.Parse(commands[1]));
                        break;
                    case "pop":
                        sw.WriteLine(queue.TryDequeue(out int poped) ? poped : "-1");
                        break;
                    case "size":
                        sw.WriteLine(queue.Count);
                        break;
                    case "empty":
                        sw.WriteLine(queue.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sw.WriteLine(queue.TryPeek(out int peeked) ? peeked : "-1");
                        break;
                    case "back":
                        sw.WriteLine(queue.Count > 0 ? last : "-1");
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
