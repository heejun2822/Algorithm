namespace Algorithm.BOJ.BOJ_10101
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10101/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] angles = new int[3];
            for (int i = 0; i < 3; i++) angles[i] = int.Parse(Console.ReadLine()!);
            string answer = "Error";
            if (angles.Sum() == 180)
            {
                if (angles[0] == angles[1]) answer = angles[0] == angles[2] ? "Equilateral" : "Isosceles";
                else answer = (angles[0] == angles[2] || angles[1] == angles[2]) ? "Isosceles" : "Scalene";
            }
            Console.WriteLine(answer);
        }
    }
}
