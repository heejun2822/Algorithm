namespace Algorithm.BOJ.BOJ_02149
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02149/input.txt",
        ];

        public static void Run(string[] args)
        {
            string key = Console.ReadLine()!;
            string ciphertext = Console.ReadLine()!;

            int N = key.Length;
            int M = ciphertext.Length / N;

            (char c, int idx)[] keyChars = new (char, int)[N];
            for (int i = 0; i < N; i++) keyChars[i] = (key[i], i);
            Array.Sort(keyChars);

            int[] columns = new int[N];
            for (int i = 0; i < N; i++) columns[keyChars[i].idx] = i;

            System.Text.StringBuilder plaintext = new();
            for (int r = 0; r < M; r++)
                for (int c = 0; c < N; c++)
                    plaintext.Append(ciphertext[M * columns[c] + r]);

            Console.WriteLine(plaintext);
        }
    }
}
