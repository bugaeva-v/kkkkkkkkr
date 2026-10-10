using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Задает параметры конфигурации SOAP для использования с классом <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />.</summary>
	// Token: 0x020005DB RID: 1499
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum SoapOption
	{
		/// <summary>Параметр по умолчанию, указывающий, что дополнительные параметры не выбраны.</summary>
		// Token: 0x0400260C RID: 9740
		None = 0,
		/// <summary>Указывает, что тип всегда будет включаться в элементы SOAP. Этот параметр полезен при выполнении взаимодействия SOAP с реализациями SOAP, которым необходимы типы для всех элементов.</summary>
		// Token: 0x0400260D RID: 9741
		AlwaysIncludeTypes = 1,
		/// <summary>Указывает, что тип выходной строки SOAP в конверте SOAP использует префикс <see langword="XSD" />, и что в полученном XML отсутствует атрибут ID для строки.</summary>
		// Token: 0x0400260E RID: 9742
		XsdString = 2,
		/// <summary>Указывает, что SOAP будет создаваться без ссылок. Этот параметр на данный момент не реализован.</summary>
		// Token: 0x0400260F RID: 9743
		EmbedAll = 4,
		/// <summary>Открытый зарезервированный параметр для временных условий взаимодействия; использование будет изменено.</summary>
		// Token: 0x04002610 RID: 9744
		Option1 = 8,
		/// <summary>Открытый зарезервированный параметр для временных условий взаимодействия; использование будет изменено.</summary>
		// Token: 0x04002611 RID: 9745
		Option2 = 16
	}
}
