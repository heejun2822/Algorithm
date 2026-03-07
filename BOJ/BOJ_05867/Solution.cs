namespace Algorithm.BOJ.BOJ_05867
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05867/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (string min, string max)[] names = new (string, string)[N];
            string[] minNames = new string[N];
            string[] maxNames = new string[N];

            for (int i = 0; i < N; i++)
            {
                char[] name = Console.ReadLine()!.ToCharArray();
                Array.Sort(name);
                minNames[i] = new(name);
                Array.Reverse(name);
                maxNames[i] = new(name);
                names[i] = (minNames[i], maxNames[i]);
            }

            Array.Sort(minNames);
            Array.Sort(maxNames);

            System.Text.StringBuilder output = new();

            for (int i = 0; i < N; i++)
            {
                int lowestPosition = SearchLowestPosition(names[i].min);
                int highestPosition = SearchHighestPosition(names[i].max);
                output.AppendLine($"{lowestPosition} {highestPosition}");
            }

            Console.Write(output);

            int SearchLowestPosition(string name)
            {
                int l = 0, r = N;

                while (l < r)
                {
                    int m = (l + r) / 2;
                    int res = maxNames[m].CompareTo(name);

                    if (res > 0)
                        r = m;
                    else if (res < 0)
                        l = m + 1;
                    else
                        l = r = m;
                }

                return l + 1;
            }

            int SearchHighestPosition(string name)
            {
                int l = 0, r = N;

                while (l < r)
                {
                    int m = (l + r) / 2;
                    int res = minNames[m].CompareTo(name);

                    if (res > 0)
                        r = m;
                    else if (res < 0)
                        l = m + 1;
                    else
                        l = r = m + 1;
                }

                return l;
            }
        }
    }
}
