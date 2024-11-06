namespace Algorithm.BOJ.BOJ_003003
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_003003/input1.txt",
            "BOJ/BOJ_003003/input2.txt",
        ];

        public override void Run()
        {
            int[] s_pieces = new int[] {1, 1, 2, 2, 2, 8};
            string[] pieces = Console.ReadLine()!.Split();
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer += $"{s_pieces[i] - int.Parse(pieces[i])} ";
            }
            Console.WriteLine(answer);
        }
    }
}
