using System;

namespace System.Configuration
{
	/// <summary>Определяет специальную категорию параметров свойства приложения.</summary>
	// Token: 0x020001DA RID: 474
	public enum SpecialSetting
	{
		/// <summary>Свойство конфигурации представляет строку подключения обычную для хранения данных или сетевого ресурса.</summary>
		// Token: 0x040007BA RID: 1978
		ConnectionString,
		/// <summary>Свойство конфигурации представляет унифицированный указатель ресурса (URL) для Интернет соединения.</summary>
		// Token: 0x040007BB RID: 1979
		WebServiceUrl
	}
}
