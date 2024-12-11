namespace Algorithm.BOJ.BOJ_14888
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14888/input1.txt",
            "BOJ/BOJ_14888/input2.txt",
            "BOJ/BOJ_14888/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] operators = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int max = -(int)1e9, min = (int)1e9;
            DoOperations(A, operators, 1, A[0], ref max, ref min);

            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        private static void DoOperations(int[] A, int[] operators, int idx, int num, ref int max, ref int min)
        {
            if (idx == A.Length)
            {
                if (num > max) max = num;
                if (num < min) min = num;
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                if (operators[i] == 0) continue;
                int res = i switch
                {
                    0 => num + A[idx],
                    1 => num - A[idx],
                    2 => num * A[idx],
                    3 => num / A[idx],
                    _ => num,
                };
                operators[i]--;
                DoOperations(A, operators, idx + 1, res, ref max, ref min);
                operators[i]++;
            }
        }
    }
}
