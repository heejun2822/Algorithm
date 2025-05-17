namespace Algorithm.BOJ.BOJ_01145
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01145/input1.txt",
            "BOJ/BOJ_01145/input2.txt",
            "BOJ/BOJ_01145/input3.txt",
            "BOJ/BOJ_01145/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int n = 1;

            while (true)
            {
                int cnt = 0;

                for (int i = 0; i < 5; i++)
                    if (n % numbers[i] == 0 && ++cnt == 3)
                    {
                        Console.WriteLine(n);
                        return;
                    }

                n++;
            }
        }
    }
}
