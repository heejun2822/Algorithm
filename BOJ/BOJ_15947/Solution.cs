namespace Algorithm.BOJ.BOJ_15947
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15947/input1.txt",
            "BOJ/BOJ_15947/input2.txt",
            "BOJ/BOJ_15947/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int itr = N / 14;
            int num = (N - 1) % 14 + 1;
            string word = "";
            switch (num)
            {
                case 1: case 13:
                    word = "baby"; break;
                case 2: case 14:
                    word = "sukhwan"; break;
                case 5:
                    word = "very"; break;
                case 6:
                    word = "cute"; break;
                case 9:
                    word = "in"; break;
                case 10:
                    word = "bed"; break;
                case 3: case 7: case 11:
                    word = "tu";
                    if (itr >= 3) word += $"+ru*{2 + itr}";
                    else for (int _ = 0; _ < 2 + itr; _++) word += "ru";
                    break;
                case 4: case 8: case 12:
                    word = "tu";
                    if (itr >= 4) word += $"+ru*{1 + itr}";
                    else for (int _ = 0; _ < 1 + itr; _++) word += "ru";
                    break;
                default:
                    break;
            }
            Console.WriteLine(word);
        }
    }
}
