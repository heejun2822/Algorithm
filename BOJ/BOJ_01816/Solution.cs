namespace Algorithm.BOJ.BOJ_01816
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01816/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < N; _++)
            {
                long S = long.Parse(Console.ReadLine()!);

                bool isProper = true;

                for (int i = 2; i <= 1_000_000; i++)
                {
                    if (S % i == 0)
                    {
                        isProper = false;
                        break;
                    }
                }

                Console.WriteLine(isProper ? "YES" : "NO");
            }
        }
    }
}
