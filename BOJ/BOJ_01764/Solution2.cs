namespace Algorithm.BOJ.BOJ_01764
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
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
            HashSet<string> names = new(N);
            for (int _ = 0; _ < N; _++) names.Add(sr.ReadLine()!);
            SortedSet<string> list = new();
            for (int _ = 0; _ < M; _++)
            {
                string name = sr.ReadLine()!;
                if (names.Contains(name)) list.Add(name);
            }
            sw.WriteLine(list.Count);
            foreach (string name in list) sw.WriteLine(name);
            sr.Close();
            sw.Close();
        }
    }
}
