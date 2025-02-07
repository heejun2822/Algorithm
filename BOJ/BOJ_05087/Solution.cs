namespace Algorithm.BOJ.BOJ_05087
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05087/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()!) != "#")
            {
                string[] cards = input.Split();

                int Cheryl = 0;
                int Tania = 0;
                foreach (string card in cards)
                {
                    if (card == "*") break;
                    if (card == "A") Cheryl++;
                    else if (int.Parse(card) % 2 == 1) Cheryl++;
                    else Tania++;
                }

                string winner = "Draw";
                if (Cheryl > Tania) winner = "Cheryl";
                else if (Tania > Cheryl) winner = "Tania";

                Console.WriteLine(winner);
            }
        }
    }
}
