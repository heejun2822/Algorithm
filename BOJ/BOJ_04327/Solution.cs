namespace Algorithm.BOJ.BOJ_04327
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04327/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder output = new();

            while (true)
            {
                int[] marks = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                if (marks[0] == 0 && marks[1] == 0 && marks[2] == 0 && marks[3] == 0) break;

                int degree = 0;

                degree += 720;
                degree += (marks[0] - marks[1] + 40) % 40 * 9;
                degree += 360;
                degree += (marks[2] - marks[1] + 40) % 40 * 9;
                degree += (marks[2] - marks[3] + 40) % 40 * 9;

                output.AppendLine(degree.ToString());
            }

            Console.Write(output);
        }
    }
}
