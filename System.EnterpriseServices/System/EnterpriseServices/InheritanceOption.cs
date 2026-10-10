using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает, следует ли создать новый контекст на основе текущего контекста или на базе информации в объекте <see cref="T:System.EnterpriseServices.ServiceConfig" />.</summary>
	// Token: 0x0200002F RID: 47
	[ComVisible(false)]
	[Serializable]
	public enum InheritanceOption
	{
		/// <summary>Новый контекст создается из существующего контекста. Значение <see cref="F:System.EnterpriseServices.InheritanceOption.Inherit" /> является значением по умолчанию для свойства <see cref="P:System.EnterpriseServices.ServiceConfig.Inheritance" />.</summary>
		// Token: 0x0400005D RID: 93
		Inherit,
		/// <summary>Новый контекст создается из контекста по умолчанию.</summary>
		// Token: 0x0400005E RID: 94
		Ignore
	}
}
