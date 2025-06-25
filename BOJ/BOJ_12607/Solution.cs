namespace Algorithm.BOJ.BOJ_12607
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_12607/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, string> keypresses = new()
            {
                {'a', "2"}, {'b', "22"}, {'c', "222"},
                {'d', "3"}, {'e', "33"}, {'f', "333"},
                {'g', "4"}, {'h', "44"}, {'i', "444"},
                {'j', "5"}, {'k', "55"}, {'l', "555"},
                {'m', "6"}, {'n', "66"}, {'o', "666"},
                {'p', "7"}, {'q', "77"}, {'r', "777"}, {'s', "7777"},
                {'t', "8"}, {'u', "88"}, {'v', "888"},
                {'w', "9"}, {'x', "99"}, {'y', "999"}, {'z', "9999"},
                {' ', "0"},
            };

            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder answer = new();

            for (int x = 1; x <= N; x++)
            {
                string message = Console.ReadLine()!;

                answer.Append($"Case #{x}: ");
                foreach (char c in message)
                {
                    if (keypresses[c][0] == answer[^1])
                        answer.Append(' ');
                    answer.Append(keypresses[c]);
                }
                answer.AppendLine();
            }

            Console.Write(answer);
        }
    }
}
