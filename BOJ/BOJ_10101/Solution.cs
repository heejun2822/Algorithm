namespace Algorithm.BOJ.BOJ_10101
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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
                int cnt = 0;
                if (angles[0] == angles[1]) cnt++;
                if (angles[0] == angles[2]) cnt++;
                if (angles[1] == angles[2]) cnt++;
                if (cnt == 3) answer = "Equilateral";
                else if (cnt == 1) answer = "Isosceles";
                else answer = "Scalene";
            }
            Console.WriteLine(answer);
        }
    }
}
