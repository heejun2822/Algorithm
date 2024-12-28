namespace Algorithm.BOJ.BOJ_11116
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11116/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < n; _++)
            {
                int m = int.Parse(Console.ReadLine()!);
                int[] timesL = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                HashSet<int> timesR = Console.ReadLine()!.Split().Select(int.Parse).ToHashSet();

                int cnt = 0;
                for (int i = 0; i < m; i++)
                {
                    if (timesL[i] == 0) continue;

                    for (int j = i + 1; j < m; j++)
                    {
                        if (timesL[j] == timesL[i] + 500)
                        {
                            timesL[j] = 0;
                            break;
                        }
                    }

                    if (timesR.Contains(timesL[i] + 1000) && timesR.Contains(timesL[i] + 1500)) cnt++;
                }

                Console.WriteLine(cnt);
            }
        }
    }
}
