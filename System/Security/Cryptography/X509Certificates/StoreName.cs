using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает имя открываемого хранилища сертификатов X.509.</summary>
	// Token: 0x020002BF RID: 703
	public enum StoreName
	{
		/// <summary>Хранилище сертификатов X.509 для других пользователей.</summary>
		// Token: 0x04000C62 RID: 3170
		AddressBook = 1,
		/// <summary>Хранилище сертификатов X.509 для сторонних центров сертификации (ЦС).</summary>
		// Token: 0x04000C63 RID: 3171
		AuthRoot,
		/// <summary>Хранилище сертификатов X.509 для промежуточных центров сертификации.</summary>
		// Token: 0x04000C64 RID: 3172
		CertificateAuthority,
		/// <summary>Хранилище сертификатов X.509 для отозванных сертификатов.</summary>
		// Token: 0x04000C65 RID: 3173
		Disallowed,
		/// <summary>Хранилище сертификатов X.509 для личных сертификатов.</summary>
		// Token: 0x04000C66 RID: 3174
		My,
		/// <summary>Хранилище сертификатов X.509 для доверенного корневого центра сертификации.</summary>
		// Token: 0x04000C67 RID: 3175
		Root,
		/// <summary>Хранилище сертификатов X.509 для непосредственно доверенных лиц и ресурсов.</summary>
		// Token: 0x04000C68 RID: 3176
		TrustedPeople,
		/// <summary>Хранилище сертификатов X.509 для непосредственно доверенных издателей.</summary>
		// Token: 0x04000C69 RID: 3177
		TrustedPublisher
	}
}
