namespace Algorithm.BOJ.BOJ_28255
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_28255/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string S = sr.ReadLine()!;
                string PS = Prime(S);
                string RPS = Rev(PS);
                string TPS = Tail(PS);
                string TRPS = Tail(RPS);

                sw.WriteLine(
                    (
                        S == PS + RPS + PS ||
                        S == PS + TRPS + PS ||
                        S == PS + RPS + TPS ||
                        S == PS + TRPS + TPS
                    )
                    ? "1"
                    : "0"
                );
            }

            sr.Close();
            sw.Close();
        }

        private static string Prime(string str)
        {
            return str[..((str.Length + 2) / 3)];
        }

        private static string Rev(string str)
        {
            string reversed = "";
            for (int i = 1; i <= str.Length; i++) reversed += str[^i];
            return reversed;
        }

        private static string Tail(string str)
        {
            return str[1..];
        }
    }
}
