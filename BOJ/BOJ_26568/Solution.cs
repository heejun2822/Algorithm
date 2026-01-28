namespace Algorithm.BOJ.BOJ_26568
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26568/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            while (n-- > 0)
            {
                int w = int.Parse(Console.ReadLine()!);
                int m = int.Parse(Console.ReadLine()!);

                System.Text.StringBuilder output = new();
                int len = 0;

                while (m-- > 0)
                {
                    foreach (string word in Console.ReadLine()!.Split())
                    {
                        if (len + word.Length > w)
                        {
                            output.AppendLine();
                            len = 0;
                        }
                        output.Append(word).Append(' ');
                        len += word.Length + 1;
                    }
                }
                output.AppendLine();

                Console.WriteLine(output);
            }
        }
    }
}
