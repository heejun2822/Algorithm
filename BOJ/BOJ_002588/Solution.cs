namespace Algorithm.BOJ.BOJ_002588
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002588/input.txt",
        ];

        public override void Run()
        {
            int num1 = int.Parse(Console.ReadLine() ?? "");
            int num2 = int.Parse(Console.ReadLine() ?? "");
            int[] numbers = new int[4];
            numbers[3] = num2;
            numbers[2] = num2 / 100;
            num2 %= 100;
            numbers[1] = num2 / 10;
            numbers[0] = num2 % 10;
            foreach (int n in numbers)
            {
                Console.WriteLine(num1 * n);
            }
        }
    }
}
