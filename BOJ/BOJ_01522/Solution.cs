namespace Algorithm.BOJ.BOJ_01522
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01522/input1.txt",
            "BOJ/BOJ_01522/input2.txt",
            "BOJ/BOJ_01522/input3.txt",
            "BOJ/BOJ_01522/input4.txt",
            "BOJ/BOJ_01522/input5.txt",
            "BOJ/BOJ_01522/input6.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;

            int cntA = 0;

            foreach (char c in str)
                if (c == 'a')
                    cntA++;

            int exchangeCnt = 0;
            int minExchangeCnt = int.MaxValue;

            for (int i = 0; i < cntA; i++)
                if (str[i] == 'b')
                    exchangeCnt++;

            for (int i = 0; i < str.Length; i++)
            {
                minExchangeCnt = Math.Min(minExchangeCnt, exchangeCnt);
                if (str[i] == 'b')
                    exchangeCnt--;
                if (str[(cntA + i) % str.Length] == 'b')
                    exchangeCnt++;
            }

            Console.WriteLine(minExchangeCnt);
        }
    }
}
