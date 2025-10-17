namespace Algorithm.BOJ.BOJ_15084
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15084/input1.txt",
            "BOJ/BOJ_15084/input2.txt",
            "BOJ/BOJ_15084/input3.txt",
            "BOJ/BOJ_15084/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int d = int.Parse(input[1]);

            HashSet<int> appeared = new();
            List<int> decimals = new() { 0 };
            bool isValid;

            while (isValid = appeared.Add(n))
            {
                n *= 10;
                int q = n / d;

                if (q == 0)
                {
                    break;
                }
                if (q == 9)
                {
                    decimals[^1]++;
                    break;
                }

                decimals.Add(q);
                n -= d * q;
            }

            if (!isValid)
            {
                Console.WriteLine("throw out");
                return;
            }

            System.Text.StringBuilder output = new();
            output.Append(decimals[0]);

            if (decimals.Count > 1)
            {
                output.Append('.');
                for (int i = 1; i < decimals.Count; i++)
                    output.Append(decimals[i]);
            }

            Console.WriteLine(output);
        }
    }
}
