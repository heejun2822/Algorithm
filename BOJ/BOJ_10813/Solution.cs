namespace Algorithm.BOJ.BOJ_10813
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10813/input.txt",
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
                (baskets[idxI], baskets[idxJ]) = (baskets[idxJ], baskets[idxI]);
            }
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}
