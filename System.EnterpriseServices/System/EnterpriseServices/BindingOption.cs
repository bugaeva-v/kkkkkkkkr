using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Показывает, должна ли вся работа, отправленная с помощью <see cref="T:System.EnterpriseServices.Activity" />, быть связана только с одним однопотоковым подразделением. Данное перечисление не оказывает никакого воздействия на многопотоковое подразделение.</summary>
	// Token: 0x02000015 RID: 21
	[ComVisible(false)]
	[Serializable]
	public enum BindingOption
	{
		/// <summary>Работа, отправленная с помощью этого действия, не связана с одиночным STA.</summary>
		// Token: 0x04000048 RID: 72
		NoBinding,
		/// <summary>Работа, отправленная с помощью этого действия, связана с одиночным STA.</summary>
		// Token: 0x04000049 RID: 73
		BindingToPoolThread
	}
}
