namespace Algorithm.BOJ.BOJ_02722
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02722/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < N; _++)
            {
                int C = int.Parse(sr.ReadLine()!);
                string S1 = sr.ReadLine()!;
                string S2 = sr.ReadLine()!;
                string result = sr.ReadLine()!;

                HashSet<string> stackSet = new();

                char[] prevStack = new char[2 * C];
                char[] currStack = new char[2 * C];

                for (int i = 0; i < C; i++)
                {
                    prevStack[i] = S1[i];
                    prevStack[C + i] = S2[i];
                }

                int cnt = 0;

                while (true)
                {
                    cnt++;

                    for (int i = 0; i < C; i++)
                    {
                        currStack[2 * i] = prevStack[C + i];
                        currStack[2 * i + 1] = prevStack[i];
                    }

                    string stack = string.Join("", currStack);

                    if (stack == result)
                        break;
                    if (!stackSet.Add(stack))
                    {
                        cnt = -1;
                        break;
                    }

                    (prevStack, currStack) = (currStack, prevStack);
                }

                output.AppendLine(cnt.ToString());
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
