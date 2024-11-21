namespace Algorithm.BOJ.BOJ_29752
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_29752/input1.txt",
            "BOJ/BOJ_29752/input2.txt",
            "BOJ/BOJ_29752/input3.txt",
            "BOJ/BOJ_29752/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] solved = Console.ReadLine()!.Split();
            int maxStreak = 0;
            int streak = 0;
            foreach (string s in solved)
            {
                if (s == "0")
                {
                    maxStreak = Math.Max(maxStreak, streak);
                    streak = 0;
                    continue;
                }
                streak++;
            }
            maxStreak = Math.Max(maxStreak, streak);
            Console.WriteLine(maxStreak);
        }
    }
}
