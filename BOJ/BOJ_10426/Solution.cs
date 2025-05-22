namespace Algorithm.BOJ.BOJ_10426
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10426/input1.txt",
            "BOJ/BOJ_10426/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            string[] date = input[0].Split('-');
            int Y = int.Parse(date[0]);
            int M = int.Parse(date[1]);
            int D = int.Parse(date[2]);
            int N = int.Parse(input[1]) - 1;

            while (N > 0)
            {
                int days = 31;
                if (M == 4 || M == 6 || M == 9 || M == 11) days = 30;
                else if (M == 2)
                {
                    if (Y % 4 == 0 && (Y % 100 > 0 || Y % 400 == 0)) days = 29;
                    else days = 28;
                }

                days -= D - 1;

                if (days <= N)
                {
                    if (++M == 13) { Y++; M = 1; }
                    D = 1;
                    N -= days;
                }
                else
                {
                    D += N;
                    N = 0;
                }
            }

            Console.WriteLine($"{Y}-{M.ToString("D2")}-{D.ToString("D2")}");
        }
    }
}
