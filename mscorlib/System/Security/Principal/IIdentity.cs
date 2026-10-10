using System;

namespace System.Security.Principal
{
	/// <summary>Определяет основные возможности объекта удостоверения.</summary>
	// Token: 0x020004DE RID: 1246
	public interface IIdentity
	{
		/// <summary>Получает имя текущего пользователя.</summary>
		/// <returns>Имя пользователя, от лица которого выполняется код программы.</returns>
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060031E4 RID: 12772
		string Name { get; }

		/// <summary>Получает тип используемой проверки подлинности.</summary>
		/// <returns>Тип проверки подлинности, применяемой для идентификации пользователя.</returns>
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060031E5 RID: 12773
		string AuthenticationType { get; }

		/// <summary>Получает значение, определяющее, прошел ли пользователь проверку подлинности.</summary>
		/// <returns>
		///   <see langword="true" />, если пользователь прошел проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060031E6 RID: 12774
		bool IsAuthenticated { get; }
	}
}
