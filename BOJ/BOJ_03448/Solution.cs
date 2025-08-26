namespace Algorithm.BOJ.BOJ_03448
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03448/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < N; _++)
            {
                int A = 0, R = 0;

                while (true)
                {
                    string line = sr.ReadLine()!;
                    if (line == "" || line == null) break;

                    A += line.Length;
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] != '#') R++;
                }

                string ratio = (100.0 * R / A).ToString("F1");
                if (ratio[^1] == '0') ratio = ratio[..^2];

                sw.WriteLine($"Efficiency ratio is {ratio}%.");
            }

            sr.Close();
            sw.Close();
        }
    }
}
