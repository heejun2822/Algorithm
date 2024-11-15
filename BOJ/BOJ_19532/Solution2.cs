namespace Algorithm.BOJ.BOJ_19532
{
    public class Solution2
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
            int x = (b * f - e * c) / (b * d - e * a);
            int y = (a * f - d * c) / (a * e - d * b);
            Console.WriteLine($"{x} {y}");
        }
    }
}
