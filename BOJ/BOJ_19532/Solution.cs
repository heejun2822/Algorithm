namespace Algorithm.BOJ.BOJ_19532
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_19532/input1.txt",
            "BOJ/BOJ_19532/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);
            int f = int.Parse(numbers[5]);
            int x = 0, y = 0;
            if (a == 0)
            {
                y = c / b;
                x = (f - e * y) / d;
            }
            else if (b == 0)
            {
                x = c / a;
                y = (f - d * x) / e;
            }
            else if (d == 0)
            {
                y = f / e;
                x = (c - b * y) / a;
            }
            else if (e == 0)
            {
                x = f / d;
                y = (c - a * x) / b;
            }
            else
            {
                y = (a * f - d * c) / (a * e - d * b);
                x = (c - b * y) / a;
            }
            Console.WriteLine($"{x} {y}");
        }
    }
}
