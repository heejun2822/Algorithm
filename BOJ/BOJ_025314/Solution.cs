namespace Algorithm.BOJ.BOJ_025314
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_025314/input1.txt",
            "BOJ/BOJ_025314/input2.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            string answer = "int";
            for (int i = 0; i < N / 4; i++)
            {
                answer = "long " + answer;
            }
            Console.WriteLine(answer);
        }
    }
}
