using System;

namespace System.Threading
{
	/// <summary>Задает апартаментное состояние потока <see cref="T:System.Threading.Thread" />.</summary>
	// Token: 0x02000280 RID: 640
	public enum ApartmentState
	{
		/// <summary>Объект <see cref="T:System.Threading.Thread" /> создаст однопоточный апартамент и войдет в него.</summary>
		// Token: 0x04001A21 RID: 6689
		STA,
		/// <summary>Объект <see cref="T:System.Threading.Thread" /> создаст многопоточный апартамент и войдет в него.</summary>
		// Token: 0x04001A22 RID: 6690
		MTA,
		/// <summary>Свойство <see cref="P:System.Threading.Thread.ApartmentState" /> не установлено.</summary>
		// Token: 0x04001A23 RID: 6691
		Unknown
	}
}
