using System;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Задает тип используемой учетной записи Windows.</summary>
	// Token: 0x020004EA RID: 1258
	[ComVisible(true)]
	[Serializable]
	public enum WindowsAccountType
	{
		/// <summary>Стандартная учетная запись пользователя.</summary>
		// Token: 0x0400232E RID: 9006
		Normal,
		/// <summary>Учетная запись гостя Windows.</summary>
		// Token: 0x0400232F RID: 9007
		Guest,
		/// <summary>Системная учетная запись Windows.</summary>
		// Token: 0x04002330 RID: 9008
		System,
		/// <summary>Анонимная учетная запись.</summary>
		// Token: 0x04002331 RID: 9009
		Anonymous
	}
}
