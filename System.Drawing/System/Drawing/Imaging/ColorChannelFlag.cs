using System;

namespace System.Drawing.Imaging
{
	/// <summary>Определяет отдельные каналы в цветовом пространстве CMYK (голубой, пурпурный, желтый, черный). Это перечисление используется методами <see cref="Overload:System.Drawing.Imaging.ImageAttributes.SetOutputChannel" />.</summary>
	// Token: 0x020000F7 RID: 247
	public enum ColorChannelFlag
	{
		/// <summary>Канал голубого цвета.</summary>
		// Token: 0x04000843 RID: 2115
		ColorChannelC,
		/// <summary>Канал пурпурного цвета.</summary>
		// Token: 0x04000844 RID: 2116
		ColorChannelM,
		/// <summary>Канал желтого цвета.</summary>
		// Token: 0x04000845 RID: 2117
		ColorChannelY,
		/// <summary>Канал черного цвета.</summary>
		// Token: 0x04000846 RID: 2118
		ColorChannelK,
		/// <summary>Необходимо использовать последний выбранный канал.</summary>
		// Token: 0x04000847 RID: 2119
		ColorChannelLast
	}
}
