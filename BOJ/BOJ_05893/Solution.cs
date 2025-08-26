namespace Algorithm.BOJ.BOJ_05893
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05893/input.txt",
        ];

        public static void Run(string[] args)
        {
            string N = Console.ReadLine()!;

            int[] digits = new int[N.Length + 5];

            for (int i = 0; i < N.Length; i++)
            {
                int d = N[i] - '0';
                digits[i + 1] += d;
                digits[i + 5] += d;
            }

            for (int i = N.Length + 4; i > 0; i--)
            {
                if (digits[i] >= 2)
                {
                    digits[i] -= 2;
                    digits[i - 1]++;
                }
            }

            System.Text.StringBuilder output = new();

            if (digits[0] == 1)
                output.Append(digits[0]);
            for (int i = 1; i < N.Length + 5; i++)
                output.Append(digits[i]);

            Console.WriteLine(output);
        }
    }
}
