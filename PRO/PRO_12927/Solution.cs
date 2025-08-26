namespace Algorithm.PRO.PRO_12927 // 야근 지수
{
    using System;

    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_12927/input1.txt",
            "PRO/PRO_12927/input2.txt",
            "PRO/PRO_12927/input3.txt",
        ];

        public override void Run(string[] args)
        {
            int n = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);
            int[] works = System.Text.Json.JsonSerializer.Deserialize<int[]>(Console.ReadLine()!)!;

            long answer = solution(n, works);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public long solution(int n, int[] works)
        {
            Array.Sort(works, (a, b) => b - a);

            int w;
            int idx;

            while (n > 0 && (w = works[idx = 0]) > 0)
            {
                while (n > 0 && idx < works.Length && works[idx] == w)
                {
                    works[idx++]--;
                    n--;
                }
            }

            long answer = 0;

            for (int i = 0; i < works.Length; i++)
                answer += works[i] * works[i];

            return answer;
        }
    }
}
