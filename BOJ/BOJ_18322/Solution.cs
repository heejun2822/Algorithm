namespace Algorithm.BOJ.BOJ_18322
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18322/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            string[] words = Console.ReadLine()!.Split();

            int characters = 0;
            for (int i = 0; i < N; i++)
            {
                if (characters + words[i].Length > K)
                {
                    Console.Write("\n");
                    characters = 0;
                }
                else if (characters > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(words[i]);
                characters += words[i].Length;
            }
        }
    }
}
