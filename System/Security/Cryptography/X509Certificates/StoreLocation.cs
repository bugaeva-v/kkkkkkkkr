using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает расположение хранилища сертификатов X.509.</summary>
	// Token: 0x020002BE RID: 702
	public enum StoreLocation
	{
		/// <summary>Хранилище сертификатов X.509 используется текущим пользователем.</summary>
		// Token: 0x04000C5F RID: 3167
		CurrentUser = 1,
		/// <summary>Хранилище сертификатов X.509, назначенное локальному компьютеру.</summary>
		// Token: 0x04000C60 RID: 3168
		LocalMachine
	}
}
