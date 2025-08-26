namespace Algorithm.BOJ.BOJ_18883
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18883/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] inputs = sr.ReadLine()!.Split();
            int N = int.Parse(inputs[0]);
            int M = int.Parse(inputs[1]);

            int num = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M - 1; j++)
                {
                    sw.Write(++num);
                    sw.Write(' ');
                }
                sw.Write(++num);
                sw.Write('\n');
            }

            sr.Close();
            sw.Close();
        }
    }
}
