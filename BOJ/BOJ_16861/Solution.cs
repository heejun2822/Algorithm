namespace Algorithm.BOJ.BOJ_16861
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16861/input1.txt",
            "BOJ/BOJ_16861/input2.txt",
            "BOJ/BOJ_16861/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            while (true)
            {
                int temp = n;
                int digitSum = 0;
                while (temp > 0)
                {
                    digitSum += temp % 10;
                    temp /= 10;
                }
                if (n % digitSum == 0)
                {
                    Console.WriteLine(n);
                    return;
                }
                n++;
            }
        }
    }
}
