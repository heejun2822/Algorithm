namespace Algorithm.BOJ.BOJ_11999
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11999/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] pails = Console.ReadLine()!.Split();
            int X = int.Parse(pails[0]);
            int Y = int.Parse(pails[1]);
            int M = int.Parse(pails[2]);

            int itr = M / Y;
            int milk = Y * itr;
            int max = 0;
            for (int _ = 0; _ < itr + 1; _++)
            {
                while (milk + X <= M) milk += X;
                if (milk > max) max = milk;
                milk -= Y;
            }

            Console.WriteLine(max);
        }
    }
}
