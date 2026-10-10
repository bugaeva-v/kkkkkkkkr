using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Xml;

namespace System.Security
{
	/// <summary>Представляет объектную модель XML для кодирования объектов безопасности. Этот класс не наследуется.</summary>
	// Token: 0x020003E6 RID: 998
	[ComVisible(true)]
	[Serializable]
	public sealed class SecurityElement
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityElement" /> с указанным тегом.</summary>
		/// <param name="tag">Имя тега элемента XML.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="tag" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="tag" /> недопустим в XML.</exception>
		// Token: 0x06002910 RID: 10512 RVA: 0x00094E40 File Offset: 0x00093040
		public SecurityElement(string tag) : this(tag, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityElement" /> с указанным тегом и текстом.</summary>
		/// <param name="tag">Имя тега элемента XML.</param>
		/// <param name="text">Текстовое содержимое элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="tag" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="tag" /> и <paramref name="text" /> недопустимы в XML.</exception>
		// Token: 0x06002911 RID: 10513 RVA: 0x00094E4C File Offset: 0x0009304C
		public SecurityElement(string tag, string text)
		{
			if (tag == null)
			{
				throw new ArgumentNullException("tag");
			}
			if (!SecurityElement.IsValidTag(tag))
			{
				throw new ArgumentException(Locale.GetText("Invalid XML string") + ": " + tag);
			}
			this.tag = tag;
			this.Text = text;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00094EA0 File Offset: 0x000930A0
		internal SecurityElement(SecurityElement se)
		{
			this.Tag = se.Tag;
			this.Text = se.Text;
			if (se.attributes != null)
			{
				foreach (object obj in se.attributes)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)obj;
					this.AddAttribute(securityAttribute.Name, securityAttribute.Value);
				}
			}
			if (se.children != null)
			{
				foreach (object obj2 in se.children)
				{
					SecurityElement child = (SecurityElement)obj2;
					this.AddChild(child);
				}
			}
		}

		/// <summary>Получает или задает атрибуты элемента XML в виде пар "имя-значение".</summary>
		/// <returns>Объект <see cref="T:System.Collections.Hashtable" /> для значений атрибутов элемента XML.</returns>
		/// <exception cref="T:System.InvalidCastException">Недопустимое имя или значение объекта <see cref="T:System.Collections.Hashtable" />.</exception>
		/// <exception cref="T:System.ArgumentException">Имя атрибута XML является недопустимым.</exception>
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x00094F7C File Offset: 0x0009317C
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x00094FFC File Offset: 0x000931FC
		public Hashtable Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					return null;
				}
				Hashtable hashtable = new Hashtable(this.attributes.Count);
				foreach (object obj in this.attributes)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)obj;
					hashtable.Add(securityAttribute.Name, securityAttribute.Value);
				}
				return hashtable;
			}
			set
			{
				if (value == null || value.Count == 0)
				{
					this.attributes.Clear();
					return;
				}
				if (this.attributes == null)
				{
					this.attributes = new ArrayList();
				}
				else
				{
					this.attributes.Clear();
				}
				IDictionaryEnumerator enumerator = value.GetEnumerator();
				while (enumerator.MoveNext())
				{
					this.attributes.Add(new SecurityElement.SecurityAttribute((string)enumerator.Key, (string)enumerator.Value));
				}
			}
		}

		/// <summary>Получает или задает массив дочерних элементов данного элемента XML.</summary>
		/// <returns>Упорядоченные дочерние элементы данного элемента XML в виде элементов безопасности.</returns>
		/// <exception cref="T:System.ArgumentException">Дочерний элемент родительского узла XML равен <see langword="null" />.</exception>
		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x00095078 File Offset: 0x00093278
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x00095080 File Offset: 0x00093280
		public ArrayList Children
		{
			get
			{
				return this.children;
			}
			set
			{
				if (value != null)
				{
					using (IEnumerator enumerator = value.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current == null)
							{
								throw new ArgumentNullException();
							}
						}
					}
				}
				this.children = value;
			}
		}

		/// <summary>Получает или задает имя тега элемента XML.</summary>
		/// <returns>Имя тега элемента XML.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение тега равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Тег не является допустимым в XML.</exception>
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000950DC File Offset: 0x000932DC
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x000950E4 File Offset: 0x000932E4
		public string Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Tag");
				}
				if (!SecurityElement.IsValidTag(value))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML string") + ": " + value);
				}
				this.tag = value;
			}
		}

		/// <summary>Получает или задает текст внутри элемента XML.</summary>
		/// <returns>Значение текста внутри элемента XML.</returns>
		/// <exception cref="T:System.ArgumentException">Текст не является допустимым в XML.</exception>
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x0009511E File Offset: 0x0009331E
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x00095126 File Offset: 0x00093326
		public string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				if (value != null && !SecurityElement.IsValidText(value))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML string") + ": " + value);
				}
				this.text = SecurityElement.Unescape(value);
			}
		}

		/// <summary>Добавляет атрибут "имя-значение" к элементу XML.</summary>
		/// <param name="name">Имя атрибута.</param>
		/// <param name="value">Значение атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="name" /> и <paramref name="value" /> недопустимы в XML.  
		///
		/// или - 
		/// Атрибут с именем, определяемым параметром <paramref name="name" />, уже существует.</exception>
		// Token: 0x0600291B RID: 10523 RVA: 0x0009515C File Offset: 0x0009335C
		public void AddAttribute(string name, string value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (this.GetAttribute(name) != null)
			{
				throw new ArgumentException(Locale.GetText("Duplicate attribute : " + name));
			}
			if (this.attributes == null)
			{
				this.attributes = new ArrayList();
			}
			this.attributes.Add(new SecurityElement.SecurityAttribute(name, value));
		}

		/// <summary>Добавляет дочерний элемент в элемент XML.</summary>
		/// <param name="child">Добавляемый дочерний элемент.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="child" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600291C RID: 10524 RVA: 0x000951CA File Offset: 0x000933CA
		public void AddChild(SecurityElement child)
		{
			if (child == null)
			{
				throw new ArgumentNullException("child");
			}
			if (this.children == null)
			{
				this.children = new ArrayList();
			}
			this.children.Add(child);
		}

		/// <summary>Находит атрибут с заданным именем в элементе XML.</summary>
		/// <param name="name">Имя атрибута для поиска.</param>
		/// <returns>Значение, связанное с именованным атрибутом, или <see langword="null" />, если атрибута с именем <paramref name="name" /> не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600291D RID: 10525 RVA: 0x000951FC File Offset: 0x000933FC
		public string Attribute(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			SecurityElement.SecurityAttribute attribute = this.GetAttribute(name);
			if (attribute != null)
			{
				return attribute.Value;
			}
			return null;
		}

		/// <summary>Создает и возвращает точную копию текущего объекта <see cref="T:System.Security.SecurityElement" />.</summary>
		/// <returns>Копия текущего объекта <see cref="T:System.Security.SecurityElement" />.</returns>
		// Token: 0x0600291E RID: 10526 RVA: 0x0009522A File Offset: 0x0009342A
		[ComVisible(false)]
		public SecurityElement Copy()
		{
			return new SecurityElement(this);
		}

		/// <summary>Сравнивает два объекта элементов XML, чтобы определить, равны ли они.</summary>
		/// <param name="other">Объект элемента XML, с которым сравнивается текущий объект элемента XML.</param>
		/// <returns>
		///   <see langword="true" />, если тег, имена и значения атрибутов, дочерние элементы и текстовые поля текущего элемента XML идентичны соответствующим составляющим параметра <paramref name="other" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600291F RID: 10527 RVA: 0x00095234 File Offset: 0x00093434
		public bool Equal(SecurityElement other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (this.text != other.text)
			{
				return false;
			}
			if (this.tag != other.tag)
			{
				return false;
			}
			if (this.attributes == null && other.attributes != null && other.attributes.Count != 0)
			{
				return false;
			}
			if (other.attributes == null && this.attributes != null && this.attributes.Count != 0)
			{
				return false;
			}
			if (this.attributes != null && other.attributes != null)
			{
				if (this.attributes.Count != other.attributes.Count)
				{
					return false;
				}
				foreach (object obj in this.attributes)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)obj;
					SecurityElement.SecurityAttribute attribute = other.GetAttribute(securityAttribute.Name);
					if (attribute == null || securityAttribute.Value != attribute.Value)
					{
						return false;
					}
				}
			}
			if (this.children == null && other.children != null && other.children.Count != 0)
			{
				return false;
			}
			if (other.children == null && this.children != null && this.children.Count != 0)
			{
				return false;
			}
			if (this.children != null && other.children != null)
			{
				if (this.children.Count != other.children.Count)
				{
					return false;
				}
				for (int i = 0; i < this.children.Count; i++)
				{
					if (!((SecurityElement)this.children[i]).Equal((SecurityElement)other.children[i]))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>Заменяет недопустимые для XML знаки в строке их допустимыми эквивалентами в XML.</summary>
		/// <param name="str">Строка, в которой выполняется обработка недопустимых знаков.</param>
		/// <returns>Строка ввода с замененными недопустимыми знаками.</returns>
		// Token: 0x06002920 RID: 10528 RVA: 0x00095408 File Offset: 0x00093608
		public static string Escape(string str)
		{
			if (str == null)
			{
				return null;
			}
			if (str.IndexOfAny(SecurityElement.invalid_chars) == -1)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int length = str.Length;
			int i = 0;
			while (i < length)
			{
				char c = str[i];
				if (c <= '&')
				{
					if (c != '"')
					{
						if (c != '&')
						{
							goto IL_96;
						}
						stringBuilder.Append("&amp;");
					}
					else
					{
						stringBuilder.Append("&quot;");
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_96;
						}
						stringBuilder.Append("&gt;");
					}
					else
					{
						stringBuilder.Append("&lt;");
					}
				}
				else
				{
					stringBuilder.Append("&apos;");
				}
				IL_9E:
				i++;
				continue;
				IL_96:
				stringBuilder.Append(c);
				goto IL_9E;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000954C4 File Offset: 0x000936C4
		private static string Unescape(string str)
		{
			if (str == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(str);
			stringBuilder.Replace("&lt;", "<");
			stringBuilder.Replace("&gt;", ">");
			stringBuilder.Replace("&amp;", "&");
			stringBuilder.Replace("&quot;", "\"");
			stringBuilder.Replace("&apos;", "'");
			return stringBuilder.ToString();
		}

		/// <summary>Создает элемент безопасности на основе строки в XML-кодировке.</summary>
		/// <param name="xml">Строка в XML-кодировке, на основе которой следует создать элемент безопасности.</param>
		/// <returns>Элемент <see cref="T:System.Security.SecurityElement" />, созданный на основе XML.</returns>
		/// <exception cref="T:System.Security.XmlSyntaxException">
		///   <paramref name="xml" /> содержит один или несколько символов одинарных кавычек.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="xml" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002922 RID: 10530 RVA: 0x00095538 File Offset: 0x00093738
		public static SecurityElement FromString(string xml)
		{
			if (xml == null)
			{
				throw new ArgumentNullException("xml");
			}
			if (xml.Length == 0)
			{
				throw new XmlSyntaxException(Locale.GetText("Empty string."));
			}
			SecurityElement result;
			try
			{
				SecurityParser securityParser = new SecurityParser();
				securityParser.LoadXml(xml);
				result = securityParser.ToXml();
			}
			catch (Exception inner)
			{
				throw new XmlSyntaxException(Locale.GetText("Invalid XML."), inner);
			}
			return result;
		}

		/// <summary>Определяет, является ли строка допустимым именем атрибута.</summary>
		/// <param name="name">Имя атрибута, проверяемое на допустимость.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="name" /> является допустимым именем атрибута XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002923 RID: 10531 RVA: 0x000955A4 File Offset: 0x000937A4
		public static bool IsValidAttributeName(string name)
		{
			return name != null && name.IndexOfAny(SecurityElement.invalid_attr_name_chars) == -1;
		}

		/// <summary>Определяет, является ли строка допустимым значением атрибута.</summary>
		/// <param name="value">Значение атрибута, проверяемое на допустимость.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="value" /> является допустимым значением атрибута XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002924 RID: 10532 RVA: 0x000955B9 File Offset: 0x000937B9
		public static bool IsValidAttributeValue(string value)
		{
			return value != null && value.IndexOfAny(SecurityElement.invalid_attr_value_chars) == -1;
		}

		/// <summary>Определяет, является ли строка допустимым тегом.</summary>
		/// <param name="tag">Тег, проверяемый на допустимость.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="tag" /> является допустимым тегом XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002925 RID: 10533 RVA: 0x000955CE File Offset: 0x000937CE
		public static bool IsValidTag(string tag)
		{
			return tag != null && tag.IndexOfAny(SecurityElement.invalid_tag_chars) == -1;
		}

		/// <summary>Определяет, допустима ли строка в качестве текста в составе элемента XML.</summary>
		/// <param name="text">Текст, проверяемый на допустимость.</param>
		/// <returns>
		///   <see langword="true" />, если параметр <paramref name="text" /> является допустимым текстовым элементом XML; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002926 RID: 10534 RVA: 0x000955E3 File Offset: 0x000937E3
		public static bool IsValidText(string text)
		{
			return text != null && text.IndexOfAny(SecurityElement.invalid_text_chars) == -1;
		}

		/// <summary>Выполняет поиск дочернего элемента по имени тега.</summary>
		/// <param name="tag">Тег, для которого нужно выполнить поиск среди дочерних элементов.</param>
		/// <returns>Первый дочерний элемент XML с указанным значением тега или <see langword="null" />, если дочернего элемента с тегом <paramref name="tag" /> не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="tag" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002927 RID: 10535 RVA: 0x000955F8 File Offset: 0x000937F8
		public SecurityElement SearchForChildByTag(string tag)
		{
			if (tag == null)
			{
				throw new ArgumentNullException("tag");
			}
			if (this.children == null)
			{
				return null;
			}
			for (int i = 0; i < this.children.Count; i++)
			{
				SecurityElement securityElement = (SecurityElement)this.children[i];
				if (securityElement.tag == tag)
				{
					return securityElement;
				}
			}
			return null;
		}

		/// <summary>Выполняет поиск дочернего элемента по имени тега и возвращает содержащийся в элементе текст.</summary>
		/// <param name="tag">Тег, для которого нужно выполнить поиск среди дочерних элементов.</param>
		/// <returns>Текстовое содержимое первого дочернего элемента с указанным значением тега.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="tag" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002928 RID: 10536 RVA: 0x00095658 File Offset: 0x00093858
		public string SearchForTextOfTag(string tag)
		{
			if (tag == null)
			{
				throw new ArgumentNullException("tag");
			}
			if (this.tag == tag)
			{
				return this.text;
			}
			if (this.children == null)
			{
				return null;
			}
			for (int i = 0; i < this.children.Count; i++)
			{
				string text = ((SecurityElement)this.children[i]).SearchForTextOfTag(tag);
				if (text != null)
				{
					return text;
				}
			}
			return null;
		}

		/// <summary>Выдает строковое представление элемента XML вместе с атрибутами, дочерними элементами и текстом.</summary>
		/// <returns>Элемент XML и его содержимое.</returns>
		// Token: 0x06002929 RID: 10537 RVA: 0x000956C8 File Offset: 0x000938C8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.ToXml(ref stringBuilder, 0);
			return stringBuilder.ToString();
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000956EC File Offset: 0x000938EC
		private void ToXml(ref StringBuilder s, int level)
		{
			s.Append("<");
			s.Append(this.tag);
			if (this.attributes != null)
			{
				s.Append(" ");
				for (int i = 0; i < this.attributes.Count; i++)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)this.attributes[i];
					s.Append(securityAttribute.Name).Append("=\"").Append(SecurityElement.Escape(securityAttribute.Value)).Append("\"");
					if (i != this.attributes.Count - 1)
					{
						s.Append(Environment.NewLine);
					}
				}
			}
			if ((this.text == null || this.text == string.Empty) && (this.children == null || this.children.Count == 0))
			{
				s.Append("/>").Append(Environment.NewLine);
				return;
			}
			s.Append(">").Append(SecurityElement.Escape(this.text));
			if (this.children != null)
			{
				s.Append(Environment.NewLine);
				foreach (object obj in this.children)
				{
					((SecurityElement)obj).ToXml(ref s, level + 1);
				}
			}
			s.Append("</").Append(this.tag).Append(">").Append(Environment.NewLine);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00095898 File Offset: 0x00093A98
		internal SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			if (this.attributes != null)
			{
				foreach (object obj in this.attributes)
				{
					SecurityElement.SecurityAttribute securityAttribute = (SecurityElement.SecurityAttribute)obj;
					if (securityAttribute.Name == name)
					{
						return securityAttribute;
					}
				}
			}
			return null;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000950DC File Offset: 0x000932DC
		internal string m_strTag
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x0009511E File Offset: 0x0009331E
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x00095908 File Offset: 0x00093B08
		internal string m_strText
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x00095911 File Offset: 0x00093B11
		internal ArrayList m_lAttributes
		{
			get
			{
				return this.attributes;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00095078 File Offset: 0x00093278
		internal ArrayList InternalChildren
		{
			get
			{
				return this.children;
			}
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x0009591C File Offset: 0x00093B1C
		internal string SearchForTextOfLocalName(string strLocalName)
		{
			if (strLocalName == null)
			{
				throw new ArgumentNullException("strLocalName");
			}
			if (this.tag == null)
			{
				return null;
			}
			if (this.tag.Equals(strLocalName) || this.tag.EndsWith(":" + strLocalName, StringComparison.Ordinal))
			{
				return SecurityElement.Unescape(this.text);
			}
			if (this.children == null)
			{
				return null;
			}
			foreach (object obj in this.children)
			{
				string text = ((SecurityElement)obj).SearchForTextOfLocalName(strLocalName);
				if (text != null)
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x04001ED6 RID: 7894
		private string text;

		// Token: 0x04001ED7 RID: 7895
		private string tag;

		// Token: 0x04001ED8 RID: 7896
		private ArrayList attributes;

		// Token: 0x04001ED9 RID: 7897
		private ArrayList children;

		// Token: 0x04001EDA RID: 7898
		private static readonly char[] invalid_tag_chars = new char[]
		{
			' ',
			'<',
			'>'
		};

		// Token: 0x04001EDB RID: 7899
		private static readonly char[] invalid_text_chars = new char[]
		{
			'<',
			'>'
		};

		// Token: 0x04001EDC RID: 7900
		private static readonly char[] invalid_attr_name_chars = new char[]
		{
			' ',
			'<',
			'>'
		};

		// Token: 0x04001EDD RID: 7901
		private static readonly char[] invalid_attr_value_chars = new char[]
		{
			'"',
			'<',
			'>'
		};

		// Token: 0x04001EDE RID: 7902
		private static readonly char[] invalid_chars = new char[]
		{
			'<',
			'>',
			'"',
			'\'',
			'&'
		};

		// Token: 0x020003E7 RID: 999
		internal class SecurityAttribute
		{
			// Token: 0x06002933 RID: 10547 RVA: 0x00095A28 File Offset: 0x00093C28
			public SecurityAttribute(string name, string value)
			{
				if (!SecurityElement.IsValidAttributeName(name))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML attribute name") + ": " + name);
				}
				if (!SecurityElement.IsValidAttributeValue(value))
				{
					throw new ArgumentException(Locale.GetText("Invalid XML attribute value") + ": " + value);
				}
				this._name = name;
				this._value = SecurityElement.Unescape(value);
			}

			// Token: 0x17000508 RID: 1288
			// (get) Token: 0x06002934 RID: 10548 RVA: 0x00095A94 File Offset: 0x00093C94
			public string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x17000509 RID: 1289
			// (get) Token: 0x06002935 RID: 10549 RVA: 0x00095A9C File Offset: 0x00093C9C
			public string Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x04001EDF RID: 7903
			private string _name;

			// Token: 0x04001EE0 RID: 7904
			private string _value;
		}
	}
}
