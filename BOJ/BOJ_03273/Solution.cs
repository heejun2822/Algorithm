namespace Algorithm.BOJ.BOJ_03273
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03273/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int[] a = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int x = int.Parse(sr.ReadLine()!);

            Array.Sort(a);

            int start = 0, end = n - 1;
            int cnt = 0;

            while (start < end)
            {
                if (a[start] + a[end] == x) cnt++;

                if (a[start] + a[end] > x) end--;
                else start++;
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
