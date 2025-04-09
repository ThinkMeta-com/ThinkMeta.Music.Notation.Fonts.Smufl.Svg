using System.Xml.Linq;
using System.Xml.Serialization;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg;

/// <summary>
/// A simple reader for SMuFL SVG fonts.
/// "Simple" means that it was tested only with "Bravura.svg"...
/// </summary>
public static class SmuflSvgFontReader
{
    /// <summary>
    /// Reads a SMuFL SVG font from a file.
    /// </summary>
    /// <param name="path">The file path.</param>
    /// <returns>The SVG font object.</returns>
    public static async Task<SvgFont> ReadFromFileAsync(string path) => ReadFromString(await File.ReadAllTextAsync(path));

    /// <summary>
    /// Reads a SMuFL SVG font from a stream.
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <returns>The SVG font object.</returns>
    public static async Task<SvgFont> ReadFromStreamAsync(Stream stream)
    {
        using var reader = new StreamReader(stream);
        return ReadFromString(await reader.ReadToEndAsync());
    }

    /// <summary>
    /// Reads a SMuFL SVG font from an XML string.
    /// </summary>
    /// <param name="xml">The XML string.</param>
    /// <returns>The SVG font object.</returns>
    public static SvgFont ReadFromString(string xml)
    {
        // parse XML without a schema
        var xmlDocument = XDocument.Parse(xml);
        XNamespace xmlNamespace = "http://www.w3.org/2000/svg";

        // get font face information
        var fontFace = Deserialize<SvgFontFace>(xmlDocument.Descendants(xmlNamespace + "font-face").First());

        // get glyphs
        List<SvgGlyph> glyphs = [];
        foreach (var glyph in xmlDocument.Descendants(xmlNamespace + "glyph"))
            glyphs.Add(Deserialize<SvgGlyph>(glyph));

        // get kerning pairs
        List<SvgKerningPairs> kerningPairs = [];
        foreach (var kerningPair in xmlDocument.Descendants(xmlNamespace + "hkern"))
            kerningPairs.Add(Deserialize<SvgKerningPairs>(kerningPair));

        return new SvgFont(fontFace, [.. glyphs], [.. kerningPairs]);
    }

    private static T Deserialize<T>(XElement element)
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = element.CreateReader();
        return (T)serializer.Deserialize(reader)!;
    }
}
