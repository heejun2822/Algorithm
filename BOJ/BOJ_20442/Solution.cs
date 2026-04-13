namespace Algorithm.BOJ.BOJ_20442
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20442/input1.txt",
            "BOJ/BOJ_20442/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;

            int[] accCntR = new int[str.Length + 1];

            for (int i = 0; i < str.Length; i++)
                accCntR[i + 1] = accCntR[i] + (str[i] == 'R' ? 1 : 0);

            int maxLen = 0;

            int l = 0, r = str.Length - 1;
            int cntR = accCntR[str.Length];
            int cntK = 0;

            while (l <= r && cntR > 0)
            {
                maxLen = Math.Max(maxLen, cntR + cntK);

                while (l <= r && str[l++] != 'K');
                while (l <= r && str[r--] != 'K');
                cntR = accCntR[r + 1] - accCntR[l];
                cntK += 2;
            }

            Console.WriteLine(maxLen);
        }
    }
}
