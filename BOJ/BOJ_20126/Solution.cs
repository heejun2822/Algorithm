namespace Algorithm.BOJ.BOJ_20126
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20126/input1.txt",
            "BOJ/BOJ_20126/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nms = sr.ReadLine()!.Split();
            int N = int.Parse(nms[0]);
            int M = int.Parse(nms[1]);
            int S = int.Parse(nms[2]);
            (int, int)[] exams = new (int, int)[N + 1];
            for (int i = 0; i < N; i++)
            {
                string[] exam = sr.ReadLine()!.Split();
                exams[i] = (int.Parse(exam[0]), int.Parse(exam[1]));
            }
            exams[N] = (S, 0);
            Array.Sort(exams);

            int t = 0;
            foreach ((int x, int y) in exams)
            {
                if (t + M <= x) break;
                t = x + y;
            }

            sw.WriteLine(t < S ? t : "-1");

            sr.Close();
            sw.Close();
        }
    }
}
