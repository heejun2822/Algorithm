namespace Algorithm.BOJ.BOJ_28088
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_28088/input1.txt",
            "BOJ/BOJ_28088/input2.txt",
            "BOJ/BOJ_28088/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nmk = Console.ReadLine()!.Split();
            int N = int.Parse(nmk[0]);
            int M = int.Parse(nmk[1]);
            int K = int.Parse(nmk[2]);
            bool[] greeting = new bool[N];
            for (int _ = 0; _ < M; _++)
                greeting[int.Parse(Console.ReadLine()!)] = true;

            for (int _ = 0; _ < K; _++)
            {
                bool first = greeting[0];
                greeting[0] = false;

                bool prev = first;
                for (int i = 1; i < N; i++)
                {
                    bool curr = greeting[i];
                    greeting[i] = false;
                    if (curr) greeting[i - 1] = !greeting[i - 1];
                    if (prev) greeting[i] = !greeting[i];
                    prev = curr;
                }

                if (first) greeting[N - 1] = !greeting[N - 1];
                if (prev) greeting[0] = !greeting[0];
            }

            Console.WriteLine(greeting.Count(e => e));
        }
    }
}
