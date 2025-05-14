namespace Algorithm.BOJ.BOJ_13018
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13018/input1.txt",
            "BOJ/BOJ_13018/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            if (k == n)
            {
                Console.WriteLine("Impossible");
                return;
            }

            System.Text.StringBuilder A = new();

            for (int i = 2; i <= n - k; i++) A.Append(i).Append(' ');
            A.Append(1).Append(' ');
            for (int i = n - k + 1; i <= n; i++) A.Append(i).Append(' ');

            Console.WriteLine(A);
        }
    }
}
