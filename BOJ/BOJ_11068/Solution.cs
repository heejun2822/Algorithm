namespace Algorithm.BOJ.BOJ_11068
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11068/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            int[] digits = new int[20];

            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine()!);

                int num, idx;
                for (int B = 2; B <= 64; B++)
                {
                    num = N; idx = 0;
                    while (num > 0)
                    {
                        digits[idx++] = num % B;
                        num /= B;
                    }
                    for (int i = 0; i < idx / 2; i++)
                    {
                        if (digits[i] != digits[idx - 1 - i]) goto NextB;
                    }

                    Console.WriteLine("1");
                    goto NextTC;

                    NextB:;
                }

                Console.WriteLine("0");

                NextTC:;
            }
        }
    }
}
