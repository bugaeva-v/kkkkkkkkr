using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Cryptography;

namespace System.Security.Permissions
{
	/// <summary>Представляет удостоверение издателя программного обеспечения. Этот класс не наследуется.</summary>
	// Token: 0x0200044F RID: 1103
	[ComVisible(true)]
	[Serializable]
	public sealed class PublisherIdentityPermission : CodeAccessPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002CBA RID: 11450 RVA: 0x0009EC4C File Offset: 0x0009CE4C
		public PublisherIdentityPermission(PermissionState state)
		{
			CodeAccessPermission.CheckPermissionState(state, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.PublisherIdentityPermission" /> указанным сертификатом Authenticode X.509v3.</summary>
		/// <param name="certificate">Сертификат X.509, представляющий удостоверение издателя программного обеспечения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="certificate" /> не является допустимым сертификатом.</exception>
		// Token: 0x06002CBB RID: 11451 RVA: 0x000A096D File Offset: 0x0009EB6D
		public PublisherIdentityPermission(X509Certificate certificate)
		{
			this.Certificate = certificate;
		}

		/// <summary>Получает или задает сертификат Authenticode X.509v3, представляющий удостоверение издателя программного обеспечения.</summary>
		/// <returns>Сертификат X.509, представляющий удостоверение издателя программного обеспечения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <see cref="P:System.Security.Permissions.PublisherIdentityPermission.Certificate" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <see cref="P:System.Security.Permissions.PublisherIdentityPermission.Certificate" /> не является допустимым сертификатом.</exception>
		/// <exception cref="T:System.NotSupportedException">Нельзя задать свойство, поскольку удостоверение неоднозначно.</exception>
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000A097C File Offset: 0x0009EB7C
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x000A0984 File Offset: 0x0009EB84
		public X509Certificate Certificate
		{
			get
			{
				return this.x509;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("X509Certificate");
				}
				this.x509 = value;
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002CBE RID: 11454 RVA: 0x000A099C File Offset: 0x0009EB9C
		public override IPermission Copy()
		{
			PublisherIdentityPermission publisherIdentityPermission = new PublisherIdentityPermission(PermissionState.None);
			if (this.x509 != null)
			{
				publisherIdentityPermission.Certificate = this.x509;
			}
			return publisherIdentityPermission;
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии параметра <paramref name="esd" />.</exception>
		// Token: 0x06002CBF RID: 11455 RVA: 0x000A09C8 File Offset: 0x0009EBC8
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			string text = esd.Attributes["X509v3Certificate"] as string;
			if (text != null)
			{
				byte[] data = CryptoConvert.FromHex(text);
				this.x509 = new X509Certificate(data);
			}
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002CC0 RID: 11456 RVA: 0x000A0A10 File Offset: 0x0009EC10
		public override IPermission Intersect(IPermission target)
		{
			PublisherIdentityPermission publisherIdentityPermission = this.Cast(target);
			if (publisherIdentityPermission == null)
			{
				return null;
			}
			if (this.x509 != null && publisherIdentityPermission.x509 != null && this.x509.GetRawCertDataString() == publisherIdentityPermission.x509.GetRawCertDataString())
			{
				return new PublisherIdentityPermission(publisherIdentityPermission.x509);
			}
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002CC1 RID: 11457 RVA: 0x000A0A64 File Offset: 0x0009EC64
		public override bool IsSubsetOf(IPermission target)
		{
			PublisherIdentityPermission publisherIdentityPermission = this.Cast(target);
			return publisherIdentityPermission != null && (this.x509 == null || (publisherIdentityPermission.x509 != null && this.x509.GetRawCertDataString() == publisherIdentityPermission.x509.GetRawCertDataString()));
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002CC2 RID: 11458 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this.x509 != null)
			{
				securityElement.AddAttribute("X509v3Certificate", this.x509.GetRawCertDataString());
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Два разрешения не равны друг другу.</exception>
		// Token: 0x06002CC3 RID: 11459 RVA: 0x000A0AE4 File Offset: 0x0009ECE4
		public override IPermission Union(IPermission target)
		{
			PublisherIdentityPermission publisherIdentityPermission = this.Cast(target);
			if (publisherIdentityPermission == null)
			{
				return this.Copy();
			}
			if (this.x509 != null && publisherIdentityPermission.x509 != null)
			{
				if (this.x509.GetRawCertDataString() == publisherIdentityPermission.x509.GetRawCertDataString())
				{
					return new PublisherIdentityPermission(this.x509);
				}
			}
			else
			{
				if (this.x509 == null && publisherIdentityPermission.x509 != null)
				{
					return new PublisherIdentityPermission(publisherIdentityPermission.x509);
				}
				if (this.x509 != null && publisherIdentityPermission.x509 == null)
				{
					return new PublisherIdentityPermission(this.x509);
				}
			}
			return null;
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000481C2 File Offset: 0x000463C2
		int IBuiltInPermission.GetTokenIndex()
		{
			return 10;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000A0B75 File Offset: 0x0009ED75
		private PublisherIdentityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			PublisherIdentityPermission publisherIdentityPermission = target as PublisherIdentityPermission;
			if (publisherIdentityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(PublisherIdentityPermission));
			}
			return publisherIdentityPermission;
		}

		// Token: 0x04002074 RID: 8308
		private const int version = 1;

		// Token: 0x04002075 RID: 8309
		private X509Certificate x509;
	}
}
