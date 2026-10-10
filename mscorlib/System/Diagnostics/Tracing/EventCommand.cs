using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Описывает команду (свойство <see cref="P:System.Diagnostics.Tracing.EventCommandEventArgs.Command" /> ), которая передается в метод обратного вызова <see cref="M:System.Diagnostics.Tracing.EventSource.OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs)" />.</summary>
	// Token: 0x020009ED RID: 2541
	public enum EventCommand
	{
		/// <summary>Обновление события.</summary>
		// Token: 0x04003819 RID: 14361
		Update,
		/// <summary>Отправить манифест.</summary>
		// Token: 0x0400381A RID: 14362
		SendManifest = -1,
		/// <summary>Включить событие.</summary>
		// Token: 0x0400381B RID: 14363
		Enable = -2,
		/// <summary>Отключить событие.</summary>
		// Token: 0x0400381C RID: 14364
		Disable = -3
	}
}
