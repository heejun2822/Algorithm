namespace Algorithm.BOJ.BOJ_10773
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10773/input1.txt",
            "BOJ/BOJ_10773/input2.txt",
        ];

        public static void Run(string[] args)
        {
            Stack<int> stack = new();

            int K = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < K; _++)
            {
                int num = int.Parse(Console.ReadLine()!);
                if (num == 0) stack.Pop();
                else stack.Push(num);
            }

            int sum = 0;
            foreach (int num in stack) sum += num;

            Console.WriteLine(sum);
        }
    }
}
