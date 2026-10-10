using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Определяет значения, указывающие, как обработчик композиции MEF выполняет поиск импортируемых данных.</summary>
	// Token: 0x02000048 RID: 72
	public enum ImportSource
	{
		/// <summary>Импорты могут быть выполнены из текущей области или любой области-предка.</summary>
		// Token: 0x040000D2 RID: 210
		Any,
		/// <summary>Импорты могут быть выполнены только из текущей области.</summary>
		// Token: 0x040000D3 RID: 211
		Local,
		/// <summary>Импорты могут быть выполнены только из области-предка.</summary>
		// Token: 0x040000D4 RID: 212
		NonLocal
	}
}
