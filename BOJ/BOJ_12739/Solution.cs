namespace Algorithm.BOJ.BOJ_12739
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12739/input1.txt",
            "BOJ/BOJ_12739/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            string colorStr = Console.ReadLine()!;

            int[] prevColors = new int[N];
            int[] currColors = new int[N];

            for (int i = 0; i < N; i++)
                currColors[i] = colorStr[i] == 'R' ? 0 : colorStr[i] == 'G' ? 1 : 2;

            int[] totalCounts = new int[3];

            while (K-- > 0)
            {
                (prevColors, currColors) = (currColors, prevColors);
                Array.Fill(totalCounts, 0);

                for (int i = 0; i < N; i++)
                {
                    int[] cnt = new int[3];
                    cnt[prevColors[(i - 1 + N) % N]]++;
                    cnt[prevColors[i]]++;
                    cnt[prevColors[(i + 1) % N]]++;

                    if (cnt[0] == cnt[1] || cnt[0] == cnt[2] || cnt[1] == cnt[2])
                        currColors[i] = 2;
                    else if (cnt[0] - cnt[1] == 1 || cnt[1] - cnt[2] == 1)
                        currColors[i] = 0;
                    else
                        currColors[i] = 1;

                    totalCounts[currColors[i]]++;
                }
            }

            Console.WriteLine(string.Join(' ', totalCounts));
        }
    }
}
