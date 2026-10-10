using System;

namespace System.ComponentModel
{
	/// <summary>Сообщает клиентам об изменении значения свойства.</summary>
	// Token: 0x02000402 RID: 1026
	public interface INotifyPropertyChanging
	{
		/// <summary>Происходит при изменении значения свойства.</summary>
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06002147 RID: 8519
		// (remove) Token: 0x06002148 RID: 8520
		event PropertyChangingEventHandler PropertyChanging;
	}
}
