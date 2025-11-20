namespace Algorithm.BOJ.BOJ_13414
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13414/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int K = ReadInt(sr), L = ReadInt(sr);

            (int studentID, bool isValid)[] waitingList = new (int, bool)[L];
            Dictionary<int, int> lastIdx = new();

            for (int i = 0; i < L; i++)
            {
                int studentID = ReadInt(sr);

                waitingList[i] = (studentID, true);
                if (lastIdx.TryGetValue(studentID, out int lIdx))
                    waitingList[lIdx].isValid = false;
                lastIdx[studentID] = i;
            }

            System.Text.StringBuilder output = new();
            int idx = 0;

            while (idx < L && K > 0)
            {
                if (waitingList[idx].isValid)
                {
                    output.AppendLine(waitingList[idx].studentID.ToString("D8"));
                    K--;
                }
                idx++;
            }

            sw.Write(output);

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
