namespace Algorithm.BOJ.BOJ_07656
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07656/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input = Console.ReadLine()!;
            string q = "What is";

            int idx = 0;
            while (idx + q.Length - 1 < input.Length)
            {
                int s = idx + q.Length;
                for (int i = 0; i < q.Length; i++)
                {
                    if (input[idx++] != q[i])
                    {
                        s = -1;
                        break;
                    }
                }

                if (s == -1) continue;

                idx--;
                while (++idx < input.Length)
                {
                    if (input[idx] == '.') break;
                    if (input[idx] == '?')
                    {
                        Console.Write("Forty-two is");
                        for (int i = s; i < idx; i++) Console.Write(input[i]);
                        Console.WriteLine(".");
                        break;
                    }
                }
            }
        }
    }
}
