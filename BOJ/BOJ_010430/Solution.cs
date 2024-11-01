namespace Algorithm.BOJ.BOJ_010430
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010430/input.txt",
        ];

        public override void Run()
        {
            string[] numbers = (Console.ReadLine() ?? "").Split();
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            int C = int.Parse(numbers[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
