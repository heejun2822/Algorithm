namespace Algorithm.BOJ.BOJ_14729
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14729/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            List<float> worsts = new(7);
            float cutline = 0;
            for (int _ = 0; _ < N; _++)
            {
                float score = float.Parse(Console.ReadLine()!);
                if (worsts.Count < 7)
                {
                    worsts.Add(score);
                    cutline = Math.Max(cutline, score);
                }
                else if (score < cutline)
                {
                    worsts.Remove(cutline);
                    worsts.Add(score);
                    cutline = worsts.Max();
                }
            }
            worsts.Sort();
            for (int i = 0; i < 7; i++) Console.WriteLine(worsts[i].ToString("N3"));
        }
    }
}
