namespace Algorithm.BOJ.BOJ_01448
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01448/input1.txt",
            "BOJ/BOJ_01448/input2.txt",
            "BOJ/BOJ_01448/input3.txt",
            "BOJ/BOJ_01448/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int[] straws = new int[N];
            for (int i = 0; i < N; i++) straws[i] = int.Parse(sr.ReadLine()!);
            Array.Sort(straws, (a, b) => b.CompareTo(a));

            int max = -1;
            for (int i = 0; i < N - 2; i++)
            {
                if (straws[i] < straws[i + 1] + straws[i + 2])
                {
                    max = straws[i] + straws[i + 1] + straws[i + 2];
                    break;
                }
            }

            sw.WriteLine(max);

            sr.Close();
            sw.Close();
        }
    }
}
