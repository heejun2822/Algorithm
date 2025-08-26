namespace Algorithm.BOJ.BOJ_09019
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09019/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] ab = sr.ReadLine()!.Split();
                int A = int.Parse(ab[0]);
                int B = int.Parse(ab[1]);

                (int prev, char command)[] trace = new (int, char)[10000];
                trace[A] = (A, ' ');

                Queue<int> queue = new();
                queue.Enqueue(A);

                while (queue.Count > 0)
                {
                    int n = queue.Dequeue();

                    (char command, int num)[] conversions = {
                        ('D', n * 2 % 10000),
                        ('S', n == 0 ? 9999 : n - 1),
                        ('L', n % 1000 * 10 + n / 1000),
                        ('R', n % 10 * 1000 + n / 10),
                    };

                    foreach ((char command, int num) in conversions)
                    {
                        if (trace[num].command != '\0') continue;

                        trace[num] = (n, command);
                        queue.Enqueue(num);

                        if (num == B) goto Found;
                    }
                }

                Found:

                Stack<char> stack = new();
                int number = B;
                while (number != A)
                {
                    stack.Push(trace[number].command);
                    number = trace[number].prev;
                }

                StringBuilder commandList = new();
                while (stack.Count > 0)
                {
                    commandList.Append(stack.Pop());
                }

                sw.WriteLine(commandList);
            }

            sr.Close();
            sw.Close();
        }
    }
}
