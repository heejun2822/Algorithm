namespace Algorithm.BOJ.BOJ_17299
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17299/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int[] F = new int[1000001];
            for (int i = 0; i < N; i++) F[A[i]]++;

            Stack<int> stack = new();
            int[] NGF = A;

            for (int i = N - 1; i >= 0; i--)
            {
                int a;
                while (stack.TryPeek(out a) && F[A[i]] >= F[a]) stack.Pop();

                stack.Push(A[i]);
                NGF[i] = a == 0 ? -1 : a;
            }

            for (int i = 0; i < N; i++)
            {
                sw.Write(NGF[i]);
                sw.Write(" ");
            }
            sw.Write("\n");

            sr.Close();
            sw.Close();
        }
    }
}
