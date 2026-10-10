using System;

namespace System.Transactions
{
	/// <summary>Определяет, должен ли объект быть присоединен в ходе подготовительной фазы.</summary>
	// Token: 0x02000011 RID: 17
	[Flags]
	public enum EnlistmentOptions
	{
		/// <summary>Объекту не требуется присоединение в ходе начальной фазы процесса фиксации.</summary>
		// Token: 0x04000035 RID: 53
		None = 0,
		/// <summary>Объект должен осуществить присоединение в ходе начальной фазы процесса фиксации.</summary>
		// Token: 0x04000036 RID: 54
		EnlistDuringPrepareRequired = 1
	}
}
