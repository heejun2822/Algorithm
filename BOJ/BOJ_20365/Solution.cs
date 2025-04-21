namespace Algorithm.BOJ.BOJ_20365
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20365/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Dictionary<char, int> counts = new() { {'B', 0}, {'R', 0} };
            char prevColor = ' ';

            for (int _ = 0; _ < N; _++)
            {
                char color = (char)Console.Read();
                if (color != prevColor) counts[color]++;
                prevColor = color;
            }

            Console.WriteLine(Math.Min(counts['B'], counts['R']) + 1);
        }
    }
}
