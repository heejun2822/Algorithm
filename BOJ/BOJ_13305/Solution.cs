namespace Algorithm.BOJ.BOJ_13305
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13305/input1.txt",
            "BOJ/BOJ_13305/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] roads = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            (int price, int city)[] gasStations = Console.ReadLine()!.Split().Select((p, i) => (int.Parse(p), i)).ToArray();
            Array.Sort(gasStations);

            int idx = 0, destination = N - 1;
            long expense = 0;
            while (idx < N)
            {
                (int price, int city) = gasStations[idx];
                while (++idx < N)
                {
                    if (gasStations[idx].price != price) break;
                    city = Math.Min(city, gasStations[idx].city);
                }
                if (city >= destination) continue;

                long distance = 0;
                for (int i = city; i < destination; i++) distance += roads[i];
                expense += price * distance;
                destination = city;
            }

            Console.WriteLine(expense);
        }
    }
}
