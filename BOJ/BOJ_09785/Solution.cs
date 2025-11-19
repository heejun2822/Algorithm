namespace Algorithm.BOJ.BOJ_09785
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09785/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            (int dps, int len)[] abilities = new (int, int)[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine()!.Split();
                abilities[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }

            Array.Sort(abilities, (a, b) => a.dps != b.dps ? b.dps - a.dps : b.len - a.len);

            int maxDps = 0;
            int maxLen = int.MaxValue;

            for (int i = 0; i < M; i++)
            {
                maxDps += abilities[i].dps;
                maxLen = Math.Min(maxLen, abilities[i].len);
            }

            Console.WriteLine($"{maxDps} {maxLen}");
        }
    }
}
