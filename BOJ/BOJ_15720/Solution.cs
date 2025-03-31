namespace Algorithm.BOJ.BOJ_15720
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15720/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int B = ReadInt(sr);
            int C = ReadInt(sr);
            int D = ReadInt(sr);

            int[] burgers = new int[B];
            int[] sidemenus = new int[C];
            int[] drinks = new int[D];
            int totalPrice = 0;

            for (int i = 0; i < B; i++) totalPrice += burgers[i] = ReadInt(sr);
            for (int i = 0; i < C; i++) totalPrice += sidemenus[i] = ReadInt(sr);
            for (int i = 0; i < D; i++) totalPrice += drinks[i] = ReadInt(sr);

            Array.Sort(burgers, (a, b) => b - a);
            Array.Sort(sidemenus, (a, b) => b - a);
            Array.Sort(drinks, (a, b) => b - a);

            int setCnt = Math.Min(B, Math.Min(C, D));
            int setPrice = 0;

            for (int i = 0; i < setCnt; i++) setPrice += burgers[i] + sidemenus[i] + drinks[i];

            sw.WriteLine(totalPrice);
            sw.WriteLine(totalPrice - setPrice / 10);

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
