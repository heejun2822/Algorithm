namespace Algorithm.BOJ.BOJ_01949
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01949/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            int[] populations = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            List<int>[] edgeLists = new List<int>[N + 1];
            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                string[] villages = sr.ReadLine()!.Split();
                int village1 = int.Parse(villages[0]);
                int village2 = int.Parse(villages[1]);
                edgeLists[village1].Add(village2);
                edgeLists[village2].Add(village1);
            }

            int[,] maxPopulations = new int[N + 1, 2];
            bool[] hasAdjacentExcellentVillage = new bool[N + 1];
            MeasureMaxPopulation(1, 0);

            sw.WriteLine(Math.Max(maxPopulations[1, 0], maxPopulations[1, 1]));

            sr.Close();
            sw.Close();

            void MeasureMaxPopulation(int node, int parent)
            {
                maxPopulations[node, 1] = populations[node - 1];

                foreach (int child in edgeLists[node])
                {
                    if (child == parent) continue;

                    MeasureMaxPopulation(child, node);

                    if (hasAdjacentExcellentVillage[child] && maxPopulations[child, 0] > maxPopulations[child, 1])
                    {
                        maxPopulations[node, 0] += maxPopulations[child, 0];
                    }
                    else
                    {
                        maxPopulations[node, 0] += maxPopulations[child, 1];
                        hasAdjacentExcellentVillage[node] = true;
                    }
                    maxPopulations[node, 1] += maxPopulations[child, 0];
                }
            }
        }
    }
}
