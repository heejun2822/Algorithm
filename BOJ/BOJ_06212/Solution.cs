namespace Algorithm.BOJ.BOJ_06212
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06212/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] mn = Console.ReadLine()!.Split();
            int M = int.Parse(mn[0]);
            int N = int.Parse(mn[1]);

            int[] counts = new int[10];

            for (int i = M; i <= N; i++)
            {
                int num = i;
                while (num > 0)
                {
                    counts[num % 10]++;
                    num /= 10;
                }
            }

            Console.WriteLine(string.Join(' ', counts));
        }
    }
}
