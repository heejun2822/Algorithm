namespace Algorithm.BOJ.BOJ_33489
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33489/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int X = int.Parse(input[0]), Y = int.Parse(input[1]);

                if (X == 1)
                {
                    output.AppendLine("1 1");
                    continue;
                }

                int y_min = 1, y_max = Math.Min(Y, X - 1);
                int k = 4;
                int[] fib = { 1, 2 };
                double factor_l = 1, factor_r = 2;

                int x = 2, y = 1;

                while (y_min <= y_max)
                {
                    if (k % 2 == 1)
                        factor_l = (double)fib[1] / fib[0];
                    else
                        factor_r = (double)fib[1] / fib[0];

                    while (y_min <= y_max)
                    {
                        int x_min = (int)Math.Floor(y_max * factor_l) + 1;
                        int x_max = (int)Math.Ceiling(y_max * factor_r) - 1;
                        if (x_max - x_min + 1 > 0 && x_min <= X)
                        {
                            x = x_min;
                            y = y_max;
                            break;
                        }
                        y_max--;
                    }
                    while (y_min <= y_max)
                    {
                        int x_min = (int)Math.Floor(y_min * factor_l) + 1;
                        int x_max = (int)Math.Ceiling(y_min * factor_r) - 1;
                        if (x_max - x_min + 1 > 0 && x_min <= X)
                        {
                            x = x_min;
                            y = y_min;
                            break;
                        }
                        y_min++;
                    }

                    k++;
                    (fib[0], fib[1]) = (fib[1], fib[0] + fib[1]);
                }

                output.AppendLine($"{x} {y}");
            }

            Console.Write(output);
        }
    }
}
