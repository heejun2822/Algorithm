namespace Algorithm.BOJ.BOJ_10866
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10866/input1.txt",
            "BOJ/BOJ_10866/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            LinkedList<int> Deque = new();

            for (int _ = 0; _ < N; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                string command = input[0];
                int X = input.Length == 2 ? int.Parse(input[1]) : 0;

                switch (command)
                {
                    case "push_front":
                        Deque.AddFirst(X);
                        break;
                    case "push_back":
                        Deque.AddLast(X);
                        break;
                    case "pop_front":
                        sw.WriteLine(Deque.First == null ? "-1" : Deque.First.Value);
                        if (Deque.Count > 0) Deque.RemoveFirst();
                        break;
                    case "pop_back":
                        sw.WriteLine(Deque.Last == null ? "-1" : Deque.Last.Value);
                        if (Deque.Count > 0) Deque.RemoveLast();
                        break;
                    case "size":
                        sw.WriteLine(Deque.Count);
                        break;
                    case "empty":
                        sw.WriteLine(Deque.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sw.WriteLine(Deque.First == null ? "-1" : Deque.First.Value);
                        break;
                    case "back":
                        sw.WriteLine(Deque.Last == null ? "-1" : Deque.Last.Value);
                        break;
                    default:
                        break;
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
