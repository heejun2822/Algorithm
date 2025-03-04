namespace Algorithm.BOJ.BOJ_26646
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_26646/input1.txt",
            "BOJ/BOJ_26646/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            int[] H = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int cost = 0;

            for (int i = 1; i < N; i++)
                cost += (H[i - 1] * H[i - 1] + H[i] * H[i]) * 2;

            sw.WriteLine(cost);

            sr.Close();
            sw.Close();
        }
    }
}
