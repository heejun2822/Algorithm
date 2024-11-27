namespace Algorithm.BOJ.BOJ_14729
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14729/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            float[] worsts = new float[7];
            Array.Fill(worsts, 100f);
            for (int _ = 0; _ < N; _++)
            {
                float score = float.Parse(Console.ReadLine()!);
                if (score < worsts[6])
                {
                    worsts[6] = score;
                    for (int i = 6; i > 0; i--)
                    {
                        if (worsts[i] >= worsts[i - 1]) break;
                        (worsts[i - 1], worsts[i]) = (worsts[i], worsts[i - 1]);
                    }
                }
            }
            foreach (float score in worsts) Console.WriteLine(score.ToString("N3"));
        }
    }
}
