namespace Algorithm.BOJ.BOJ_03009
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03009/input1.txt",
            "BOJ/BOJ_03009/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] x = new string[3];
            string[] y = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string[] point = Console.ReadLine()!.Split();
                x[i] = point[0];
                y[i] = point[1];
            }
            string px = x[0] == x[1] ? x[2] : x[0] == x[2] ? x[1] : x[0];
            string py = y[0] == y[1] ? y[2] : y[0] == y[2] ? y[1] : y[0];
            Console.WriteLine($"{px} {py}");
        }
    }
}
