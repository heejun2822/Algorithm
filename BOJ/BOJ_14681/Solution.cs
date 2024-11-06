namespace Algorithm.BOJ.BOJ_14681
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14681/input1.txt",
            "BOJ/BOJ_14681/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            int quadrant;
            if (x > 0 && y > 0) quadrant = 1;
            else if (x < 0 && y > 0) quadrant = 2;
            else if (x < 0 && y < 0) quadrant = 3;
            else quadrant = 4;
            Console.WriteLine(quadrant);
        }
    }
}
