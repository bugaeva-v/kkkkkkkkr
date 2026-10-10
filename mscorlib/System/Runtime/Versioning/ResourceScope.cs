using System;

namespace System.Runtime.Versioning
{
	/// <summary>Определяет область видимости общего ресурса.</summary>
	// Token: 0x02000641 RID: 1601
	[Flags]
	public enum ResourceScope
	{
		/// <summary>Состояние с совместным доступом отсутствует.</summary>
		// Token: 0x040026FA RID: 9978
		None = 0,
		/// <summary>Состояние совместно используется объектами одного компьютера.</summary>
		// Token: 0x040026FB RID: 9979
		Machine = 1,
		/// <summary>Состояние является совместно используемым внутри процесса.</summary>
		// Token: 0x040026FC RID: 9980
		Process = 2,
		/// <summary>Состояние совместно используется объектами в домене приложения <see cref="T:System.AppDomain" />.</summary>
		// Token: 0x040026FD RID: 9981
		AppDomain = 4,
		/// <summary>Состояние совместно используется объектами в библиотеке.</summary>
		// Token: 0x040026FE RID: 9982
		Library = 8,
		/// <summary>Ресурсы видимы только данному типу.</summary>
		// Token: 0x040026FF RID: 9983
		Private = 16,
		/// <summary>Ресурс является видимым в области сборки.</summary>
		// Token: 0x04002700 RID: 9984
		Assembly = 32
	}
}
