using System;

namespace System.Data
{
	/// <summary>Описание версии <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x020000C7 RID: 199
	public enum DataRowVersion
	{
		/// <summary>Строка содержит исходные значения.</summary>
		// Token: 0x040007EF RID: 2031
		Original = 256,
		/// <summary>Строка содержит текущие значения.</summary>
		// Token: 0x040007F0 RID: 2032
		Current = 512,
		/// <summary>Строка содержит предложенное значение.</summary>
		// Token: 0x040007F1 RID: 2033
		Proposed = 1024,
		/// <summary>Версия <see cref="T:System.Data.DataRowState" /> по умолчанию. Для значения <see langword="DataRowState" /><see langword="Added" />, <see langword="Modified" /> или <see langword="Deleted" /> по умолчанию используется версия <see langword="Current" />. Для значения <see cref="T:System.Data.DataRowState" /><see langword="Detached" /> используется версия <see langword="Proposed" />.</summary>
		// Token: 0x040007F2 RID: 2034
		Default = 1536
	}
}
