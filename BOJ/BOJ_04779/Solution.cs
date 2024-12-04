namespace Algorithm.BOJ.BOJ_04779
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04779/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            while (true)
            {
                string input = sr.ReadLine()!;
                if (input == null) break;
                int N = int.Parse(input);
                sw.WriteLine(Cantor(N));
            }

            sr.Close();
            sw.Close();
        }

        private static string Cantor(int n)
        {
            if (n == 0) return "-";
            string line = Cantor(n - 1);
            return line + new string(' ', line.Length) + line;
        }
    }
}
