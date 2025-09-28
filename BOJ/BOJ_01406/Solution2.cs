namespace Algorithm.BOJ.BOJ_01406
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01406/input1.txt",
            "BOJ/BOJ_01406/input2.txt",
            "BOJ/BOJ_01406/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            Stack<char> left = new(sr.ReadLine()!);
            Stack<char> right = new();

            int M = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < M; _++)
            {
                string[] input = sr.ReadLine()!.Split();

                if (input[0] == "L")
                {
                    if (left.Count == 0) continue;
                    right.Push(left.Pop());
                }
                else if (input[0] == "D")
                {
                    if (right.Count == 0) continue;
                    left.Push(right.Pop());
                }
                else if (input[0] == "B")
                {
                    if (left.Count == 0) continue;
                    left.Pop();
                }
                else if (input[0] == "P")
                {
                    char c = char.Parse(input[1]);
                    left.Push(c);
                }
            }

            System.Text.StringBuilder output = new();

            while (left.Count > 0)
                right.Push(left.Pop());

            while (right.Count > 0)
                output.Append(right.Pop());

            sw.WriteLine(output);

            sr.Close();
            sw.Close();
        }
    }
}
