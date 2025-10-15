namespace Algorithm.BOJ.BOJ_06784
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06784/input1.txt",
            "BOJ/BOJ_06784/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            char[] responses = new char[N];

            for (int i = 0; i < N; i++)
                responses[i] = char.Parse(Console.ReadLine()!);

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                char answer = char.Parse(Console.ReadLine()!);
                if (responses[i] == answer)
                    cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
