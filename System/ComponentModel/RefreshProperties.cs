using System;

namespace System.ComponentModel
{
	/// <summary>Определяет идентификаторы, которые указывают тип обновления окна "Свойства".</summary>
	// Token: 0x02000436 RID: 1078
	public enum RefreshProperties
	{
		/// <summary>Обновление не требуется.</summary>
		// Token: 0x0400109F RID: 4255
		None,
		/// <summary>Следует опросить свойства и обновить представление.</summary>
		// Token: 0x040010A0 RID: 4256
		All,
		/// <summary>Представление следует обновить.</summary>
		// Token: 0x040010A1 RID: 4257
		Repaint
	}
}
