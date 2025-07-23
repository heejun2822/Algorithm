namespace Algorithm.BOJ.BOJ_11312
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11312/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                long m = A / B;

                sw.WriteLine(m * m);
            }

            sr.Close();
            sw.Close();
        }
    }
}
