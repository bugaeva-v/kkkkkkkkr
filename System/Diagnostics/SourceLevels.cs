using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Задает уровни сообщений трассировки, фильтруемых переключателем источника и фильтром типов событий.</summary>
	// Token: 0x02000222 RID: 546
	[Flags]
	public enum SourceLevels
	{
		/// <summary>Запрещает передачу любых событий.</summary>
		// Token: 0x040009AD RID: 2477
		Off = 0,
		/// <summary>Разрешает передачу только событий типа <see cref="F:System.Diagnostics.TraceEventType.Critical" />.</summary>
		// Token: 0x040009AE RID: 2478
		Critical = 1,
		/// <summary>Разрешает передачу только событий типа <see cref="F:System.Diagnostics.TraceEventType.Critical" /> и <see cref="F:System.Diagnostics.TraceEventType.Error" />.</summary>
		// Token: 0x040009AF RID: 2479
		Error = 3,
		/// <summary>Разрешает передачу событий типа <see cref="F:System.Diagnostics.TraceEventType.Critical" />, <see cref="F:System.Diagnostics.TraceEventType.Error" /> и <see cref="F:System.Diagnostics.TraceEventType.Warning" />.</summary>
		// Token: 0x040009B0 RID: 2480
		Warning = 7,
		/// <summary>Разрешает передачу событий типа <see cref="F:System.Diagnostics.TraceEventType.Critical" />, <see cref="F:System.Diagnostics.TraceEventType.Error" />, <see cref="F:System.Diagnostics.TraceEventType.Warning" /> и <see cref="F:System.Diagnostics.TraceEventType.Information" />.</summary>
		// Token: 0x040009B1 RID: 2481
		Information = 15,
		/// <summary>Разрешает передачу событий типа <see cref="F:System.Diagnostics.TraceEventType.Critical" />, <see cref="F:System.Diagnostics.TraceEventType.Error" />, <see cref="F:System.Diagnostics.TraceEventType.Warning" />, <see cref="F:System.Diagnostics.TraceEventType.Information" /> и <see cref="F:System.Diagnostics.TraceEventType.Verbose" />.</summary>
		// Token: 0x040009B2 RID: 2482
		Verbose = 31,
		/// <summary>Разрешает передачу событий типа <see cref="F:System.Diagnostics.TraceEventType.Stop" />, <see cref="F:System.Diagnostics.TraceEventType.Start" />, <see cref="F:System.Diagnostics.TraceEventType.Suspend" />, <see cref="F:System.Diagnostics.TraceEventType.Transfer" /> и <see cref="F:System.Diagnostics.TraceEventType.Resume" />.</summary>
		// Token: 0x040009B3 RID: 2483
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		ActivityTracing = 65280,
		/// <summary>Разрешает передачу всех событий.</summary>
		// Token: 0x040009B4 RID: 2484
		All = -1
	}
}
