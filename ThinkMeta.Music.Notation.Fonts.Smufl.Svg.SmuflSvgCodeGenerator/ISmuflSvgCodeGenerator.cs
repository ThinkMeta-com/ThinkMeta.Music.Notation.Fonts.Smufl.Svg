namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg.SmuflSvgCodeGenerator;

internal interface ISmuflSvgCodeGenerator
{
    Task InitializeAsync();
    Task GenerateAsync();
}
