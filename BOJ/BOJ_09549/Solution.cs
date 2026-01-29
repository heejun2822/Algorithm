namespace Algorithm.BOJ.BOJ_09549
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09549/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            while (T-- > 0)
            {
                string encryptedPW = sr.ReadLine()!;
                string originalPW = sr.ReadLine()!;

                int[] counts = new int[26];
                int[] currCounts = new int[26];
                int fitCnt = 0;

                for (int i = 0; i < originalPW.Length; i++)
                {
                    counts[originalPW[i] - 'a']++;
                    currCounts[encryptedPW[i] - 'a']++;
                }

                for (int i = 0; i < 26; i++)
                    if (currCounts[i] == counts[i])
                        fitCnt++;

                bool isPossible = fitCnt == 26;
                int idx = originalPW.Length;

                while (!isPossible && idx < encryptedPW.Length)
                {
                    int a = encryptedPW[idx] - 'a', r = encryptedPW[idx - originalPW.Length] - 'a';

                    if (currCounts[a] == counts[a])
                        fitCnt--;
                    if (++currCounts[a] == counts[a])
                        fitCnt++;
                    if (currCounts[r] == counts[r])
                        fitCnt--;
                    if (--currCounts[r] == counts[r])
                        fitCnt++;

                    isPossible = fitCnt == 26;
                    idx++;
                }

                sw.WriteLine(isPossible ? "YES" : "NO");
            }

            sr.Close();
            sw.Close();
        }
    }
}
