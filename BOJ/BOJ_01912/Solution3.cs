namespace Algorithm.BOJ.BOJ_01912
{
    public class Solution3
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01912/input1.txt",
            "BOJ/BOJ_01912/input2.txt",
            "BOJ/BOJ_01912/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] sqn = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int max = sqn[0];
            for (int i = 1; i < n; i++)
            {
                // sqn[i]에 a~i번째 수의 합 중 최댓값으로 덮어쓰기 (0 <= a <= i)
                sqn[i] = Math.Max(sqn[i], sqn[i - 1] + sqn[i]);
                max = Math.Max(max, sqn[i]);
            }

            Console.WriteLine(max);
        }
    }
}
