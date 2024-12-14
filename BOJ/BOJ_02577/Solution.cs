namespace Algorithm.BOJ.BOJ_02577
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02577/input.txt",
        ];

        public static void Run(string[] args)
        {
            int num = 1;
            for (int _ = 0; _ < 3; _++) num *= int.Parse(Console.ReadLine()!);

            int[] counts = new int[10];
            while (num > 0)
            {
                counts[num % 10]++;
                num /= 10;
            }

            foreach (int cnt in counts) Console.WriteLine(cnt);
        }
    }
}
