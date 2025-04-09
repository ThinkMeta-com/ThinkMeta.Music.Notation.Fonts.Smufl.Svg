using System.Xml.Serialization;

namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg;

/// <summary>
/// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElement" />
/// </summary>
[XmlRoot(ElementName = "font-face", Namespace = "http://www.w3.org/2000/svg")]
public class SvgFontFace
{
    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementFontFamilyAttribute"/>
    /// </summary>
    [XmlAttribute("font-family")]
    public string FontFamily { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementFontWeightAttribute"/>
    /// </summary>
    [XmlAttribute("font-weight")]
    public string FontWeight { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementFontStretchAttribute"/>
    /// </summary>
    [XmlAttribute("font-stretch")]
    public string FontStretch { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementUnitsPerEmAttribute"/>
    /// </summary>
    [XmlAttribute("units-per-em")]
    public int UnitsPerEm { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementPanose1Attribute"/>
    /// </summary>
    [XmlAttribute("panose-1")]
    public string Panose1 { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementAscentAttribute"/>
    /// </summary>
    [XmlAttribute("ascent")]
    public int Ascent { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementDescentAttribute"/>
    /// </summary>
    [XmlAttribute("descent")]
    public int Descent { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementBboxAttribute"/>
    /// </summary>
    [XmlAttribute("bbox")]
    public string BoundingBox { get; set; } = default!;

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementUnderlineThicknessAttribute"/>
    /// </summary>
    [XmlAttribute("underline-thickness")]
    public int UnderlineThickness { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementUnderlinePositionAttribute"/>
    /// </summary>
    [XmlAttribute("underline-position")]
    public int UnderlinePosition { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementStemhAttribute"/>
    /// </summary>
    [XmlAttribute("stemh")]
    public int StemH { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementStemvAttribute"/>
    /// </summary>
    [XmlAttribute("stemv")]
    public int StemV { get; set; }

    /// <summary>
    /// <see href="https://www.w3.org/TR/SVG11/fonts.html#FontFaceElementUnicodeRangeAttribute"/>
    /// </summary>
    [XmlAttribute("unicode-range")]
    public string UnicodeRange { get; set; } = default!;
}