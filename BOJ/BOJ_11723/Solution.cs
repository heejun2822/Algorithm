namespace Algorithm.BOJ.BOJ_11723
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11723/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int M = int.Parse(sr.ReadLine()!);

            int S = 0;
            System.Text.StringBuilder output = new();

            while (M-- > 0)
            {
                string[] input = sr.ReadLine()!.Split();
                string cmd = input[0];
                int x;

                switch (cmd)
                {
                    case "add":
                        x = int.Parse(input[1]) - 1;
                        S |= (1 << x);
                        break;
                    case "remove":
                        x = int.Parse(input[1]) - 1;
                        S &= ~(1 << x);
                        break;
                    case "check":
                        x = int.Parse(input[1]) - 1;
                        output.AppendLine((S & (1 << x)) > 0 ? "1" : "0");
                        break;
                    case "toggle":
                        x = int.Parse(input[1]) - 1;
                        S ^= (1 << x);
                        break;
                    case "all":
                        S = (1 << 20) - 1;
                        break;
                    case "empty":
                        S = 0;
                        break;
                    default:
                        break;
                }
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
