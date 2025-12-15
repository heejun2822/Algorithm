namespace Algorithm.BOJ.BOJ_25381
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25381/input1.txt",
            "BOJ/BOJ_25381/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;

            Stack<int> indicesA = new();
            LinkedList<int> indicesB = new();
            Queue<int> indicesC = new();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'A')
                    indicesA.Push(i);
                else if (S[i] == 'B')
                    indicesB.AddLast(i);
                else if (S[i] == 'C')
                    indicesC.Enqueue(i);
            }

            int cnt = 0;

            while (indicesA.Count > 0 && indicesB.Count > 0)
            {
                if (indicesB.Last!.Value > indicesA.Pop())
                {
                    indicesB.RemoveLast();
                    cnt++;
                }
            }
            while (indicesC.Count > 0 && indicesB.Count > 0)
            {
                if (indicesB.First!.Value < indicesC.Dequeue())
                {
                    indicesB.RemoveFirst();
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
