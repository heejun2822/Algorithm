namespace Algorithm.BOJ.BOJ_25709
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25709/input1.txt",
            "BOJ/BOJ_25709/input2.txt",
            "BOJ/BOJ_25709/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string N = Console.ReadLine()!;

            string numStr = "0";
            int minCnt = 0;

            foreach (char d in N)
            {
                if (d == '1') minCnt++;
                else numStr += d;
            }

            int num = int.Parse(numStr);

            while (num > 0)
            {
                int digit = num % 10;
                if (digit == 0)
                {
                    num--;
                    minCnt++;
                }
                else
                {
                    num /= 10;
                    minCnt += digit;
                }
            }

            Console.WriteLine(minCnt);
        }
    }
}
