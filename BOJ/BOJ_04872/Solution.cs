namespace Algorithm.BOJ.BOJ_04872
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04872/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input = Console.ReadLine()!;
            int D = input.Length;
            int[] wheels = new int[D];

            for (int i = 0; i < D; i++)
                wheels[i] = input[i] - '0';

            while ((input = Console.ReadLine()!) != null)
            {
                for (int i = 0; i < D; i++)
                    wheels[i] += input[i] - '0';
            }

            for (int i = 0; i < D; i++)
                wheels[i] %= 10;

            Console.WriteLine(string.Join("", wheels));
        }
    }
}
