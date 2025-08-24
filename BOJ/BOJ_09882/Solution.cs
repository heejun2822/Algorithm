namespace Algorithm.BOJ.BOJ_09882
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09882/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] skillLevels = new int[12];

            for (int i = 0; i < 12; i++)
                skillLevels[i] = int.Parse(Console.ReadLine()!);

            (int memberCnt, int skillLevel)[] teams = new (int, int)[4];
            int minDiff = int.MaxValue;

            MakeTeams(0);

            Console.WriteLine(minDiff);

            void MakeTeams(int idx)
            {
                if (idx == 12)
                {
                    int S = int.MinValue, s = int.MaxValue;
                    for (int i = 0; i < 4; i++)
                    {
                        S = Math.Max(S, teams[i].skillLevel);
                        s = Math.Min(s, teams[i].skillLevel);
                    }
                    minDiff = Math.Min(minDiff, S - s);
                    return;
                }

                for (int i = 0; i < 4; i++)
                {
                    if (teams[i].memberCnt == 3) continue;

                    teams[i].memberCnt++;
                    teams[i].skillLevel += skillLevels[idx];
                    MakeTeams(idx + 1);
                    teams[i].memberCnt--;
                    teams[i].skillLevel -= skillLevels[idx];
                }
            }
        }
    }
}
