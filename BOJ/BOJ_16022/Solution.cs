namespace Algorithm.BOJ.BOJ_16022
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16022/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] V = new int[N];

            for (int i = 0; i < N; i++)
                V[i] = int.Parse(Console.ReadLine()!);

            Array.Sort(V);

            double minSize = double.MaxValue;

            for (int i = 2; i < N; i++)
                minSize = Math.Min(minSize, (V[i] - V[i - 2]) / 2d);

            Console.WriteLine(minSize.ToString("F1"));
        }
    }
}
