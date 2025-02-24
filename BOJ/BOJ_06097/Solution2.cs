namespace Algorithm.BOJ.BOJ_06097
{
    using System.Numerics;

    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06097/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] np = sr.ReadLine()!.Split();
            string N = np[0];
            int P = int.Parse(np[1]);

            string result = BigInteger.Pow(BigInteger.Parse(N), P).ToString();

            int idx = 0;
            for (int i = 0; i < result.Length / 70; i++)
            {
                for (int j = 0; j < 70; j++) sw.Write(result[idx++]);
                sw.Write("\n");
            }
            if (idx != result.Length)
            {
                while (idx < result.Length) sw.Write(result[idx++]);
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }
    }
}
