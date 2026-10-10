using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Указывает, как настроены параллельные сборки для объекта <see cref="T:System.EnterpriseServices.ServiceConfig" />.</summary>
	// Token: 0x0200004D RID: 77
	[ComVisible(false)]
	[Serializable]
	public enum SxsOption
	{
		/// <summary>Параллельные сборки не используются во вложенном контексте. Значение <see cref="F:System.EnterpriseServices.SxsOption.Ignore" /> является параметром по умолчанию для свойства <see cref="P:System.EnterpriseServices.ServiceConfig.SxsOption" />, когда свойству <see cref="P:System.EnterpriseServices.ServiceConfig.Inheritance" /> присвоено значение <see cref="F:System.EnterpriseServices.InheritanceOption.Ignore" />.</summary>
		// Token: 0x04000089 RID: 137
		Ignore,
		/// <summary>Используется текущая параллельная сборка вложенного контекста. Значение <see cref="F:System.EnterpriseServices.SxsOption.Inherit" /> является параметром по умолчанию для свойства <see cref="P:System.EnterpriseServices.ServiceConfig.SxsOption" />, когда свойству <see cref="P:System.EnterpriseServices.ServiceConfig.Inheritance" /> присвоено значение <see cref="F:System.EnterpriseServices.InheritanceOption.Inherit" />.</summary>
		// Token: 0x0400008A RID: 138
		Inherit,
		/// <summary>Для вложенного контекста создается новая параллельная сборка.</summary>
		// Token: 0x0400008B RID: 139
		New
	}
}
