namespace Algorithm.BOJ.BOJ_11286
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11286/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            Comparison<int> comparison = (a, b) => Math.Abs(a) == Math.Abs(b) ? a - b : Math.Abs(a) - Math.Abs(b);
            PriorityQueue<int, int> priorityQueue = new(Comparer<int>.Create(comparison));
            for (int _ = 0; _ < N; _++)
            {
                int x = int.Parse(sr.ReadLine()!);
                if (x == 0) sw.WriteLine(priorityQueue.TryDequeue(out int ele, out int p) ? ele : "0");
                else priorityQueue.Enqueue(x, x);
            }

            sr.Close();
            sw.Close();
        }
    }
}
