namespace Algorithm.BOJ.BOJ_07869
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07869/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            double x1 = double.Parse(input[0]);
            double y1 = double.Parse(input[1]);
            double r1 = double.Parse(input[2]);
            double x2 = double.Parse(input[3]);
            double y2 = double.Parse(input[4]);
            double r2 = double.Parse(input[5]);

            double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            if (d >= r1 + r2)
            {
                Console.WriteLine("0.000");
            }
            else if (d <= Math.Abs(r1 - r2))
            {
                double area = Math.Pow(Math.Min(r1, r2), 2) * Math.PI;
                Console.WriteLine(area.ToString("F3"));
            }
            else
            {
                double cos1 = (r1 * r1 + d * d - r2 * r2) / (2 * r1 * d);
                double cos2 = (r2 * r2 + d * d - r1 * r1) / (2 * r2 * d);
                double area = r1 * r1 * Math.Acos(cos1) + r2 * r2 * Math.Acos(cos2) - r1 * Math.Sqrt(1 - cos1 * cos1) * d;
                Console.WriteLine(area.ToString("F3"));
            }
        }
    }
}
