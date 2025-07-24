namespace Algorithm.BOJ.BOJ_17224
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17224/input1.txt",
            "BOJ/BOJ_17224/input2.txt",
            "BOJ/BOJ_17224/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);
            int K = int.Parse(input[2]);

            int cnt1 = 0, cnt2 = 0;

            for (int _ = 0; _ < N; _++)
            {
                input = Console.ReadLine()!.Split();
                int sub1 = int.Parse(input[0]);
                int sub2 = int.Parse(input[1]);

                if (L >= sub2)
                    cnt2++;
                else if (L >= sub1)
                    cnt1++;
            }

            int score = cnt2 >= K ? 140 * K : 140 * cnt2 + 100 * Math.Min(K - cnt2, cnt1);

            Console.WriteLine(score);
        }
    }
}
