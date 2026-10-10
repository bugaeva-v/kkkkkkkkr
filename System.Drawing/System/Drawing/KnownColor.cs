using System;

namespace System.Drawing
{
	/// <summary>Задает известные системные цвета.</summary>
	// Token: 0x02000011 RID: 17
	public enum KnownColor
	{
		/// <summary>Определенный системой цвет, являющийся цветом границы активного окна.</summary>
		// Token: 0x04000094 RID: 148
		ActiveBorder = 1,
		/// <summary>Определенный системой цвет, являющийся цветом фона строки заголовка активного окна.</summary>
		// Token: 0x04000095 RID: 149
		ActiveCaption,
		/// <summary>Определенный системой цвет текста строки заголовка активного окна.</summary>
		// Token: 0x04000096 RID: 150
		ActiveCaptionText,
		/// <summary>Определенный системой цвет, являющийся цветом рабочей области приложения. Рабочая область приложения — это область в многодокументном представлении, не занятая документами.</summary>
		// Token: 0x04000097 RID: 151
		AppWorkspace,
		/// <summary>Определенный системой цвет лицевой стороны трехмерного элемента.</summary>
		// Token: 0x04000098 RID: 152
		Control,
		/// <summary>Определенный системой цвет, являющийся цветом тени трехмерного элемента. Цвет тени применяется к тем участкам трехмерного элемента, которые обращены не к источнику света, а от него.</summary>
		// Token: 0x04000099 RID: 153
		ControlDark,
		/// <summary>Определенный системой цвет, являющийся темным цветом тени трехмерного элемента. Темный цвет тени применяется к тем участкам трехмерного элемента, которые имеют самый темный цвет.</summary>
		// Token: 0x0400009A RID: 154
		ControlDarkDark,
		/// <summary>Определенный системой цвет, являющийся светлым цветом трехмерного элемента. Светлый цвет применяется к участкам трехмерного элемента, которые обращены к источнику света.</summary>
		// Token: 0x0400009B RID: 155
		ControlLight,
		/// <summary>Определенный системой цвет, являющийся цветом выделения трехмерного элемента. Цвет выделения применяется к тем участкам трехмерного элемента, которые имеют самый светлый цвет.</summary>
		// Token: 0x0400009C RID: 156
		ControlLightLight,
		/// <summary>Определенный системой цвет, являющийся цветом текста трехмерного элемента.</summary>
		// Token: 0x0400009D RID: 157
		ControlText,
		/// <summary>Определенный системой цвет, являющийся цветом рабочего стола.</summary>
		// Token: 0x0400009E RID: 158
		Desktop,
		/// <summary>Определенный системой цвет, являющийся цветом серого текста. Неактивные элементы списка изображаются серым текстом.</summary>
		// Token: 0x0400009F RID: 159
		GrayText,
		/// <summary>Определенный системой цвет, представляющий собой цвет фона выбранных элементов. К ним относятся выбранные элементы меню, а также выделенный текст.</summary>
		// Token: 0x040000A0 RID: 160
		Highlight,
		/// <summary>Определенный системой цвет, являющийся цветом текста выбранных элементов.</summary>
		// Token: 0x040000A1 RID: 161
		HighlightText,
		/// <summary>Определенный системой цвет, используемый для обозначения отслеженного элемента. Щелчок отслеженного элемента приводит к его выполнению.</summary>
		// Token: 0x040000A2 RID: 162
		HotTrack,
		/// <summary>Определенный системой цвет, являющийся цветом границы неактивного окна.</summary>
		// Token: 0x040000A3 RID: 163
		InactiveBorder,
		/// <summary>Определенный системой цвет, являющийся цветом фона строки заголовка неактивного окна.</summary>
		// Token: 0x040000A4 RID: 164
		InactiveCaption,
		/// <summary>Определенный системой цвет текста строки заголовка неактивного окна.</summary>
		// Token: 0x040000A5 RID: 165
		InactiveCaptionText,
		/// <summary>Определенный системой цвет, представляющий собой цвет фона всплывающей подсказки.</summary>
		// Token: 0x040000A6 RID: 166
		Info,
		/// <summary>Определенный системой цвет текста всплывающей подсказки.</summary>
		// Token: 0x040000A7 RID: 167
		InfoText,
		/// <summary>Определенный системой цвет, являющийся цветом фона меню.</summary>
		// Token: 0x040000A8 RID: 168
		Menu,
		/// <summary>Определенный системой цвет текста меню.</summary>
		// Token: 0x040000A9 RID: 169
		MenuText,
		/// <summary>Определенный системой цвет, являющийся цветом фона строки прокрутки.</summary>
		// Token: 0x040000AA RID: 170
		ScrollBar,
		/// <summary>Определенный системой цвет, являющийся цветом фона в клиентской области окна.</summary>
		// Token: 0x040000AB RID: 171
		Window,
		/// <summary>Определенный системой цвет рамки окна.</summary>
		// Token: 0x040000AC RID: 172
		WindowFrame,
		/// <summary>Определенный системой цвет, являющийся цветом текста в клиентской области окна.</summary>
		// Token: 0x040000AD RID: 173
		WindowText,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000AE RID: 174
		Transparent,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000AF RID: 175
		AliceBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B0 RID: 176
		AntiqueWhite,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B1 RID: 177
		Aqua,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B2 RID: 178
		Aquamarine,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B3 RID: 179
		Azure,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B4 RID: 180
		Beige,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B5 RID: 181
		Bisque,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B6 RID: 182
		Black,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B7 RID: 183
		BlanchedAlmond,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B8 RID: 184
		Blue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000B9 RID: 185
		BlueViolet,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BA RID: 186
		Brown,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BB RID: 187
		BurlyWood,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BC RID: 188
		CadetBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BD RID: 189
		Chartreuse,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BE RID: 190
		Chocolate,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000BF RID: 191
		Coral,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C0 RID: 192
		CornflowerBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C1 RID: 193
		Cornsilk,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C2 RID: 194
		Crimson,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C3 RID: 195
		Cyan,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C4 RID: 196
		DarkBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C5 RID: 197
		DarkCyan,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C6 RID: 198
		DarkGoldenrod,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C7 RID: 199
		DarkGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C8 RID: 200
		DarkGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000C9 RID: 201
		DarkKhaki,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CA RID: 202
		DarkMagenta,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CB RID: 203
		DarkOliveGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CC RID: 204
		DarkOrange,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CD RID: 205
		DarkOrchid,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CE RID: 206
		DarkRed,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000CF RID: 207
		DarkSalmon,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D0 RID: 208
		DarkSeaGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D1 RID: 209
		DarkSlateBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D2 RID: 210
		DarkSlateGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D3 RID: 211
		DarkTurquoise,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D4 RID: 212
		DarkViolet,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D5 RID: 213
		DeepPink,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D6 RID: 214
		DeepSkyBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D7 RID: 215
		DimGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D8 RID: 216
		DodgerBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000D9 RID: 217
		Firebrick,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DA RID: 218
		FloralWhite,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DB RID: 219
		ForestGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DC RID: 220
		Fuchsia,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DD RID: 221
		Gainsboro,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DE RID: 222
		GhostWhite,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000DF RID: 223
		Gold,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E0 RID: 224
		Goldenrod,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E1 RID: 225
		Gray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E2 RID: 226
		Green,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E3 RID: 227
		GreenYellow,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E4 RID: 228
		Honeydew,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E5 RID: 229
		HotPink,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E6 RID: 230
		IndianRed,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E7 RID: 231
		Indigo,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E8 RID: 232
		Ivory,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000E9 RID: 233
		Khaki,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000EA RID: 234
		Lavender,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000EB RID: 235
		LavenderBlush,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000EC RID: 236
		LawnGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000ED RID: 237
		LemonChiffon,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000EE RID: 238
		LightBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000EF RID: 239
		LightCoral,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F0 RID: 240
		LightCyan,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F1 RID: 241
		LightGoldenrodYellow,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F2 RID: 242
		LightGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F3 RID: 243
		LightGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F4 RID: 244
		LightPink,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F5 RID: 245
		LightSalmon,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F6 RID: 246
		LightSeaGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F7 RID: 247
		LightSkyBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F8 RID: 248
		LightSlateGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000F9 RID: 249
		LightSteelBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FA RID: 250
		LightYellow,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FB RID: 251
		Lime,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FC RID: 252
		LimeGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FD RID: 253
		Linen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FE RID: 254
		Magenta,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x040000FF RID: 255
		Maroon,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000100 RID: 256
		MediumAquamarine,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000101 RID: 257
		MediumBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000102 RID: 258
		MediumOrchid,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000103 RID: 259
		MediumPurple,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000104 RID: 260
		MediumSeaGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000105 RID: 261
		MediumSlateBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000106 RID: 262
		MediumSpringGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000107 RID: 263
		MediumTurquoise,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000108 RID: 264
		MediumVioletRed,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000109 RID: 265
		MidnightBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010A RID: 266
		MintCream,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010B RID: 267
		MistyRose,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010C RID: 268
		Moccasin,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010D RID: 269
		NavajoWhite,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010E RID: 270
		Navy,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400010F RID: 271
		OldLace,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000110 RID: 272
		Olive,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000111 RID: 273
		OliveDrab,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000112 RID: 274
		Orange,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000113 RID: 275
		OrangeRed,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000114 RID: 276
		Orchid,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000115 RID: 277
		PaleGoldenrod,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000116 RID: 278
		PaleGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000117 RID: 279
		PaleTurquoise,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000118 RID: 280
		PaleVioletRed,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000119 RID: 281
		PapayaWhip,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011A RID: 282
		PeachPuff,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011B RID: 283
		Peru,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011C RID: 284
		Pink,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011D RID: 285
		Plum,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011E RID: 286
		PowderBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400011F RID: 287
		Purple,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000120 RID: 288
		Red,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000121 RID: 289
		RosyBrown,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000122 RID: 290
		RoyalBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000123 RID: 291
		SaddleBrown,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000124 RID: 292
		Salmon,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000125 RID: 293
		SandyBrown,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000126 RID: 294
		SeaGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000127 RID: 295
		SeaShell,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000128 RID: 296
		Sienna,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000129 RID: 297
		Silver,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012A RID: 298
		SkyBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012B RID: 299
		SlateBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012C RID: 300
		SlateGray,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012D RID: 301
		Snow,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012E RID: 302
		SpringGreen,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400012F RID: 303
		SteelBlue,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000130 RID: 304
		Tan,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000131 RID: 305
		Teal,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000132 RID: 306
		Thistle,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000133 RID: 307
		Tomato,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000134 RID: 308
		Turquoise,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000135 RID: 309
		Violet,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000136 RID: 310
		Wheat,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000137 RID: 311
		White,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000138 RID: 312
		WhiteSmoke,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x04000139 RID: 313
		Yellow,
		/// <summary>Цвет, определенный системой.</summary>
		// Token: 0x0400013A RID: 314
		YellowGreen,
		/// <summary>Определенный системой цвет лицевой стороны трехмерного элемента.</summary>
		// Token: 0x0400013B RID: 315
		ButtonFace,
		/// <summary>Определенный системой цвет, являющийся цветом выделения трехмерного элемента. Этот цвет применяется к тем участкам трехмерного элемента, которые обращены к источнику света.</summary>
		// Token: 0x0400013C RID: 316
		ButtonHighlight,
		/// <summary>Определенный системой цвет, являющийся цветом тени трехмерного элемента. Этот цвет применяется к тем участкам трехмерного элемента, которые обращены не к источнику света, а от него.</summary>
		// Token: 0x0400013D RID: 317
		ButtonShadow,
		/// <summary>Определенный системой цвет, являющийся самым светлым цветом градиента цвета в строке заголовка активного окна.</summary>
		// Token: 0x0400013E RID: 318
		GradientActiveCaption,
		/// <summary>Определенный системой цвет самого светлого цвета градиента цвета в строке заголовка неактивного окна.</summary>
		// Token: 0x0400013F RID: 319
		GradientInactiveCaption,
		/// <summary>Определенный системой цвет, представляющий собой цвет фона строки меню.</summary>
		// Token: 0x04000140 RID: 320
		MenuBar,
		/// <summary>Определенный системой цвет, являющийся цветом, используемым для выделения пунктов меню, когда меню отображается как плоское меню.</summary>
		// Token: 0x04000141 RID: 321
		MenuHighlight
	}
}
