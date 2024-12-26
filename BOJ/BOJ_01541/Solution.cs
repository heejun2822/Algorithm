namespace Algorithm.BOJ.BOJ_01541
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01541/input1.txt",
            "BOJ/BOJ_01541/input2.txt",
            "BOJ/BOJ_01541/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] terms = Console.ReadLine()!.Split('-');

            int ans = 0;
            for (int i = 0; i < terms.Length; i++)
            {
                int sum = 0;
                string[] numbers = terms[i].Split('+');
                foreach (string num in numbers) sum += int.Parse(num);
                ans += i == 0 ? sum : -sum;
            }

            Console.WriteLine(ans);
        }
    }
}
