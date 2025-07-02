namespace Algorithm.BOJ.BOJ_14545
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14545/input.txt",
        ];

        public static void Run(string[] args)
        {
            int P = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < P; _++)
            {
                long l = long.Parse(Console.ReadLine()!);
                Console.WriteLine(l * (l + 1) * (2 * l + 1) / 6);
            }
        }
    }
}
