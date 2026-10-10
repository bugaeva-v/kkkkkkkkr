using System;

namespace System.Diagnostics
{
	/// <summary>Определяет уровни доступа, используемые классами разрешений <see cref="T:System.Diagnostics.EventLog" />.</summary>
	// Token: 0x02000261 RID: 609
	[Flags]
	public enum EventLogPermissionAccess
	{
		/// <summary>Класс <see cref="T:System.Diagnostics.EventLog" /> не имеет разрешений.</summary>
		// Token: 0x04000AD1 RID: 2769
		None = 0,
		/// <summary>С помощью класса <see cref="T:System.Diagnostics.EventLog" /> можно производить чтение существующих журналов. <see langword="Note" /> Данный элемент является устаревшим, вместо него следует использовать <see cref="F:System.Diagnostics.EventLogPermissionAccess.Administer" />.</summary>
		// Token: 0x04000AD2 RID: 2770
		[Obsolete]
		Browse = 2,
		/// <summary>С помощью класса <see cref="T:System.Diagnostics.EventLog" /> можно производить чтение или запись в существующие журналы, а также создавать источники и журналы событий. <see langword="Note" /> Данный элемент является устаревшим, вместо него следует использовать <see cref="F:System.Diagnostics.EventLogPermissionAccess.Write" />.</summary>
		// Token: 0x04000AD3 RID: 2771
		[Obsolete]
		Instrument = 6,
		/// <summary>
		///   <see cref="T:System.Diagnostics.EventLog" /> позволяет производить чтение из существующего журнала, удалять источники и журналы событий, просматривать записи, очищать журнал событий, прослушивать события, а также получать доступ к коллекции всех журналов событий. <see langword="Note" /> Данный элемент является устаревшим, вместо него следует использовать <see cref="F:System.Diagnostics.EventLogPermissionAccess.Administer" />.</summary>
		// Token: 0x04000AD4 RID: 2772
		[Obsolete]
		Audit = 10,
		/// <summary>С помощью класса <see cref="T:System.Diagnostics.EventLog" /> можно производить запись в существующие журналы, а также создавать источники и журналы событий.</summary>
		// Token: 0x04000AD5 RID: 2773
		Write = 16,
		/// <summary>
		///   <see cref="T:System.Diagnostics.EventLog" /> позволяет создавать источник событий, производить чтение из существующего журнала, удалять источники и журналы событий, просматривать записи, очищать журнал событий, прослушивать события, а также получать доступ к коллекции всех журналов событий.</summary>
		// Token: 0x04000AD6 RID: 2774
		Administer = 48
	}
}
