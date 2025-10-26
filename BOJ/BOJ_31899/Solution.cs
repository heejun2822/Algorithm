namespace Algorithm.BOJ.BOJ_31899
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31899/input1.txt",
            "BOJ/BOJ_31899/input2.txt",
            "BOJ/BOJ_31899/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;
            string result = "";

            result += str[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[0])
                {
                    result += str[i];

                    if (str[^1] == str[0])
                    {
                        result += str[^1];
                    }

                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
