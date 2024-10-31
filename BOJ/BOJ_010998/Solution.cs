using Algorithm;

namespace BOJ_010998
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010998/input1.txt",
            "BOJ/BOJ_010998/input2.txt",
        ];

        public override void Run()
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            int answer = int.Parse(integers[0]) * int.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
