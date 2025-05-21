namespace Algorithm.BOJ.BOJ_01681
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01681/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nl = Console.ReadLine()!.Split();
            int N = int.Parse(nl[0]);
            int L = int.Parse(nl[1]);

            int num = 0;
            int cnt = 0;

            while (cnt < N)
            {
                if (!ContainsL(++num)) cnt++;
            }

            Console.WriteLine(num);

            bool ContainsL(int num)
            {
                while (num > 0)
                {
                    if (num % 10 == L) return true;
                    num /= 10;
                }
                return false;
            }
        }
    }
}
