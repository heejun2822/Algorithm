namespace Algorithm.BOJ.BOJ_09252
{
    using System.Text;

    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09252/input.txt",
        ];

        public static void Run(string[] args)
        {
            string str1 = Console.ReadLine()!;
            string str2 = Console.ReadLine()!;

            int[,] memo = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        memo[i, j] = memo[i - 1, j - 1] + 1;
                    else
                        memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                }
            }

            Stack<char> stack = new();
            int a = str1.Length, b = str2.Length;

            while (a > 0 && b > 0)
            {
                if (str1[a - 1] == str2[b - 1])
                {
                    stack.Push(str1[a - 1]);
                    a--;
                    b--;
                    continue;
                }
                
                if (memo[a - 1, b] > memo[a, b - 1]) a--;
                else b--;
            }

            StringBuilder LCS = new();
            while (stack.Count > 0) LCS.Append(stack.Pop());

            Console.WriteLine(LCS.Length);
            if (LCS.Length == 0) return;
            Console.WriteLine(LCS);
        }
    }
}
