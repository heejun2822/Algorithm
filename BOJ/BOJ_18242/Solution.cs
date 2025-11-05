namespace Algorithm.BOJ.BOJ_18242
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18242/input1.txt",
            "BOJ/BOJ_18242/input2.txt",
            "BOJ/BOJ_18242/input3.txt",
            "BOJ/BOJ_18242/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int l = -1, r = -1;
            string answer = "DOWN";

            for (int _ = 0; _ < N; _++)
            {
                string row = Console.ReadLine()!;

                if (l == -1)
                {
                    int cnt = 0;

                    for (int i = 0; i < M; i++)
                    {
                        if (row[i] == '#')
                        {
                            if (l == -1)
                                l = i;
                            r = i;
                            cnt++;
                        }
                    }

                    if (cnt > 0 && cnt % 2 == 0)
                    {
                        answer = "UP";
                        break;
                    }
                }
                else
                {
                    if (row[l] == '.' && row[r] == '#')
                    {
                        answer = "LEFT";
                        break;
                    }
                    else if (row[l] == '#' && row[r] == '.')
                    {
                        answer = "RIGHT";
                        break;
                    }
                    else if (row[l] == '.' && row[r] == '.')
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
