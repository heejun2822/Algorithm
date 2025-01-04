namespace Algorithm.BOJ.BOJ_18141
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18141/input1.txt",
            "BOJ/BOJ_18141/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(A, (a, b) => b - a);

            for (int k = 0; k < n; k++)
            {
                if (k > 0 && A[k] == A[k - 1]) continue;

                for (int i = 0; i < n - 1; i++)
                {
                    if (i == k) continue;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (j == k) continue;
                        if ((A[i] - A[j]) % A[k] != 0)
                        {
                            Console.WriteLine("no");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("yes");
        }
    }
}
