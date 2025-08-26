namespace Algorithm.BOJ.BOJ_32943
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32943/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] xck = sr.ReadLine()!.Split();
            int X = int.Parse(xck[0]);
            int C = int.Parse(xck[1]);
            int K = int.Parse(xck[2]);

            (int T, int S, int N)[] logs = new (int, int, int)[K];
            for (int i = 0; i < K; i++)
            {
                string[] tsn = sr.ReadLine()!.Split();
                logs[i] = (int.Parse(tsn[0]), int.Parse(tsn[1]), int.Parse(tsn[2]));
            }
            Array.Sort(logs);

            int[] seats = new int[X + 1];
            bool[] isAssignedSeat = new bool[C + 1];

            foreach ((int T, int S, int N) in logs)
            {
                if (isAssignedSeat[S]) continue;

                isAssignedSeat[seats[N]] = false;
                seats[N] = S;
                isAssignedSeat[S] = true;
            }

            for (int i = 1; i <= X; i++)
                if (seats[i] != 0) sw.WriteLine($"{i} {seats[i]}");

            sr.Close();
            sw.Close();
        }
    }
}
