using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg.Tests;

[TestClass]
public class SmuflSvgFontReaderTests
{
    [TestMethod]
    public async Task ReadBravuraSvgAsync()
    {
        try {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ThinkMeta.Music.Notation.Fonts.Smufl.Svg.Tests.Resources.Bravura.svg");
            var svgFont = await SmuflSvgFontReader.ReadFromStreamAsync(stream!);
            Assert.IsNotNull(svgFont);
        }
        catch {
            Assert.Fail();
        }
    }
}
