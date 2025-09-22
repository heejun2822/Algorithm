namespace Algorithm.BOJ.BOJ_10610
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10610/input1.txt",
            "BOJ/BOJ_10610/input2.txt",
            "BOJ/BOJ_10610/input3.txt",
            "BOJ/BOJ_10610/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string N = Console.ReadLine()!;

            int[] count = new int[10];
            int sum = 0;

            foreach (char c in N)
            {
                int d = c - '0';
                count[d]++;
                sum += d;
            }

            if (count[0] > 0 && sum % 3 == 0)
            {
                System.Text.StringBuilder output = new();
                for (char c = '9'; c >= '0'; c--)
                    output.Append(new string(c, count[c - '0']));
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
