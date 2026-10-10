using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Определяет контекст, в котором выполняется раздел COM+.</summary>
	// Token: 0x02000036 RID: 54
	[ComVisible(false)]
	[Serializable]
	public enum PartitionOption
	{
		/// <summary>Вложенный контекст выполняется в глобальном разделе. Значение <see cref="F:System.EnterpriseServices.PartitionOption.Ignore" /> является параметром по умолчанию для свойства <see cref="P:System.EnterpriseServices.ServiceConfig.PartitionOption" />, когда свойству <see cref="P:System.EnterpriseServices.ServiceConfig.Inheritance" /> присвоено значение <see cref="F:System.EnterpriseServices.InheritanceOption.Ignore" />.</summary>
		// Token: 0x04000074 RID: 116
		Ignore,
		/// <summary>Вложенный контекст выполняется в текущем содержащем разделе COM+. Это установка по умолчанию для объекта <see cref="P:System.EnterpriseServices.ServiceConfig.PartitionOption" />, когда значение <see cref="P:System.EnterpriseServices.ServiceConfig.Inheritance" /> установлено для <see cref="F:System.EnterpriseServices.InheritanceOption.Inherit" />.</summary>
		// Token: 0x04000075 RID: 117
		Inherit,
		/// <summary>Вложенный контекст выполняется в разделе COM+, отличающемся от текущего содержащего раздела.</summary>
		// Token: 0x04000076 RID: 118
		New
	}
}
