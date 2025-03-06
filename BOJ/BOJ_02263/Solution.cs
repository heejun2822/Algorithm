namespace Algorithm.BOJ.BOJ_02263
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02263/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int[] inorder = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int[] postorder = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int[] inorderIndices = new int[n + 1];
            for (int i = 0; i < n; i++) inorderIndices[inorder[i]] = i;

            System.Text.StringBuilder preorder = new();

            TraversePreorder(0, n - 1, 0, n - 1);
            sw.WriteLine(preorder);

            sr.Close();
            sw.Close();

            void TraversePreorder(int inS, int inE, int postS, int postE)
            {
                if (inS > inE || postS > postE) return;

                int parent = postorder[postE];
                preorder.Append(parent).Append(' ');

                int leftLen = inorderIndices[parent] - inS;
                int rightLen = inE - inorderIndices[parent];

                TraversePreorder(inS, inS + leftLen - 1, postS, postS + leftLen - 1);
                TraversePreorder(inE - rightLen + 1, inE, postE - rightLen, postE - 1);
            }
        }
    }
}
