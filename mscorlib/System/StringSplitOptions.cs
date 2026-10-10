using System;

namespace System
{
	/// <summary>Указывает, включает или исключает пустые строки из возвращаемого значения соответствующий метод <see cref="Overload:System.String.Split" />.</summary>
	// Token: 0x0200018D RID: 397
	[Flags]
	public enum StringSplitOptions
	{
		/// <summary>Возвращаемое значение содержит элементы массива, содержащие пустые строки.</summary>
		// Token: 0x040012FE RID: 4862
		None = 0,
		/// <summary>Возвращаемое значение не содержит элементы массива, содержащие пустые строки.</summary>
		// Token: 0x040012FF RID: 4863
		RemoveEmptyEntries = 1
	}
}
