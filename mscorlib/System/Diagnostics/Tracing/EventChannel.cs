using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Указывает канал журнала событий для события.</summary>
	// Token: 0x020009EA RID: 2538
	public enum EventChannel : byte
	{
		/// <summary>Канал не указан.</summary>
		// Token: 0x040037FE RID: 14334
		None,
		/// <summary>Канал журнала администратора.</summary>
		// Token: 0x040037FF RID: 14335
		Admin = 16,
		/// <summary>Операционный канал.</summary>
		// Token: 0x04003800 RID: 14336
		Operational,
		/// <summary>Аналитический канал.</summary>
		// Token: 0x04003801 RID: 14337
		Analytic,
		/// <summary>Канал отладки.</summary>
		// Token: 0x04003802 RID: 14338
		Debug
	}
}
