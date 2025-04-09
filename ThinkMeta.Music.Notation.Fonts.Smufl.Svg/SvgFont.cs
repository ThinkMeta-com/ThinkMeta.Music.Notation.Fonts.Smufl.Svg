namespace ThinkMeta.Music.Notation.Fonts.Smufl.Svg;

/// <summary>
/// Provides a representation of a SMuFL SVG font.
/// </summary>
public record SvgFont(SvgFontFace FontFace, SvgGlyph[] Glyphs, SvgKerningPairs[] KerningPairs);
