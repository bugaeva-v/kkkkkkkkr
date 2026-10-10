using System;
using System.Security.Permissions;
using Unity;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>
	///         Предоставляет сведения об отметке времени, которая была применена к подписи Authenticode для манифеста.
	///       </summary>
	// Token: 0x02000372 RID: 882
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class TimestampInformation
	{
		// Token: 0x06001ADF RID: 6879 RVA: 0x0000235B File Offset: 0x0000055B
		internal TimestampInformation()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает хэш-алгоритм, используемый для вычисления подписи отметки времени.
		///       </summary>
		/// <returns>
		///         Хэш-алгоритм, используемый для вычисления подписи отметки времени.
		///       </returns>
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0005A05A File Offset: 0x0005825A
		public string HashAlgorithm
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает значение HRESULT, полученного в результате проверки подписи.
		///       </summary>
		/// <returns>
		///         Значение HRESULT, полученного в результате проверки подписи.
		///       </returns>
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0005A144 File Offset: 0x00058344
		public int HResult
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли допустимым штамп времени подписи.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если отметка времени допустима; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0005A160 File Offset: 0x00058360
		public bool IsValid
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(bool);
			}
		}

		/// <summary>
		///         Получает цепочку сертификатов, используемую для проверки отметки времени подписи.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> Объект, представляющий цепочки сертификатов.
		///       </returns>
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0005A05A File Offset: 0x0005825A
		public X509Chain SignatureChain
		{
			[SecuritySafeCritical]
			[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает сертификат, подписанный штамп времени.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> Объект, представляющий сертификат.
		///       </returns>
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x0005A05A File Offset: 0x0005825A
		public X509Certificate2 SigningCertificate
		{
			[SecuritySafeCritical]
			[StorePermission(SecurityAction.Demand, OpenStore = true, EnumerateCertificates = true)]
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Получает отметку времени, которая была применена к подписи.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.DateTime" /> объект, который представляет собой отметку времени.
		///       </returns>
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0005A17C File Offset: 0x0005837C
		public DateTime Timestamp
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return default(DateTime);
			}
		}

		/// <summary>
		///         Возвращает результат проверки подписи отметки времени.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Security.Cryptography.SignatureVerificationResult" />.
		///       </returns>
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0005A198 File Offset: 0x00058398
		public SignatureVerificationResult VerificationResult
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return SignatureVerificationResult.Valid;
			}
		}
	}
}
