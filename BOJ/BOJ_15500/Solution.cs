namespace Algorithm.BOJ.BOJ_15500
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15500/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Stack<int> rod1 = new(a);
            Stack<int> rod2 = new();

            System.Text.StringBuilder answer = new();
            int cnt = 0;

            for (int i = N; i > 0; i--)
            {
                if (rod1.Contains(i))
                {
                    int disc;
                    while ((disc = rod1.Pop()) != i)
                    {
                        rod2.Push(disc);
                        answer.AppendLine("1 2");
                        cnt++;
                    }
                    answer.AppendLine("1 3");
                    cnt++;
                }
                else
                {
                    int disc;
                    while ((disc = rod2.Pop()) != i)
                    {
                        rod1.Push(disc);
                        answer.AppendLine("2 1");
                        cnt++;
                    }
                    answer.AppendLine("2 3");
                    cnt++;
                }
            }

            answer.Insert(0, $"{cnt}\n");

            Console.Write(answer);
        }
    }
}
