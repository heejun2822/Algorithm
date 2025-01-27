namespace Algorithm.BOJ.BOJ_15182
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15182/input1.txt",
            "BOJ/BOJ_15182/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            string parity = "";
            int[] bitCounts = new int[8];
            int oddIdx = 0;
            int evenIdx = 0;
            int brokenByteIdx = 0;
            int brokenBitIdx = 0;

            for (int i = 0; i < N; i++)
            {
                string singleByte = Console.ReadLine()!;
                int cnt = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (singleByte[2 * j] == '1')
                    {
                        cnt++;
                        bitCounts[j]++;
                    }
                }

                if (cnt % 2 == 1)
                {
                    if (oddIdx != 0) parity = "Odd";
                    oddIdx = i + 1;
                }
                else
                {
                    if (evenIdx != 0) parity = "Even";
                    evenIdx = i + 1;
                }
            }

            if (parity == "Odd") brokenByteIdx = evenIdx;
            else if (parity == "Even") brokenByteIdx = oddIdx;

            string parityByte = Console.ReadLine()!;
            for (int i = 0; i < 8; i++)
            {
                if (parityByte[2 * i] == '1') bitCounts[i]++;
                if ((parity == "Odd" && bitCounts[i] % 2 == 0) || (parity == "Even" && bitCounts[i] % 2 == 1))
                {
                    brokenBitIdx = i + 1;
                    break;
                }
            }

            Console.WriteLine(parity);
            Console.WriteLine($"Byte {brokenByteIdx} is broken");
            Console.WriteLine($"Bit {brokenBitIdx} is broken");
        }
    }
}
