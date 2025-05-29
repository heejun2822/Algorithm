namespace Algorithm.BOJ.BOJ_16623
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16623/input1.txt",
            "BOJ/BOJ_16623/input2.txt",
            "BOJ/BOJ_16623/input3.txt",
            "BOJ/BOJ_16623/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), m = ReadInt(sr);

            int location = 0;
            int minLapCnt = 0;

            for (int _ = 0; _ < m; _++)
            {
                int newLocation = ReadInt(sr);
                if (newLocation < location) minLapCnt++;
                location = newLocation;
            }

            sw.WriteLine(minLapCnt);

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
