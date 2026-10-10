using System;
using System.Security.Permissions;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Отображает диалоговые окна интерфейса пользователя, которые позволяют выбрать и просмотреть сертификаты X.509. Этот класс не наследуется.</summary>
	// Token: 0x02000017 RID: 23
	public static class X509Certificate2UI
	{
		/// <summary>Отображает диалоговое окно, содержащее свойства сертификата X.509 и связанной цепочки сертификатов.</summary>
		/// <param name="certificate">Отображаемый сертификат X.509.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="certificate" /> недопустим.</exception>
		// Token: 0x0600005C RID: 92 RVA: 0x00003063 File Offset: 0x00001263
		[MonoTODO]
		public static void DisplayCertificate(X509Certificate2 certificate)
		{
			X509Certificate2UI.DisplayCertificate(certificate, IntPtr.Zero);
		}

		/// <summary>Отображает диалоговое окно, содержащее свойства сертификата X.509 и связанной цепочки сертификатов, с помощью дескриптора родительского окна.</summary>
		/// <param name="certificate">Отображаемый сертификат X.509.</param>
		/// <param name="hwndParent">Дескриптор родительского окна, используемый для диалогового окна отображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="certificate" /> недопустим.</exception>
		// Token: 0x0600005D RID: 93 RVA: 0x00003070 File Offset: 0x00001270
		[MonoTODO]
		[UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.SafeTopLevelWindows)]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public static void DisplayCertificate(X509Certificate2 certificate, IntPtr hwndParent)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			certificate.GetRawCertData();
			throw new NotImplementedException();
		}

		/// <summary>Отображает диалоговое окно для выбора сертификата X.509 из коллекции сертификатов.</summary>
		/// <param name="certificates">Коллекция сертификатов X.509, из которых производится выбор.</param>
		/// <param name="title">Название диалогового окна.</param>
		/// <param name="message">Сообщение с описанием для помощи пользователю.  Сообщение отображается в диалоговом окне.</param>
		/// <param name="selectionFlag">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509SelectionFlag" />, определяющее, будет ли разрешен выбор одного или нескольких сертификатов.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, который содержит выбранный сертификат или выбранные сертификаты.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="selectionFlag" /> не является допустимым флагом.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="certificates" /> недопустим.</exception>
		// Token: 0x0600005E RID: 94 RVA: 0x0000308C File Offset: 0x0000128C
		[MonoTODO]
		public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag)
		{
			return X509Certificate2UI.SelectFromCollection(certificates, title, message, selectionFlag, IntPtr.Zero);
		}

		/// <summary>Отображает диалоговое окно для выбора сертификата X.509 из коллекции сертификатов с помощью дескриптора родительского окна.</summary>
		/// <param name="certificates">Коллекция сертификатов X.509, из которых производится выбор.</param>
		/// <param name="title">Название диалогового окна.</param>
		/// <param name="message">Сообщение с описанием для помощи пользователю.  Сообщение отображается в диалоговом окне.</param>
		/// <param name="selectionFlag">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509SelectionFlag" />, определяющее, будет ли разрешен выбор одного или нескольких сертификатов.</param>
		/// <param name="hwndParent">Дескриптор родительского окна, используемый для диалогового окна отображения.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, который содержит выбранный сертификат или выбранные сертификаты.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="selectionFlag" /> не является допустимым флагом.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificates" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="certificates" /> недопустим.</exception>
		// Token: 0x0600005F RID: 95 RVA: 0x0000309C File Offset: 0x0000129C
		[MonoTODO]
		[UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.SafeTopLevelWindows)]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public static X509Certificate2Collection SelectFromCollection(X509Certificate2Collection certificates, string title, string message, X509SelectionFlag selectionFlag, IntPtr hwndParent)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			if (selectionFlag < X509SelectionFlag.SingleSelection || selectionFlag > X509SelectionFlag.MultiSelection)
			{
				throw new ArgumentException("selectionFlag");
			}
			throw new NotImplementedException();
		}
	}
}
