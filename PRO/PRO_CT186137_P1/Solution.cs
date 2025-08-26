namespace Algorithm.PRO.PRO_CT186137_P1 // 250818 데브시스터즈 코딩테스트 프로그래밍1
{
    using System;

    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_CT186137_P1/input.txt",
        ];

        // 퀘스트마다 퀘스트가 열리는데 필요한 경험치, 퀘스트를 클리어했을 때 얻는 경험치가 주어짐
        // 클리어할 수 있는 퀘스트의 최대 개수를 찾아라
        // 정확성 100.0 / 100.0
        // 합계   100.0 / 100.0
        public override void Run(string[] args)
        {
            int[][] _quest = System.Text.Json.JsonSerializer.Deserialize<int[][]>(Console.ReadLine()!)!;
            int[,] quest = new int[_quest.Length, _quest[0].Length];

            for (int i = 0; i < quest.GetLength(0); i++)
                for (int j = 0; j < quest.GetLength(1); j++)
                    quest[i, j] = _quest[i][j];

            int answer = solution(quest);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public int solution(int[,] quest)
        {
            int len = quest.GetLength(0);
            QuestData[] questDatas = new QuestData[len];

            for (int i = 0; i < len; i++)
            {
                questDatas[i] = new QuestData(quest[i, 0], quest[i, 1]);
            }

            Array.Sort(questDatas, (a, b) => a.requiredExp - b.requiredExp);

            int exp = 0;
            int cnt = 0;

            for (int i = 0; i < len; i++)
            {
                if (exp >= questDatas[i].requiredExp)
                {
                    exp += questDatas[i].rewardExp;
                    cnt++;
                }
                else
                {
                    break;
                }
            }

            return cnt;
        }
    }

    class QuestData
    {
        public int requiredExp;
        public int rewardExp;

        public QuestData(int requiredExp, int rewardExp)
        {
            this.requiredExp = requiredExp;
            this.rewardExp = rewardExp;
        }
    }
}
