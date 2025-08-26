namespace Algorithm.BOJ.BOJ_31824
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31824/input1.txt",
            "BOJ/BOJ_31824/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            (string Q, string A)[] infos = new (string, string)[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                infos[i] = (info[0], info[1]);
            }
            Array.Sort(infos);

            for (int _ = 0; _ < M; _++)
            {
                string S = Console.ReadLine()!;
                System.Text.StringBuilder answer = new();

                for (int k = 0; k < S.Length; k++)
                {
                    foreach ((string Q, string A) in infos)
                    {
                        if (Q.Length > S.Length - k) continue;

                        bool hasQ = true;
                        for (int l = 0; l < Q.Length; l++)
                        {
                            if (S[k + l] != Q[l])
                            {
                                hasQ = false;
                                break;
                            }
                        }

                        if (hasQ) answer.Append(A);
                    }
                }

                Console.WriteLine(answer.Length > 0 ? answer : "-1");
            }
        }
    }
}
