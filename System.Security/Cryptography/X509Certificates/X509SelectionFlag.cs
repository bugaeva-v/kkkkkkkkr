using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает тип запрошенного выбора с помощью метода <see cref="Overload:System.Security.Cryptography.X509Certificates.X509Certificate2UI.SelectFromCollection" />.</summary>
	// Token: 0x02000018 RID: 24
	public enum X509SelectionFlag
	{
		/// <summary>Выбор одного сертификата. Пользовательский интерфейс позволяет выбирать один сертификат X.509.</summary>
		// Token: 0x0400013C RID: 316
		SingleSelection,
		/// <summary>Выбор нескольких сертификатов. Нажмите клавишу SHIFT или CRTL, чтобы выбрать несколько сертификатов X.509.</summary>
		// Token: 0x0400013D RID: 317
		MultiSelection
	}
}
