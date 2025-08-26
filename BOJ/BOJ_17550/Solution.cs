namespace Algorithm.BOJ.BOJ_17550
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17550/input1.txt",
            "BOJ/BOJ_17550/input2.txt",
            "BOJ/BOJ_17550/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);

            int[] a = new int[n];
            long accSum = 0;
            long accSqrSum = 0;

            for (int i = 0; i < n; i++)
            {
                accSum += a[i] = int.Parse(sr.ReadLine()!);
            }

            long value = 0;
            long maxValue = 0;

            for (int k = 0; k < n; k++)
            {
                value -= accSqrSum * a[k];
                accSum -= a[k];
                accSqrSum += a[k] * a[k];
                value += accSum * a[k] * a[k];

                maxValue = Math.Max(maxValue, value);
            }

            sw.WriteLine(maxValue);

            sr.Close();
            sw.Close();
        }
    }
}
