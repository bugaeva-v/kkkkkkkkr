using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Идентифицирует операционную систему или платформу, поддерживаемую сборкой.</summary>
	// Token: 0x02000248 RID: 584
	[ComVisible(true)]
	[Serializable]
	public enum PlatformID
	{
		/// <summary>Операционной системой является одна из систем Win32. Это значение больше не используется.</summary>
		// Token: 0x04001770 RID: 6000
		Win32S,
		/// <summary>Используется операционная система Windows 95 или Windows 98. Это значение больше не используется.</summary>
		// Token: 0x04001771 RID: 6001
		Win32Windows,
		/// <summary>Операционной системой является Windows NT или более поздняя версия.</summary>
		// Token: 0x04001772 RID: 6002
		Win32NT,
		/// <summary>Операционной системой является Windows CE. Это значение больше не используется.</summary>
		// Token: 0x04001773 RID: 6003
		WinCE,
		/// <summary>Операционной системой является Unix.</summary>
		// Token: 0x04001774 RID: 6004
		Unix,
		/// <summary>Платформой разработки является Xbox 360. Это значение больше не используется.</summary>
		// Token: 0x04001775 RID: 6005
		Xbox,
		/// <summary>Операционной системой является Macintosh. Это значение было возвращено Silverlight. В .NET Core в качестве аналога используется Unix.</summary>
		// Token: 0x04001776 RID: 6006
		MacOSX
	}
}
