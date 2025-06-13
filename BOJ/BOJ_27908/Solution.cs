namespace Algorithm.BOJ.BOJ_27908
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_27908/input1.txt",
            "BOJ/BOJ_27908/input2.txt",
            "BOJ/BOJ_27908/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nd = Console.ReadLine()!.Split();
            int n = int.Parse(nd[0]);
            int d = int.Parse(nd[1]);

            System.Text.StringBuilder calendar = new();
            string line = "+---------------------+";
            int date = 2 - d;

            calendar.AppendLine(line);
            while (date <= n)
            {
                calendar.Append('|');
                for (int _ = 0; _ < 7; _++)
                {
                    if (date <= 0 || date > n)
                        calendar.Append("...");
                    else if (date < 10)
                        calendar.Append($"..{date}");
                    else
                        calendar.Append($".{date}");
                    date++;
                }
                calendar.AppendLine("|");
            }
            calendar.AppendLine(line);

            Console.Write(calendar);
        }
    }
}
