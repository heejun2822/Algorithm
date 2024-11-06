namespace Algorithm.BOJ.BOJ_10811
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10811/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] baskets = Enumerable.Range(1, N).ToArray();
            for (int i = 0; i < M; i++)
            {
                string[] indices = Console.ReadLine()!.Split();
                int idxI = int.Parse(indices[0]) - 1;
                int idxJ = int.Parse(indices[1]) - 1;
                int itr = (idxJ - idxI + 1) / 2;
                for (int j = 0; j < itr; j++)
                {
                    int idxA = idxI + j;
                    int idxB = idxJ - j;
                    (baskets[idxA], baskets[idxB]) = (baskets[idxB], baskets[idxA]);
                }
            }
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}
