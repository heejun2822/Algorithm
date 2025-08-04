namespace Algorithm.BOJ.BOJ_06211
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06211/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int C = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int[] calories = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int maxCalory = 0;
            FindMaxCalory(0, 0);

            Console.WriteLine(maxCalory);

            void FindMaxCalory(int idx, int calory)
            {
                if (calory > C) return;

                maxCalory = Math.Max(maxCalory, calory);

                if (idx == B) return;

                FindMaxCalory(idx + 1, calory + calories[idx]);
                FindMaxCalory(idx + 1, calory);
            }
        }
    }
}
