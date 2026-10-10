using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Unity;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Сведения о подписи манифеста.
	///       </summary>
	// Token: 0x02000370 RID: 880
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManifestSignatureInformation
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x0000235B File Offset: 0x0000055B
		internal ManifestSignatureInformation()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает сведения о подписи Authenticode для манифеста.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Security.Cryptography.X509Certificates.AuthenticodeSignatureInformation" /> Объект, содержащий сведения о подписи Authenticode для манифеста, или <see langword="null" /> Если подпись отсутствует.
		///       </returns>
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0005A05A File Offset: 0x0005825A
		public AuthenticodeSignatureInformation AuthenticodeSignature
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Возвращает тип манифеста.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Security.ManifestKinds" />.
		///       </returns>
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0005A0D4 File Offset: 0x000582D4
		public ManifestKinds Manifest
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return ManifestKinds.None;
			}
		}

		/// <summary>
		///         Возвращает сведения о подписи строгого имени манифеста.
		///       </summary>
		/// <returns>
		///         Объект <see cref="P:System.Security.Cryptography.ManifestSignatureInformation.StrongNameSignature" /> объект, который содержит подпись, или <see langword="null" /> Если подпись строгого имени отсутствует.
		///       </returns>
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0005A05A File Offset: 0x0005825A
		public StrongNameSignatureInformation StrongNameSignature
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>
		///         Собирает и проверяет сведения о подписях манифестов, относящихся к заданному контексту активации.
		///       </summary>
		/// <param name="application">
		///           Контекст активации манифеста.
		///            Контексты активации относятся к приложению и содержат несколько манифестов.
		///         </param>
		/// <returns>
		///         Коллекция, содержащая <see cref="T:System.Security.Cryptography.ManifestSignatureInformation" /> каждый манифест, проверяемый объект.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="application" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001AD2 RID: 6866 RVA: 0x0005A05A File Offset: 0x0005825A
		public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Собирает и проверяет сведения о подписях манифестов, принадлежащих к заданному контексту активации и типу манифеста.
		///       </summary>
		/// <param name="application">
		///           Контекст активации манифеста.
		///            Контексты активации относятся к приложению и содержат несколько манифестов.
		///         </param>
		/// <param name="manifests">
		///           Тип манифеста.
		///            Этот параметр определяет, какие манифесты в контексте активации необходимо проверить.
		///         </param>
		/// <returns>
		///         Коллекция, содержащая <see cref="T:System.Security.Cryptography.ManifestSignatureInformation" /> каждый манифест, проверяемый объект.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="application" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001AD3 RID: 6867 RVA: 0x0005A05A File Offset: 0x0005825A
		public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>
		///         Собирает и проверяет сведения о подписях манифестов, относящихся к заданному контексту активации и типу манифеста и разрешает выбор отзыва сертификатов.
		///       </summary>
		/// <param name="application">
		///           Контекст приложения манифестов.
		///            Контексты активации относятся к приложению и содержат несколько манифестов.
		///         </param>
		/// <param name="manifests">
		///           Тип манифеста.
		///            Этот параметр определяет, какие манифесты в контексте активации необходимо проверить.
		///         </param>
		/// <param name="revocationFlag">
		///           Одно из значений перечисления, которое указывает, какие сертификаты в цепочке проверки отзыва.
		///            Значение по умолчанию — <see cref="F:System.Security.Cryptography.X509Certificates.X509RevocationFlag.ExcludeRoot" />.
		///         </param>
		/// <param name="revocationMode">
		///           Определяет ли X.509 при проверке интерактивным спискам отзыва сертификатов.
		///         </param>
		/// <returns>
		///         Коллекция, содержащая <see cref="T:System.Security.Cryptography.ManifestSignatureInformation" /> каждый манифест, проверяемый объект.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="application" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение, указанное для <paramref name="revocationFlag" /> или <paramref name="revocationMode" /> указан недопустимый параметр.
		///           </exception>
		// Token: 0x06001AD4 RID: 6868 RVA: 0x0005A05A File Offset: 0x0005825A
		[SecuritySafeCritical]
		public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
