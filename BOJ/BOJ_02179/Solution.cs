namespace Algorithm.BOJ.BOJ_02179
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02179/input1.txt",
            "BOJ/BOJ_02179/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            string[] words = new string[N];

            for (int i = 0; i < N; i++)
                words[i] = sr.ReadLine()!;

            WordTree wordTree = new();
            int maxLen = 0;
            string S = "", T = "";

            for (int i = N - 1; i >= 0; i--)
            {
                string word = words[i];
                string similarWord = wordTree.GetSimilarWord(word, out int len);

                if (len >= maxLen)
                {
                    maxLen = len;
                    S = word;
                    T = similarWord;
                }

                wordTree.Add(word);
            }

            sw.WriteLine(S);
            sw.WriteLine(T);

            sr.Close();
            sw.Close();
        }

        private class WordTree
        {
            private CharNode m_root = new();

            public string GetSimilarWord(string word, out int len)
            {
                len = 0;
                System.Text.StringBuilder sb = new();

                CharNode node = m_root;

                foreach (char c in word)
                {
                    if (!node.TryGetChild(c, out CharNode? child)) break;

                    len++;
                    sb.Append(c);
                    node = child!;
                }

                while (node.FirstChild != ' ')
                {
                    sb.Append(node.FirstChild);
                    node.TryGetChild(node.FirstChild, out node!);
                }

                return sb.ToString();
            }

            public void Add(string word)
            {
                CharNode node = m_root;

                foreach (char c in word)
                    node = node.AddChild(c);
                node.AddChild(' ');
            }
        }

        private class CharNode
        {
            private Dictionary<char, CharNode> children = new();
            public char FirstChild { get; private set; } = ' ';

            public CharNode AddChild(char c)
            {
                children.TryAdd(c, new());
                FirstChild = c;

                return children[c];
            }

            public bool TryGetChild(char c, out CharNode? node)
            {
                return children.TryGetValue(c, out node);
            }
        }
    }
}
