namespace Algorithm.BOJ.BOJ_03447
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03447/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine()!;
                if (line == null) return;
                while (line.Contains("BUG")) line = line.Replace("BUG", "");
                Console.WriteLine(line);
            }
        }
    }
}
