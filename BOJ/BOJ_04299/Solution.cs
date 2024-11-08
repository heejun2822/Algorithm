namespace Algorithm.BOJ.BOJ_04299
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04299/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] info = Console.ReadLine()!.Split();
            int sum = int.Parse(info[0]);
            int diff = int.Parse(info[1]);
            string answer;
            if (sum < diff || (sum + diff) % 2 == 1) answer = "-1";
            else answer = $"{(sum + diff) / 2} {(sum - diff) / 2}";
            Console.WriteLine(answer);
        }
    }
}
