namespace Algorithm.BOJ.BOJ_11272
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11272/input1.txt",
            "BOJ/BOJ_11272/input2.txt",
        ];

        public static void Run(string[] args)
        {
            bool isPossible = true;

            int f = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < f; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int t = int.Parse(input[0]), n = int.Parse(input[1]);

                bool[] prevDP = new bool[t + 1];
                bool[] currDP = new bool[t + 1];
                Array.Fill(prevDP, true);

                for (int j = 0; j < n; j++)
                {
                    input = Console.ReadLine()!.Split();
                    int dt = int.Parse(input[1]) - int.Parse(input[0]);

                    int cnt = 0;

                    for (int r = 0; r <= t; r++)
                        if (currDP[r] = (r - dt >= 0 && prevDP[r - dt]) || (r + dt <= t && prevDP[r + dt]))
                            cnt++;

                    if (!(isPossible = cnt > 0)) break;

                    (prevDP, currDP) = (currDP, prevDP);
                }

                if (!isPossible) break;
            }

            Console.WriteLine(isPossible ? "possible" : "impossible");
        }
    }
}
