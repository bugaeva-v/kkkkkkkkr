using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Mono.Security;

namespace System.Security.Policy
{
	/// <summary>Предоставляет веб-сайт, являющийся источником сборки кода, используемой в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x0200041E RID: 1054
	[ComVisible(true)]
	[Serializable]
	public sealed class Site : EvidenceBase, IIdentityPermissionFactory, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Site" /> с веб-сайтом, являющимся источником сборки кода.</summary>
		/// <param name="name">Веб-сайт, являющийся источником для связанной сборки кода.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B19 RID: 11033 RVA: 0x0009C20C File Offset: 0x0009A40C
		public Site(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("url");
			}
			if (!Site.IsValid(name))
			{
				throw new ArgumentException(Locale.GetText("name is not valid"));
			}
			this.origin_site = name;
		}

		/// <summary>Создает новый объект <see cref="T:System.Security.Policy.Site" /> из указанного URL-адреса.</summary>
		/// <param name="url">Универсальный код ресурса (URI), на основании которого создается новый объект <see cref="T:System.Security.Policy.Site" />.</param>
		/// <returns>Новый объект сайта.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="url" /> является недопустимым URL-адресом.  
		///
		/// или - 
		/// Параметр <paramref name="url" /> является именем файла.</exception>
		// Token: 0x06002B1A RID: 11034 RVA: 0x0009C244 File Offset: 0x0009A444
		public static Site CreateFromUrl(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (url.Length == 0)
			{
				throw new FormatException(Locale.GetText("Empty URL."));
			}
			string text = Site.UrlToSite(url);
			if (text == null)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid URL '{0}'."), url), "url");
			}
			return new Site(text);
		}

		/// <summary>Создает эквивалентную копию объекта <see cref="T:System.Security.Policy.Site" />.</summary>
		/// <returns>Новый объект, идентичный текущему объекту <see cref="T:System.Security.Policy.Site" />.</returns>
		// Token: 0x06002B1B RID: 11035 RVA: 0x0009C2A0 File Offset: 0x0009A4A0
		public object Copy()
		{
			return new Site(this.origin_site);
		}

		/// <summary>Создает разрешение идентификации, соответствующее текущему объекту <see cref="T:System.Security.Policy.Site" />.</summary>
		/// <param name="evidence">Свидетельство, из которого создается разрешение идентификации.</param>
		/// <returns>Разрешение идентификаторов сайта для текущего объекта <see cref="T:System.Security.Policy.Site" />.</returns>
		// Token: 0x06002B1C RID: 11036 RVA: 0x0009C2AD File Offset: 0x0009A4AD
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return new SiteIdentityPermission(this.origin_site);
		}

		/// <summary>Сравнивает на предмет равенства указанный объект и текущий объект <see cref="T:System.Security.Policy.Site" />.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если два экземпляра класса <see cref="T:System.Security.Policy.Site" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002B1D RID: 11037 RVA: 0x0009C2BC File Offset: 0x0009A4BC
		public override bool Equals(object o)
		{
			Site site = o as Site;
			return site != null && string.Compare(site.Name, this.origin_site, true, CultureInfo.InvariantCulture) == 0;
		}

		/// <summary>Возвращает хэш-код текущего имени веб-сайта.</summary>
		/// <returns>Хэш-код текущего имени веб-сайта.</returns>
		// Token: 0x06002B1E RID: 11038 RVA: 0x0009C2EF File Offset: 0x0009A4EF
		public override int GetHashCode()
		{
			return this.origin_site.GetHashCode();
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Policy.Site" />.</summary>
		/// <returns>Представление текущего сайта.</returns>
		// Token: 0x06002B1F RID: 11039 RVA: 0x0009C2FC File Offset: 0x0009A4FC
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement("System.Security.Policy.Site");
			securityElement.AddAttribute("version", "1");
			securityElement.AddChild(new SecurityElement("Name", this.origin_site));
			return securityElement.ToString();
		}

		/// <summary>Получает веб-сайт, являющийся источником сборки кода.</summary>
		/// <returns>Имя веб-сайта, являющегося источником сборки кода.</returns>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x0009C333 File Offset: 0x0009A533
		public string Name
		{
			get
			{
				return this.origin_site;
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0009C33B File Offset: 0x0009A53B
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return (verbose ? 3 : 1) + this.origin_site.Length;
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0009C350 File Offset: 0x0009A550
		internal static bool IsValid(string name)
		{
			if (name == string.Empty)
			{
				return false;
			}
			if (name.Length == 1 && name == ".")
			{
				return false;
			}
			string[] array = name.Split('.', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (i != 0 || !(text == "*"))
				{
					string text2 = text;
					for (int j = 0; j < text2.Length; j++)
					{
						int num = Convert.ToInt32(text2[j]);
						if (num != 33 && num != 45 && (num < 35 || num > 41) && (num < 48 || num > 57) && (num < 64 || num > 90) && (num < 94 || num > 95) && (num < 97 || num > 123) && (num < 125 || num > 126))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x0009C444 File Offset: 0x0009A644
		internal static string UrlToSite(string url)
		{
			if (url == null)
			{
				return null;
			}
			Uri uri = new Uri(url);
			if (uri.Scheme == Uri.UriSchemeFile)
			{
				return null;
			}
			string host = uri.Host;
			if (!Site.IsValid(host))
			{
				return null;
			}
			return host;
		}

		// Token: 0x04001FB2 RID: 8114
		internal string origin_site;
	}
}
