namespace Algorithm.BOJ.BOJ_20743
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20743/input1.txt",
            "BOJ/BOJ_20743/input2.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> cubeNumbers = new();
            Dictionary<int, int> sumCounts = new();
            List<int> busNumbers = new();

            for (int i = 1; i * i * i < 400_000; i++)
            {
                int cube = i * i * i;
                foreach (int otherCube in cubeNumbers)
                {
                    int sum = cube + otherCube;
                    if (sum > 400_000) break;
                    if (!sumCounts.TryAdd(sum, 1))
                        if (++sumCounts[sum] == 2)
                            busNumbers.Add(sum);
                }
                cubeNumbers.Add(cube);
            }

            busNumbers.Sort((a, b) => b - a);

            int m = int.Parse(Console.ReadLine()!);

            foreach (int x in busNumbers)
            {
                if (x <= m)
                {
                    Console.WriteLine(x);
                    return;
                }
            }
            Console.WriteLine("none");
        }
    }
}
