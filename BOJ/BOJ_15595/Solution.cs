namespace Algorithm.BOJ.BOJ_15595
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15595/input1.txt",
            "BOJ/BOJ_15595/input2.txt",
            "BOJ/BOJ_15595/input3.txt",
            "BOJ/BOJ_15595/input4.txt",
            "BOJ/BOJ_15595/input5.txt",
            "BOJ/BOJ_15595/input6.txt",
            "BOJ/BOJ_15595/input7.txt",
            "BOJ/BOJ_15595/input8.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            Dictionary<string, int> submissionCnt = new();

            for (int _ = 0; _ < N; _++)
            {
                string[] submissionInfo = sr.ReadLine()!.Split();
                string userId = submissionInfo[1];
                int result = int.Parse(submissionInfo[2]);

                if (userId == "megalusion") continue;

                submissionCnt.TryAdd(userId, 0);

                if (submissionCnt[userId] > 0) continue;

                submissionCnt[userId]--;

                if (result == 4) submissionCnt[userId] = -submissionCnt[userId];
            }

            int ratioN = 0, ratioD = 0;

            foreach (int cnt in submissionCnt.Values)
            {
                if (cnt < 0) continue;

                ratioN++;
                ratioD += cnt;
            }

            sw.WriteLine(ratioD == 0 ? 0 : 100d * ratioN / ratioD);

            sr.Close();
            sw.Close();
        }
    }
}
