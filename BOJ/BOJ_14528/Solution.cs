namespace Algorithm.BOJ.BOJ_14528
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14528/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            string[] spottyGenomes = new string[N];
            string[] plainGenomes = new string[N];

            for (int i = 0; i < N; i++)
                spottyGenomes[i] = Console.ReadLine()!;
            for (int i = 0; i < N; i++)
                plainGenomes[i] = Console.ReadLine()!;

            HashSet<int> set = new(N);

            int predictableCnt = 0;

            Combination(new int[3], 0, 0);

            Console.WriteLine(predictableCnt);

            void Combination(int[] arr, int idxA, int idxT)
            {
                if (idxA == arr.Length)
                {
                    if (IsPredictable(arr))
                        predictableCnt++;
                    return;
                }

                if (idxT == M)
                {
                    return;
                }

                arr[idxA] = idxT;
                Combination(arr, idxA + 1, idxT + 1);
                Combination(arr, idxA, idxT + 1);
            }

            bool IsPredictable(int[] indices)
            {
                set.Clear();

                foreach (string genome in spottyGenomes)
                {
                    int value = 0;
                    int factor = 1;

                    foreach (int idx in indices)
                    {
                        value += (genome[idx] - 'A') * factor;
                        factor *= 26;
                    }

                    set.Add(value);
                }

                foreach (string genome in plainGenomes)
                {
                    int value = 0;
                    int factor = 1;

                    foreach (int idx in indices)
                    {
                        value += (genome[idx] - 'A') * factor;
                        factor *= 26;
                    }

                    if (set.Contains(value))
                        return false;
                }

                return true;
            }
        }
    }
}
