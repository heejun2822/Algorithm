namespace Algorithm.BOJ.BOJ_30503
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30503/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] A = Console.ReadLine()!.Split();
            int Q = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            for (int _ = 0; _ < Q; _++)
            {
                string[] query = Console.ReadLine()!.Split();
                if (query[0] == "1")
                {
                    int cnt = 0;
                    for (int i = int.Parse(query[1]) - 1; i < int.Parse(query[2]); i++)
                    {
                        if (A[i] == query[3]) cnt++;
                    }
                    answer.AppendLine(cnt.ToString());
                }
                else if (query[0] == "2")
                {
                    for (int i = int.Parse(query[1]) - 1; i < int.Parse(query[2]); i++)
                    {
                        A[i] = "";
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
