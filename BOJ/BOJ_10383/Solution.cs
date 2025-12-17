namespace Algorithm.BOJ.BOJ_10383
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10383/input.txt",
        ];

        public static void Run(string[] args)
        {
            int num = 0;
            int n;

            while ((n = int.Parse(Console.ReadLine()!)) != 0)
            {
                (string name, int idx)[] products = new (string, int)[n];
                int idx = 0;

                while (idx < n)
                    foreach (string name in Console.ReadLine()!.Split())
                        if (!string.IsNullOrWhiteSpace(name))
                            products[idx] = (name, idx++);

                Array.Sort(products, (a, b) => a.name.CompareTo(b.name));

                int len = 0;

                for (int i = 0; i < n; i++)
                    len += Math.Abs(products[i].idx - i);

                Console.WriteLine($"Site {++num}: {len}");
            }
        }
    }
}
