namespace Algorithm.BOJ.BOJ_08016
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08016/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int[] a = new int[n];
            int A = 0;

            for (int i = 0; i < n; i++)
                A += a[i] = int.Parse(sr.ReadLine()!);

            Array.Sort(a);

            int l = 0, r = n - 1;
            while (l < r)
                A += a[r--] - a[l++];

            sw.WriteLine(A);

            sr.Close();
            sw.Close();
        }
    }
}
