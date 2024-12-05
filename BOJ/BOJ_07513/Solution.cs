namespace Algorithm.BOJ.BOJ_07513
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07513/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int T = int.Parse(sr.ReadLine()!);
            for (int t = 1; t <= T; t++)
            {
                int m = int.Parse(sr.ReadLine()!);
                string[] words = new string[m];
                for (int i = 0; i < m; i++) words[i] = sr.ReadLine()!;
                int n = int.Parse(sr.ReadLine()!);

                sw.Write("Scenario #");
                sw.Write(t);
                sw.Write(":\n");
                for (int _ = 0; _ < n; _++)
                {
                    string[] pwdInfo = sr.ReadLine()!.Split();
                    for (int i = 1; i < pwdInfo.Length; i++)
                        sw.Write(words[int.Parse(pwdInfo[i])]);
                    sw.Write('\n');
                }
                sw.Write('\n');
            }

            sr.Close();
            sw.Close();
        }
    }
}
