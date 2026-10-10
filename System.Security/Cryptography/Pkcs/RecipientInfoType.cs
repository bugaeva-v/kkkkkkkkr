using System;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Перечисление <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoType" /> определяет типы информации о получателе.</summary>
	// Token: 0x02000083 RID: 131
	public enum RecipientInfoType
	{
		/// <summary>Тип информации о получателе неизвестен.</summary>
		// Token: 0x0400029F RID: 671
		Unknown,
		/// <summary>Информация о получателе при передаче ключей.</summary>
		// Token: 0x040002A0 RID: 672
		KeyTransport,
		/// <summary>Информация о получателе при согласовании ключей.</summary>
		// Token: 0x040002A1 RID: 673
		KeyAgreement
	}
}
