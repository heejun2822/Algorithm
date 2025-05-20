namespace Algorithm.BOJ.BOJ_25997
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25997/input1.txt",
            "BOJ/BOJ_25997/input2.txt",
            "BOJ/BOJ_25997/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] xy = Console.ReadLine()!.Split();
            string X = xy[0];
            string Y = xy[1];

            double turn = Math.Abs(GetDegree(X) - GetDegree(Y));

            Console.WriteLine(Math.Min(turn, 360 - turn).ToString("F6"));

            double GetDegree(string direction)
            {
                if (direction.Length == 1)
                    return direction switch
                    {
                        "N" => 0,
                        "E" => 90,
                        "S" => 180,
                        "W" => 270,
                        _ => 0,
                    };

                double degree = 0;
                char posDir = 'N', negDir = 'N';

                switch (direction[^2..])
                {
                    case "NE":
                        posDir = 'E';
                        negDir = 'N';
                        degree = 45;
                        break;
                    case "SE":
                        posDir = 'S';
                        negDir = 'E';
                        degree = 135;
                        break;
                    case "SW":
                        posDir = 'W';
                        negDir = 'S';
                        degree = 225;
                        break;
                    case "NW":
                        posDir = 'N';
                        negDir = 'W';
                        degree = 315;
                        break;
                    default:
                        break;
                }

                double d = 22.5f;

                for (int i = 3; i <= direction.Length; i++)
                {
                    if (direction[^i] == posDir) degree += d;
                    else if (direction[^i] == negDir) degree -= d;
                    d /= 2;
                }

                return degree;
            }
        }
    }
}
