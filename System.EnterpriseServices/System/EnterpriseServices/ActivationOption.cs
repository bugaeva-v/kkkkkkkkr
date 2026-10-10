using System;

namespace System.EnterpriseServices
{
	/// <summary>Задает способ активизации обслуживаемых компонентов в приложении.</summary>
	// Token: 0x0200000A RID: 10
	[Serializable]
	public enum ActivationOption
	{
		/// <summary>Указывает, что обслуживаемые компоненты в помеченном приложении активируются в процессе создателя.</summary>
		// Token: 0x0400002F RID: 47
		Library,
		/// <summary>Указывает, что обслуживаемые компоненты в помеченном приложении активируются в ходе системного процесса.</summary>
		// Token: 0x04000030 RID: 48
		Server
	}
}
