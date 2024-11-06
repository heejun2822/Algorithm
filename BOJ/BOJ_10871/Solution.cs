namespace Algorithm.BOJ.BOJ_10871
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10871/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nx = Console.ReadLine()!.Split();
            int N = int.Parse(nx[0]);
            int X = int.Parse(nx[1]);
            int[] A = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            string answer = string.Join(" ", A.Where(n => n < X));
            Console.WriteLine(answer);
        }
    }
}
