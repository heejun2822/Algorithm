namespace Algorithm.BOJ.BOJ_28375
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28375/input1.txt",
            "BOJ/BOJ_28375/input2.txt",
            "BOJ/BOJ_28375/input3.txt",
            "BOJ/BOJ_28375/input4.txt",
            "BOJ/BOJ_28375/input5.txt",
        ];

        public static void Run(string[] args)
        {
            string n = Console.ReadLine()!;

            int cnt = n.Length == 1 ? 1 : (n.Length - 1) * 10;

            cnt += n[0] - '0';

            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > n[0])
                    break;
                if (n[i] < n[0])
                {
                    cnt--;
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
