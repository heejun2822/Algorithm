namespace Algorithm.BOJ.BOJ_12980
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12980/input1.txt",
            "BOJ/BOJ_12980/input2.txt",
            "BOJ/BOJ_12980/input3.txt",
            "BOJ/BOJ_12980/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int[] P = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int score = 0;
            List<int> indices = new();
            bool[] exists = new bool[N + 1];

            for (int i = 0; i < N; i++)
            {
                if (P[i] == 0)
                {
                    indices.Add(i);
                    continue;
                }

                exists[P[i]] = true;
                for (int j = 0; j < i; j++)
                {
                    if (P[j] == 0) continue;
                    if (P[j] < P[i])
                        score++;
                }
            }

            int L = indices.Count;

            List<int> numbers = new(L);

            for (int num = 1; num <= N; num++)
                if (!exists[num])
                    numbers.Add(num);

            int[,] scoreMat = new int[L, L];

            for (int i = 0; i < L; i++)
                for (int j = 0; j < L; j++)
                    for (int k = 0; k < N; k++)
                    {
                        if (P[k] == 0) continue;
                        if ((k < indices[j] && P[k] < numbers[i]) || (k > indices[j] && P[k] > numbers[i]))
                            scoreMat[i, j]++;
                    }

            int cnt = 0;
            int[] arr = new int[L];
            bool[] visited = new bool[L];

            Permutation(0, score);

            Console.WriteLine(cnt);

            void Permutation(int idx, int score)
            {
                if (score > S) return;

                if (idx == L)
                {
                    if (score == S) cnt++;
                    return;
                }

                for (int i = 0; i < L; i++)
                {
                    if (visited[i]) continue;

                    visited[i] = true;

                    arr[idx] = numbers[i];

                    int additionalScore = scoreMat[i, idx];
                    for (int j = 0; j < idx; j++)
                        if (arr[j] < arr[idx])
                            additionalScore++;

                    Permutation(idx + 1, score + additionalScore);

                    visited[i] = false;
                }
            }
        }
    }
}
