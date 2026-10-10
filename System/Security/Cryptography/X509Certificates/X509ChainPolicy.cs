using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет политику цепочки, применяемую при построении цепочки сертификатов X509. Этот класс не наследуется.</summary>
	// Token: 0x020002DF RID: 735
	public sealed class X509ChainPolicy
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />.</summary>
		// Token: 0x06001757 RID: 5975 RVA: 0x0005CA41 File Offset: 0x0005AC41
		public X509ChainPolicy()
		{
			this.Reset();
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0005CA4F File Offset: 0x0005AC4F
		internal X509ChainPolicy(X509CertificateCollection store)
		{
			this.store = store;
			this.Reset();
		}

		/// <summary>Получает коллекцию идентификаторов объекта (OID), задающих политики применения и расширенные использования ключа, которые должен поддерживать сертификат.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.OidCollection" />.</returns>
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0005CA64 File Offset: 0x0005AC64
		public OidCollection ApplicationPolicy
		{
			get
			{
				return this.apps;
			}
		}

		/// <summary>Получает коллекцию идентификаторов объекта (OID), задающих политики сертификатов, которые должен поддерживать сертификат.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.OidCollection" />.</returns>
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0005CA6C File Offset: 0x0005AC6C
		public OidCollection CertificatePolicy
		{
			get
			{
				return this.cert;
			}
		}

		/// <summary>Получает объект, представляющий дополнительную коллекцию сертификатов, в которой поиск может осуществляться модулем цепочки при проверке цепочки сертификатов.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</returns>
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0005CA74 File Offset: 0x0005AC74
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x0005CAFC File Offset: 0x0005ACFC
		public X509Certificate2Collection ExtraStore
		{
			get
			{
				if (this.store2 != null)
				{
					return this.store2;
				}
				this.store2 = new X509Certificate2Collection();
				if (this.store != null)
				{
					foreach (X509Certificate certificate in this.store)
					{
						this.store2.Add(new X509Certificate2(certificate));
					}
				}
				return this.store2;
			}
			internal set
			{
				this.store2 = value;
			}
		}

		/// <summary>Получает или задает значения для флагов отзыва X509.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" />.</returns>
		/// <exception cref="T:System.ArgumentException">Указанное значение <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> не является допустимым флагом.</exception>
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0005CB05 File Offset: 0x0005AD05
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x0005CB0D File Offset: 0x0005AD0D
		public X509RevocationFlag RevocationFlag
		{
			get
			{
				return this.rflag;
			}
			set
			{
				if (value < X509RevocationFlag.EndCertificateOnly || value > X509RevocationFlag.ExcludeRoot)
				{
					throw new ArgumentException("RevocationFlag");
				}
				this.rflag = value;
			}
		}

		/// <summary>Получает или задает значения для режима отзыва сертификата X509.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" />.</returns>
		/// <exception cref="T:System.ArgumentException">Указанное значение <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> не является допустимым флагом.</exception>
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x0005CB29 File Offset: 0x0005AD29
		// (set) Token: 0x06001760 RID: 5984 RVA: 0x0005CB31 File Offset: 0x0005AD31
		public X509RevocationMode RevocationMode
		{
			get
			{
				return this.mode;
			}
			set
			{
				if (value < X509RevocationMode.NoCheck || value > X509RevocationMode.Offline)
				{
					throw new ArgumentException("RevocationMode");
				}
				this.mode = value;
			}
		}

		/// <summary>Получает или задает максимальное количество времени, которое можно затратить на интерактивную проверку отзыва или загрузку списка отзыва сертификатов (CRL). Значение <see cref="F:System.TimeSpan.Zero" /> означает отсутствие ограничений.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />.</returns>
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0005CB4D File Offset: 0x0005AD4D
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0005CB55 File Offset: 0x0005AD55
		public TimeSpan UrlRetrievalTimeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				this.timeout = value;
			}
		}

		/// <summary>Получает флаги проверки для сертификата.</summary>
		/// <returns>Значение из перечисления <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" />.</returns>
		/// <exception cref="T:System.ArgumentException">Указанное значение <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> не является допустимым флагом. По умолчанию устанавливается значение <see cref="F:System.Security.Cryptography.X509Certificates.X509VerificationFlags.NoFlag" />.</exception>
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0005CB5E File Offset: 0x0005AD5E
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0005CB66 File Offset: 0x0005AD66
		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return this.vflags;
			}
			set
			{
				if ((value | X509VerificationFlags.AllFlags) != X509VerificationFlags.AllFlags)
				{
					throw new ArgumentException("VerificationFlags");
				}
				this.vflags = value;
			}
		}

		/// <summary>Возвращает или задает время, за которое требуется проверить цепочку.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />.</returns>
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x0005CB88 File Offset: 0x0005AD88
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0005CB90 File Offset: 0x0005AD90
		public DateTime VerificationTime
		{
			get
			{
				return this.vtime;
			}
			set
			{
				this.vtime = value;
			}
		}

		/// <summary>Восстанавливает значения по умолчанию для членов <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />.</summary>
		// Token: 0x06001767 RID: 5991 RVA: 0x0005CB9C File Offset: 0x0005AD9C
		public void Reset()
		{
			this.apps = new OidCollection();
			this.cert = new OidCollection();
			this.store2 = null;
			this.rflag = X509RevocationFlag.ExcludeRoot;
			this.mode = X509RevocationMode.Online;
			this.timeout = TimeSpan.Zero;
			this.vflags = X509VerificationFlags.NoFlag;
			this.vtime = DateTime.Now;
		}

		// Token: 0x04000D19 RID: 3353
		private OidCollection apps;

		// Token: 0x04000D1A RID: 3354
		private OidCollection cert;

		// Token: 0x04000D1B RID: 3355
		private X509CertificateCollection store;

		// Token: 0x04000D1C RID: 3356
		private X509Certificate2Collection store2;

		// Token: 0x04000D1D RID: 3357
		private X509RevocationFlag rflag;

		// Token: 0x04000D1E RID: 3358
		private X509RevocationMode mode;

		// Token: 0x04000D1F RID: 3359
		private TimeSpan timeout;

		// Token: 0x04000D20 RID: 3360
		private X509VerificationFlags vflags;

		// Token: 0x04000D21 RID: 3361
		private DateTime vtime;
	}
}
