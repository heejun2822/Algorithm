namespace Algorithm.PRO.PRO_12927 // 야근 지수
{
    using System;

    class Solution
    {
        private static Solution Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_12927/input1.txt",
            "PRO/PRO_12927/input2.txt",
            "PRO/PRO_12927/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);
            int[] works = System.Text.Json.JsonSerializer.Deserialize<int[]>(Console.ReadLine()!)!;

            Console.WriteLine(Instance.solution(n, works));
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
