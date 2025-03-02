namespace Algorithm.BOJ.BOJ_25841
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25841/input1.txt",
            "BOJ/BOJ_25841/input2.txt",
            "BOJ/BOJ_25841/input3.txt",
            "BOJ/BOJ_25841/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int rangeS = int.Parse(input[0]);
            int rangeE = int.Parse(input[1]);
            char digit = char.Parse(input[2]);

            int cnt = 0;

            for (int n = rangeS; n <= rangeE; n++)
                foreach (char d in n.ToString())
                    if (d == digit) cnt++;

            Console.WriteLine(cnt);
        }
    }
}
