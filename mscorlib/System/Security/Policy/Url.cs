using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Mono.Security;

namespace System.Security.Policy
{
	/// <summary>Предоставляет URL-адрес, являющийся источником сборки кода, используемой в качестве свидетельства для оценки политики. Этот класс не наследуется.</summary>
	// Token: 0x02000425 RID: 1061
	[ComVisible(true)]
	[Serializable]
	public sealed class Url : EvidenceBase, IIdentityPermissionFactory, IBuiltInEvidence
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Url" /> с URL-адресом, являющимся источником сборки кода.</summary>
		/// <param name="name">URL-адрес, являющийся источником сборки кода.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B66 RID: 11110 RVA: 0x0009CDD0 File Offset: 0x0009AFD0
		public Url(string name) : this(name, false)
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0009CDDA File Offset: 0x0009AFDA
		internal Url(string name, bool validated)
		{
			this.origin_url = (validated ? name : this.Prepare(name));
		}

		/// <summary>Создает новую копию объекта свидетельства.</summary>
		/// <returns>Новая, идентичная копия объекта свидетельства.</returns>
		// Token: 0x06002B68 RID: 11112 RVA: 0x0009CDF5 File Offset: 0x0009AFF5
		public object Copy()
		{
			return new Url(this.origin_url, true);
		}

		/// <summary>Создает разрешение идентификации, соответствующее текущему экземпляру свидетельства <see cref="T:System.Security.Policy.Url" />.</summary>
		/// <param name="evidence">Набор свидетельств, из которого создается разрешение идентификации.</param>
		/// <returns>Разрешение <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> для указанного свидетельства <see cref="T:System.Security.Policy.Url" />.</returns>
		// Token: 0x06002B69 RID: 11113 RVA: 0x0009CE03 File Offset: 0x0009B003
		public IPermission CreateIdentityPermission(Evidence evidence)
		{
			return new UrlIdentityPermission(this.origin_url);
		}

		/// <summary>Сравнивает указанный объект и текущий объект свидетельства<see cref="T:System.Security.Policy.Url" /> на предмет равенства.</summary>
		/// <param name="o">Объект свидетельства <see cref="T:System.Security.Policy.Url" />, который требуется проверить на эквивалентность текущему объекту.</param>
		/// <returns>Значение <see langword="true" />, если два объекта <see cref="T:System.Security.Policy.Url" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002B6A RID: 11114 RVA: 0x0009CE10 File Offset: 0x0009B010
		public override bool Equals(object o)
		{
			Url url = o as Url;
			if (url == null)
			{
				return false;
			}
			string text = url.Value;
			string text2 = this.origin_url;
			if (text.IndexOf(Uri.SchemeDelimiter) < 0)
			{
				text = "file://" + text;
			}
			if (text2.IndexOf(Uri.SchemeDelimiter) < 0)
			{
				text2 = "file://" + text2;
			}
			return string.Compare(text, text2, true, CultureInfo.InvariantCulture) == 0;
		}

		/// <summary>Получает хэш-код текущего URL-адреса.</summary>
		/// <returns>Хэш-код текущего URL-адреса.</returns>
		// Token: 0x06002B6B RID: 11115 RVA: 0x0009CE7C File Offset: 0x0009B07C
		public override int GetHashCode()
		{
			string text = this.origin_url;
			if (text.IndexOf(Uri.SchemeDelimiter) < 0)
			{
				text = "file://" + text;
			}
			return text.GetHashCode();
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Policy.Url" />.</summary>
		/// <returns>Представление текущего объекта <see cref="T:System.Security.Policy.Url" />.</returns>
		// Token: 0x06002B6C RID: 11116 RVA: 0x0009CEB0 File Offset: 0x0009B0B0
		public override string ToString()
		{
			SecurityElement securityElement = new SecurityElement("System.Security.Policy.Url");
			securityElement.AddAttribute("version", "1");
			securityElement.AddChild(new SecurityElement("Url", this.origin_url));
			return securityElement.ToString();
		}

		/// <summary>Получает URL-адрес, являющийся источником сборки кода.</summary>
		/// <returns>URL-адрес, являющийся источником сборки кода.</returns>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x0009CEE7 File Offset: 0x0009B0E7
		public string Value
		{
			get
			{
				return this.origin_url;
			}
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0009CEEF File Offset: 0x0009B0EF
		int IBuiltInEvidence.GetRequiredSize(bool verbose)
		{
			return (verbose ? 3 : 1) + this.origin_url.Length;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.InitFromBuffer(char[] buffer, int position)
		{
			return 0;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("IBuiltInEvidence")]
		int IBuiltInEvidence.OutputToBuffer(char[] buffer, int position, bool verbose)
		{
			return 0;
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0009CF04 File Offset: 0x0009B104
		private string Prepare(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("Url");
			}
			if (url == string.Empty)
			{
				throw new FormatException(Locale.GetText("Invalid (empty) Url"));
			}
			if (url.IndexOf(Uri.SchemeDelimiter) > 0)
			{
				if (url.StartsWith("file://"))
				{
					url = "file://" + url.Substring(7);
				}
				url = new Uri(url, false, false).ToString();
			}
			int num = url.Length - 1;
			if (url[num] == '/')
			{
				url = url.Substring(0, num);
			}
			return url;
		}

		// Token: 0x04001FC6 RID: 8134
		private string origin_url;
	}
}
