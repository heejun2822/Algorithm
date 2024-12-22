namespace Algorithm.BOJ.BOJ_01331
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01331/input1.txt",
            "BOJ/BOJ_01331/input2.txt",
            "BOJ/BOJ_01331/input3.txt",
            "BOJ/BOJ_01331/input4.txt",
            "BOJ/BOJ_01331/input5.txt",
        ];

        public static void Run(string[] args)
        {
            HashSet<string> visited = new(36);
            bool isValid = true;

            string firstCell = Console.ReadLine()!;
            visited.Add(firstCell);
            string cell = firstCell;
            for (int i = 0; i < 36; i++)
            {
                string nextCell;
                if (i == 35)
                    nextCell = firstCell;
                else
                {
                    nextCell = Console.ReadLine()!;
                    if (visited.Contains(nextCell)) { isValid = false; break; }
                    visited.Add(nextCell);
                }

                int row = Math.Abs(nextCell[0] - cell[0]);
                int col = Math.Abs(nextCell[1] - cell[1]);
                if (!(row == 2 && col == 1) && !(row == 1 && col == 2)) { isValid = false; break; }

                cell = nextCell;
            }

            Console.WriteLine(isValid ? "Valid" : "Invalid");
        }
    }
}
