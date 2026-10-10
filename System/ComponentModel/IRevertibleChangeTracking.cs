using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет поддержку для отката изменений.</summary>
	// Token: 0x020003FE RID: 1022
	public interface IRevertibleChangeTracking : IChangeTracking
	{
		/// <summary>Восстанавливает неизмененное состояние объекта, отменяя изменения.</summary>
		// Token: 0x0600213E RID: 8510
		void RejectChanges();
	}
}
