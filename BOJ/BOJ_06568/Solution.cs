namespace Algorithm.BOJ.BOJ_06568
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06568/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] memory = new int[32];
            string input;

            while ((input = Console.ReadLine()!) != null)
            {
                memory[0] = Convert.ToInt32(input, 2);
                for (int i = 1; i < 32; i++)
                    memory[i] = Convert.ToInt32(Console.ReadLine()!, 2);

                int pc = 0;
                int adder = 0;

                while (true)
                {
                    int command = memory[pc] / 32;
                    int x = memory[pc] % 32;
                    pc = (pc + 1) % 32;

                    if (command == 0)
                        memory[x] = adder;
                    else if (command == 1)
                        adder = memory[x];
                    else if (command == 2)
                        pc = adder == 0 ? x : pc;
                    else if (command == 3)
                        continue;
                    else if (command == 4)
                        adder = (adder + 255) % 256;
                    else if (command == 5)
                        adder = (adder + 1) % 256;
                    else if (command == 6)
                        pc = x;
                    else if (command == 7)
                        break;
                }

                Console.WriteLine(Convert.ToString(adder, 2).PadLeft(8, '0'));
            }
        }
    }
}
