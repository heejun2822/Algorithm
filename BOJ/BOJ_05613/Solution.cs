namespace Algorithm.BOJ.BOJ_05613
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05613/input1.txt",
            "BOJ/BOJ_05613/input2.txt",
            "BOJ/BOJ_05613/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int ans = int.Parse(Console.ReadLine()!);

            while (true)
            {
                char opr = char.Parse(Console.ReadLine()!);

                if (opr == '=') break;

                int num = int.Parse(Console.ReadLine()!);

                if (opr == '+')
                    ans += num;
                else if (opr == '-')
                    ans -= num;
                else if (opr == '*')
                    ans *= num;
                else if (opr == '/')
                    ans /= num;
            }

            Console.WriteLine(ans);
        }
    }
}
