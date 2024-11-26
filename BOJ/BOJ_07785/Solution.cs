namespace Algorithm.BOJ.BOJ_07785
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07785/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int n = int.Parse(sr.ReadLine()!);
            HashSet<string> presents = new();
            for (int _ = 0; _ < n; _++)
            {
                string[] log = sr.ReadLine()!.Split();
                if (log[1] == "enter") presents.Add(log[0]);
                else presents.Remove(log[0]);
            }
            string[] names = presents.ToArray();
            Array.Sort(names, (a, b) => b.CompareTo(a));
            foreach (string name in names) sw.WriteLine(name);
            sr.Close();
            sw.Close();
        }
    }
}
