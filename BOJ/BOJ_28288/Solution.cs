namespace Algorithm.BOJ.BOJ_28288
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28288/input1.txt",
            "BOJ/BOJ_28288/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] attendCounts = new int[5];

            for (int _ = 0; _ < N; _++)
            {
                string availability = Console.ReadLine()!;
                for (int i = 0; i < 5; i++)
                    if (availability[i] == 'Y')
                        attendCounts[i]++;
            }

            int maxCnt = 0;
            List<int> maxDays = new();

            for (int i = 0; i < 5; i++)
            {
                if (attendCounts[i] > maxCnt)
                {
                    maxCnt = attendCounts[i];
                    maxDays.Clear();
                    maxDays.Add(i + 1);
                }
                else if (attendCounts[i] == maxCnt)
                {
                    maxDays.Add(i + 1);
                }
            }

            Console.WriteLine(string.Join(',', maxDays));
        }
    }
}
