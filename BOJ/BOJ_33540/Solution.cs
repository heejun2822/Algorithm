namespace Algorithm.BOJ.BOJ_33540
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_33540/input1.txt",
            "BOJ/BOJ_33540/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Dictionary<string, int> totalScores = new();

            for (int _ = 0; _ < n; _++)
            {
                string[] mk = Console.ReadLine()!.Split();
                string M = mk[0];
                int k = int.Parse(mk[1]);

                if (!totalScores.TryAdd(M, k)) totalScores[M] += k;
            }

            System.Text.StringBuilder answer = new();

            foreach (string M in totalScores.Keys.OrderBy(e => e))
                answer.AppendLine($"{M} {totalScores[M]}");

            Console.Write(answer);
        }
    }
}
