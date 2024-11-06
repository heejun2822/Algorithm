namespace Algorithm.BOJ.BOJ_25304
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25304/input1.txt",
            "BOJ/BOJ_25304/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int totalPrice = int.Parse(Console.ReadLine()!);
            int cnt = int.Parse(Console.ReadLine()!);
            int priceSum = 0;
            for (int i = 0; i < cnt; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                priceSum += int.Parse(info[0]) * int.Parse(info[1]);
            }
            string answer = totalPrice == priceSum ? "Yes" : "No";
            Console.WriteLine(answer);
        }
    }
}
