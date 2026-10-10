using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает способ открытия хранилища сертификатов X.509.</summary>
	// Token: 0x020002BD RID: 701
	[Flags]
	public enum OpenFlags
	{
		/// <summary>Откройте хранилище сертификатов X.509 только для чтения.</summary>
		// Token: 0x04000C59 RID: 3161
		ReadOnly = 0,
		/// <summary>Откройте хранилище сертификатов X.509 для чтения и записи.</summary>
		// Token: 0x04000C5A RID: 3162
		ReadWrite = 1,
		/// <summary>Откройте хранилище сертификатов X.509 для самого высокого уровня доступа.</summary>
		// Token: 0x04000C5B RID: 3163
		MaxAllowed = 2,
		/// <summary>Открывает только существующие хранилища; если хранилища отсутствуют, метод <see cref="M:System.Security.Cryptography.X509Certificates.X509Store.Open(System.Security.Cryptography.X509Certificates.OpenFlags)" /> не создаст новое хранилище.</summary>
		// Token: 0x04000C5C RID: 3164
		OpenExistingOnly = 4,
		/// <summary>Откройте хранилище сертификатов X.509 и включите архив сертификатов.</summary>
		// Token: 0x04000C5D RID: 3165
		IncludeArchived = 8
	}
}
