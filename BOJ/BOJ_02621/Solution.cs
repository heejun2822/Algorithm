namespace Algorithm.BOJ.BOJ_02621
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02621/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, int> colorCounts = new() { { 'R', 0 }, { 'B', 0 }, { 'Y', 0 }, { 'G', 0 } };
            int[] numCounts = new int[10];

            for (int _ = 0; _ < 5; _++)
            {
                string[] input = Console.ReadLine()!.Split();
                char color = char.Parse(input[0]);
                int num = int.Parse(input[1]);
                colorCounts[color]++;
                numCounts[num]++;
            }

            bool isOneColor = false;
            bool isContinuous = false;
            int maxNum = 0;
            int sameNum4 = 0;
            int sameNum3 = 0;
            int[] sameNum2 = new int[2];

            foreach (int cnt in colorCounts.Values)
                if (cnt == 5)
                    isOneColor = true;

            int continued = 0;
            int idx = 0;
            for (int i = 1; i < 10; i++)
            {
                if (numCounts[i] > 0)
                {
                    if (++continued == 5)
                        isContinuous = true;
                    maxNum = i;
                }
                else
                {
                    continued = 0;
                }

                if (numCounts[i] == 4)
                    sameNum4 = i;
                else if (numCounts[i] == 3)
                    sameNum3 = i;
                else if (numCounts[i] == 2)
                    sameNum2[idx++] = i;
            }

            int score;

            if (isOneColor && isContinuous)
                score = 900 + maxNum;
            else if (sameNum4 > 0)
                score = 800 + sameNum4;
            else if (sameNum3 > 0 && sameNum2[0] > 0)
                score = 700 + 10 * sameNum3 + sameNum2[0];
            else if (isOneColor)
                score = 600 + maxNum;
            else if (isContinuous)
                score = 500 + maxNum;
            else if (sameNum3 > 0)
                score = 400 + sameNum3;
            else if (sameNum2[0] > 0 && sameNum2[1] > 0)
                score = 300 + 10 * sameNum2[1] + sameNum2[0];
            else if (sameNum2[0] > 0)
                score = 200 + sameNum2[0];
            else
                score = 100 + maxNum;

            Console.WriteLine(score);
        }
    }
}
