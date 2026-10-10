using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Представляет неструктурированную запись журнала, доставленную в виде структуры <see langword="CrmLogRecordRead" /> COM+. Этот класс не наследуется.</summary>
	// Token: 0x02000075 RID: 117
	public sealed class LogRecord
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x000021E0 File Offset: 0x000003E0
		[MonoTODO]
		internal LogRecord()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000027A1 File Offset: 0x000009A1
		[MonoTODO]
		internal LogRecord(_LogRecord logRecord)
		{
			this.flags = (LogRecordFlags)logRecord.dwCrmFlags;
			this.sequence = logRecord.dwSequenceNumber;
			this.record = logRecord.blobUserData;
		}

		/// <summary>Получает значение, показывающее, когда была сделана запись.</summary>
		/// <returns>Битовая комбинация значений <see cref="T:System.EnterpriseServices.CompensatingResourceManager.LogRecordFlags" /> предоставляет сведения о том, когда была сделана запись.</returns>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000027CD File Offset: 0x000009CD
		public LogRecordFlags Flags
		{
			get
			{
				return this.flags;
			}
		}

		/// <summary>Получает данные пользователя из записей журнала.</summary>
		/// <returns>Один BLOB-объект, содержащий данные пользователя.</returns>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000027D5 File Offset: 0x000009D5
		public object Record
		{
			get
			{
				return this.record;
			}
		}

		/// <summary>Порядковый номер записи журнала.</summary>
		/// <returns>Целое число, указывающее порядковый номер записи журнала.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000027DD File Offset: 0x000009DD
		public int Sequence
		{
			get
			{
				return this.sequence;
			}
		}

		// Token: 0x040000BE RID: 190
		private LogRecordFlags flags;

		// Token: 0x040000BF RID: 191
		private object record;

		// Token: 0x040000C0 RID: 192
		private int sequence;
	}
}
