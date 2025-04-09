using System.Diagnostics;
using System.Xml.Serialization;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg;

/// <summary>
/// <see href="https://www.w3.org/TR/SVG11/fonts.html#GlyphElement"/>
/// </summary>
[XmlRoot(ElementName = "glyph", Namespace = "http://www.w3.org/2000/svg")]
[DebuggerDisplay("{GlyphName} - {Unicode}")]
public class SvgGlyph
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#GlyphElementGlyphNameAttribute"/>
    /// </summary>
    [XmlAttribute("glyph-name")]
    public string GlyphName { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#GlyphElementUnicodeAttribute"/>
    /// </summary>
    [XmlAttribute("unicode")]
    public string Unicode { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#GlyphElementDAttribute"/>
    /// </summary>
    [XmlAttribute("d")]
    public string PathData { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#GlyphElementHorizAdvXAttribute"/>
    /// </summary>
    [XmlAttribute("horiz-adv-x")]
    public int HorizontalAdvanceX { get; set; }
}