using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Определяет разрешение удостоверения для строгих имен. Этот класс не наследуется.</summary>
	// Token: 0x0200045C RID: 1116
	[ComVisible(true)]
	[Serializable]
	public sealed class StrongNameIdentityPermission : CodeAccessPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002D55 RID: 11605 RVA: 0x000A24E6 File Offset: 0x000A06E6
		public StrongNameIdentityPermission(PermissionState state)
		{
			this._state = CodeAccessPermission.CheckPermissionState(state, true);
			this._list = new ArrayList();
			this._list.Add(StrongNameIdentityPermission.SNIP.CreateDefault());
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> для указанного удостоверения строгого имени.</summary>
		/// <param name="blob">Открытый ключ, определяющий пространство имен удостоверений строгих имен.</param>
		/// <param name="name">Часть простого имени удостоверения строгого имени. Это соответствует имени сборки.</param>
		/// <param name="version">Номер версии удостоверения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="blob" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="name" /> представляет собой пустую строку ("").</exception>
		// Token: 0x06002D56 RID: 11606 RVA: 0x000A251C File Offset: 0x000A071C
		public StrongNameIdentityPermission(StrongNamePublicKeyBlob blob, string name, Version version)
		{
			if (blob == null)
			{
				throw new ArgumentNullException("blob");
			}
			if (name != null && name.Length == 0)
			{
				throw new ArgumentException("name");
			}
			this._state = PermissionState.None;
			this._list = new ArrayList();
			this._list.Add(new StrongNameIdentityPermission.SNIP(blob, name, version));
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000A2580 File Offset: 0x000A0780
		internal StrongNameIdentityPermission(StrongNameIdentityPermission snip)
		{
			this._state = snip._state;
			this._list = new ArrayList(snip._list.Count);
			foreach (object obj in snip._list)
			{
				StrongNameIdentityPermission.SNIP snip2 = (StrongNameIdentityPermission.SNIP)obj;
				this._list.Add(new StrongNameIdentityPermission.SNIP(snip2.PublicKey, snip2.Name, snip2.AssemblyVersion));
			}
		}

		/// <summary>Возвращает или задает часть простого имени идентификатора строгого имени.</summary>
		/// <returns>Простое имя идентификатора.</returns>
		/// <exception cref="T:System.ArgumentException">Значением является пустая строка ("").</exception>
		/// <exception cref="T:System.NotSupportedException">Не удалось получить значение свойства, поскольку содержащееся в нем удостоверение неоднозначно.</exception>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000A2624 File Offset: 0x000A0824
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000A2650 File Offset: 0x000A0850
		public string Name
		{
			get
			{
				if (this._list.Count > 1)
				{
					throw new NotSupportedException();
				}
				return ((StrongNameIdentityPermission.SNIP)this._list[0]).Name;
			}
			set
			{
				if (value != null && value.Length == 0)
				{
					throw new ArgumentException("name");
				}
				if (this._list.Count > 1)
				{
					this.ResetToDefault();
				}
				StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)this._list[0];
				snip.Name = value;
				this._list[0] = snip;
			}
		}

		/// <summary>Возвращает или задает большой двоичный объект открытого ключа, который определяет пространство имен удостоверений строгих имен.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.StrongNamePublicKeyBlob" />, содержащий открытый ключ удостоверения, или <see langword="null" />, если ключ отсутствует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойству задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Не удалось получить значение свойства, поскольку содержащееся в нем удостоверение неоднозначно.</exception>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000A26B3 File Offset: 0x000A08B3
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x000A26E0 File Offset: 0x000A08E0
		public StrongNamePublicKeyBlob PublicKey
		{
			get
			{
				if (this._list.Count > 1)
				{
					throw new NotSupportedException();
				}
				return ((StrongNameIdentityPermission.SNIP)this._list[0]).PublicKey;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (this._list.Count > 1)
				{
					this.ResetToDefault();
				}
				StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)this._list[0];
				snip.PublicKey = value;
				this._list[0] = snip;
			}
		}

		/// <summary>Возвращает или задает номер версии удостоверения.</summary>
		/// <returns>Версия удостоверения.</returns>
		/// <exception cref="T:System.NotSupportedException">Не удалось получить значение свойства, поскольку удостоверение неоднозначно.</exception>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000A273B File Offset: 0x000A093B
		// (set) Token: 0x06002D5D RID: 11613 RVA: 0x000A2768 File Offset: 0x000A0968
		public Version Version
		{
			get
			{
				if (this._list.Count > 1)
				{
					throw new NotSupportedException();
				}
				return ((StrongNameIdentityPermission.SNIP)this._list[0]).AssemblyVersion;
			}
			set
			{
				if (this._list.Count > 1)
				{
					this.ResetToDefault();
				}
				StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)this._list[0];
				snip.AssemblyVersion = value;
				this._list[0] = snip;
			}
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000A27B5 File Offset: 0x000A09B5
		internal void ResetToDefault()
		{
			this._list.Clear();
			this._list.Add(StrongNameIdentityPermission.SNIP.CreateDefault());
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002D5F RID: 11615 RVA: 0x000A27D8 File Offset: 0x000A09D8
		public override IPermission Copy()
		{
			if (this.IsEmpty())
			{
				return new StrongNameIdentityPermission(PermissionState.None);
			}
			return new StrongNameIdentityPermission(this);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии параметра <paramref name="e" />.</exception>
		// Token: 0x06002D60 RID: 11616 RVA: 0x000A27F0 File Offset: 0x000A09F0
		public override void FromXml(SecurityElement e)
		{
			CodeAccessPermission.CheckSecurityElement(e, "e", 1, 1);
			this._list.Clear();
			if (e.Children != null && e.Children.Count > 0)
			{
				using (IEnumerator enumerator = e.Children.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						SecurityElement se = (SecurityElement)obj;
						this._list.Add(this.FromSecurityElement(se));
					}
					return;
				}
			}
			this._list.Add(this.FromSecurityElement(e));
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000A28A4 File Offset: 0x000A0AA4
		private StrongNameIdentityPermission.SNIP FromSecurityElement(SecurityElement se)
		{
			string name = se.Attribute("Name");
			StrongNamePublicKeyBlob pk = StrongNamePublicKeyBlob.FromString(se.Attribute("PublicKeyBlob"));
			string text = se.Attribute("AssemblyVersion");
			Version version = (text == null) ? null : new Version(text);
			return new StrongNameIdentityPermission.SNIP(pk, name, version);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего разрешения и указанного разрешения, или <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D62 RID: 11618 RVA: 0x000A28F0 File Offset: 0x000A0AF0
		public override IPermission Intersect(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			StrongNameIdentityPermission strongNameIdentityPermission = target as StrongNameIdentityPermission;
			if (strongNameIdentityPermission == null)
			{
				throw new ArgumentException(Locale.GetText("Wrong permission type."));
			}
			if (this.IsEmpty() || strongNameIdentityPermission.IsEmpty())
			{
				return null;
			}
			if (!this.Match(strongNameIdentityPermission.Name))
			{
				return null;
			}
			string name = (this.Name.Length < strongNameIdentityPermission.Name.Length) ? this.Name : strongNameIdentityPermission.Name;
			if (!this.Version.Equals(strongNameIdentityPermission.Version))
			{
				return null;
			}
			if (!this.PublicKey.Equals(strongNameIdentityPermission.PublicKey))
			{
				return null;
			}
			return new StrongNameIdentityPermission(this.PublicKey, name, this.Version);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D63 RID: 11619 RVA: 0x000A29A4 File Offset: 0x000A0BA4
		public override bool IsSubsetOf(IPermission target)
		{
			StrongNameIdentityPermission strongNameIdentityPermission = this.Cast(target);
			if (strongNameIdentityPermission == null)
			{
				return this.IsEmpty();
			}
			if (this.IsEmpty())
			{
				return true;
			}
			if (this.IsUnrestricted())
			{
				return strongNameIdentityPermission.IsUnrestricted();
			}
			if (strongNameIdentityPermission.IsUnrestricted())
			{
				return true;
			}
			foreach (object obj in this._list)
			{
				StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)obj;
				foreach (object obj2 in strongNameIdentityPermission._list)
				{
					StrongNameIdentityPermission.SNIP target2 = (StrongNameIdentityPermission.SNIP)obj2;
					if (!snip.IsSubsetOf(target2))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002D64 RID: 11620 RVA: 0x000A2A88 File Offset: 0x000A0C88
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this._list.Count > 1)
			{
				using (IEnumerator enumerator = this._list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)obj;
						SecurityElement securityElement2 = new SecurityElement("StrongName");
						this.ToSecurityElement(securityElement2, snip);
						securityElement.AddChild(securityElement2);
					}
					return securityElement;
				}
			}
			if (this._list.Count == 1)
			{
				StrongNameIdentityPermission.SNIP snip2 = (StrongNameIdentityPermission.SNIP)this._list[0];
				if (!this.IsEmpty(snip2))
				{
					this.ToSecurityElement(securityElement, snip2);
				}
			}
			return securityElement;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000A2B44 File Offset: 0x000A0D44
		private void ToSecurityElement(SecurityElement se, StrongNameIdentityPermission.SNIP snip)
		{
			if (snip.PublicKey != null)
			{
				se.AddAttribute("PublicKeyBlob", snip.PublicKey.ToString());
			}
			if (snip.Name != null)
			{
				se.AddAttribute("Name", snip.Name);
			}
			if (snip.AssemblyVersion != null)
			{
				se.AddAttribute("AssemblyVersion", snip.AssemblyVersion.ToString());
			}
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Разрешения не равны, и одно является подмножеством другого.</exception>
		// Token: 0x06002D66 RID: 11622 RVA: 0x000A2BAC File Offset: 0x000A0DAC
		public override IPermission Union(IPermission target)
		{
			StrongNameIdentityPermission strongNameIdentityPermission = this.Cast(target);
			if (strongNameIdentityPermission == null || strongNameIdentityPermission.IsEmpty())
			{
				return this.Copy();
			}
			if (this.IsEmpty())
			{
				return strongNameIdentityPermission.Copy();
			}
			StrongNameIdentityPermission strongNameIdentityPermission2 = (StrongNameIdentityPermission)this.Copy();
			foreach (object obj in strongNameIdentityPermission._list)
			{
				StrongNameIdentityPermission.SNIP snip = (StrongNameIdentityPermission.SNIP)obj;
				if (!this.IsEmpty(snip) && !this.Contains(snip))
				{
					strongNameIdentityPermission2._list.Add(snip);
				}
			}
			return strongNameIdentityPermission2;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00048419 File Offset: 0x00046619
		int IBuiltInPermission.GetTokenIndex()
		{
			return 12;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000A2C5C File Offset: 0x000A0E5C
		private bool IsUnrestricted()
		{
			return this._state == PermissionState.Unrestricted;
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000A2C68 File Offset: 0x000A0E68
		private bool Contains(StrongNameIdentityPermission.SNIP snip)
		{
			foreach (object obj in this._list)
			{
				StrongNameIdentityPermission.SNIP snip2 = (StrongNameIdentityPermission.SNIP)obj;
				bool flag = (snip2.PublicKey == null && snip.PublicKey == null) || (snip2.PublicKey != null && snip2.PublicKey.Equals(snip.PublicKey));
				bool flag2 = snip2.IsNameSubsetOf(snip.Name);
				bool flag3 = (snip2.AssemblyVersion == null && snip.AssemblyVersion == null) || (snip2.AssemblyVersion != null && snip2.AssemblyVersion.Equals(snip.AssemblyVersion));
				if (flag && flag2 && flag3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000A2D54 File Offset: 0x000A0F54
		private bool IsEmpty(StrongNameIdentityPermission.SNIP snip)
		{
			return this.PublicKey == null && (this.Name == null || this.Name.Length <= 0) && (this.Version == null || StrongNameIdentityPermission.defaultVersion.Equals(this.Version));
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000A2DA4 File Offset: 0x000A0FA4
		private bool IsEmpty()
		{
			return !this.IsUnrestricted() && this._list.Count <= 1 && this.PublicKey == null && (this.Name == null || this.Name.Length <= 0) && (this.Version == null || StrongNameIdentityPermission.defaultVersion.Equals(this.Version));
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000A2E0B File Offset: 0x000A100B
		private StrongNameIdentityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			StrongNameIdentityPermission strongNameIdentityPermission = target as StrongNameIdentityPermission;
			if (strongNameIdentityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(StrongNameIdentityPermission));
			}
			return strongNameIdentityPermission;
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000A2E2C File Offset: 0x000A102C
		private bool Match(string target)
		{
			if (this.Name == null || target == null)
			{
				return false;
			}
			int num = this.Name.LastIndexOf('*');
			int num2 = target.LastIndexOf('*');
			int length;
			if (num == -1 && num2 == -1)
			{
				length = Math.Max(this.Name.Length, target.Length);
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
			return string.Compare(this.Name, 0, target, 0, length, true, CultureInfo.InvariantCulture) == 0;
		}

		// Token: 0x040020AD RID: 8365
		private const int version = 1;

		// Token: 0x040020AE RID: 8366
		private static Version defaultVersion = new Version(0, 0);

		// Token: 0x040020AF RID: 8367
		private PermissionState _state;

		// Token: 0x040020B0 RID: 8368
		private ArrayList _list;

		// Token: 0x0200045D RID: 1117
		private struct SNIP
		{
			// Token: 0x06002D6F RID: 11631 RVA: 0x000A2EC2 File Offset: 0x000A10C2
			internal SNIP(StrongNamePublicKeyBlob pk, string name, Version version)
			{
				this.PublicKey = pk;
				this.Name = name;
				this.AssemblyVersion = version;
			}

			// Token: 0x06002D70 RID: 11632 RVA: 0x000A2ED9 File Offset: 0x000A10D9
			internal static StrongNameIdentityPermission.SNIP CreateDefault()
			{
				return new StrongNameIdentityPermission.SNIP(null, string.Empty, (Version)StrongNameIdentityPermission.defaultVersion.Clone());
			}

			// Token: 0x06002D71 RID: 11633 RVA: 0x000A2EF8 File Offset: 0x000A10F8
			internal bool IsNameSubsetOf(string target)
			{
				if (this.Name == null)
				{
					return target == null;
				}
				if (target == null)
				{
					return true;
				}
				int num = this.Name.LastIndexOf('*');
				if (num == 0)
				{
					return true;
				}
				if (num == -1)
				{
					num = this.Name.Length;
				}
				return string.Compare(this.Name, 0, target, 0, num, true, CultureInfo.InvariantCulture) == 0;
			}

			// Token: 0x06002D72 RID: 11634 RVA: 0x000A2F54 File Offset: 0x000A1154
			internal bool IsSubsetOf(StrongNameIdentityPermission.SNIP target)
			{
				return (this.PublicKey != null && this.PublicKey.Equals(target.PublicKey)) || (this.IsNameSubsetOf(target.Name) && (!(this.AssemblyVersion != null) || this.AssemblyVersion.Equals(target.AssemblyVersion)) && this.PublicKey == null && target.PublicKey == null);
			}

			// Token: 0x040020B1 RID: 8369
			public StrongNamePublicKeyBlob PublicKey;

			// Token: 0x040020B2 RID: 8370
			public string Name;

			// Token: 0x040020B3 RID: 8371
			public Version AssemblyVersion;
		}
	}
}
