//--------------------------------------
//			   PowerUI
//
//		For documentation or 
//	if you have any issues, visit
//		powerUI.kulestar.com
//
//	Copyright © 2013 Kulestar Ltd
//		  www.kulestar.com
//--------------------------------------


namespace Svg{
	
	public enum TextPathMethod{
		
		/// <summary>Indicates that the glyphs should be rendered using simple 2x3 transformations such that there is no stretching/warping of the glyphs. Typically, supplemental rotation, scaling and translation transformations are done for each glyph to be rendered. As a result, with align, fonts where the glyphs are designed to be connected (e.g., cursive fonts), the connections may not align properly when text is rendered along a path.</summary>
		Align,

		/// <summary>Indicates that the glyph outlines will be converted into paths, and then all end points and control points will be adjusted to be along the perpendicular vectors from the path, thereby stretching and possibly warping the glyphs. With this approach, connected glyphs, such as in cursive scripts, will maintain their connections.</summary>
		Stretch
	}
	
}