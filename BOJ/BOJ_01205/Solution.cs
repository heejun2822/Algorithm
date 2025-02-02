namespace Algorithm.BOJ.BOJ_01205
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01205/input1.txt",
            "BOJ/BOJ_01205/input2.txt",
            "BOJ/BOJ_01205/input3.txt",
            "BOJ/BOJ_01205/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nsp = Console.ReadLine()!.Split();
            int N = int.Parse(nsp[0]);
            int S = int.Parse(nsp[1]);
            int P = int.Parse(nsp[2]);

            if (N == 0)
            {
                Console.WriteLine("1");
                return;
            }

            int[] rankedScores = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            if (N == P && S <= rankedScores[^1])
            {
                Console.WriteLine("-1");
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if (S >= rankedScores[i])
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(N + 1);
        }
    }
}
