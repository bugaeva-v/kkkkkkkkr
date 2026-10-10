using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Описывает обратные вызовы, выполняемые импортером библиотеки типов при импортировании библиотеки типов.</summary>
	// Token: 0x02000745 RID: 1861
	[ComVisible(true)]
	[Serializable]
	public enum ImporterEventKind
	{
		/// <summary>Определяет, что событие вызывается при импортировании типа.</summary>
		// Token: 0x04002BC3 RID: 11203
		NOTIF_TYPECONVERTED,
		/// <summary>Определяет, что событие вызывается при появлении предупреждения в процессе преобразования.</summary>
		// Token: 0x04002BC4 RID: 11204
		NOTIF_CONVERTWARNING,
		/// <summary>Это свойство не поддерживается в данной версии платформы .NET Framework.</summary>
		// Token: 0x04002BC5 RID: 11205
		ERROR_REFTOINVALIDTYPELIB
	}
}
