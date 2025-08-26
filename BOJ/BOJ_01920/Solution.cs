namespace Algorithm.BOJ.BOJ_01920
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01920/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            Array.Sort(A);
            int M = int.Parse(sr.ReadLine()!);
            int[] X = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int low, high, mid;
            bool isExist;
            for (int i = 0; i < M; i++)
            {
                low = 0;
                high = N - 1;
                isExist = false;
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    if (A[mid] < X[i]) low = mid + 1;
                    else if (A[mid] > X[i]) high = mid - 1;
                    else { isExist = true; break; }
                }
                sw.WriteLine(isExist ? "1" : "0");
            }

            sr.Close();
            sw.Close();
        }
    }
}
