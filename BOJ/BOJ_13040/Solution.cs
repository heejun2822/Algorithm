namespace Algorithm.BOJ.BOJ_13040
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13040/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nt = Console.ReadLine()!.Split();
            int n = int.Parse(nt[0]);
            int t = int.Parse(nt[1]);
            int t0 = int.Parse(nt[2]);

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                int mi = int.Parse(info[0]);

                int sum = 0;
                int max = t0;
                int j = 0;
                while (++j <= mi)
                {
                    int tij = int.Parse(info[j]);
                    if (tij > max) { sum += max; max = tij; }
                    else sum += tij;

                    if (sum > t) break;
                }

                Console.WriteLine(j - 1);
            }
        }
    }
}
