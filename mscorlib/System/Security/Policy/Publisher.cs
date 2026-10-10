using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Policy
{
	/// <summary>Предоставляет цифровую подпись Authenticode X.509v3 сборки кода в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x020003FC RID: 1020
	[Serializable]
	public sealed class Publisher : EvidenceBase, IIdentityPermissionFactory
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Publisher" /> с сертификатом Authenticode X.509v3, содержащим открытый ключ издателя.</summary>
		/// <param name="cert">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, содержащий открытый ключ издателя программного обеспечения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="cert" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060029B3 RID: 10675 RVA: 0x00097E22 File Offset: 0x00096022
		public Publisher(X509Certificate cert)
		{
		}

		/// <summary>Получает сертификат издателя Authenticode X.509v3.</summary>
		/// <returns>Сертификат издателя <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x0000AF5E File Offset: 0x0000915E
		public X509Certificate Certificate
		{
			get
			{
				return null;
			}
		}

		/// <summary>Создает эквивалентную копию объекта <see cref="T:System.Security.Policy.Publisher" />.</summary>
		/// <returns>Новая, идентичная копия объекта <see cref="T:System.Security.Policy.Publisher" />.</returns>
		// Token: 0x060029B5 RID: 10677 RVA: 0x0000AF5E File Offset: 0x0000915E
		public object Copy()
		{
			return null;
		}

		/// <summary>Создает разрешение идентификации, соответствующее текущему экземпляру класса <see cref="T:System.Security.Policy.Publisher" />.</summary>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" />, из которого создается разрешение идентификации.</param>
		/// <returns>Разрешение <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> для указанного объекта <see cref="T:System.Security.Policy.Publisher" />.</returns>
		// Token: 0x060029B6 RID: 10678 RVA: 0x0000AF5E File Offset: 0x0000915E
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return null;
		}

		/// <summary>Сравнивает на предмет равенства указанный объект и текущий объект <see cref="T:System.Security.Policy.Publisher" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Security.Policy.Publisher" />, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если два экземпляра класса <see cref="T:System.Security.Policy.Publisher" /> равны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="o" /> не является объектом <see cref="T:System.Security.Policy.Publisher" />.</exception>
		// Token: 0x060029B7 RID: 10679 RVA: 0x00097E2A File Offset: 0x0009602A
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		/// <summary>Получает хэш-код текущего объекта <see cref="P:System.Security.Policy.Publisher.Certificate" />.</summary>
		/// <returns>Хэш-код текущего объекта <see cref="P:System.Security.Policy.Publisher.Certificate" />.</returns>
		// Token: 0x060029B8 RID: 10680 RVA: 0x000930E8 File Offset: 0x000912E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Policy.Publisher" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.Publisher" />.</returns>
		// Token: 0x060029B9 RID: 10681 RVA: 0x00097E33 File Offset: 0x00096033
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
