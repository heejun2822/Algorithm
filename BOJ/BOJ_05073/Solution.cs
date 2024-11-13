namespace Algorithm.BOJ.BOJ_05073
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05073/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder answer = new();
            while (true)
            {
                int[] sides = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                Array.Sort(sides);
                if (sides[0] == 0) break;
                if (sides[0] + sides[1] > sides[2])
                {
                    if (sides[0] == sides[1] && sides[0] == sides[2]) answer.AppendLine("Equilateral");
                    else if (sides[0] == sides[1] || sides[0] == sides[2] || sides[1] == sides[2]) answer.AppendLine("Isosceles");
                    else answer.AppendLine("Scalene");
                }
                else answer.AppendLine("Invalid");
            }
            Console.WriteLine(answer);
        }
    }
}
