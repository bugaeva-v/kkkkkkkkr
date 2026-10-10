using System;

namespace System.Diagnostics
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Diagnostics.EventLog.EntryWritten" />.</summary>
	// Token: 0x02000256 RID: 598
	public class EntryWrittenEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EntryWrittenEventArgs" />.</summary>
		// Token: 0x06001271 RID: 4721 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
		public EntryWrittenEventArgs() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EntryWrittenEventArgs" /> с указанной записью в журнале событий.</summary>
		/// <param name="entry">Объект <see cref="T:System.Diagnostics.EventLogEntry" />, представляющий запись в журнале событий.</param>
		// Token: 0x06001272 RID: 4722 RVA: 0x0004FBED File Offset: 0x0004DDED
		public EntryWrittenEventArgs(EventLogEntry entry)
		{
			this.entry = entry;
		}

		/// <summary>Возвращает запись, внесенную в журнал.</summary>
		/// <returns>Объект <see cref="T:System.Diagnostics.EventLogEntry" />, представляющий запись, внесенную в журнал событий.</returns>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x0004FBFC File Offset: 0x0004DDFC
		public EventLogEntry Entry
		{
			get
			{
				return this.entry;
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private EventLogEntry entry;
	}
}
