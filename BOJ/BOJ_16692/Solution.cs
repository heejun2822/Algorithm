namespace Algorithm.BOJ.BOJ_16692
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16692/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]), c = int.Parse(input[1]);

            int[] t = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            PriorityQueue<(int time, int idx), (int time, int idx)> cashierQueue = new();
            System.Text.StringBuilder output = new();

            for (int i = 0; i < n; i++)
            {
                output.Append(i + 1).Append(' ');
                cashierQueue.Enqueue((t[i], i + 1), (t[i], i + 1));
            }
            for (int i = n; i < c; i++)
            {
                (int time, int idx) = cashierQueue.Dequeue();
                output.Append(idx).Append(' ');
                cashierQueue.Enqueue((time + t[i], idx), (time + t[i], idx));
            }

            Console.WriteLine(output);
        }
    }
}
