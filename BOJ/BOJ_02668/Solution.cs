namespace Algorithm.BOJ.BOJ_02668
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02668/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] table = new int[N + 1];

            for (int i = 1; i <= N; i++)
                table[i] = int.Parse(Console.ReadLine()!);

            bool[] visited = new bool[N + 1];
            HashSet<int> set = new();
            List<int> selected = new();

            for (int i = 1; i <= N; i++)
                DFS(i, set);

            selected.Sort();

            Console.WriteLine(selected.Count);
            foreach (int num in selected)
                Console.WriteLine(num);

            int DFS(int num, HashSet<int> set)
            {
                if (set.Contains(num))
                    return num;

                if (visited[num])
                    return 0;

                visited[num] = true;
                set.Add(num);

                int result = DFS(table[num], set);

                set.Remove(num);

                if (result == 0)
                    return 0;

                selected.Add(num);

                return result == num ? 0 : result;
            }
        }
    }
}
