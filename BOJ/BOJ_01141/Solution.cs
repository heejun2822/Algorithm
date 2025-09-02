namespace Algorithm.BOJ.BOJ_01141
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01141/input1.txt",
            "BOJ/BOJ_01141/input2.txt",
            "BOJ/BOJ_01141/input3.txt",
            "BOJ/BOJ_01141/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            string[] words = new string[N];

            for (int i = 0; i < N; i++)
                words[i] = Console.ReadLine()!;

            Array.Sort(words, (a, b) => a[0] != b[0] ? a[0] - b[0] : a.Length - b.Length);

            int size = N;

            for (int a = 0; a < N; a++)
            {
                for (int b = a + 1; b < N; b++)
                {
                    if (words[b][0] != words[a][0]) break;

                    if (words[b].StartsWith(words[a]))
                    {
                        size--;
                        break;
                    }
                }
            }

            Console.WriteLine(size);
        }
    }
}
