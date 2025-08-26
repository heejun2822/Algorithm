namespace Algorithm.BOJ.BOJ_19637
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19637/input1.txt",
            "BOJ/BOJ_19637/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            (string name, int upperLimitPower)[] titles = new (string, int)[N];

            for (int i = 0; i < N; i++)
            {
                input = sr.ReadLine()!.Split();
                titles[i] = (input[0], int.Parse(input[1]));
            }

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < M; _++)
            {
                int power = int.Parse(sr.ReadLine()!);
                int low = 0, high = N - 1;

                while (low < high)
                {
                    int mid = (low + high) / 2;
                    if (power <= titles[mid].upperLimitPower)
                        high = mid;
                    else
                        low = mid + 1;
                }

                output.AppendLine(titles[low].name);
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
