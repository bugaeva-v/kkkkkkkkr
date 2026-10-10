using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает флаги, передаваемые параметру флагов метода <see cref="Overload:System.Drawing.Bitmap.LockBits" />. Метод <see cref="Overload:System.Drawing.Bitmap.LockBits" /> блокирует часть изображения, так что можно считывать или записывать данные о пикселях.</summary>
	// Token: 0x0200010C RID: 268
	public enum ImageLockMode
	{
		/// <summary>Указывает, что часть изображения заблокирована для чтения.</summary>
		// Token: 0x040009DD RID: 2525
		ReadOnly = 1,
		/// <summary>Указывает, что часть изображения заблокирована для записи.</summary>
		// Token: 0x040009DE RID: 2526
		WriteOnly,
		/// <summary>Указывает, что часть изображения заблокирована для чтения и записи.</summary>
		// Token: 0x040009DF RID: 2527
		ReadWrite,
		/// <summary>Указывает, что буфер для чтения или записи данных о пикселях определяется пользователем. Если данный флаг установлен, то параметр <paramref name="flags" /> метода <see cref="Overload:System.Drawing.Bitmap.LockBits" /> выступает в роли входного параметра (и, возможно, в качестве выходного параметра). Если данный флаг снят, параметр <paramref name="flags" /> является только выходным параметром.</summary>
		// Token: 0x040009E0 RID: 2528
		UserInputBuffer
	}
}
