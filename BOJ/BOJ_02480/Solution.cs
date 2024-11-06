namespace Algorithm.BOJ.BOJ_02480
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02480/input1.txt",
            "BOJ/BOJ_02480/input2.txt",
            "BOJ/BOJ_02480/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int[] dices = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int reward;
            if (dices[0] == dices[1])
            {
                if (dices[1] == dices[2]) reward = 10000 + dices[0] * 1000;
                else reward = 1000 + dices[0] * 100;
            }
            else if (dices[0] == dices[2]) reward = 1000 + dices[0] * 100;
            else if (dices[1] == dices[2]) reward = 1000 + dices[1] * 100;
            else reward = dices.Max() * 100;
            Console.WriteLine(reward);
        }
    }
}
