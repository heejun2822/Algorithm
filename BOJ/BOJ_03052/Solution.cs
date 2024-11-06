namespace Algorithm.BOJ.BOJ_03052
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03052/input1.txt",
            "BOJ/BOJ_03052/input2.txt",
            "BOJ/BOJ_03052/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()!);
            }
            int cnt = numbers.Select(n => n % 42).Distinct().Count();
            Console.WriteLine(cnt);
        }
    }
}
