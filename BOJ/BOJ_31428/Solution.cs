namespace Algorithm.BOJ.BOJ_31428
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31428/input1.txt",
            "BOJ/BOJ_31428/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Dictionary<char, int> counts = new() { {'C', 0}, {'S', 0}, {'I', 0}, {'A', 0} };
            for (int i = 0; i < N; i++)
            {
                counts[(char)Console.Read()]++;
                Console.Read();
            }
            char track = char.Parse(Console.ReadLine()!);

            Console.WriteLine(counts[track]);
        }
    }
}
