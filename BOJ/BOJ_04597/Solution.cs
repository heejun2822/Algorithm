namespace Algorithm.BOJ.BOJ_04597
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04597/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;

            System.Text.StringBuilder output = new();

            while ((input = Console.ReadLine()!) != "#")
            {
                bool isEven = true;

                foreach (char c in input)
                    if (c == '1')
                        isEven = !isEven;

                output.Append(input[..^1]).AppendLine((isEven ^ (input[^1] == 'e')) ? "1" : "0");
            }

            Console.Write(output);
        }
    }
}
