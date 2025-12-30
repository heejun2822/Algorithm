namespace Algorithm.BOJ.BOJ_33489
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33489/input.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> fib = new() { 1, 1 };

            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int X = int.Parse(input[0]), Y = int.Parse(input[1]);

                int idx = 1;
                int x = 1, y = 1;

                while (fib[idx] <= X && fib[idx - 1] <= Y)
                {
                    x = fib[idx];
                    y = fib[idx - 1];

                    if (++idx == fib.Count)
                        fib.Add(fib[^1] + fib[^2]);
                }

                output.AppendLine($"{x} {y}");
            }

            Console.Write(output);
        }
    }
}
