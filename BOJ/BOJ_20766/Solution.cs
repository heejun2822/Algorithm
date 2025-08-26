namespace Algorithm.BOJ.BOJ_20766
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20766/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < T; _++)
            {
                string text = sr.ReadLine()!;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ':' || text[i] == '-')
                    {
                        if (i > 0 && text[i - 1] != ' ' && output[^1] != ' ') output.Append(' ');
                        output.Append(text[i]);
                        if (i < text.Length - 1 && text[i + 1] != ' ') output.Append(' ');
                    }
                    else
                    {
                        output.Append(text[i]);
                    }
                }
                output.AppendLine();
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
