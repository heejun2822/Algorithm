namespace Algorithm.BOJ.BOJ_025304
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_025304/input1.txt",
            "BOJ/BOJ_025304/input2.txt",
        ];

        public override void Run()
        {
            int totalPrice = int.Parse(Console.ReadLine()!);
            int cnt = int.Parse(Console.ReadLine()!);
            int priceSum = 0;
            for (int i = 0; i < cnt; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                priceSum += int.Parse(info[0]) * int.Parse(info[1]);
            }
            string answer = totalPrice == priceSum ? "Yes" : "No";
            Console.WriteLine(answer);
        }
    }
}
