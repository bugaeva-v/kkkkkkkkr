using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Описывает источник записи журнала CRM.</summary>
	// Token: 0x02000077 RID: 119
	[Flags]
	[Serializable]
	public enum LogRecordFlags
	{
		/// <summary>Показывает, что доставленную запись не нужно запоминать.</summary>
		// Token: 0x040000C5 RID: 197
		ForgetTarget = 1,
		/// <summary>Запись журнала сделана во время подготовки.</summary>
		// Token: 0x040000C6 RID: 198
		WrittenDuringPrepare = 2,
		/// <summary>Запись журнала сделана во время фиксирования.</summary>
		// Token: 0x040000C7 RID: 199
		WrittenDuringCommit = 4,
		/// <summary>Запись журнала сделана во время прерывания.</summary>
		// Token: 0x040000C8 RID: 200
		WrittenDuringAbort = 8,
		/// <summary>Запись журнала сделана во время восстановления.</summary>
		// Token: 0x040000C9 RID: 201
		WrittenDurringRecovery = 16,
		/// <summary>Запись журнала сделана во время повтора.</summary>
		// Token: 0x040000CA RID: 202
		WrittenDuringReplay = 32,
		/// <summary>Запись журнала сделана при выполнении повтора.</summary>
		// Token: 0x040000CB RID: 203
		ReplayInProgress = 64
	}
}
