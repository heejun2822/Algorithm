namespace Algorithm.BOJ.BOJ_02565
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02565/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int A, int B)[] wires = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                wires[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }
            Array.Sort(wires);

            int[] LIS = new int[N];
            for (int i = 0; i < N; i++)
            {
                LIS[i] = 1;
                for (int j = 0; j < i; j++)
                    if (wires[i].B > wires[j].B) LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
            }

            Console.WriteLine(N - LIS.Max());
        }
    }
}
