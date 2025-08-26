namespace Algorithm.BOJ.BOJ_01337
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01337/input1.txt",
            "BOJ/BOJ_01337/input2.txt",
            "BOJ/BOJ_01337/input3.txt",
            "BOJ/BOJ_01337/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
                arr[i] = int.Parse(Console.ReadLine()!);

            Array.Sort(arr);

            int l = 0, r = 0;
            int maxCnt = 0;

            while (r < N)
            {
                if (arr[r] < arr[l] + 5)
                    maxCnt = Math.Max(maxCnt, r++ - l + 1);
                else
                    l++;
            }

            Console.WriteLine(5 - maxCnt);
        }
    }
}
