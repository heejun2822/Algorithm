namespace Algorithm.BOJ.BOJ_12924
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12924/input1.txt",
            "BOJ/BOJ_12924/input2.txt",
            "BOJ/BOJ_12924/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int A = int.Parse(input[0]), B = int.Parse(input[1]);

            int P = (int)Math.Pow(10, A.ToString().Length);
            int cnt = 0;

            for (int x = A; x < B; x++)
            {
                int y = x;
                do
                {
                    y *= 10;
                    y = y % P + y / P;

                    if (y > x && y <= B)
                        cnt++;
                } while (y != x);
            }

            Console.WriteLine(cnt);
        }
    }
}
