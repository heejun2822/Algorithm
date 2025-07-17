namespace Algorithm.BOJ.BOJ_22840
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_22840/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            System.Text.StringBuilder output = new();

            int N;

            while ((N = int.Parse(sr.ReadLine()!)) > 0)
            {
                int top = 1, bottom = 6;
                int north = 2, south = 5;
                int west = 3, east = 4;

                while (N-- > 0)
                {
                    switch (sr.ReadLine()!)
                    {
                        case "north":
                            (top, north, bottom, south) = (south, top, north, bottom);
                            break;
                        case "east":
                            (top, east, bottom, west) = (west, top, east, bottom);
                            break;
                        case "south":
                            (top, south, bottom, north) = (north, top, south, bottom);
                            break;
                        case "west":
                            (top, west, bottom, east) = (east, top, west, bottom);
                            break;
                        default:
                            break;
                    }
                }

                output.AppendLine(top.ToString());
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
