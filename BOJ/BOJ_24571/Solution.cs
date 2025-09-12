namespace Algorithm.BOJ.BOJ_24571
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24571/input1.txt",
            "BOJ/BOJ_24571/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int X = int.Parse(sr.ReadLine()!);
            string[,] sameGroups = new string[X, 2];
            for (int i = 0; i < X; i++)
            {
                string[] students = sr.ReadLine()!.Split();
                sameGroups[i, 0] = students[0];
                sameGroups[i, 1] = students[1];
            }

            int Y = int.Parse(sr.ReadLine()!);
            string[,] separateGroups = new string[Y, 2];
            for (int i = 0; i < Y; i++)
            {
                string[] students = sr.ReadLine()!.Split();
                separateGroups[i, 0] = students[0];
                separateGroups[i, 1] = students[1];
            }

            int G = int.Parse(sr.ReadLine()!);
            Dictionary<string, int> groups = new(3 * G);
            for (int g = 0; g < G; g++)
            {
                string[] students = sr.ReadLine()!.Split();
                for (int i = 0; i < 3; i++)
                    groups.Add(students[i], g);
            }

            int cnt = 0;

            for (int i = 0; i < X; i++)
                if (groups[sameGroups[i, 0]] != groups[sameGroups[i, 1]])
                    cnt++;
            for (int i = 0; i < Y; i++)
                if (groups[separateGroups[i, 0]] == groups[separateGroups[i, 1]])
                    cnt++;

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
