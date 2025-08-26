namespace Algorithm.BOJ.BOJ_01620
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01620/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            string[] numberMap = new string[N + 1];
            Dictionary<string, int> nameMap = new();
            for (int i = 1; i <= N; i++)
            {
                string name = sr.ReadLine()!;
                numberMap[i] = name;
                nameMap.Add(name, i);
            }
            for (int _ = 0; _ < M; _++)
            {
                string question = sr.ReadLine()!;
                if (question[0] >= 'A' && question[0] <= 'Z') sw.WriteLine(nameMap[question]);
                else sw.WriteLine(numberMap[int.Parse(question)]);
            }
            sr.Close();
            sw.Close();
        }
    }
}
