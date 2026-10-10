using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Cryptography;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000450 RID: 1104
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class PublisherIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.PublisherIdentityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002CC6 RID: 11462 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public PublisherIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает файл сертификации, содержащий сертификат Authenticode X.509v3.</summary>
		/// <returns>Путь к файлу сертификата X.509 (обычно имеет расширение CER).</returns>
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000A0B95 File Offset: 0x0009ED95
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x000A0B9D File Offset: 0x0009ED9D
		public string CertFile
		{
			get
			{
				return this.certFile;
			}
			set
			{
				this.certFile = value;
			}
		}

		/// <summary>Получает или задает подписанный файл, из которого необходимо извлечь сертификат Authenticode X.509v3.</summary>
		/// <returns>Путь к файлу с сигнатурой Authenticode.</returns>
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000A0BA6 File Offset: 0x0009EDA6
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x000A0BAE File Offset: 0x0009EDAE
		public string SignedFile
		{
			get
			{
				return this.signedFile;
			}
			set
			{
				this.signedFile = value;
			}
		}

		/// <summary>Получает или задает сертификат Authenticode X.509v3, в котором указывается издатель вызывающего кода.</summary>
		/// <returns>Шестнадцатеричное представление сертификата X.509.</returns>
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000A0BB7 File Offset: 0x0009EDB7
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x000A0BBF File Offset: 0x0009EDBF
		public string X509Certificate
		{
			get
			{
				return this.x509data;
			}
			set
			{
				this.x509data = value;
			}
		}

		/// <summary>Создает и возвращает новый экземпляр объекта <see cref="T:System.Security.Permissions.PublisherIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.PublisherIdentityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002CCD RID: 11469 RVA: 0x000A0BC8 File Offset: 0x0009EDC8
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new PublisherIdentityPermission(PermissionState.Unrestricted);
			}
			if (this.x509data != null)
			{
				return new PublisherIdentityPermission(new X509Certificate(CryptoConvert.FromHex(this.x509data)));
			}
			if (this.certFile != null)
			{
				return new PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(this.certFile));
			}
			if (this.signedFile != null)
			{
				return new PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromSignedFile(this.signedFile));
			}
			return new PublisherIdentityPermission(PermissionState.None);
		}

		// Token: 0x04002076 RID: 8310
		private string certFile;

		// Token: 0x04002077 RID: 8311
		private string signedFile;

		// Token: 0x04002078 RID: 8312
		private string x509data;
	}
}
