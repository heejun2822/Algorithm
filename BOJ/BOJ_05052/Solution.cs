namespace Algorithm.BOJ.BOJ_05052
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05052/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int t = int.Parse(sr.ReadLine()!);

            while (t-- > 0)
            {
                int n = int.Parse(sr.ReadLine()!);
                string[] phoneNumbers = new string[n];

                for (int i = 0; i < n; i++)
                    phoneNumbers[i] = sr.ReadLine()!;

                Array.Sort(phoneNumbers, (a, b) => a.Length - b.Length);

                sw.WriteLine(IsConsistent(phoneNumbers) ? "YES" : "NO");
            }

            sr.Close();
            sw.Close();

            bool IsConsistent(string[] phoneNumbers)
            {
                List<int[]> childrenPool = new() { new int[10] };

                foreach (string pn in phoneNumbers)
                {
                    int[] children = childrenPool[0];
                    int digit;

                    for (int i = 0; i < pn.Length - 1; i++)
                    {
                        digit = pn[i] - '0';

                        if (children[digit] == -1)
                            return false;

                        if (children[digit] == 0)
                        {
                            children[digit] = childrenPool.Count;
                            childrenPool.Add(new int[10]);
                        }

                        children = childrenPool[children[digit]];
                    }

                    digit = pn[^1] - '0';
                    children[digit] = -1;
                }

                return true;
            }
        }
    }
}
