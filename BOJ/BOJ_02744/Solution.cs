namespace Algorithm.BOJ.BOJ_02744
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02744/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input = Console.ReadLine()!;
            System.Text.StringBuilder output = new();

            foreach (char c in input)
                output.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));

            Console.WriteLine(output);
        }
    }
}
