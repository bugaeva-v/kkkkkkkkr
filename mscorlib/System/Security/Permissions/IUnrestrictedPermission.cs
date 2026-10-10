using System;

namespace System.Security.Permissions
{
	/// <summary>Позволяет разрешению предоставлять неограниченное состояние.</summary>
	// Token: 0x0200042B RID: 1067
	public interface IUnrestrictedPermission
	{
		/// <summary>Возвращает значение, указывающее, разрешен ли неограниченный доступ к ресурсу, защищенному с помощью разрешения.</summary>
		/// <returns>Значение <see langword="true" />, если разрешено неограниченное использование ресурса, защищенного разрешением. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002B98 RID: 11160
		bool IsUnrestricted();
	}
}
