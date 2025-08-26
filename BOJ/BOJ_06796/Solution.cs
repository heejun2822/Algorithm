namespace Algorithm.BOJ.BOJ_06796
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06796/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] variables = new int[2];

            while (true)
            {
                string[] instruction = Console.ReadLine()!.Split();

                switch (int.Parse(instruction[0]))
                {
                    case 1:
                        variables[char.Parse(instruction[1]) - 'A'] = int.Parse(instruction[2]);
                        break;
                    case 2:
                        Console.WriteLine(variables[char.Parse(instruction[1]) - 'A']);
                        break;
                    case 3:
                        variables[char.Parse(instruction[1]) - 'A'] += variables[char.Parse(instruction[2]) - 'A'];
                        break;
                    case 4:
                        variables[char.Parse(instruction[1]) - 'A'] *= variables[char.Parse(instruction[2]) - 'A'];
                        break;
                    case 5:
                        variables[char.Parse(instruction[1]) - 'A'] -= variables[char.Parse(instruction[2]) - 'A'];
                        break;
                    case 6:
                        variables[char.Parse(instruction[1]) - 'A'] /= variables[char.Parse(instruction[2]) - 'A'];
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
