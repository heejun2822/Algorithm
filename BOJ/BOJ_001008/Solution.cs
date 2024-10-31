namespace Algorithm.BOJ.BOJ_001008
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001008/input1.txt",
            "BOJ/BOJ_001008/input2.txt",
        ];

        public override void Run()
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            double answer = double.Parse(integers[0]) / double.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
