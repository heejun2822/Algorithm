namespace Algorithm.BOJ.BOJ_01000
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01000/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            int answer = int.Parse(integers[0]) + int.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
