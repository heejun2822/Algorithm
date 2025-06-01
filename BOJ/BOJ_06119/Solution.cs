namespace Algorithm.BOJ.BOJ_06119
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06119/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int S = int.Parse(sr.ReadLine()!);

            int[] line = new int[S];
            int l = 0, r = -1;
            int cowNumber = 1;

            for (int _ = 0; _ < S; _++)
            {
                string[] input = sr.ReadLine()!.Split();

                if (input[0] == "A")
                {
                    if (input[1] == "L")
                        line[--l < 0 ? l + S : l] = cowNumber++;
                    else
                        line[++r < 0 ? r + S : r] = cowNumber++;
                }
                else
                {
                    int K = int.Parse(input[2]);

                    if (input[1] == "L")
                        l += K;
                    else
                        r -= K;
                }
            }

            System.Text.StringBuilder answer = new();

            for (int i = l; i <= r; i++)
                answer.AppendLine(line[i < 0 ? i + S : i].ToString());

            sw.Write(answer);

            sr.Close();
            sw.Close();
        }
    }
}
