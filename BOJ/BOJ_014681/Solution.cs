namespace Algorithm.BOJ.BOJ_014681
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_014681/input1.txt",
            "BOJ/BOJ_014681/input2.txt",
        ];

        public override void Run()
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
