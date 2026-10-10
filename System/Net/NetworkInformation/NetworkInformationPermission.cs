using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.NetworkInformation
{
	/// <summary>Управляет доступом к сведениям о сети и статистике трафика для локального компьютера. Этот класс не наследуется.</summary>
	// Token: 0x020006F7 RID: 1783
	[Serializable]
	public sealed class NetworkInformationPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x0600394C RID: 14668 RVA: 0x000C83CA File Offset: 0x000C65CA
		public NetworkInformationPermission(PermissionState state)
		{
			if (state == PermissionState.Unrestricted)
			{
				this.access = (NetworkInformationAccess.Read | NetworkInformationAccess.Ping);
				this.unrestricted = true;
				return;
			}
			this.access = NetworkInformationAccess.None;
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x000C83EC File Offset: 0x000C65EC
		internal NetworkInformationPermission(bool unrestricted)
		{
			if (unrestricted)
			{
				this.access = (NetworkInformationAccess.Read | NetworkInformationAccess.Ping);
				unrestricted = true;
				return;
			}
			this.access = NetworkInformationAccess.None;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />, используя указанное значение <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" />.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" />.</param>
		// Token: 0x0600394E RID: 14670 RVA: 0x000C8409 File Offset: 0x000C6609
		public NetworkInformationPermission(NetworkInformationAccess access)
		{
			this.access = access;
		}

		/// <summary>Возвращает уровень доступа к сведениям о сети, которым управляет данное разрешение.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" />.</returns>
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x000C8418 File Offset: 0x000C6618
		public NetworkInformationAccess Access
		{
			get
			{
				return this.access;
			}
		}

		/// <summary>Добавляет указанное значение в данное разрешение.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" />.</param>
		// Token: 0x06003950 RID: 14672 RVA: 0x000C8420 File Offset: 0x000C6620
		public void AddPermission(NetworkInformationAccess access)
		{
			this.access |= access;
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003951 RID: 14673 RVA: 0x000C8430 File Offset: 0x000C6630
		public bool IsUnrestricted()
		{
			return this.unrestricted;
		}

		/// <summary>Создает и возвращает точную копию данного разрешения.</summary>
		/// <returns>Объект разрешений <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />, идентичный текущему разрешению.</returns>
		// Token: 0x06003952 RID: 14674 RVA: 0x000C8438 File Offset: 0x000C6638
		public override IPermission Copy()
		{
			if (this.unrestricted)
			{
				return new NetworkInformationPermission(true);
			}
			return new NetworkInformationPermission(this.access);
		}

		/// <summary>Создает разрешение, представляющее собой объединение данного и заданного разрешений.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />, объединяемое с текущим разрешением.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		// Token: 0x06003953 RID: 14675 RVA: 0x000C8454 File Offset: 0x000C6654
		public override IPermission Union(IPermission target)
		{
			if (target == null)
			{
				return this.Copy();
			}
			NetworkInformationPermission networkInformationPermission = target as NetworkInformationPermission;
			if (networkInformationPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			if (this.unrestricted || networkInformationPermission.IsUnrestricted())
			{
				return new NetworkInformationPermission(true);
			}
			return new NetworkInformationPermission(this.access | networkInformationPermission.access);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />, представляющий собой пересечение текущего и заданного разрешений. Если пересечение пусто или параметр <paramref name="target" /> имеет значение <see langword="null" />, новое разрешение будет иметь значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не является объектом <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />.</exception>
		// Token: 0x06003954 RID: 14676 RVA: 0x000C84B4 File Offset: 0x000C66B4
		public override IPermission Intersect(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			NetworkInformationPermission networkInformationPermission = target as NetworkInformationPermission;
			if (networkInformationPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			if (this.unrestricted && networkInformationPermission.IsUnrestricted())
			{
				return new NetworkInformationPermission(true);
			}
			return new NetworkInformationPermission(this.access & networkInformationPermission.access);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, для которого требуется проверить соотношение подмножеств. Данное разрешение должно иметь тот же тип, что и текущее разрешение.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003955 RID: 14677 RVA: 0x000C8510 File Offset: 0x000C6710
		public override bool IsSubsetOf(IPermission target)
		{
			if (target == null)
			{
				return this.access == NetworkInformationAccess.None;
			}
			NetworkInformationPermission networkInformationPermission = target as NetworkInformationPermission;
			if (networkInformationPermission == null)
			{
				throw new ArgumentException(SR.GetString("Cannot cast target permission type."), "target");
			}
			return (!this.unrestricted || networkInformationPermission.IsUnrestricted()) && (this.access & networkInformationPermission.access) == this.access;
		}

		/// <summary>Задает состояние разрешения, используя указанное XML-кодирование.</summary>
		/// <param name="securityElement">Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование, используемое для задания состояния текущего разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="securityElement" /> не является кодировкой разрешения.  
		/// -или- 
		///  Параметр <paramref name="securityElement" /> не является кодировкой разрешения <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />.  
		/// -или- 
		///  Недопустимые значения <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> в параметре <paramref name="securityElement" />.</exception>
		// Token: 0x06003956 RID: 14678 RVA: 0x000C8574 File Offset: 0x000C6774
		public override void FromXml(SecurityElement securityElement)
		{
			this.access = NetworkInformationAccess.None;
			if (securityElement == null)
			{
				throw new ArgumentNullException("securityElement");
			}
			if (!securityElement.Tag.Equals("IPermission"))
			{
				throw new ArgumentException(SR.GetString("Specified value does not contain 'IPermission' as its tag."), "securityElement");
			}
			string text = securityElement.Attribute("class");
			if (text == null)
			{
				throw new ArgumentException(SR.GetString("Specified value does not contain a 'class' attribute."), "securityElement");
			}
			if (text.IndexOf(base.GetType().FullName) < 0)
			{
				throw new ArgumentException(SR.GetString("The value class attribute is not valid."), "securityElement");
			}
			string text2 = securityElement.Attribute("Unrestricted");
			if (text2 != null && string.Compare(text2, "true", StringComparison.OrdinalIgnoreCase) == 0)
			{
				this.access = (NetworkInformationAccess.Read | NetworkInformationAccess.Ping);
				this.unrestricted = true;
				return;
			}
			if (securityElement.Children != null)
			{
				foreach (object obj in securityElement.Children)
				{
					text2 = ((SecurityElement)obj).Attribute("Access");
					if (string.Compare(text2, "Read", StringComparison.OrdinalIgnoreCase) == 0)
					{
						this.access |= NetworkInformationAccess.Read;
					}
					else if (string.Compare(text2, "Ping", StringComparison.OrdinalIgnoreCase) == 0)
					{
						this.access |= NetworkInformationAccess.Ping;
					}
				}
			}
		}

		/// <summary>Создает XML-кодирование состояния данного разрешения.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование текущего разрешения.</returns>
		// Token: 0x06003957 RID: 14679 RVA: 0x000C86C8 File Offset: 0x000C68C8
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = new SecurityElement("IPermission");
			securityElement.AddAttribute("class", base.GetType().FullName + ", " + base.GetType().Module.Assembly.FullName.Replace('"', '\''));
			securityElement.AddAttribute("version", "1");
			if (this.unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
				return securityElement;
			}
			if ((this.access & NetworkInformationAccess.Read) > NetworkInformationAccess.None)
			{
				SecurityElement securityElement2 = new SecurityElement("NetworkInformationAccess");
				securityElement2.AddAttribute("Access", "Read");
				securityElement.AddChild(securityElement2);
			}
			if ((this.access & NetworkInformationAccess.Ping) > NetworkInformationAccess.None)
			{
				SecurityElement securityElement3 = new SecurityElement("NetworkInformationAccess");
				securityElement3.AddAttribute("Access", "Ping");
				securityElement.AddChild(securityElement3);
			}
			return securityElement;
		}

		// Token: 0x04002197 RID: 8599
		private NetworkInformationAccess access;

		// Token: 0x04002198 RID: 8600
		private bool unrestricted;
	}
}
