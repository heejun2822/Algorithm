namespace Algorithm.BOJ.BOJ_02082
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02082/input1.txt",
            "BOJ/BOJ_02082/input2.txt",
            "BOJ/BOJ_02082/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int[] digitArr =
            {
                Convert.ToInt32("111101101101111", 2),
                Convert.ToInt32("001001001001001", 2),
                Convert.ToInt32("111001111100111", 2),
                Convert.ToInt32("111001111001111", 2),
                Convert.ToInt32("101101111001001", 2),
                Convert.ToInt32("111100111001111", 2),
                Convert.ToInt32("111100111101111", 2),
                Convert.ToInt32("111001001001001", 2),
                Convert.ToInt32("111101111101111", 2),
                Convert.ToInt32("111101111001111", 2),
            };

            int[] texts = new int[4];

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine()!;

                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 3; k++)
                        if (input[4 * j + k] == '#')
                            texts[j] |= 1 << (14 - (3 * i + k));
            }

            for (int i = 0; i < 4; i++)
            {
                for (int d = 0; d < 9; d++)
                {
                    if ((texts[i] ^ digitArr[d] & texts[i]) == 0)
                    {
                        texts[i] = d;
                        break;
                    }
                }
            }

            Console.WriteLine($"{texts[0]}{texts[1]}:{texts[2]}{texts[3]}");
        }
    }
}
