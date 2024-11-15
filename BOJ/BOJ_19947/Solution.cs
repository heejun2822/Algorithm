namespace Algorithm.BOJ.BOJ_19947
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_19947/input1.txt",
            "BOJ/BOJ_19947/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int H = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            int[] balances = new int[Y + 1];
            balances[0] = H;
            for (int i = 1; i <= Y; i++)
            {
                balances[i] = (int)(balances[i - 1] * 1.05);
                if (i >= 3) balances[i] = Math.Max(balances[i], (int)(balances[i - 3] * 1.2));
                if (i >= 5) balances[i] = Math.Max(balances[i], (int)(balances[i - 5] * 1.35));
            }
            Console.WriteLine(balances[Y]);
        }
    }
}
