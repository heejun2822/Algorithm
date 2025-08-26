namespace Algorithm.BOJ.BOJ_10816
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10816/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            int[] cards = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            Array.Sort(cards);
            int M = int.Parse(sr.ReadLine()!);
            int[] numbers = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            for (int i = 0; i < M; i++)
            {
                int low = 0, high = N - 1;
                int mid;
                int cnt = 0;
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (cards[mid] < numbers[i]) low = mid + 1;
                    else if (cards[mid] > numbers[i]) high = mid - 1;
                    else
                    {
                        int leftLow = low, leftHigh = mid;
                        int leftMid;
                        while (leftLow != leftHigh)
                        {
                            leftMid = (leftLow + leftHigh) / 2;
                            if (cards[leftMid] == numbers[i]) leftHigh = leftMid;
                            else leftLow = leftMid + 1;
                        }

                        int rightLow = mid, rightHigh = high;
                        int rightMid;
                        while (rightLow != rightHigh)
                        {
                            rightMid = (rightLow + rightHigh + 1) / 2;
                            if (cards[rightMid] == numbers[i]) rightLow = rightMid;
                            else rightHigh = rightMid - 1;
                        }

                        cnt = rightHigh - leftLow + 1;
                        break;
                    }
                }
                sw.Write(cnt);
                sw.Write(' ');
            }

            sr.Close();
            sw.Close();
        }
    }
}
