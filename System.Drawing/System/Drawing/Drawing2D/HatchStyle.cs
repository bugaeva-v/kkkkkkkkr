using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает различные шаблоны, доступные для объектов <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</summary>
	// Token: 0x02000143 RID: 323
	public enum HatchStyle
	{
		/// <summary>Шаблон горизонтальных линий.</summary>
		// Token: 0x04000AE4 RID: 2788
		Horizontal,
		/// <summary>Шаблон вертикальных линий.</summary>
		// Token: 0x04000AE5 RID: 2789
		Vertical,
		/// <summary>Шаблон линий по диагонали из верхнего левого угла к нижнему правому углу.</summary>
		// Token: 0x04000AE6 RID: 2790
		ForwardDiagonal,
		/// <summary>Шаблон линий по диагонали от правого верхнего угла к левому нижнему углу.</summary>
		// Token: 0x04000AE7 RID: 2791
		BackwardDiagonal,
		/// <summary>Определяет пересекающиеся горизонтальные и вертикальные линии.</summary>
		// Token: 0x04000AE8 RID: 2792
		Cross,
		/// <summary>Шаблон для перекрещивающихся диагональных линий.</summary>
		// Token: 0x04000AE9 RID: 2793
		DiagonalCross,
		/// <summary>Задает пятипроцентную штриховку. Отношение цвета переднего плана к цвету фона равно 5:95.</summary>
		// Token: 0x04000AEA RID: 2794
		Percent05,
		/// <summary>Задает десятипроцентную штриховку. Отношение цвета переднего плана к цвету фона равно 10:90.</summary>
		// Token: 0x04000AEB RID: 2795
		Percent10,
		/// <summary>Задает 20-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 20:80.</summary>
		// Token: 0x04000AEC RID: 2796
		Percent20,
		/// <summary>Задает 25-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 25:75.</summary>
		// Token: 0x04000AED RID: 2797
		Percent25,
		/// <summary>Задает 30-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 30:70.</summary>
		// Token: 0x04000AEE RID: 2798
		Percent30,
		/// <summary>Задает 40-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 40:60.</summary>
		// Token: 0x04000AEF RID: 2799
		Percent40,
		/// <summary>Задает 50-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 50:50.</summary>
		// Token: 0x04000AF0 RID: 2800
		Percent50,
		/// <summary>Задает 60-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 60:40.</summary>
		// Token: 0x04000AF1 RID: 2801
		Percent60,
		/// <summary>Задает 70-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 70:30.</summary>
		// Token: 0x04000AF2 RID: 2802
		Percent70,
		/// <summary>Задает 75-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 75:25.</summary>
		// Token: 0x04000AF3 RID: 2803
		Percent75,
		/// <summary>Задает 80-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 80:100.</summary>
		// Token: 0x04000AF4 RID: 2804
		Percent80,
		/// <summary>Задает 90-процентную штриховку. Отношение цвета переднего плана к цвету фона равно 90:10.</summary>
		// Token: 0x04000AF5 RID: 2805
		Percent90,
		/// <summary>Определяет диагональные линии, которые отклоняются вправо от верхних точек к нижним точкам и располагаются на 50 процентов ближе друг к другу, чем у объекта <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />, но эти линии не сглажены.</summary>
		// Token: 0x04000AF6 RID: 2806
		LightDownwardDiagonal,
		/// <summary>Определяет диагональные линии с уклоном влево от верхних точек к нижним точкам, расположенные на 50 процентов ближе друг к другу, чем у объекта <see cref="F:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal" />, однако эти линии не сглажены.</summary>
		// Token: 0x04000AF7 RID: 2807
		LightUpwardDiagonal,
		/// <summary>Определяет диагональные линии, которые отклоняются вправо от верхних точек к нижним точкам, располагаются на 50 процентов ближе друг к другу и вдвое шире, чем <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />. Шаблон штриховки не сглажен.</summary>
		// Token: 0x04000AF8 RID: 2808
		DarkDownwardDiagonal,
		/// <summary>Определяет диагональные линии с уклоном влево от верхних точек к нижним точкам, расположенные на 50 процентов ближе друг к другу, чем в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal" />, и вдвое шире линий этого объекта, однако эти линии не сглажены.</summary>
		// Token: 0x04000AF9 RID: 2809
		DarkUpwardDiagonal,
		/// <summary>Определяет диагональные линии с уклоном вправо от верхних точек к нижним точкам, которые имеют интервал между линиями, как в стиле штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />, однако ширина линий втрое больше и они несглаженные.</summary>
		// Token: 0x04000AFA RID: 2810
		WideDownwardDiagonal,
		/// <summary>Определяет диагональные линии с уклоном влево от верхних точек к нижним точкам, которые имеют такой же интервал между линиями, как в стиле штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal" />, однако ширина линий втрое больше и они несглаженные.</summary>
		// Token: 0x04000AFB RID: 2811
		WideUpwardDiagonal,
		/// <summary>Определяет вертикальные линии, расположенные на 50 процентов ближе друг к другу, чем у объекта <see cref="F:System.Drawing.Drawing2D.HatchStyle.Vertical" />.</summary>
		// Token: 0x04000AFC RID: 2812
		LightVertical,
		/// <summary>Определяет горизонтальные линии, расположенные на 50 процентов ближе друг к другу, чем определяет <see cref="F:System.Drawing.Drawing2D.HatchStyle.Horizontal" />.</summary>
		// Token: 0x04000AFD RID: 2813
		LightHorizontal,
		/// <summary>Определяет вертикальные линии, расположенные на 75 процентов ближе друг к другу, чем в стиле штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.Vertical" /> (или на 25 процентов ближе друг к другу, чем в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.LightVertical" />).</summary>
		// Token: 0x04000AFE RID: 2814
		NarrowVertical,
		/// <summary>Определяет горизонтальные линии, расположенные на 75 процентов ближе друг к другу, чем в стиле штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.Horizontal" /> (или на 25 процентов ближе друг к другу, чем в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.LightHorizontal" />).</summary>
		// Token: 0x04000AFF RID: 2815
		NarrowHorizontal,
		/// <summary>Определяет вертикальные линии, которые расположены на 50 процентов ближе друг к другу и вдвое шире, чем в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.Vertical" />.</summary>
		// Token: 0x04000B00 RID: 2816
		DarkVertical,
		/// <summary>Определяет горизонтальные линии, расположенные на 50 процентов ближе друг к другу, чем в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.Horizontal" />, и вдвое шире линий в объекте <see cref="F:System.Drawing.Drawing2D.HatchStyle.Horizontal" />.</summary>
		// Token: 0x04000B01 RID: 2817
		DarkHorizontal,
		/// <summary>Определяет пунктирные диагональные линии с уклоном вправо от верхних точек к нижним точкам.</summary>
		// Token: 0x04000B02 RID: 2818
		DashedDownwardDiagonal,
		/// <summary>Определяет пунктирные диагональные линии, имеющие уклон влево от верхних точек к нижним точкам.</summary>
		// Token: 0x04000B03 RID: 2819
		DashedUpwardDiagonal,
		/// <summary>Определяет пунктирные горизонтальные линии.</summary>
		// Token: 0x04000B04 RID: 2820
		DashedHorizontal,
		/// <summary>Определяет пунктирные вертикальные линии.</summary>
		// Token: 0x04000B05 RID: 2821
		DashedVertical,
		/// <summary>Определяет штриховку, выглядящую как конфетти.</summary>
		// Token: 0x04000B06 RID: 2822
		SmallConfetti,
		/// <summary>Определяет штриховку, выглядящую как конфетти и состоящую из частей, которые больше, чем у объекта <see cref="F:System.Drawing.Drawing2D.HatchStyle.SmallConfetti" />.</summary>
		// Token: 0x04000B07 RID: 2823
		LargeConfetti,
		/// <summary>Определяет горизонтальные линии, состоящие из зигзагов.</summary>
		// Token: 0x04000B08 RID: 2824
		ZigZag,
		/// <summary>Определяет горизонтальные линии, состоящие из тильд (~).</summary>
		// Token: 0x04000B09 RID: 2825
		Wave,
		/// <summary>Определяет штриховку, которая имеет вид слоев кирпичей с уклоном влево от верхних точек к нижним точкам.</summary>
		// Token: 0x04000B0A RID: 2826
		DiagonalBrick,
		/// <summary>Определяет штриховку, выглядящую как горизонтальные слои кирпичей.</summary>
		// Token: 0x04000B0B RID: 2827
		HorizontalBrick,
		/// <summary>Определяет штриховку, выглядящую как ткань.</summary>
		// Token: 0x04000B0C RID: 2828
		Weave,
		/// <summary>Определяет штриховку, выглядящую как клетчатый плед.</summary>
		// Token: 0x04000B0D RID: 2829
		Plaid,
		/// <summary>Определяет штриховку, выглядящую как дерн.</summary>
		// Token: 0x04000B0E RID: 2830
		Divot,
		/// <summary>Определяет пересекающиеся горизонтальные и вертикальные линии, состоящие из точек.</summary>
		// Token: 0x04000B0F RID: 2831
		DottedGrid,
		/// <summary>Определяет пересекающиеся прямые и обратные диагональные линии, состоящие из точек.</summary>
		// Token: 0x04000B10 RID: 2832
		DottedDiamond,
		/// <summary>Определяет штриховку, которая имеет вид диагональных слоев гальки с уклоном вправо из верхних точек к нижним точкам.</summary>
		// Token: 0x04000B11 RID: 2833
		Shingle,
		/// <summary>Определяет штриховку, выглядящую как сетка.</summary>
		// Token: 0x04000B12 RID: 2834
		Trellis,
		/// <summary>Определяет штриховку, выглядящую как шары, расположенные рядом друг с другом.</summary>
		// Token: 0x04000B13 RID: 2835
		Sphere,
		/// <summary>Определяет горизонтальные и вертикальные пересекающиеся линии, расположенные на 50 процентов ближе друг к другу, чем в стиле штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.Cross" />.</summary>
		// Token: 0x04000B14 RID: 2836
		SmallGrid,
		/// <summary>Определяет штриховку, выглядящую как шахматная доска.</summary>
		// Token: 0x04000B15 RID: 2837
		SmallCheckerBoard,
		/// <summary>Определяет штриховку, выглядящую как шахматная доска, с квадратами, вдвое большими, чем у объекта <see cref="F:System.Drawing.Drawing2D.HatchStyle.SmallCheckerBoard" />.</summary>
		// Token: 0x04000B16 RID: 2838
		LargeCheckerBoard,
		/// <summary>Определяет несглаженные пересекающиеся прямые и обратные диагональные линии.</summary>
		// Token: 0x04000B17 RID: 2839
		OutlinedDiamond,
		/// <summary>Определяет штриховку, выглядящую как шахматная доска, расположенная диагонально.</summary>
		// Token: 0x04000B18 RID: 2840
		SolidDiamond,
		/// <summary>Определяет тип штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.Cross" />.</summary>
		// Token: 0x04000B19 RID: 2841
		LargeGrid = 4,
		/// <summary>Определяет стиль штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.Horizontal" />.</summary>
		// Token: 0x04000B1A RID: 2842
		Min = 0,
		/// <summary>Определяет стиль штриховки <see cref="F:System.Drawing.Drawing2D.HatchStyle.SolidDiamond" />.</summary>
		// Token: 0x04000B1B RID: 2843
		Max = 4
	}
}
