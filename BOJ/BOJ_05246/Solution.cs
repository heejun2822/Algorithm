namespace Algorithm.BOJ.BOJ_05246
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05246/input.txt",
        ];

        public static void Run(string[] args)
        {
            int numOfBoards = int.Parse(Console.ReadLine()!);

            int[] piecesOnRow = new int[9];

            for (int _ = 0; _ < numOfBoards; _++)
            {
                Array.Fill(piecesOnRow, 0);

                int c;

                int numOfPieces = 0;
                while ((c = Console.Read()) != ' ')
                {
                    numOfPieces *= 10;
                    numOfPieces += c - '0';
                }

                for (int i = 0; i < numOfPieces; i++)
                {
                    Console.Read();
                    Console.Read();
                    piecesOnRow[Console.Read() - '0']++;
                    while ((c = Console.Read()) != ' ' && c != '\n' && c != -1);
                }

                Console.WriteLine(piecesOnRow.Max());
            }
        }
    }
}
