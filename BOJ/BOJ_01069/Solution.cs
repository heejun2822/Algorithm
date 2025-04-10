namespace Algorithm.BOJ.BOJ_01069
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01069/input1.txt",
            "BOJ/BOJ_01069/input2.txt",
            "BOJ/BOJ_01069/input3.txt",
            "BOJ/BOJ_01069/input4.txt",
            "BOJ/BOJ_01069/input5.txt",
            "BOJ/BOJ_01069/input6.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            int D = int.Parse(input[2]);
            int T = int.Parse(input[3]);

            double distance = Math.Sqrt(X * X + Y * Y);
            double minTime = 0;

            if (D <= T)
            {
                minTime = distance;
            }
            else
            {
                if (distance > D)
                {
                    double jumpCnt = Math.Ceiling(distance / D) - 2;
                    minTime += T * jumpCnt;
                    distance -= D * jumpCnt;

                    minTime += Math.Min(T + distance - D, T * 2);
                }
                else
                {
                    minTime = Math.Min(distance, Math.Min(T + D - distance, T * 2));
                }
            }

            Console.WriteLine(minTime);
        }
    }
}
