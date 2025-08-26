namespace Algorithm.BOJ.BOJ_10814
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10814/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int N = int.Parse(sr.ReadLine()!);
            (int id, int age, string name)[] members = new (int id, int age, string name)[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = sr.ReadLine()!.Split();
                members[i] = (i, int.Parse(info[0]), info[1]);
            }
            Array.Sort(members, (a, b) => a.age != b.age ? a.age - b.age : a.id - b.id);
            foreach ((int id, int age, string name) in members) sw.WriteLine($"{age} {name}");
            sr.Close();
            sw.Close();
        }
    }
}
