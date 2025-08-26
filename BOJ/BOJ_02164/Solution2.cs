namespace Algorithm.BOJ.BOJ_02164
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02164/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Queue<int> queue = new(Enumerable.Range(1, N));

            bool discard = true;
            while (queue.Count > 1)
            {
                if (discard) queue.Dequeue();
                else queue.Enqueue(queue.Dequeue());
                discard = !discard;
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}
