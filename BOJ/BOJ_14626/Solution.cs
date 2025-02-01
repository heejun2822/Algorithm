namespace Algorithm.BOJ.BOJ_14626
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14626/input.txt",
        ];

        public static void Run(string[] args)
        {
            int num = 0;
            int weight = 1;
            for (int i = 1; i <= 13; i++)
            {
                char d = (char)Console.Read();
                int w = i % 2 == 1 ? 1 : 3;

                if (d == '*') weight = w;
                else num += (d - '0') * w;
            }

            for (int d = 0; d <= 9; d++)
            {
                if ((num + d * weight) % 10 == 0)
                {
                    Console.WriteLine(d);
                    break;
                }
            }
        }
    }
}
