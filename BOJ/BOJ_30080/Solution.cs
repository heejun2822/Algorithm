namespace Algorithm.BOJ.BOJ_30080
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30080/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string houses = Console.ReadLine()!;

            HashSet<string> trainSet = new();
            int maxCnt = 0;
            string maxTrain = string.Empty;

            for (int i = 0; i + 7 < houses.Length; i++)
            {
                string train = houses[i..(i + 8)];

                if (trainSet.Contains(train)) continue;

                int cnt = 8;
                int idx = i + 8;

                while (idx + 7 < houses.Length)
                {
                    bool isFit = true;

                    for (int j = 0; j < 8; j++)
                    {
                        if (houses[idx + j] != train[j])
                        {
                            isFit = false;
                            break;
                        }
                    }

                    if (isFit)
                    {
                        cnt += 8;
                        idx += 8;
                    }
                    else
                    {
                        idx++;
                    }
                }

                trainSet.Add(train);
                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                    maxTrain = train;
                }
            }

            Console.WriteLine(maxCnt);
            Console.WriteLine(maxTrain);
        }
    }
}
