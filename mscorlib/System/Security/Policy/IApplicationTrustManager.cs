using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Определяет, должно ли выполняться приложение и какой набор разрешений должен быть предоставлен приложению.</summary>
	// Token: 0x02000414 RID: 1044
	[ComVisible(true)]
	public interface IApplicationTrustManager : ISecurityEncodable
	{
		/// <summary>Определяет, должно ли выполняться приложение и какой набор разрешений должен быть предоставлен приложению.</summary>
		/// <param name="activationContext">Контекст активации для приложения.</param>
		/// <param name="context">Контекст диспетчера доверия для приложения.</param>
		/// <returns>Объект, содержащий решения по обеспечению безопасности приложения.</returns>
		// Token: 0x06002ABE RID: 10942
		ApplicationTrust DetermineApplicationTrust(ActivationContext activationContext, TrustManagerContext context);
	}
}
