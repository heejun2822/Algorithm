namespace Algorithm.BOJ.BOJ_22277
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_22277/input1.txt",
            "BOJ/BOJ_22277/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string balance = Console.ReadLine()!;
            int cents = int.Parse(balance[^2..]);

            int cnt = 0;
            for (int _ = 0; _ < N; _++)
            {
                string deposit = Console.ReadLine()!;
                cents += int.Parse(deposit[^2..]);
                if (cents % 100 != 0) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
