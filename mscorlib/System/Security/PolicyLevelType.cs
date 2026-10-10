using System;

namespace System.Security
{
	/// <summary>Указывает тип уровня политики управляемого кода.</summary>
	// Token: 0x020003CA RID: 970
	public enum PolicyLevelType
	{
		/// <summary>Политика безопасности для всего управляемого кода в приложении.</summary>
		// Token: 0x04001E8F RID: 7823
		AppDomain = 3,
		/// <summary>Политика безопасности для всего управляемого кода на предприятии.</summary>
		// Token: 0x04001E90 RID: 7824
		Enterprise = 2,
		/// <summary>Политика безопасности для всего управляемого кода, выполняемого на данном компьютере.</summary>
		// Token: 0x04001E91 RID: 7825
		Machine = 1,
		/// <summary>Политика безопасности для всего управляемого кода, выполняемого данным пользователем.</summary>
		// Token: 0x04001E92 RID: 7826
		User = 0
	}
}
