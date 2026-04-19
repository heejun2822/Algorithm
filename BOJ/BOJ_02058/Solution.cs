namespace Algorithm.BOJ.BOJ_02058
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02058/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            Dictionary<int, bool> atomVisited = new(N);
            int[] protons = new int[M];

            for (int i = 0; i < N; i++)
                atomVisited.Add(int.Parse(Console.ReadLine()!), false);
            for (int i = 0; i < M; i++)
                protons[i] = int.Parse(Console.ReadLine()!);

            var maxEnergy = GetMaxEnergy(atomVisited.First().Key);
            Console.WriteLine(Math.Max(maxEnergy.inc, maxEnergy.exc));

            (int inc, int exc) GetMaxEnergy(int currAtom)
            {
                atomVisited[currAtom] = true;

                int inc = currAtom;
                int exc = 0;

                for (int i = 0; i < M; i++)
                {
                    for (int j = -1; j <= 1; j += 2)
                    {
                        int nextAtom = currAtom + protons[i] * j;

                        if (!atomVisited.TryGetValue(nextAtom, out bool visited) || visited) continue;

                        var maxEnergy = GetMaxEnergy(nextAtom);
                        inc += maxEnergy.exc;
                        exc += Math.Max(maxEnergy.inc, maxEnergy.exc);
                    }
                }

                return (inc, exc);
            }
        }
    }
}
