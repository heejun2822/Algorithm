namespace Algorithm.BOJ.BOJ_26596
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26596/input1.txt",
            "BOJ/BOJ_26596/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int M = int.Parse(Console.ReadLine()!);
            Dictionary<string, int> recipe = new();
            for (int _ = 0; _ < M; _++)
            {
                string[] ingredient = Console.ReadLine()!.Split();
                string s = ingredient[0];
                int x = int.Parse(ingredient[1]);
                if (!recipe.TryAdd(s, x)) recipe[s] += x;
            }

            foreach ((string si, int xi) in recipe)
            {
                int grx = (int)(xi * 1.618f);
                foreach ((string sj, int xj) in recipe)
                {
                    if (sj == si) continue;
                    if (xj == grx)
                    {
                        Console.WriteLine("Delicious!");
                        return;
                    }
                }
            }
            Console.WriteLine("Not Delicious...");
        }
    }
}
