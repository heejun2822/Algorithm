namespace Algorithm.BOJ.BOJ_10981
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10981/input1.txt",
            "BOJ/BOJ_10981/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nk = sr.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            Dictionary<string, (string name, int score, int penalty)> topTeams = new();

            for (int _ = 0; _ < N; _++)
            {
                string[] info = sr.ReadLine()!.Split();
                string university = info[0];
                string name = info[1];
                int score = int.Parse(info[2]);
                int penalty = int.Parse(info[3]);

                if (topTeams.TryGetValue(university, out var team) && (score, -penalty).CompareTo((team.score, -team.penalty)) < 0)
                    continue;

                topTeams[university] = (name, score, penalty);
            }

            PriorityQueue<string, (int, int)> priorityQueue = new(topTeams.Count);

            foreach ((string name, int score, int penalty) in topTeams.Values)
                priorityQueue.Enqueue(name, (-score, penalty));

            for (int _ = 0; _ < K; _++)
                sw.WriteLine(priorityQueue.Dequeue());

            sr.Close();
            sw.Close();
        }
    }
}
