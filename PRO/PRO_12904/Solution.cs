namespace Algorithm.PRO.PRO_12904 // 가장 긴 팰린드롬
{
    using System;

    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_12904/input1.txt",
            "PRO/PRO_12904/input2.txt",
        ];

        public override void Run(string[] args)
        {
            string s = System.Text.Json.JsonSerializer.Deserialize<string>(Console.ReadLine()!)!;

            int answer = solution(s);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public int solution(string s)
        {
            int maxLen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len = 1;
                int l = i - 1;
                int r = i + 1;

                while (l >= 0 && r < s.Length && s[l--] == s[r++])
                    len += 2;

                maxLen = Math.Max(maxLen, len);

                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    len = 2;
                    l = i - 1;
                    r = i + 2;

                    while (l >= 0 && r < s.Length && s[l--] == s[r++])
                        len += 2;

                    maxLen = Math.Max(maxLen, len);
                }
            }

            return maxLen;
        }
    }
}
