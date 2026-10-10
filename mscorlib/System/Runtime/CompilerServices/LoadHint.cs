using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Задает предпочитаемую привязку по умолчанию для зависимой сборки.</summary>
	// Token: 0x02000829 RID: 2089
	[Serializable]
	public enum LoadHint
	{
		/// <summary>Предпочтение не указано.</summary>
		// Token: 0x04002D73 RID: 11635
		Default,
		/// <summary>Зависимость всегда загружается.</summary>
		// Token: 0x04002D74 RID: 11636
		Always,
		/// <summary>Зависимость иногда загружается.</summary>
		// Token: 0x04002D75 RID: 11637
		Sometimes
	}
}
