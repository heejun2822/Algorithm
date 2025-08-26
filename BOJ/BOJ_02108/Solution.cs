namespace Algorithm.BOJ.BOJ_02108
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02108/input1.txt",
            "BOJ/BOJ_02108/input2.txt",
            "BOJ/BOJ_02108/input3.txt",
            "BOJ/BOJ_02108/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            SortedDictionary<int, int> counts = new();

            for (int _ = 0; _ < N; _++)
            {
                int num = int.Parse(Console.ReadLine()!);
                if (counts.ContainsKey(num)) counts[num]++;
                else counts[num] = 1;
            }

            int sum = 0;
            int totalCnt = 0;
            int mid = 4001;
            int mostCnt = 0;
            int min = 4000;
            int max = -4000;
            List<int> mostNums = new();
            foreach ((int num, int cnt) in counts)
            {
                sum += num * cnt;
                if (mid == 4001 && (totalCnt += cnt) > N / 2) mid = num;
                if (cnt > mostCnt) { mostCnt = cnt; mostNums = new() {num}; }
                else if (cnt == mostCnt) mostNums.Add(num);
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine((int)Math.Round((double)sum / N));
            Console.WriteLine(mid);
            Console.WriteLine(mostNums[mostNums.Count > 1 ? 1 : 0]);
            Console.WriteLine(max - min);
        }
    }
}
