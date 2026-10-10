using System;

namespace System.Drawing.Imaging
{
	/// <summary>Определяет методы, доступные для использования с метафайлом для чтения и записи графических команд.</summary>
	// Token: 0x020000FF RID: 255
	public enum EmfPlusRecordType
	{
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000873 RID: 2163
		WmfRecordBase = 65536,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000874 RID: 2164
		WmfSetBkColor = 66049,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000875 RID: 2165
		WmfSetBkMode = 65794,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000876 RID: 2166
		WmfSetMapMode,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000877 RID: 2167
		WmfSetROP2,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000878 RID: 2168
		WmfSetRelAbs,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000879 RID: 2169
		WmfSetPolyFillMode,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087A RID: 2170
		WmfSetStretchBltMode,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087B RID: 2171
		WmfSetTextCharExtra,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087C RID: 2172
		WmfSetTextColor = 66057,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087D RID: 2173
		WmfSetTextJustification,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087E RID: 2174
		WmfSetWindowOrg,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400087F RID: 2175
		WmfSetWindowExt,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000880 RID: 2176
		WmfSetViewportOrg,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000881 RID: 2177
		WmfSetViewportExt,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000882 RID: 2178
		WmfOffsetWindowOrg,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000883 RID: 2179
		WmfScaleWindowExt = 66576,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000884 RID: 2180
		WmfOffsetViewportOrg = 66065,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000885 RID: 2181
		WmfScaleViewportExt = 66578,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000886 RID: 2182
		WmfLineTo = 66067,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000887 RID: 2183
		WmfMoveTo,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000888 RID: 2184
		WmfExcludeClipRect = 66581,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000889 RID: 2185
		WmfIntersectClipRect,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088A RID: 2186
		WmfArc = 67607,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088B RID: 2187
		WmfEllipse = 66584,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088C RID: 2188
		WmfFloodFill,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088D RID: 2189
		WmfPie = 67610,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088E RID: 2190
		WmfRectangle = 66587,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400088F RID: 2191
		WmfRoundRect = 67100,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000890 RID: 2192
		WmfPatBlt,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000891 RID: 2193
		WmfSaveDC = 65566,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000892 RID: 2194
		WmfSetPixel = 66591,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000893 RID: 2195
		WmfOffsetCilpRgn = 66080,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000894 RID: 2196
		WmfTextOut = 66849,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000895 RID: 2197
		WmfBitBlt = 67874,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000896 RID: 2198
		WmfStretchBlt = 68387,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000897 RID: 2199
		WmfPolygon = 66340,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000898 RID: 2200
		WmfPolyline,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000899 RID: 2201
		WmfEscape = 67110,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089A RID: 2202
		WmfRestoreDC = 65831,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089B RID: 2203
		WmfFillRegion = 66088,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089C RID: 2204
		WmfFrameRegion = 66601,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089D RID: 2205
		WmfInvertRegion = 65834,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089E RID: 2206
		WmfPaintRegion,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400089F RID: 2207
		WmfSelectClipRegion,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A0 RID: 2208
		WmfSelectObject,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A1 RID: 2209
		WmfSetTextAlign,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A2 RID: 2210
		WmfChord = 67632,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A3 RID: 2211
		WmfSetMapperFlags = 66097,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A4 RID: 2212
		WmfExtTextOut = 68146,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A5 RID: 2213
		WmfSetDibToDev = 68915,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A6 RID: 2214
		WmfSelectPalette = 66100,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A7 RID: 2215
		WmfRealizePalette = 65589,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A8 RID: 2216
		WmfAnimatePalette = 66614,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008A9 RID: 2217
		WmfSetPalEntries = 65591,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008AA RID: 2218
		WmfPolyPolygon = 66872,
		/// <summary>Увеличивает или уменьшает размер логической палитры на основе указанного значения.</summary>
		// Token: 0x040008AB RID: 2219
		WmfResizePalette = 65849,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008AC RID: 2220
		WmfDibBitBlt = 67904,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008AD RID: 2221
		WmfDibStretchBlt = 68417,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008AE RID: 2222
		WmfDibCreatePatternBrush = 65858,
		/// <summary>Копирует данные о цвете для прямоугольника из пикселей файла DIB в указанный конечный прямоугольник.</summary>
		// Token: 0x040008AF RID: 2223
		WmfStretchDib = 69443,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B0 RID: 2224
		WmfExtFloodFill = 66888,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B1 RID: 2225
		WmfSetLayout = 65865,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B2 RID: 2226
		WmfDeleteObject = 66032,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B3 RID: 2227
		WmfCreatePalette = 65783,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B4 RID: 2228
		WmfCreatePatternBrush = 66041,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B5 RID: 2229
		WmfCreatePenIndirect = 66298,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B6 RID: 2230
		WmfCreateFontIndirect,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B7 RID: 2231
		WmfCreateBrushIndirect,
		/// <summary>См. раздел "Windows-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B8 RID: 2232
		WmfCreateRegion = 67327,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008B9 RID: 2233
		EmfHeader = 1,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BA RID: 2234
		EmfPolyBezier,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BB RID: 2235
		EmfPolygon,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BC RID: 2236
		EmfPolyline,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BD RID: 2237
		EmfPolyBezierTo,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BE RID: 2238
		EmfPolyLineTo,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008BF RID: 2239
		EmfPolyPolyline,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C0 RID: 2240
		EmfPolyPolygon,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C1 RID: 2241
		EmfSetWindowExtEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C2 RID: 2242
		EmfSetWindowOrgEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C3 RID: 2243
		EmfSetViewportExtEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C4 RID: 2244
		EmfSetViewportOrgEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C5 RID: 2245
		EmfSetBrushOrgEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C6 RID: 2246
		EmfEof,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C7 RID: 2247
		EmfSetPixelV,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C8 RID: 2248
		EmfSetMapperFlags,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008C9 RID: 2249
		EmfSetMapMode,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CA RID: 2250
		EmfSetBkMode,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CB RID: 2251
		EmfSetPolyFillMode,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CC RID: 2252
		EmfSetROP2,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CD RID: 2253
		EmfSetStretchBltMode,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CE RID: 2254
		EmfSetTextAlign,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008CF RID: 2255
		EmfSetColorAdjustment,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D0 RID: 2256
		EmfSetTextColor,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D1 RID: 2257
		EmfSetBkColor,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D2 RID: 2258
		EmfOffsetClipRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D3 RID: 2259
		EmfMoveToEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D4 RID: 2260
		EmfSetMetaRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D5 RID: 2261
		EmfExcludeClipRect,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D6 RID: 2262
		EmfIntersectClipRect,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D7 RID: 2263
		EmfScaleViewportExtEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D8 RID: 2264
		EmfScaleWindowExtEx,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008D9 RID: 2265
		EmfSaveDC,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DA RID: 2266
		EmfRestoreDC,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DB RID: 2267
		EmfSetWorldTransform,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DC RID: 2268
		EmfModifyWorldTransform,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DD RID: 2269
		EmfSelectObject,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DE RID: 2270
		EmfCreatePen,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008DF RID: 2271
		EmfCreateBrushIndirect,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E0 RID: 2272
		EmfDeleteObject,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E1 RID: 2273
		EmfAngleArc,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E2 RID: 2274
		EmfEllipse,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E3 RID: 2275
		EmfRectangle,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E4 RID: 2276
		EmfRoundRect,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E5 RID: 2277
		EmfRoundArc,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E6 RID: 2278
		EmfChord,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E7 RID: 2279
		EmfPie,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E8 RID: 2280
		EmfSelectPalette,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008E9 RID: 2281
		EmfCreatePalette,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008EA RID: 2282
		EmfSetPaletteEntries,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008EB RID: 2283
		EmfResizePalette,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008EC RID: 2284
		EmfRealizePalette,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008ED RID: 2285
		EmfExtFloodFill,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008EE RID: 2286
		EmfLineTo,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008EF RID: 2287
		EmfArcTo,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F0 RID: 2288
		EmfPolyDraw,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F1 RID: 2289
		EmfSetArcDirection,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F2 RID: 2290
		EmfSetMiterLimit,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F3 RID: 2291
		EmfBeginPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F4 RID: 2292
		EmfEndPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F5 RID: 2293
		EmfCloseFigure,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F6 RID: 2294
		EmfFillPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F7 RID: 2295
		EmfStrokeAndFillPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F8 RID: 2296
		EmfStrokePath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008F9 RID: 2297
		EmfFlattenPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FA RID: 2298
		EmfWidenPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FB RID: 2299
		EmfSelectClipPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FC RID: 2300
		EmfAbortPath,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FD RID: 2301
		EmfReserved069,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FE RID: 2302
		EmfGdiComment,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x040008FF RID: 2303
		EmfFillRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000900 RID: 2304
		EmfFrameRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000901 RID: 2305
		EmfInvertRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000902 RID: 2306
		EmfPaintRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000903 RID: 2307
		EmfExtSelectClipRgn,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000904 RID: 2308
		EmfBitBlt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000905 RID: 2309
		EmfStretchBlt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000906 RID: 2310
		EmfMaskBlt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000907 RID: 2311
		EmfPlgBlt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000908 RID: 2312
		EmfSetDIBitsToDevice,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000909 RID: 2313
		EmfStretchDIBits,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090A RID: 2314
		EmfExtCreateFontIndirect,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090B RID: 2315
		EmfExtTextOutA,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090C RID: 2316
		EmfExtTextOutW,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090D RID: 2317
		EmfPolyBezier16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090E RID: 2318
		EmfPolygon16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400090F RID: 2319
		EmfPolyline16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000910 RID: 2320
		EmfPolyBezierTo16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000911 RID: 2321
		EmfPolylineTo16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000912 RID: 2322
		EmfPolyPolyline16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000913 RID: 2323
		EmfPolyPolygon16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000914 RID: 2324
		EmfPolyDraw16,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000915 RID: 2325
		EmfCreateMonoBrush,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000916 RID: 2326
		EmfCreateDibPatternBrushPt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000917 RID: 2327
		EmfExtCreatePen,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000918 RID: 2328
		EmfPolyTextOutA,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000919 RID: 2329
		EmfPolyTextOutW,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091A RID: 2330
		EmfSetIcmMode,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091B RID: 2331
		EmfCreateColorSpace,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091C RID: 2332
		EmfSetColorSpace,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091D RID: 2333
		EmfDeleteColorSpace,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091E RID: 2334
		EmfGlsRecord,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400091F RID: 2335
		EmfGlsBoundedRecord,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000920 RID: 2336
		EmfPixelFormat,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000921 RID: 2337
		EmfDrawEscape,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000922 RID: 2338
		EmfExtEscape,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000923 RID: 2339
		EmfStartDoc,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000924 RID: 2340
		EmfSmallTextOut,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000925 RID: 2341
		EmfForceUfiMapping,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000926 RID: 2342
		EmfNamedEscpae,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000927 RID: 2343
		EmfColorCorrectPalette,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000928 RID: 2344
		EmfSetIcmProfileA,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000929 RID: 2345
		EmfSetIcmProfileW,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092A RID: 2346
		EmfAlphaBlend,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092B RID: 2347
		EmfSetLayout,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092C RID: 2348
		EmfTransparentBlt,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092D RID: 2349
		EmfReserved117,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092E RID: 2350
		EmfGradientFill,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x0400092F RID: 2351
		EmfSetLinkedUfis,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000930 RID: 2352
		EmfSetTextJustification,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000931 RID: 2353
		EmfColorMatchToTargetW,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000932 RID: 2354
		EmfCreateColorSpaceW,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000933 RID: 2355
		EmfMax = 122,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000934 RID: 2356
		EmfMin = 1,
		/// <summary>См. раздел "Enhanced-Format Metafiles" в разделе GDI библиотеки MSDN.</summary>
		// Token: 0x04000935 RID: 2357
		EmfPlusRecordBase = 16384,
		/// <summary>Указывает недопустимые данные.</summary>
		// Token: 0x04000936 RID: 2358
		Invalid = 16384,
		/// <summary>Определяет запись, которая является заголовком EMF+.</summary>
		// Token: 0x04000937 RID: 2359
		Header,
		/// <summary>Определяет запись, которая помечает последнюю запись EMF+ в метафайле.</summary>
		// Token: 0x04000938 RID: 2360
		EndOfFile,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.AddMetafileComment(System.Byte[])" />.</summary>
		// Token: 0x04000939 RID: 2361
		Comment,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.GetHdc" />.</summary>
		// Token: 0x0400093A RID: 2362
		GetDC,
		/// <summary>Помечает начало многоформатного раздела.</summary>
		// Token: 0x0400093B RID: 2363
		MultiFormatStart,
		/// <summary>Помечает многоформатный раздел.</summary>
		// Token: 0x0400093C RID: 2364
		MultiFormatSection,
		/// <summary>Помечает конец многоформатного раздела.</summary>
		// Token: 0x0400093D RID: 2365
		MultiFormatEnd,
		/// <summary>Помечает объект.</summary>
		// Token: 0x0400093E RID: 2366
		Object,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.Clear(System.Drawing.Color)" />.</summary>
		// Token: 0x0400093F RID: 2367
		Clear,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.FillRectangles" />.</summary>
		// Token: 0x04000940 RID: 2368
		FillRects,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawRectangles" />.</summary>
		// Token: 0x04000941 RID: 2369
		DrawRects,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.FillPolygon" />.</summary>
		// Token: 0x04000942 RID: 2370
		FillPolygon,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawLines" />.</summary>
		// Token: 0x04000943 RID: 2371
		DrawLines,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.FillEllipse" />.</summary>
		// Token: 0x04000944 RID: 2372
		FillEllipse,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawEllipse" />.</summary>
		// Token: 0x04000945 RID: 2373
		DrawEllipse,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.FillPie" />.</summary>
		// Token: 0x04000946 RID: 2374
		FillPie,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawPie" />.</summary>
		// Token: 0x04000947 RID: 2375
		DrawPie,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawArc" />.</summary>
		// Token: 0x04000948 RID: 2376
		DrawArc,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.FillRegion(System.Drawing.Brush,System.Drawing.Region)" />.</summary>
		// Token: 0x04000949 RID: 2377
		FillRegion,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.FillPath(System.Drawing.Brush,System.Drawing.Drawing2D.GraphicsPath)" />.</summary>
		// Token: 0x0400094A RID: 2378
		FillPath,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.DrawPath(System.Drawing.Pen,System.Drawing.Drawing2D.GraphicsPath)" />.</summary>
		// Token: 0x0400094B RID: 2379
		DrawPath,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.FillClosedCurve" />.</summary>
		// Token: 0x0400094C RID: 2380
		FillClosedCurve,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawClosedCurve" />.</summary>
		// Token: 0x0400094D RID: 2381
		DrawClosedCurve,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawCurve" />.</summary>
		// Token: 0x0400094E RID: 2382
		DrawCurve,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawBeziers" />.</summary>
		// Token: 0x0400094F RID: 2383
		DrawBeziers,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawImage" />.</summary>
		// Token: 0x04000950 RID: 2384
		DrawImage,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawImage" />.</summary>
		// Token: 0x04000951 RID: 2385
		DrawImagePoints,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.DrawString" />.</summary>
		// Token: 0x04000952 RID: 2386
		DrawString,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.RenderingOrigin" />.</summary>
		// Token: 0x04000953 RID: 2387
		SetRenderingOrigin,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.SmoothingMode" />.</summary>
		// Token: 0x04000954 RID: 2388
		SetAntiAliasMode,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.TextRenderingHint" />.</summary>
		// Token: 0x04000955 RID: 2389
		SetTextRenderingHint,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.TextContrast" />.</summary>
		// Token: 0x04000956 RID: 2390
		SetTextContrast,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.InterpolationMode" />.</summary>
		// Token: 0x04000957 RID: 2391
		SetInterpolationMode,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.PixelOffsetMode" />.</summary>
		// Token: 0x04000958 RID: 2392
		SetPixelOffsetMode,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.CompositingMode" />.</summary>
		// Token: 0x04000959 RID: 2393
		SetCompositingMode,
		/// <summary>См. раздел <see cref="P:System.Drawing.Graphics.CompositingQuality" />.</summary>
		// Token: 0x0400095A RID: 2394
		SetCompositingQuality,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.Save" />.</summary>
		// Token: 0x0400095B RID: 2395
		Save,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.Restore(System.Drawing.Drawing2D.GraphicsState)" />.</summary>
		// Token: 0x0400095C RID: 2396
		Restore,
		/// <summary>См. методы <see cref="M:System.Drawing.Graphics.BeginContainer" />.</summary>
		// Token: 0x0400095D RID: 2397
		BeginContainer,
		/// <summary>См. методы <see cref="M:System.Drawing.Graphics.BeginContainer" />.</summary>
		// Token: 0x0400095E RID: 2398
		BeginContainerNoParams,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.EndContainer(System.Drawing.Drawing2D.GraphicsContainer)" />.</summary>
		// Token: 0x0400095F RID: 2399
		EndContainer,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.TransformPoints" />.</summary>
		// Token: 0x04000960 RID: 2400
		SetWorldTransform,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.ResetTransform" />.</summary>
		// Token: 0x04000961 RID: 2401
		ResetWorldTransform,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.MultiplyTransform" />.</summary>
		// Token: 0x04000962 RID: 2402
		MultiplyWorldTransform,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.TransformPoints" />.</summary>
		// Token: 0x04000963 RID: 2403
		TranslateWorldTransform,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.ScaleTransform" />.</summary>
		// Token: 0x04000964 RID: 2404
		ScaleWorldTransform,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.RotateTransform" />.</summary>
		// Token: 0x04000965 RID: 2405
		RotateWorldTransform,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.TransformPoints" />.</summary>
		// Token: 0x04000966 RID: 2406
		SetPageTransform,
		/// <summary>См. раздел <see cref="M:System.Drawing.Graphics.ResetClip" />.</summary>
		// Token: 0x04000967 RID: 2407
		ResetClip,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.SetClip" />.</summary>
		// Token: 0x04000968 RID: 2408
		SetClipRect,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.SetClip" />.</summary>
		// Token: 0x04000969 RID: 2409
		SetClipPath,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.SetClip" />.</summary>
		// Token: 0x0400096A RID: 2410
		SetClipRegion,
		/// <summary>См. методы <see cref="Overload:System.Drawing.Graphics.TranslateClip" />.</summary>
		// Token: 0x0400096B RID: 2411
		OffsetClip,
		/// <summary>Определяет строку символов, расположение и сведения о форматировании.</summary>
		// Token: 0x0400096C RID: 2412
		DrawDriverString,
		/// <summary>Для внутреннего использования.</summary>
		// Token: 0x0400096D RID: 2413
		Total,
		/// <summary>Максимальное значение данного перечисления.</summary>
		// Token: 0x0400096E RID: 2414
		Max = 16438,
		/// <summary>Минимальное значение данного перечисления.</summary>
		// Token: 0x0400096F RID: 2415
		Min = 16385
	}
}
