namespace Algorithm.BOJ.BOJ_02754
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02754/input.txt",
        ];

        public static void Run(string[] args)
        {
            Console.WriteLine
            (
                Console.ReadLine() switch
                {
                    "A+" => "4.3",
                    "A0" => "4.0",
                    "A-" => "3.7",
                    "B+" => "3.3",
                    "B0" => "3.0",
                    "B-" => "2.7",
                    "C+" => "2.3",
                    "C0" => "2.0",
                    "C-" => "1.7",
                    "D+" => "1.3",
                    "D0" => "1.0",
                    "D-" => "0.7",
                    _ => "0.0"
                }
            );
        }
    }
}
