namespace Algorithm.BOJ.BOJ_20959
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20959/input1.txt",
            "BOJ/BOJ_20959/input2.txt",
            "BOJ/BOJ_20959/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!;

            HashSet<long> numbers = new();
            long num = 0;

            foreach (char c in word)
            {
                if (char.IsDigit(c))
                    num = num * 10 + c - '0';
                else if (num > 0)
                {
                    numbers.Add(num);
                    num = 0;
                }
            }
            if (num > 0)
                numbers.Add(num);

            Console.WriteLine(numbers.Count);
        }
    }
}
