namespace Algorithm.BOJ.BOJ_34724
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_34724/input1.txt",
            "BOJ/BOJ_34724/input2.txt",
            "BOJ/BOJ_34724/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            bool[] prevRow = new bool[M];

            for (int r = 0; r < N; r++)
            {
                string row = Console.ReadLine()!;

                bool isPrevColWide = false;

                for (int c = 0; c < M; c++)
                {
                    bool state = row[c] == '1';
                    bool isCurrColWide = prevRow[c] && state;

                    if (isPrevColWide && isCurrColWide)
                    {
                        Console.WriteLine(1);
                        return;
                    }

                    prevRow[c] = state;
                    isPrevColWide = isCurrColWide;
                }
            }

            Console.WriteLine(0);
        }
    }
}
