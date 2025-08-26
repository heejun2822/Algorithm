namespace Algorithm.BOJ.BOJ_33524
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33524/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int[] B = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            Array.Sort(A);

            System.Text.StringBuilder C = new();

            for (int i = 0; i < M; i++)
            {
                int start = -1, end = N - 1;
                while (start < end)
                {
                    int mid = (start + end + 1) / 2;
                    if (A[mid] <= B[i]) start = mid;
                    else end = mid - 1;
                }

                int cnt = start + 1;
                C.Append(cnt == 0 ? 0 : (int)((3 + Math.Sqrt(9 - 12 * (1 - cnt))) / 6)).Append(' ');
            }

            sw.WriteLine(C);

            sr.Close();
            sw.Close();
        }
    }
}
