using System;

namespace System.Security
{
	/// <summary>Управляет проверкой стека, которая определяет, имеют ли все вызывающие объекты в стеке вызовов разрешения, необходимые для доступа к защищенному ресурсу.</summary>
	// Token: 0x020003C9 RID: 969
	public interface IStackWalk
	{
		/// <summary>Подтверждает, что вызывающий код может получить доступ к ресурсу, определяемому текущим объектом разрешения, даже если вызывающим объектам выше в стеке вызовов не предоставлено разрешение на доступ к ресурсу.</summary>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего кода отсутствует <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Assertion" />.</exception>
		// Token: 0x06002856 RID: 10326
		void Assert();

		/// <summary>Определяет во время выполнения, было ли разрешение, указанное текущим объектом разрешений, предоставлено всем вызывающим методам в стеке вызовов.</summary>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий метод, расположенный выше в стеке вызовов, не имеет разрешения, указанного текущим объектом разрешений.  
		///
		/// или - 
		/// Вызывающий метод в стеке вызовов вызвал <see cref="M:System.Security.IStackWalk.Deny" /> в текущем объекте разрешений.</exception>
		// Token: 0x06002857 RID: 10327
		void Demand();

		/// <summary>Вызывает ошибку каждого <see cref="M:System.Security.IStackWalk.Demand" /> для текущего объекта, проходящего через вызывающий код.</summary>
		// Token: 0x06002858 RID: 10328
		void Deny();

		/// <summary>Вызывает сбой всех <see cref="M:System.Security.IStackWalk.Demand" /> для всех объектов, кроме текущего, проходящих через вызывающий код, даже если коду выше в стеке вызовов было предоставлено разрешение на доступ к другим ресурсам.</summary>
		// Token: 0x06002859 RID: 10329
		void PermitOnly();
	}
}
