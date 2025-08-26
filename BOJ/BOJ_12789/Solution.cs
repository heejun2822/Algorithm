namespace Algorithm.BOJ.BOJ_12789
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12789/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int order = 0;
            Stack<int> stack = new();
            string result = "Nice";

            foreach (int num in numbers)
            {
                if (num == order + 1) {order = num; continue;}

                stack.TryPeek(out int peeked);
                while (peeked == order + 1)
                {
                    order = peeked;
                    stack.Pop();
                    stack.TryPeek(out peeked);
                }

                if (peeked == 0 || peeked > num) stack.Push(num);
                else {result = "Sad"; break;}
            }

            Console.WriteLine(result);
        }
    }
}
