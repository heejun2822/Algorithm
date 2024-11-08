namespace Algorithm.BOJ.BOJ_09653
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09653/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder logo = new();
            logo.AppendLine("    8888888888  888    88888");
            logo.AppendLine("   88     88   88 88   88  88");
            logo.AppendLine("    8888  88  88   88  88888");
            logo.AppendLine("       88 88 888888888 88   88");
            logo.AppendLine("88888888  88 88     88 88    888888");
            logo.AppendLine();
            logo.AppendLine("88  88  88   888    88888    888888");
            logo.AppendLine("88  88  88  88 88   88  88  88");
            logo.AppendLine("88 8888 88 88   88  88888    8888");
            logo.AppendLine(" 888  888 888888888 88  88      88");
            logo.AppendLine("  88  88  88     88 88   88888888");
            Console.WriteLine(logo);
        }
    }
}
