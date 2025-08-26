namespace Algorithm.BOJ.BOJ_11816
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11816/input1.txt",
            "BOJ/BOJ_11816/input2.txt",
            "BOJ/BOJ_11816/input3.txt",
            "BOJ/BOJ_11816/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string X = Console.ReadLine()!;
            int decimalX;

            if (X[0] == '0')
                if (X[1] == 'x')
                    decimalX = Convert.ToInt32(X[2..], 16);
                else
                    decimalX = Convert.ToInt32(X[1..], 8);
            else
                decimalX = Convert.ToInt32(X, 10);

            Console.WriteLine(decimalX);
        }
    }
}
