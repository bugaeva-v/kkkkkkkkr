using System;

namespace System.IO.Pipes
{
	/// <summary>
	///         Предоставляет параметры для создания <see cref="T:System.IO.Pipes.PipeStream" /> объекта.
	///          Это перечисление имеет атрибут <see cref="T:System.FlagsAttribute" />, который позволяет составлять побитовые сочетания значений его элементов.
	///       </summary>
	// Token: 0x0200034D RID: 845
	[Flags]
	public enum PipeOptions
	{
		/// <summary>
		///         Указывает, что нет дополнительных параметров.
		///       </summary>
		// Token: 0x04000C4C RID: 3148
		None = 0,
		/// <summary>
		///         Указывает, что система должна выполняться через любой промежуточный кэш и перейти непосредственно к каналу.
		///       </summary>
		// Token: 0x04000C4D RID: 3149
		WriteThrough = -2147483648,
		/// <summary>
		///         Указывает, что канал может использоваться для асинхронного чтения и записи.
		///       </summary>
		// Token: 0x04000C4E RID: 3150
		Asynchronous = 1073741824,
		// Token: 0x04000C4F RID: 3151
		CurrentUserOnly = 536870912
	}
}
