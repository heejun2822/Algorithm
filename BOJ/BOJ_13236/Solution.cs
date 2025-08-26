namespace Algorithm.BOJ.BOJ_13236
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13236/input1.txt",
            "BOJ/BOJ_13236/input2.txt",
            "BOJ/BOJ_13236/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (n != 1)
            {
                output.Append(n).Append(' ');
                n = n % 2 == 0 ? n / 2 : n * 3 + 1;
            }
            output.Append(1);

            Console.WriteLine(output);
        }
    }
}
