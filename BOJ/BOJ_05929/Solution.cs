namespace Algorithm.BOJ.BOJ_05929
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05929/input.txt",
        ];

        public static void Run(string[] args)
        {
            string base2 = Console.ReadLine()!;
            string base3 = Console.ReadLine()!;

            int base2Num = 0;
            for (int i = 0; i < base2.Length; i++)
                base2Num += (base2[^(i + 1)] - '0') * (int)Math.Pow(2, i);

            HashSet<int> candidates = new();
            for (int i = 0; i < base2.Length; i++)
            {
                if (base2[^(i + 1)] == '0')
                    candidates.Add(base2Num + (int)Math.Pow(2, i));
                else
                    candidates.Add(base2Num - (int)Math.Pow(2, i));
            }

            int base3Num = 0;
            for (int i = 0; i < base3.Length; i++)
                base3Num += (base3[^(i + 1)] - '0') * (int)Math.Pow(3, i);

            int[,] v = { {1, 2}, {-1, 1}, {-2, -1} };
            for (int i = 0; i < base3.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int num = base3Num + v[base3[^(i + 1)] - '0', j] * (int)Math.Pow(3, i);
                    if (candidates.Contains(num))
                    {
                        Console.WriteLine(num);
                        return;
                    }
                }
            }
        }
    }
}
