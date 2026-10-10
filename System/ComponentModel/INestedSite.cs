using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет возможность получить полное иерархическое имя компонента.</summary>
	// Token: 0x020003B9 RID: 953
	public interface INestedSite : ISite, IServiceProvider
	{
		/// <summary>Возвращает полное имя компонента в этом узле.</summary>
		/// <returns>Полное имя компонента в этом узле.</returns>
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001F18 RID: 7960
		string FullName { get; }
	}
}
