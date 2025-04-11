namespace Algorithm.BOJ.BOJ_20112
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20112/input1.txt",
            "BOJ/BOJ_20112/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            string[] words = new string[N];
            for (int i = 0; i < N; i++) words[i] = Console.ReadLine()!;

            for (int i = 0; i < N - 1; i++)
                for (int j = i + 1; j < N; j++)
                    if (words[i][j] != words[j][i])
                    {
                        Console.WriteLine("NO");
                        return;
                    }
            Console.WriteLine("YES");
        }
    }
}
