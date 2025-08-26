namespace Algorithm.BOJ.BOJ_11653
{
    using System.Text;

    public class Solution3 : SolutionBOJ<Solution3>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11653/input1.txt",
            "BOJ/BOJ_11653/input2.txt",
            "BOJ/BOJ_11653/input3.txt",
            "BOJ/BOJ_11653/input4.txt",
            "BOJ/BOJ_11653/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            // 소인수분해
            int limit = (int)Math.Sqrt(N);
            for (int i = 2; i <= limit; i++)
            {
                while (N % i == 0)
                {
                    answer.AppendLine(i.ToString());
                    N /= i;
                }
            }
            // N 이하의 제곱수 중 가장 큰 수를 m^2이라고 하면 (m, N] 범위 내에 N의 소인수가 최대 1개만 존재한다.
            // 만약 2개의 소인수 m+a (a >= 1)와 m+b (b > a)가 존재한다면
            // N >= (m+a)(m+b) > (m+a)^2 >= (m+1)^2 가 되어 N 이하의 제곱수 중 m^2이 가장 크다는 가정에 모순이다.
            if (N != 1) answer.AppendLine(N.ToString());
            Console.WriteLine(answer);
        }
    }
}
