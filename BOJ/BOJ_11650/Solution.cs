namespace Algorithm.BOJ.BOJ_11650
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11650/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int x, int y)[] points = new (int x, int y)[N];
            for (int i = 0; i < N; i++)
            {
                string[] point = Console.ReadLine()!.Split();
                points[i] = (int.Parse(point[0]), int.Parse(point[1]));
            }
            (int x, int y)[] sortedPoints = points.OrderBy(p => p.x).ThenBy(p => p.y).ToArray();
            StringBuilder answer = new();
            foreach ((int x, int y) in sortedPoints) answer.AppendLine($"{x} {y}");
            Console.WriteLine(answer);
        }
    }
}
