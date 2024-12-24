namespace Algorithm.BOJ.BOJ_11660
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11660/input1.txt",
            "BOJ/BOJ_11660/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[,] arr = new int[N + 1, N + 1];
            for (int i = 1; i <= N; i++)
            {
                string[] numbers = sr.ReadLine()!.Split();
                for (int j = 1; j <= N; j++)
                    arr[i, j] = arr[i, j - 1] + arr[i - 1, j] - arr[i - 1, j - 1] + int.Parse(numbers[j - 1]);
            }

            for (int _ = 0; _ < M; _++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                int x1 = input[0], y1 = input[1], x2 = input[2], y2 = input[3];
                sw.WriteLine(arr[x2, y2] - arr[x2, y1 - 1] - arr[x1 - 1, y2] + arr[x1 - 1, y1 - 1]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
