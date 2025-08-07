using ThinkMeta.Music.Notation.Fonts.Smufl.Metadata;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg.SmuflSvgCodeGenerator;

internal abstract class SmuflSvgCodeGeneratorBase : ISmuflSvgCodeGenerator
{
    private readonly Dictionary<string, string> _args = [];

    protected const string Indent1 = "    ";
    protected const string Indent2 = "        ";
    protected const string Indent3 = "            ";
    protected const string Indent4 = "                ";

    public abstract Task GenerateAsync();

    protected IReadOnlyDictionary<string, string> Args => _args;
    protected FontMetadata? Metadata { get; private set; }
    protected SvgFont? Font { get; private set; }

    protected SmuflSvgCodeGeneratorBase(string[] args)
    {
        foreach (var arg in args) {
            var kv = arg.Split('=');
            if (kv.Length == 2)
                _args.Add(kv[0].ToLowerInvariant(), kv[1]);
            else
                throw new ArgumentException($"Invalid argument '{arg}'.");
        }
    }

    public async Task InitializeAsync()
    {
        Metadata = await FontMetadata.DeserializeFromFileAsync(Args["fontmetadata"]);
        Font = await SmuflSvgFontReader.ReadFromFileAsync(Args["font"]);
    }
}
