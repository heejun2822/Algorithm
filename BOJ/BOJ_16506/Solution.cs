namespace Algorithm.BOJ.BOJ_16506
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16506/input1.txt",
            "BOJ/BOJ_16506/input2.txt",
        ];

        private static Dictionary<string, string> opcode = new()
        {
            {"ADD", "00000"}, {"ADDC", "00001"},
            {"SUB", "00010"}, {"SUBC", "00011"},
            {"MOV", "00100"}, {"MOVC", "00101"},
            {"AND", "00110"}, {"ANDC", "00111"},
            {"OR", "01000"}, {"ORC", "01001"},
            {"NOT", "01010"},
            {"MULT", "01100"}, {"MULTC", "01101"},
            {"LSFTL", "01110"}, {"LSFTLC", "01111"},
            {"LSFTR", "10000"}, {"LSFTRC", "10001"},
            {"ASFTR", "10010"}, {"ASFTRC", "10011"},
            {"RL", "10100"}, {"RLC", "10101"},
            {"RR", "10110"}, {"RRC", "10111"},
        };

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < N; _++)
            {
                string[] command = sr.ReadLine()!.Split();
                sw.Write(opcode[command[0]]);
                sw.Write("0");
                sw.Write(Convert.ToString(int.Parse(command[1]), 2).PadLeft(3, '0'));
                sw.Write(Convert.ToString(int.Parse(command[2]), 2).PadLeft(3, '0'));
                if (command[0].EndsWith('C'))
                    sw.Write(Convert.ToString(int.Parse(command[3]), 2).PadLeft(4, '0'));
                else
                    sw.Write(Convert.ToString(int.Parse(command[3]), 2).PadLeft(3, '0') + "0");
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }
    }
}
