namespace Algorithm.BOJ.BOJ_01764
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01764/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            string[] neverHeard = new string[N];
            for (int i = 0; i < N; i++) neverHeard[i] = sr.ReadLine()!;
            string[] neverSeen = new string[M];
            for (int i = 0; i < M; i++) neverSeen[i] = sr.ReadLine()!;
            string[] intersects = neverHeard.Intersect(neverSeen).OrderBy(n => n).ToArray();
            sw.WriteLine(intersects.Length);
            foreach (string name in intersects) sw.WriteLine(name);
            sr.Close();
            sw.Close();
        }
    }
}
