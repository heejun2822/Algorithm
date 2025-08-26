namespace Algorithm.BOJ.BOJ_17488
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17488/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] L = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[][] registeredStudents = new int[M + 1][];
            for (int i = 1; i <= M; i++) registeredStudents[i] = new int[L[i - 1]];

            int[] starts = new int[M + 1];
            int[] ends = new int[M + 1];

            List<int>[] studentBuckets = new List<int>[N];
            for (int i = 0; i < N; i++) studentBuckets[i] = new();

            for (int _ = 0; _ < 2; _++)
            {
                for (int s = 0; s < N; s++)
                {
                    int[] courses = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                    foreach (int c in courses)
                    {
                        if (c == -1) break;

                        if (ends[c] < registeredStudents[c].Length)
                            registeredStudents[c][ends[c]++] = s;
                        else
                            ends[c]++;
                    }
                }

                for (int c = 1; c <= M; c++)
                {
                    if (ends[c] > registeredStudents[c].Length) continue;

                    for (int i = starts[c]; i < ends[c]; i++)
                        studentBuckets[registeredStudents[c][i]].Add(c);
                    starts[c] = ends[c];
                }
            }

            for (int s = 0; s < N; s++)
            {
                if (studentBuckets[s].Count > 0)
                {
                    studentBuckets[s].Sort();
                    Console.WriteLine(string.Join(' ', studentBuckets[s]));
                }
                else
                    Console.WriteLine("망했어요");
            }
        }
    }
}
