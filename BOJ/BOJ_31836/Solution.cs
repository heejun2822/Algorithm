namespace Algorithm.BOJ.BOJ_31836
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31836/input1.txt",
            "BOJ/BOJ_31836/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder A = new();
            System.Text.StringBuilder B = new();

            int x = N, itr = N / 3;
            for (int _ = 0; _ < itr; _++)
            {
                A.Append(x--).Append(' ');
                B.Append(x--).Append(' ').Append(x--).Append(' ');
            }
            if (N % 3 == 2)
            {
                A.Append(2);
                B.Append(1);
            }

            Console.WriteLine(N / 3 + (N % 3 == 2 ? 1 : 0));
            Console.WriteLine(A);
            Console.WriteLine(N / 3 * 2 + (N % 3 == 2 ? 1 : 0));
            Console.WriteLine(B);
        }
    }
}
