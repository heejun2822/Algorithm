namespace Algorithm.BOJ.BOJ_26332
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26332/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int n = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < n; _++)
            {
                string[] info = sr.ReadLine()!.Split();
                int c = int.Parse(info[0]);
                int p = int.Parse(info[1]);
                sw.Write(c);
                sw.Write(' ');
                sw.Write(p);
                sw.Write('\n');
                sw.WriteLine((p - 2) * c + 2);
            }

            sr.Close();
            sw.Close();
        }
    }
}
