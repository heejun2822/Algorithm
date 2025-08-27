namespace Algorithm.BOJ.BOJ_29847
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_29847/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int[] frequencies = new int[128];

            for (int _ = 0; _ < N; _++)
            {
                string text = sr.ReadLine()!;
                foreach (char c in text)
                    if (c != ' ')
                        frequencies[c]++;
            }

            for (int c = 0; c < 128; c++)
                if (frequencies[c] > 0)
                    sw.WriteLine($"{(char)c} {frequencies[c]}");

            sr.Close();
            sw.Close();
        }
    }
}
