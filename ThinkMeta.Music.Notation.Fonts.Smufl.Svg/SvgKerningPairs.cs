using System.Xml.Serialization;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg;

/// <summary>
/// <see href="https://www.w3.org/TR/SVG11/fonts.html#KernElements"/>
/// </summary>
[XmlRoot(ElementName = "hkern", Namespace = "http://www.w3.org/2000/svg")]
public class SvgKerningPairs
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#HKernElementU1Attribute"/>
    /// </summary>
    [XmlAttribute("u1")]
    public string? Unicode1 { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#HKernElementU2Attribute"/>
    /// </summary>
    [XmlAttribute("u2")]
    public string? Unicode2 { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#HKernElementG1Attribute"/>
    /// </summary>
    [XmlAttribute("g1")]
    public string? GlyphName1 { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#HKernElementG2Attribute"/>
    /// </summary>
    [XmlAttribute("g2")]
    public string? GlyphName2 { get; set; }

    /// <summary>
    /// <see ref="https://www.w3.org/TR/SVG11/fonts.html#HKernElementKAttribute"/>
    /// </summary>
    [XmlAttribute("k")]
    public int Kerning { get; set; }
}