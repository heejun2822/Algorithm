namespace Algorithm.BOJ.BOJ_27889
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27889/input.txt",
        ];

        public static void Run(string[] args)
        {
            Console.WriteLine(
                Console.ReadLine()! switch
                {
                    "NLCS" => "North London Collegiate School",
                    "BHA" => "Branksome Hall Asia",
                    "KIS" => "Korea International School",
                    "SJA" => "St. Johnsbury Academy",
                    _ => "",
                }
            );
        }
    }
}
