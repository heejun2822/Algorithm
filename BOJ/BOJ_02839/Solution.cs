namespace Algorithm.BOJ.BOJ_02839
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02839/input1.txt",
            "BOJ/BOJ_02839/input2.txt",
            "BOJ/BOJ_02839/input3.txt",
            "BOJ/BOJ_02839/input4.txt",
            "BOJ/BOJ_02839/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int sugar = N % 5;
            int cnt_5 = N / 5;
            while (sugar % 3 != 0)
            {
                if (cnt_5 == 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
                cnt_5--;
                sugar += 5;
            }
            int cnt_3 = sugar / 3;
            Console.WriteLine(cnt_5 + cnt_3);
        }
    }
}
