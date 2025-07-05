namespace Algorithm.BOJ.BOJ_07515
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07515/input.txt",
        ];

        public static void Run(string[] args)
        {
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine()!);

                int cnt = 1;
                int hn = 2, hr = n - 1;

                while (hr >= 0)
                {
                    cnt += DuplicatedCombination(hn, hr);
                    hn += 1;
                    hr -= 2;
                }

                Console.WriteLine($"Scenario {i}:\n{cnt}\n");
            }

            int DuplicatedCombination(int n, int r)
            {
                n = n + r - 1;
                r = Math.Min(r, n - r);

                int ans = 1;

                for (int i = 0; i < r; i++)
                {
                    ans *= n - i;
                    ans /= i + 1;
                }

                return ans;
            }
        }
    }
}
