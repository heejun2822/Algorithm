namespace Algorithm.BOJ.BOJ_11972
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11972/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nmds = Console.ReadLine()!.Split();
            int N = int.Parse(nmds[0]);
            int M = int.Parse(nmds[1]);
            int D = int.Parse(nmds[2]);
            int S = int.Parse(nmds[3]);

            (int p, int m, int t)[] drink = new (int, int, int)[D];
            for (int i = 0; i < D; i++)
            {
                string[] rec = Console.ReadLine()!.Split();
                drink[i] = (int.Parse(rec[0]), int.Parse(rec[1]), int.Parse(rec[2]));
            }

            (int p, int t)[] sick = new (int, int)[S];
            for (int i = 0; i < S; i++)
            {
                string[] rec = Console.ReadLine()!.Split();
                sick[i] = (int.Parse(rec[0]), int.Parse(rec[1]));
            }

            HashSet<int> badMilks = Enumerable.Range(1, M).ToHashSet();
            HashSet<int> personalBadMilks = new();
            for (int i = 0; i < S; i++)
            {
                personalBadMilks.Clear();
                for (int j = 0; j < D; j++)
                    if (drink[j].p == sick[i].p && drink[j].t < sick[i].t)
                        personalBadMilks.Add(drink[j].m);
                badMilks.IntersectWith(personalBadMilks);
            }

            bool[] sickPeople = new bool[N + 1];
            for (int i = 0; i < D; i++)
                if (badMilks.Contains(drink[i].m))
                    sickPeople[drink[i].p] = true;

            Console.WriteLine(sickPeople.Count(e => e));
        }
    }
}
