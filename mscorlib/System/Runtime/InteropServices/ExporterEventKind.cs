using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает обратные вызовы, которые делает программа экспорта библиотек типов при экспорте библиотеки типов.</summary>
	// Token: 0x0200073C RID: 1852
	[ComVisible(true)]
	[Serializable]
	public enum ExporterEventKind
	{
		/// <summary>Определяет, что это событие вызвано при экспортировании типа.</summary>
		// Token: 0x04002BBB RID: 11195
		NOTIF_TYPECONVERTED,
		/// <summary>Определяет, что событие вызывается при появлении предупреждения в процессе преобразования.</summary>
		// Token: 0x04002BBC RID: 11196
		NOTIF_CONVERTWARNING,
		/// <summary>Это значение не поддерживается в данной версии платформы .NET Framework.</summary>
		// Token: 0x04002BBD RID: 11197
		ERROR_REFTOINVALIDASSEMBLY
	}
}
