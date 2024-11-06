namespace Algorithm.BOJ.BOJ_10430
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10430/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = (Console.ReadLine() ?? "").Split();
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            int C = int.Parse(numbers[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
