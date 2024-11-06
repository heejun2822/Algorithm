namespace Algorithm.BOJ.BOJ_10807
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10807/input1.txt",
            "BOJ/BOJ_10807/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] numbers = Console.ReadLine()!.Split();
            string v = Console.ReadLine()!;
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (numbers[i] == v) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
