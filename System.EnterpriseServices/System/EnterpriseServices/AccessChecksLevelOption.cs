using System;

namespace System.EnterpriseServices
{
	/// <summary>Задает уровень проверки доступа для приложения либо только на уровне процесса, либо на всех уровнях, включая уровни компонентов, интерфейсов и методов.</summary>
	// Token: 0x02000009 RID: 9
	[Serializable]
	public enum AccessChecksLevelOption
	{
		/// <summary>Разрешает проверки доступа только на уровне процесса. На уровне компонентов, интерфейсов и методов проверки доступа не выполняются.</summary>
		// Token: 0x0400002C RID: 44
		Application,
		/// <summary>Разрешает проверки доступа на всех уровнях по вызовам в приложении.</summary>
		// Token: 0x0400002D RID: 45
		ApplicationComponent
	}
}
