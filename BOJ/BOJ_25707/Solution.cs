namespace Algorithm.BOJ.BOJ_25707
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25707/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] beads = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int min = (int)1e9, max = 1;
            foreach (int num in beads)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }

            Console.WriteLine((max - min) * 2);
        }
    }
}
