namespace Algorithm.BOJ.BOJ_01934
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01934/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            for (int _ = 0; _ < T; _++)
            {
                string[] ab = Console.ReadLine()!.Split();
                int A = int.Parse(ab[0]);
                int B = int.Parse(ab[1]);
                // 유클리드 호제법
                int L = A * B;
                int G = 1;
                while (B > 0)
                {
                    (A, B) = (B, A % B);
                    G = A;
                }
                L /= G;
                answer.AppendLine(L.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
