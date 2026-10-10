using System;
using System.Reflection;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Security.Policy;
using Unity;

namespace System.Security
{
	/// <summary>Позволяет настраивать работу системы безопасности домена приложения и управлять ею.</summary>
	// Token: 0x020003DF RID: 991
	[ComVisible(true)]
	[Serializable]
	public class HostSecurityManager
	{
		/// <summary>При переопределении в производном классе получает политику безопасности для текущего домена приложения.</summary>
		/// <returns>Политика безопасности для текущего домена приложения. Значение по умолчанию — <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод использует политику разграничения доступа кода (CAS), которая является устаревшей для .NET Framework 4. Чтобы включить политику CAS для обеспечения совместимости с предыдущими версиями .NET Framework, используйте элемент &lt;legacyCasPolicy&gt;.</exception>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0000AF5E File Offset: 0x0000915E
		public virtual PolicyLevel DomainPolicy
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает флаги, представляющие компоненты политики безопасности, необходимые сайту.</summary>
		/// <returns>Одно из значений перечисления, указывающее компоненты политики безопасности. Значение по умолчанию — <see cref="F:System.Security.HostSecurityManagerOptions.AllFlags" />.</returns>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x00093303 File Offset: 0x00091503
		public virtual HostSecurityManagerOptions Flags
		{
			get
			{
				return HostSecurityManagerOptions.AllFlags;
			}
		}

		/// <summary>Определяет, должно ли выполняться приложение.</summary>
		/// <param name="applicationEvidence">Свидетельство для активируемого приложения.</param>
		/// <param name="activatorEvidence">Свидетельство для активирующего домена приложения (необязательное).</param>
		/// <param name="context">Контекст доверия.</param>
		/// <returns>Объект, содержащий сведения о доверии в отношении приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="applicationEvidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Не удается найти в свидетельстве приложения объект <see cref="T:System.Runtime.Hosting.ActivationArguments" />.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Runtime.Hosting.ActivationArguments.ActivationContext" /> в аргументах активации имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Набор разрешений <see cref="T:System.Security.Policy.ApplicationTrust" /> не содержит минимального набора запросов, определенного в объекте <see cref="T:System.ActivationContext" />.</exception>
		// Token: 0x060028AE RID: 10414 RVA: 0x00093308 File Offset: 0x00091508
		public virtual ApplicationTrust DetermineApplicationTrust(Evidence applicationEvidence, Evidence activatorEvidence, TrustManagerContext context)
		{
			if (applicationEvidence == null)
			{
				throw new ArgumentNullException("applicationEvidence");
			}
			ActivationArguments activationArguments = null;
			foreach (object obj in applicationEvidence)
			{
				activationArguments = (obj as ActivationArguments);
				if (activationArguments != null)
				{
					break;
				}
			}
			if (activationArguments == null)
			{
				throw new ArgumentException(string.Format(Locale.GetText("No {0} found in {1}."), "ActivationArguments", "Evidence"), "applicationEvidence");
			}
			if (activationArguments.ActivationContext == null)
			{
				throw new ArgumentException(string.Format(Locale.GetText("No {0} found in {1}."), "ActivationContext", "ActivationArguments"), "applicationEvidence");
			}
			if (!ApplicationSecurityManager.DetermineApplicationTrust(activationArguments.ActivationContext, context))
			{
				return null;
			}
			if (activationArguments.ApplicationIdentity == null)
			{
				return new ApplicationTrust();
			}
			return new ApplicationTrust(activationArguments.ApplicationIdentity);
		}

		/// <summary>Содержит свидетельство домена приложения для загружаемой сборки.</summary>
		/// <param name="inputEvidence">Дополнительное свидетельство, добавляемое к свидетельству <see cref="T:System.AppDomain" />.</param>
		/// <returns>Свидетельство, используемое для класса <see cref="T:System.AppDomain" />.</returns>
		// Token: 0x060028AF RID: 10415 RVA: 0x00002731 File Offset: 0x00000931
		public virtual Evidence ProvideAppDomainEvidence(Evidence inputEvidence)
		{
			return inputEvidence;
		}

		/// <summary>Содержит свидетельство сборки для загружаемой сборки.</summary>
		/// <param name="loadedAssembly">Загруженная сборка.</param>
		/// <param name="inputEvidence">Дополнительное свидетельство, добавляемое в свидетельство сборки.</param>
		/// <returns>Свидетельство, используемое для сборки.</returns>
		// Token: 0x060028B0 RID: 10416 RVA: 0x0008868F File Offset: 0x0008688F
		public virtual Evidence ProvideAssemblyEvidence(Assembly loadedAssembly, Evidence inputEvidence)
		{
			return inputEvidence;
		}

		/// <summary>Определяет разрешения, которые нужно предоставить коду, на основе определенного свидетельства.</summary>
		/// <param name="evidence">Набор свидетельств, используемых для оценки политики.</param>
		/// <returns>Набор разрешений, которые могут быть предоставлены системой безопасности.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060028B1 RID: 10417 RVA: 0x000933E8 File Offset: 0x000915E8
		public virtual PermissionSet ResolvePolicy(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new NullReferenceException("evidence");
			}
			return SecurityManager.ResolvePolicy(evidence);
		}

		/// <summary>Запрашивает определенный тип свидетельства для домена приложения.</summary>
		/// <param name="evidenceType">Тип свидетельства.</param>
		/// <returns>Запрошенное свидетельство домена приложения.</returns>
		// Token: 0x060028B2 RID: 10418 RVA: 0x00052955 File Offset: 0x00050B55
		public virtual EvidenceBase GenerateAppDomainEvidence(Type evidenceType)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Запрашивает определенный тип свидетельства для сборки.</summary>
		/// <param name="evidenceType">Тип свидетельства.</param>
		/// <param name="assembly">Целевая сборка.</param>
		/// <returns>Запрошенное свидетельство сборки.</returns>
		// Token: 0x060028B3 RID: 10419 RVA: 0x00052955 File Offset: 0x00050B55
		public virtual EvidenceBase GenerateAssemblyEvidence(Type evidenceType, Assembly assembly)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Определяет, какие типы свидетельства узел может предоставить домену приложения при запросе.</summary>
		/// <returns>Массив типов свидетельства.</returns>
		// Token: 0x060028B4 RID: 10420 RVA: 0x00052955 File Offset: 0x00050B55
		public virtual Type[] GetHostSuppliedAppDomainEvidenceTypes()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Определяет, какие типы свидетельства узел может предоставить сборке при запросе.</summary>
		/// <param name="assembly">Целевая сборка.</param>
		/// <returns>Массив типов свидетельства.</returns>
		// Token: 0x060028B5 RID: 10421 RVA: 0x00052955 File Offset: 0x00050B55
		public virtual Type[] GetHostSuppliedAssemblyEvidenceTypes(Assembly assembly)
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
