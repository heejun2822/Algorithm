namespace Algorithm.BOJ.BOJ_17298
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17298/input1.txt",
            "BOJ/BOJ_17298/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            Stack<int> stack = new();
            int[] NGE = A;

            for (int i = 0; i < N; i++)
            {
                while (stack.TryPeek(out int idx) && A[idx] < A[i])
                    NGE[stack.Pop()] = A[i];

                stack.Push(i);
            }

            while (stack.Count > 0)
                NGE[stack.Pop()] = -1;

            for (int i = 0; i < N; i++)
            {
                sw.Write(NGE[i]);
                sw.Write(" ");
            }
            sw.Write("\n");

            sr.Close();
            sw.Close();
        }
    }
}
