namespace Algorithm.BOJ.BOJ_14003
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14003/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            string[] A = sr.ReadLine()!.Split();

            List<(int idx, int num)> LIS = new() { (N, 1_000_000_001) };
            int[] nextIdx = new int[N];
            int firstIdx = 0;

            for (int i = N - 1; i >= 0; i--)
            {
                int num = int.Parse(A[i]);

                if (num < LIS[^1].num)
                {
                    LIS.Add((i, num));
                    nextIdx[i] = LIS[^2].idx;
                    firstIdx = i;
                }
                else if (num > LIS[^1].num)
                {
                    int low = 0, high = LIS.Count - 1;

                    while (low < high)
                    {
                        int mid = (low + high) / 2;
                        if (LIS[mid].num > num) low = mid + 1;
                        else if (LIS[mid].num < num) high = mid;
                        else break;
                    }

                    if (low == high)
                    {
                        LIS[low] = (i, num);
                        nextIdx[i] = LIS[low - 1].idx;
                    }
                }
            }

            StringBuilder strLIS = new();
            int idx = firstIdx;
            while (idx < N)
            {
                strLIS.Append(A[idx]);
                strLIS.Append(' ');
                idx = nextIdx[idx];
            }

            sw.WriteLine(LIS.Count - 1);
            sw.WriteLine(strLIS);

            sr.Close();
            sw.Close();
        }
    }
}
