using System;

namespace System.Security
{
	/// <summary>Предоставляет базовый класс для запроса состояния безопасности действия из объекта <see cref="T:System.AppDomainManager" />.</summary>
	// Token: 0x020003EC RID: 1004
	public abstract class SecurityState
	{
		/// <summary>При переопределении в производном классе обеспечивает доступность на узле состояния, представленного объектом <see cref="T:System.Security.SecurityState" />.</summary>
		// Token: 0x0600297C RID: 10620
		public abstract void EnsureState();

		/// <summary>Получает значение, показывающее, доступно ли состояние данной реализации класса <see cref="T:System.Security.SecurityState" /> на текущем узле.</summary>
		/// <returns>Значение <see langword="true" />, если состояние доступно, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600297D RID: 10621 RVA: 0x00096640 File Offset: 0x00094840
		public bool IsStateAvailable()
		{
			AppDomainManager domainManager = AppDomain.CurrentDomain.DomainManager;
			return domainManager != null && domainManager.CheckSecuritySettings(this);
		}
	}
}
