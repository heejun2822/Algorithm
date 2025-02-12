namespace Algorithm.BOJ.BOJ_04153
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04153/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                int[] sides = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                if (sides[0] == 0) break;

                Array.Sort(sides);

                bool isRightTriangle = sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];

                Console.WriteLine(isRightTriangle ? "right" : "wrong");
            }
        }
    }
}
