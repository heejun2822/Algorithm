namespace Algorithm.BOJ.BOJ_16083
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16083/input1.txt",
            "BOJ/BOJ_16083/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            BinarySearchTree bst = new();

            int n = ReadInt(sr);

            while (n-- > 0)
            {
                int a = ReadInt(sr);
                int level = bst.Add(a);
                sw.Write(level);
                sw.Write(' ');
            }
            sw.WriteLine();

            sr.Close();
            sw.Close();
        }

        private class BinarySearchTree
        {
            private Node? _rootNode;

            public int Add(int value)
            {
                int level = 0;

                if (_rootNode == null)
                    _rootNode = new(value);
                else
                    _rootNode.Add(value, ref level);

                return level;
            }
        }

        private class Node
        {
            private int _value;
            private Node? _leftNode;
            private Node? _rightNode;

            public Node(int value)
            {
                _value = value;
            }

            public void Add(int value, ref int level)
            {
                level++;

                if (value < _value)
                {
                    if (_leftNode == null)
                        _leftNode = new(value);
                    else
                        _leftNode.Add(value, ref level);
                }
                else
                {
                    if (_rightNode == null)
                        _rightNode = new(value);
                    else
                        _rightNode.Add(value, ref level);
                }
            }
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
