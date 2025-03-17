namespace Algorithm.BOJ.BOJ_14608
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14608/input.txt",
        ];

        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine()!);  // K = 1
            int[] c = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            string[] abn = Console.ReadLine()!.Split();
            int a = int.Parse(abn[0]);
            int b = int.Parse(abn[1]);
            int N = int.Parse(abn[2]);

            float dx = (float)(b - a) / N;
            float value = c[0] * (b * b - a * a) / 2f + c[1] * (b - a);

            value /= dx;
            value -= c[1] * N;
            value /= c[0];
            value -= a * N;
            value -= (N - 1) * N / 2 * dx;
            value /= N;

            Console.WriteLine(value);
        }
    }
}
