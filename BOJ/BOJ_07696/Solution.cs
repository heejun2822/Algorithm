namespace Algorithm.BOJ.BOJ_07696
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07696/input.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> repeatlessNumbers = new(1_000_001) { 0 };
            System.Text.StringBuilder output = new();

            int n;
            while ((n = int.Parse(Console.ReadLine()!)) != 0)
            {
                while (repeatlessNumbers.Count <= n)
                {
                    int num = repeatlessNumbers[^1];
                    while (!IsRepeatless(++num)) ;
                    repeatlessNumbers.Add(num);
                }

                output.AppendLine(repeatlessNumbers[n].ToString());
            }

            Console.Write(output);

            bool IsRepeatless(int num)
            {
                bool[] contained = new bool[10];

                while (num > 0)
                {
                    int digit = num % 10;

                    if (contained[digit]) return false;

                    contained[digit] = true;
                    num /= 10;
                }

                return true;
            }
        }
    }
}
