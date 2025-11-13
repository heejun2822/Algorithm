namespace Algorithm.BOJ.BOJ_32219
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32219/input.txt",
        ];

        public static void Run(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);

            while (t-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int r = int.Parse(input[0]);
                int c = int.Parse(input[1]);

                if (r == c)
                {
                    Console.WriteLine("dohoon");
                }
                else
                {
                    Console.WriteLine("jinseo");
                    int m = Math.Min(r, c);
                    Console.WriteLine($"{m} {m}");
                }
            }
        }
    }
}
