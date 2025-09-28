namespace Algorithm.BOJ.BOJ_01406
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01406/input1.txt",
            "BOJ/BOJ_01406/input2.txt",
            "BOJ/BOJ_01406/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            LinkedList<char> list = new(sr.ReadLine()!);
            list.AddFirst('_');
            LinkedListNode<char> node = list.Last!;

            int M = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < M; _++)
            {
                string[] input = sr.ReadLine()!.Split();

                if (input[0] == "L")
                {
                    if (node == list.First) continue;
                    node = node.Previous!;
                }
                else if (input[0] == "D")
                {
                    if (node == list.Last) continue;
                    node = node.Next!;
                }
                else if (input[0] == "B")
                {
                    if (node == list.First) continue;
                    node = node.Previous!;
                    list.Remove(node.Next!);
                }
                else if (input[0] == "P")
                {
                    char c = char.Parse(input[1]);
                    list.AddAfter(node, c);
                    node = node.Next!;
                }
            }

            System.Text.StringBuilder output = new();

            node = list.First!;
            for (int _ = 1; _ < list.Count; _++)
            {
                node = node.Next!;
                output.Append(node.Value);
            }

            sw.WriteLine(output);

            sr.Close();
            sw.Close();
        }
    }
}
