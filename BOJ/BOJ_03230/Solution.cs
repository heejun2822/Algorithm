namespace Algorithm.BOJ.BOJ_03230
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03230/input1.txt",
            "BOJ/BOJ_03230/input2.txt",
            "BOJ/BOJ_03230/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            List<int> rankings1 = new(N + 1) {0};
            for (int i = 1; i <= N; i++)
            {
                int rank = int.Parse(Console.ReadLine()!);
                rankings1.Insert(rank, i);
            }

            List<int> rankings2 = new(M + 1) {0};
            for (int i = M; i >= 1; i--)
            {
                int rank = int.Parse(Console.ReadLine()!);
                rankings2.Insert(rank, rankings1[i]);
            }

            for (int i = 1; i <= 3; i++)
                Console.WriteLine(rankings2[i]);
        }
    }
}
