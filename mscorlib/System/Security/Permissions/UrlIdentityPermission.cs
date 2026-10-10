using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Определяет разрешение удостоверения для URL-адреса, являющегося источником кода. Этот класс не наследуется.</summary>
	// Token: 0x02000462 RID: 1122
	[ComVisible(true)]
	[Serializable]
	public sealed class UrlIdentityPermission : CodeAccessPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002D99 RID: 11673 RVA: 0x000A35E7 File Offset: 0x000A17E7
		public UrlIdentityPermission(PermissionState state)
		{
			CodeAccessPermission.CheckPermissionState(state, false);
			this.url = string.Empty;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> для представления идентификатора URL-адреса, который описывается параметром <paramref name="site" />.</summary>
		/// <param name="site">URL-адрес или выражение с подстановочными знаками.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="site" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина параметра <paramref name="site" /> равна нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Одна из составляющих параметра <paramref name="site" /> (URL-адрес, каталог или веб-узел) имеет недопустимое значение.</exception>
		// Token: 0x06002D9A RID: 11674 RVA: 0x000A3602 File Offset: 0x000A1802
		public UrlIdentityPermission(string site)
		{
			if (site == null)
			{
				throw new ArgumentNullException("site");
			}
			this.url = site;
		}

		/// <summary>Возвращает или задает URL-адрес, представляющий удостоверение интернет-кода.</summary>
		/// <returns>URL-адрес, представляющий удостоверение интернет-кода.</returns>
		/// <exception cref="T:System.NotSupportedException">URL-адрес получить не удалось, поскольку удостоверение неоднозначно.</exception>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000A361F File Offset: 0x000A181F
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000A3627 File Offset: 0x000A1827
		public string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				this.url = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002D9D RID: 11677 RVA: 0x000A363A File Offset: 0x000A183A
		public override IPermission Copy()
		{
			if (this.url == null)
			{
				return new UrlIdentityPermission(PermissionState.None);
			}
			return new UrlIdentityPermission(this.url);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии параметра <paramref name="esd" />.</exception>
		// Token: 0x06002D9E RID: 11678 RVA: 0x000A3658 File Offset: 0x000A1858
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			string text = esd.Attribute("Url");
			if (text == null)
			{
				this.url = string.Empty;
				return;
			}
			this.Url = text;
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Свойство URL-адреса не является допустимым URL-адресом.</exception>
		// Token: 0x06002D9F RID: 11679 RVA: 0x000A3698 File Offset: 0x000A1898
		public override IPermission Intersect(IPermission target)
		{
			UrlIdentityPermission urlIdentityPermission = this.Cast(target);
			if (urlIdentityPermission == null || this.IsEmpty())
			{
				return null;
			}
			if (!this.Match(urlIdentityPermission.url))
			{
				return null;
			}
			if (this.url.Length > urlIdentityPermission.url.Length)
			{
				return this.Copy();
			}
			return urlIdentityPermission.Copy();
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Свойство URL-адреса не является допустимым URL-адресом.</exception>
		// Token: 0x06002DA0 RID: 11680 RVA: 0x000A36F0 File Offset: 0x000A18F0
		public override bool IsSubsetOf(IPermission target)
		{
			UrlIdentityPermission urlIdentityPermission = this.Cast(target);
			if (urlIdentityPermission == null)
			{
				return this.IsEmpty();
			}
			if (this.IsEmpty())
			{
				return true;
			}
			if (urlIdentityPermission.url == null)
			{
				return false;
			}
			int num = urlIdentityPermission.url.LastIndexOf('*');
			if (num == -1)
			{
				num = urlIdentityPermission.url.Length;
			}
			return string.Compare(this.url, 0, urlIdentityPermission.url, 0, num, true, CultureInfo.InvariantCulture) == 0;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002DA1 RID: 11681 RVA: 0x000A3760 File Offset: 0x000A1960
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (!this.IsEmpty())
			{
				securityElement.AddAttribute("Url", this.url);
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Свойство <see cref="P:System.Security.Permissions.UrlIdentityPermission.Url" /> не является допустимым URL-адресом.  
		///
		/// или - 
		/// Два разрешения не равны, и одно не является подмножеством другого.</exception>
		/// <exception cref="T:System.NotSupportedException">Операция является неоднозначной, так как разрешение представляет несколько идентификаторов.</exception>
		// Token: 0x06002DA2 RID: 11682 RVA: 0x000A3790 File Offset: 0x000A1990
		public override IPermission Union(IPermission target)
		{
			UrlIdentityPermission urlIdentityPermission = this.Cast(target);
			if (urlIdentityPermission == null)
			{
				return this.Copy();
			}
			if (this.IsEmpty() && urlIdentityPermission.IsEmpty())
			{
				return null;
			}
			if (urlIdentityPermission.IsEmpty())
			{
				return this.Copy();
			}
			if (this.IsEmpty())
			{
				return urlIdentityPermission.Copy();
			}
			if (!this.Match(urlIdentityPermission.url))
			{
				throw new ArgumentException(Locale.GetText("Cannot union two different urls."), "target");
			}
			if (this.url.Length < urlIdentityPermission.url.Length)
			{
				return this.Copy();
			}
			return urlIdentityPermission.Copy();
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0003D1E6 File Offset: 0x0003B3E6
		int IBuiltInPermission.GetTokenIndex()
		{
			return 13;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000A3827 File Offset: 0x000A1A27
		private bool IsEmpty()
		{
			return this.url == null || this.url.Length == 0;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000A3841 File Offset: 0x000A1A41
		private UrlIdentityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			UrlIdentityPermission urlIdentityPermission = target as UrlIdentityPermission;
			if (urlIdentityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(UrlIdentityPermission));
			}
			return urlIdentityPermission;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000A3864 File Offset: 0x000A1A64
		private bool Match(string target)
		{
			if (this.url == null || target == null)
			{
				return false;
			}
			int num = this.url.LastIndexOf('*');
			int num2 = target.LastIndexOf('*');
			int length;
			if (num == -1 && num2 == -1)
			{
				length = Math.Max(this.url.Length, target.Length);
			}
			else if (num == -1)
			{
				length = num2;
			}
			else if (num2 == -1)
			{
				length = num;
			}
			else
			{
				length = Math.Min(num, num2);
			}
			return string.Compare(this.url, 0, target, 0, length, true, CultureInfo.InvariantCulture) == 0;
		}

		// Token: 0x040020BD RID: 8381
		private const int version = 1;

		// Token: 0x040020BE RID: 8382
		private string url;
	}
}
