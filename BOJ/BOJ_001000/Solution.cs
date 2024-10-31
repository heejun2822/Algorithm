using Algorithm;

namespace BOJ_001000
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001000/input.txt",
        ];

        public override void Run()
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            int answer = int.Parse(integers[0]) + int.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
