namespace Algorithm.BOJ.BOJ_06097
{
    public class Solution
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

            string result = Power(N, P);

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

        private static string Power(string N, int P)
        {
            if (P == 1) return N;

            if (P % 2 == 0)
                return Power(Multiply(N, N), P / 2);
            else
                return Multiply(Power(Multiply(N, N), P / 2), N);
        }

        private static string Multiply(string A, string B)
        {
            int[] digits = new int[A.Length + B.Length];

            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < B.Length; j++)
                    digits[^(i + j + 1)] += (A[^(i + 1)] - '0') * (B[^(j + 1)] - '0');

            for (int i = 1; i < digits.Length; i++)
            {
                digits[^(i + 1)] += digits[^i] / 10;
                digits[^i] %= 10;
            }

            int startIndex = 0;
            while (digits[startIndex] == 0) startIndex++;

            return string.Join("", digits)[startIndex..];
        }
    }
}
