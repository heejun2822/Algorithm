namespace Algorithm.BOJ.BOJ_21965
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_21965/input1.txt",
            "BOJ/BOJ_21965/input2.txt",
            "BOJ/BOJ_21965/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int idx = 1;
            while (idx < N)
            {
                if (A[idx - 1] >= A[idx]) break;
                idx++;
            }
            while (idx < N)
            {
                if (A[idx - 1] <= A[idx]) break;
                idx++;
            }

            sw.WriteLine(idx == N ? "YES" : "NO");

            sr.Close();
            sw.Close();
        }
    }
}
