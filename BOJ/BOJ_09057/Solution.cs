namespace Algorithm.BOJ.BOJ_09057
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09057/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                int N = int.Parse(Console.ReadLine()!);

                Queue<(int rank, string team, string school)> teamQueue = new(N);
                Dictionary<string, int> totalTeamCnt = new();
                Dictionary<string, int> draftTeamCnt = new();

                for (int rank = 1; rank <= N; rank++)
                {
                    string[] input = Console.ReadLine()!.Split();
                    string team = input[0], school = input[1];

                    teamQueue.Enqueue((rank, team, school));
                    if (!totalTeamCnt.TryAdd(school, 1))
                        totalTeamCnt[school]++;
                    draftTeamCnt.TryAdd(school, 0);
                }

                int cnt = 0;
                string lastTeam = string.Empty;
                int lastTeamRank = 0;

                for (int _ = 0; _ < N; _++)
                {
                    if (cnt >= 60) break;

                    (int rank, string team, string school) = teamQueue.Dequeue();
                    int currDraftCnt = draftTeamCnt[school];

                    bool draft = currDraftCnt < (totalTeamCnt[school] + 1) / 2;
                    if (draft)
                    {
                        if (rank <= 10)
                            draft = currDraftCnt <= 3;
                        else if (rank <= 20)
                            draft = currDraftCnt <= 2;
                        else if (rank <= 30)
                            draft = currDraftCnt <= 1;
                        else
                            draft = currDraftCnt == 0;
                    }

                    if (draft)
                    {
                        cnt++;
                        lastTeam = team;
                        lastTeamRank = rank;
                        draftTeamCnt[school]++;
                    }
                    else
                    {
                        teamQueue.Enqueue((rank, team, school));
                    }
                }

                while (cnt++ < 60 && teamQueue.Count > 0)
                {
                    (int rank, string team, string school) = teamQueue.Dequeue();
                    if (rank > lastTeamRank)
                        lastTeam = team;
                }

                Console.WriteLine(lastTeam);
            }
        }
    }
}
