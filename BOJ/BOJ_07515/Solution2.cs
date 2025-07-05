namespace Algorithm.BOJ.BOJ_07515
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07515/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] counts = new int[41];
            counts[0] = 1;
            counts[1] = 2;

            for (int i = 2; i <= 40; i++)
                counts[i] = counts[i - 1] + counts[i - 2];

            int num = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"Scenario {i}:\n{counts[n]}\n");
            }
        }
    }
}
