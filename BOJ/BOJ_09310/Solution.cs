namespace Algorithm.BOJ.BOJ_09310
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09310/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder answer = new();
            while (true)
            {
                int N = int.Parse(Console.ReadLine()!);
                if (N == 0) break;
                int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                if (a[0] + a[2] == 2 * a[1])
                {
                    int d = a[1] - a[0];
                    int s = N * (2 * a[0] + (N - 1) * d) / 2;
                    answer.AppendLine(s.ToString());
                }
                else
                {
                    int r = a[1] / a[0];
                    int s = a[0] * ((int)Math.Pow(r, N) - 1) / (r - 1);
                    answer.AppendLine(s.ToString());
                }
            }
            Console.WriteLine(answer);
        }
    }
}
