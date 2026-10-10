using System;

namespace System.Diagnostics
{
	/// <summary>Указывает, какие сообщения должны выводиться для классов <see cref="T:System.Diagnostics.Debug" />, <see cref="T:System.Diagnostics.Trace" /> и <see cref="T:System.Diagnostics.TraceSwitch" />.</summary>
	// Token: 0x02000230 RID: 560
	public enum TraceLevel
	{
		/// <summary>Не выводить сообщения трассировки и отладки.</summary>
		// Token: 0x040009EE RID: 2542
		Off,
		/// <summary>Выводить сообщения обработки ошибок.</summary>
		// Token: 0x040009EF RID: 2543
		Error,
		/// <summary>Выводить предупреждения и сообщения обработки ошибок.</summary>
		// Token: 0x040009F0 RID: 2544
		Warning,
		/// <summary>Выводить информационные сообщения, предупреждения и сообщения обработки ошибок.</summary>
		// Token: 0x040009F1 RID: 2545
		Info,
		/// <summary>Выводить все сообщения отладки и трассировки.</summary>
		// Token: 0x040009F2 RID: 2546
		Verbose
	}
}
