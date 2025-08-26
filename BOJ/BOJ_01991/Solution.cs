namespace Algorithm.BOJ.BOJ_01991
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01991/input.txt",
        ];

        private static (char left, char right)[] childNodes = {};

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            childNodes = new (char, char)[N];
            for (int i = 0; i < N; i++)
            {
                char[] info = Array.ConvertAll(Console.ReadLine()!.Split(), char.Parse);
                childNodes[info[0] - 'A'] = (info[1], info[2]);
            }

            StringBuilder result = new();

            PreorderTraverse(result, 'A');
            Console.WriteLine(result);

            InorderTraverse(result.Clear(), 'A');
            Console.WriteLine(result);

            PostorderTraverse(result.Clear(), 'A');
            Console.WriteLine(result);
        }

        private static void PreorderTraverse(StringBuilder result, char node)
        {
            if (node == '.') return;

            result.Append(node);
            PreorderTraverse(result, childNodes[node - 'A'].left);
            PreorderTraverse(result, childNodes[node - 'A'].right);
        }

        private static void InorderTraverse(StringBuilder result, char node)
        {
            if (node == '.') return;

            InorderTraverse(result, childNodes[node - 'A'].left);
            result.Append(node);
            InorderTraverse(result, childNodes[node - 'A'].right);
        }

        private static void PostorderTraverse(StringBuilder result, char node)
        {
            if (node == '.') return;

            PostorderTraverse(result, childNodes[node - 'A'].left);
            PostorderTraverse(result, childNodes[node - 'A'].right);
            result.Append(node);
        }
    }
}
