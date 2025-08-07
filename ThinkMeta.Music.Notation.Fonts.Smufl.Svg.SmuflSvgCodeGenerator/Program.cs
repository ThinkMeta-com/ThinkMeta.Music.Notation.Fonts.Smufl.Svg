namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg.SmuflSvgCodeGenerator;

internal static class Program
{
    private static async Task Main(string[] args)
    {
        if (args.Length == 0) {
            return;
        }

        try {
            ISmuflSvgCodeGenerator codeGenerator = args[0].ToLowerInvariant() switch {
                "wpf" => new WpfSmuflSvgCodeGenerator(args[1..]),
                _ => throw new NotSupportedException($"Target {args[0]} is not supported.")
            };

            await codeGenerator.InitializeAsync();
            await codeGenerator.GenerateAsync();
        }
        catch (Exception ex) {
            Console.WriteLine($"ERROR: {ex}");
        }
    }
}
