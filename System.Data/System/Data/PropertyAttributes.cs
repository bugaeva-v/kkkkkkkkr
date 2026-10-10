using System;
using System.ComponentModel;

namespace System.Data
{
	/// <summary>Указывает атрибуты свойства.</summary>
	// Token: 0x02000158 RID: 344
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	[Obsolete("PropertyAttributes has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public enum PropertyAttributes
	{
		/// <summary>Данным поставщиком это свойство не поддерживается.</summary>
		// Token: 0x04000BA3 RID: 2979
		NotSupported = 0,
		/// <summary>Пользователь должен задать значение этого свойства перед инициализацией источника данных.</summary>
		// Token: 0x04000BA4 RID: 2980
		Required = 1,
		/// <summary>Пользователю не требуется задавать значение этого свойства перед инициализацией источника данных.</summary>
		// Token: 0x04000BA5 RID: 2981
		Optional = 2,
		/// <summary>Пользователь может прочитать значение этого свойства.</summary>
		// Token: 0x04000BA6 RID: 2982
		Read = 512,
		/// <summary>Пользователь может изменить значение этого свойства.</summary>
		// Token: 0x04000BA7 RID: 2983
		Write = 1024
	}
}
