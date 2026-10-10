using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using Mono.Security;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки ее URL-адреса. Этот класс не наследуется.</summary>
	// Token: 0x02000426 RID: 1062
	[ComVisible(true)]
	[Serializable]
	public sealed class UrlMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IConstantMembershipCondition
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.UrlMembershipCondition" /> с URL-адресом, определяющим членство.</summary>
		/// <param name="url">URL-адрес, используемый при проверке.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="url" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="url" /> должен быть абсолютным URL-адресом.</exception>
		// Token: 0x06002B72 RID: 11122 RVA: 0x0009CF98 File Offset: 0x0009B198
		public UrlMembershipCondition(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.CheckUrl(url);
			this.userUrl = url;
			this.url = new Url(url);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0009CFCF File Offset: 0x0009B1CF
		internal UrlMembershipCondition(Url url, string userUrl)
		{
			this.url = (Url)url.Copy();
			this.userUrl = userUrl;
		}

		/// <summary>Возвращает или задает URL-адрес, который используется при проверке условия членства.</summary>
		/// <returns>URL-адрес, используемый при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение не является абсолютным URL-адресом.</exception>
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0009CFF6 File Offset: 0x0009B1F6
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x0009D017 File Offset: 0x0009B217
		public string Url
		{
			get
			{
				if (this.userUrl == null)
				{
					this.userUrl = this.url.Value;
				}
				return this.userUrl;
			}
			set
			{
				this.url = new Url(value);
			}
		}

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> — <see langword="null" />.</exception>
		// Token: 0x06002B76 RID: 11126 RVA: 0x0009D028 File Offset: 0x0009B228
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			string value = this.url.Value;
			int num = value.LastIndexOf("*");
			if (num == -1)
			{
				num = value.Length;
			}
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				if (hostEnumerator.Current is Url && string.Compare(value, 0, (hostEnumerator.Current as Url).Value, 0, num, true, CultureInfo.InvariantCulture) == 0)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> — <see langword="null" />.</exception>
		// Token: 0x06002B77 RID: 11127 RVA: 0x0009D09F File Offset: 0x0009B29F
		public IMembershipCondition Copy()
		{
			return new UrlMembershipCondition(this.url, this.userUrl);
		}

		/// <summary>Определяет, эквивалентен ли URL-адрес указанного объекта URL-адресу, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.UrlMembershipCondition" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Security.Policy.UrlMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если URL-адрес указанного объекта эквивалентен URL-адресу, содержащемуся в текущем объекте <see cref="T:System.Security.Policy.UrlMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> текущего объекта или указанный объект имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B78 RID: 11128 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
		public override bool Equals(object o)
		{
			UrlMembershipCondition urlMembershipCondition = o as UrlMembershipCondition;
			if (o == null)
			{
				return false;
			}
			string value = this.url.Value;
			int num = value.Length;
			if (value[num - 1] == '*')
			{
				num--;
				if (value[num - 1] == '/')
				{
					num--;
				}
			}
			return string.Compare(value, 0, urlMembershipCondition.Url, 0, num, true, CultureInfo.InvariantCulture) == 0;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B79 RID: 11129 RVA: 0x0009D11A File Offset: 0x0009B31A
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для разрешения ссылок на именованные наборы разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002B7A RID: 11130 RVA: 0x0009D124 File Offset: 0x0009B324
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
			string text = e.Attribute("Url");
			if (text != null)
			{
				this.CheckUrl(text);
				this.url = new Url(text);
			}
			else
			{
				this.url = null;
			}
			this.userUrl = text;
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> — <see langword="null" />.</exception>
		// Token: 0x06002B7B RID: 11131 RVA: 0x0009D17B File Offset: 0x0009B37B
		public override int GetHashCode()
		{
			return this.url.GetHashCode();
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление состояния условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> — <see langword="null" />.</exception>
		// Token: 0x06002B7C RID: 11132 RVA: 0x0009D188 File Offset: 0x0009B388
		public override string ToString()
		{
			return "Url - " + this.Url;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B7D RID: 11133 RVA: 0x0009D19A File Offset: 0x0009B39A
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст уровня политики для разрешения ссылок на именованные наборы разрешений.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Security.Policy.UrlMembershipCondition.Url" /> — <see langword="null" />.</exception>
		// Token: 0x06002B7E RID: 11134 RVA: 0x0009D1A3 File Offset: 0x0009B3A3
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = MembershipConditionHelper.Element(typeof(UrlMembershipCondition), this.version);
			securityElement.AddAttribute("Url", this.userUrl);
			return securityElement;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		internal void CheckUrl(string url)
		{
			if (new Uri((url.IndexOf(Uri.SchemeDelimiter) < 0) ? ("file://" + url) : url, false, false).Host.IndexOf('*') >= 1)
			{
				throw new ArgumentException(Locale.GetText("Invalid * character in url"), "name");
			}
		}

		// Token: 0x04001FC7 RID: 8135
		private readonly int version = 1;

		// Token: 0x04001FC8 RID: 8136
		private Url url;

		// Token: 0x04001FC9 RID: 8137
		private string userUrl;
	}
}
