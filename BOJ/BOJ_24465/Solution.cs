namespace Algorithm.BOJ.BOJ_24465
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24465/input1.txt",
            "BOJ/BOJ_24465/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            (int m, int d)[] constellationDates = {
                (1, 20), (2, 19), (3, 21), (4, 20), (5, 21), (6, 22),
                (7, 23), (8, 23), (9, 23), (10, 23), (11, 23), (12, 22),
            };

            bool[] isFilled = new bool[12];

            for (int _ = 0; _ < 7; _++)
            {
                (int m, int d) birthday = (ReadInt(sr), ReadInt(sr));
                isFilled[GetConstellationIdx(birthday)] = true;
            }

            int N = ReadInt(sr);

            List<(int m, int d)> passedBirthdays = new();

            for (int _ = 0; _ < N; _++)
            {
                (int m, int d) birthday = (ReadInt(sr), ReadInt(sr));
                if (!isFilled[GetConstellationIdx(birthday)]) passedBirthdays.Add(birthday);
            }

            if (passedBirthdays.Count == 0)
            {
                sw.WriteLine("ALL FAILED");
            }
            else
            {
                passedBirthdays.Sort();
                System.Text.StringBuilder output = new();
                foreach ((int m, int d) in passedBirthdays) output.AppendLine($"{m} {d}");
                sw.Write(output);
            }

            sr.Close();
            sw.Close();

            int GetConstellationIdx((int, int) birthday)
            {
                for (int i = 11; i >= 0; i--)
                    if (birthday.CompareTo(constellationDates[i]) >= 0)
                        return i;
                return 11;
            }
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
