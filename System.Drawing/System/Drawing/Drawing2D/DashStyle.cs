using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает стиль пунктирных линий, нарисованных с помощью объекта <see cref="T:System.Drawing.Pen" />.</summary>
	// Token: 0x0200013D RID: 317
	public enum DashStyle
	{
		/// <summary>Задает сплошную линию.</summary>
		// Token: 0x04000AD5 RID: 2773
		Solid,
		/// <summary>Задает линию, состоящую из штрихов.</summary>
		// Token: 0x04000AD6 RID: 2774
		Dash,
		/// <summary>Задает линию, состоящую из точек.</summary>
		// Token: 0x04000AD7 RID: 2775
		Dot,
		/// <summary>Задает штрих-пунктирную линию.</summary>
		// Token: 0x04000AD8 RID: 2776
		DashDot,
		/// <summary>Задает линию, состоящую из повторяющегося шаблона "штрих-две точки".</summary>
		// Token: 0x04000AD9 RID: 2777
		DashDotDot,
		/// <summary>Задает пользовательский тип пунктирных линий.</summary>
		// Token: 0x04000ADA RID: 2778
		Custom
	}
}
