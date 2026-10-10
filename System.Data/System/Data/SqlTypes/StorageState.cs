using System;

namespace System.Data.SqlTypes
{
	/// <summary>Перечисление <see cref="T:System.Data.SqlTypes.StorageState" /> не предназначено для использования в качестве самостоятельного компонента; оно является перечислением, от которого другие классы наследуют стандартные функциональные возможности.</summary>
	// Token: 0x02000319 RID: 793
	public enum StorageState
	{
		/// <summary>Размер буфера.</summary>
		// Token: 0x040018FC RID: 6396
		Buffer,
		/// <summary>Поток.</summary>
		// Token: 0x040018FD RID: 6397
		Stream,
		/// <summary>Неуправляемый буфер.</summary>
		// Token: 0x040018FE RID: 6398
		UnmanagedBuffer
	}
}
