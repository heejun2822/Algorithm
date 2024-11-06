namespace Algorithm.BOJ.BOJ_11382
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11382/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = (Console.ReadLine() ?? "").Split();
            long answer = numbers.Aggregate(0L, (acc, cur) => acc + long.Parse(cur));
            Console.WriteLine(answer);
        }
    }
}
