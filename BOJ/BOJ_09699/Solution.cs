namespace Algorithm.BOJ.BOJ_09699
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09699/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            System.Text.StringBuilder answer = new();

            for (int i = 1; i <= T; i++)
            {
                int maxWeight = 0;

                for (int _ = 0; _ < 5; _++)
                    maxWeight = Math.Max(maxWeight, ReadInt(sr));

                answer.AppendLine($"Case #{i}: {maxWeight}");
            }

            sw.Write(answer);

            sr.Close();
            sw.Close();
        }
        
        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
