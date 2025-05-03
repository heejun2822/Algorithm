namespace Algorithm.BOJ.BOJ_28135
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_28135/input1.txt",
            "BOJ/BOJ_28135/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = N;
            for (int i = 1; i < N; i++)
                if (i.ToString().Contains("50")) cnt++;

            Console.WriteLine(cnt);
        }
    }
}
