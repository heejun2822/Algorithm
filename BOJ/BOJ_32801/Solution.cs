namespace Algorithm.BOJ.BOJ_32801
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32801/input1.txt",
            "BOJ/BOJ_32801/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nab = Console.ReadLine()!.Split();
            int n = int.Parse(nab[0]);
            int a = int.Parse(nab[1]);
            int b = int.Parse(nab[2]);

            int[] counts = new int[3];

            for (int i = 1; i <= n; i++)
            {
                int idx = -1;
                if (i % a == 0) idx += 1;
                if (i % b == 0) idx += 2;
                if (idx >= 0) counts[idx]++;
            }

            Console.WriteLine(string.Join(' ', counts));
        }
    }
}
