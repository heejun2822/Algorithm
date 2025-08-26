namespace Algorithm.BOJ.BOJ_31762
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31762/input1.txt",
            "BOJ/BOJ_31762/input2.txt",
            "BOJ/BOJ_31762/input3.txt",
            "BOJ/BOJ_31762/input4.txt",
            "BOJ/BOJ_31762/input5.txt",
            "BOJ/BOJ_31762/input6.txt",
            "BOJ/BOJ_31762/input7.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine()!.Split();
            int R = int.Parse(input[0]);
            int C = int.Parse(input[1]);
            int K = int.Parse(input[2]);

            string output = "Y";

            for (int _ = 0; _ < R; _++)
            {
                input = sr.ReadLine()!.Split();
                string M = input[0];
                string P = input[1];

                if (M.Contains('-') && P.Contains('*'))
                {
                    output = "N";
                    break;
                }
            }

            sw.WriteLine(output);

            sr.Close();
            sw.Close();
        }
    }
}
