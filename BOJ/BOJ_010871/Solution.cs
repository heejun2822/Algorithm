namespace Algorithm.BOJ.BOJ_010871
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_010871/input.txt",
        ];

        public override void Run()
        {
            string[] nx = Console.ReadLine()!.Split();
            int N = int.Parse(nx[0]);
            int X = int.Parse(nx[1]);
            int[] A = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            string answer = string.Join(" ", A.Where(n => n < X));
            Console.WriteLine(answer);
        }
    }
}
