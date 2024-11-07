namespace Algorithm.BOJ.BOJ_02941
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02941/input1.txt",
            "BOJ/BOJ_02941/input2.txt",
            "BOJ/BOJ_02941/input3.txt",
            "BOJ/BOJ_02941/input4.txt",
            "BOJ/BOJ_02941/input5.txt",
        ];

        private static string word = "";
        private static int cnt;
        private static int idx;

        public static void Run(string[] args)
        {
            word = Console.ReadLine()!;
            cnt = idx = 0;
            while (idx < word.Length)
            {
                DetectCroatian();
                cnt++;
                idx++;
            }
            Console.WriteLine(cnt);
        }

        private static bool DetectCroatian()
        {
            if (idx == word.Length - 1) return false;
            switch (word[idx])
            {
                case 'c':
                    idx++;
                    if (word[idx] == '=' || word[idx] == '-') return true;
                    idx--;
                    break;
                case 'd':
                    idx++;
                    if (word[idx] == '-') return true;
                    else if (word[idx] == 'z' && DetectCroatian()) return true;
                    idx--;
                    break;
                case 'l':
                case 'n':
                    idx++;
                    if (word[idx] == 'j') return true;
                    idx--;
                    break;
                case 's':
                case 'z':
                    idx++;
                    if (word[idx] == '=') return true;
                    idx--;
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
