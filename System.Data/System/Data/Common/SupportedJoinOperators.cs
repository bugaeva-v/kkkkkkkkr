using System;

namespace System.Data.Common
{
	/// <summary>Указывает, какие типы операторов соединения Transact-SQL поддерживаются источником данных.</summary>
	// Token: 0x020003C0 RID: 960
	[Flags]
	public enum SupportedJoinOperators
	{
		/// <summary>Источник данных не поддерживает запросы соединений.</summary>
		// Token: 0x04001BE3 RID: 7139
		None = 0,
		/// <summary>Источник данных поддерживает внутренние соединения.</summary>
		// Token: 0x04001BE4 RID: 7140
		Inner = 1,
		/// <summary>Источник данных поддерживает левые внешние соединения.</summary>
		// Token: 0x04001BE5 RID: 7141
		LeftOuter = 2,
		/// <summary>Источник данных поддерживает правые внешние соединения.</summary>
		// Token: 0x04001BE6 RID: 7142
		RightOuter = 4,
		/// <summary>Источник данных поддерживает полные внешние соединения.</summary>
		// Token: 0x04001BE7 RID: 7143
		FullOuter = 8
	}
}
