namespace Algorithm.BOJ.BOJ_11720
{
    public class Solution3
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11720/input1.txt",
            "BOJ/BOJ_11720/input2.txt",
            "BOJ/BOJ_11720/input3.txt",
            "BOJ/BOJ_11720/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string numbers = Console.ReadLine()!;
            int sum = numbers.Aggregate(0, (acc, cur) => acc += cur - '0');
            Console.WriteLine(sum);
        }
    }
}
