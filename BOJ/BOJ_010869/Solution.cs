namespace Algorithm.BOJ.BOJ_010869
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010869/input.txt",
        ];

        public override void Run()
        {
            int[] numbers = (Console.ReadLine() ?? "").Split().Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(numbers[0] + numbers[1]);
            Console.WriteLine(numbers[0] - numbers[1]);
            Console.WriteLine(numbers[0] * numbers[1]);
            Console.WriteLine(numbers[0] / numbers[1]);
            Console.WriteLine(numbers[0] % numbers[1]);
        }
    }
}
