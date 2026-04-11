namespace Algorithm.BOJ.BOJ_14856
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14856/input.txt",
        ];

        public static void Run(string[] args)
        {
            long N = long.Parse(Console.ReadLine()!);

            List<long> F = new() { 1, 2 };

            while (F[^1] + F[^2] <= N)
                F.Add(F[^1] + F[^2]);

            Stack<int> selected = new();
            int idx = F.Count;

            while (N > 0 && --idx >= 0)
            {
                if (F[idx] <= N)
                {
                    selected.Push(idx);
                    N -= F[idx--];                
                }
            }

            if (N > 0)
            {
                Console.WriteLine(-1);
                return;
            }

            Console.WriteLine(selected.Count);
            while (selected.Count > 0)
            {
                Console.Write(F[selected.Pop()]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
