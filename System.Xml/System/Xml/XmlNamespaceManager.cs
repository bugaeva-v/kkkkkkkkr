using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml
{
	/// <summary>
	///         Разрешает, добавляет и удаляет пространства имен из коллекции и обеспечивает управление областью для этих пространств имен.
	///       </summary>
	// Token: 0x0200023E RID: 574
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00084053 File Offset: 0x00082253
		internal static IXmlNamespaceResolver EmptyResolver
		{
			get
			{
				if (XmlNamespaceManager.s_EmptyResolver == null)
				{
					XmlNamespaceManager.s_EmptyResolver = new XmlNamespaceManager(new NameTable());
				}
				return XmlNamespaceManager.s_EmptyResolver;
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0000216B File Offset: 0x0000036B
		internal XmlNamespaceManager()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlNamespaceManager" /> указанным значением <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="nameTable">
		///           Используемый <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.NullReferenceException">
		///             <see langword="null" /> передается в конструктор 
		///           </exception>
		// Token: 0x06001579 RID: 5497 RVA: 0x00084078 File Offset: 0x00082278
		public XmlNamespaceManager(XmlNameTable nameTable)
		{
			this.nameTable = nameTable;
			this.xml = nameTable.Add("xml");
			this.xmlNs = nameTable.Add("xmlns");
			this.nsdecls = new XmlNamespaceManager.NamespaceDeclaration[8];
			string text = nameTable.Add(string.Empty);
			this.nsdecls[0].Set(text, text, -1, -1);
			this.nsdecls[1].Set(this.xmlNs, nameTable.Add("http://www.w3.org/2000/xmlns/"), -1, -1);
			this.nsdecls[2].Set(this.xml, nameTable.Add("http://www.w3.org/XML/1998/namespace"), 0, -1);
			this.lastDecl = 2;
			this.scopeId = 1;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNameTable" /> связанных с этим объектом.
		///       </summary>
		/// <returns>
		///         Диспетчер <see cref="T:System.Xml.XmlNameTable" />, используемый этим объектом.
		///       </returns>
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00084137 File Offset: 0x00082337
		public virtual XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		/// <summary>
		///         Возвращает универсальный код ресурса (URI) для пространства имен по умолчанию.
		///       </summary>
		/// <returns>
		///         Возвращает URI для пространства имен по умолчанию или String.Empty, если пространство имен по умолчанию отсутствует.
		///       </returns>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00084140 File Offset: 0x00082340
		public virtual string DefaultNamespace
		{
			get
			{
				string text = this.LookupNamespace(string.Empty);
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}

		/// <summary>
		///         Заносит область видимости пространства имен в стек.
		///       </summary>
		// Token: 0x0600157C RID: 5500 RVA: 0x00084163 File Offset: 0x00082363
		public virtual void PushScope()
		{
			this.scopeId++;
		}

		/// <summary>
		///         Извлекает из стека область видимости пространства имен.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если остались области пространств имен в стеке; <see langword="false" /> Если отсутствуют дополнительные пространства имен для раскрытия.
		///       </returns>
		// Token: 0x0600157D RID: 5501 RVA: 0x00084174 File Offset: 0x00082374
		public virtual bool PopScope()
		{
			int num = this.lastDecl;
			if (this.scopeId == 1)
			{
				return false;
			}
			while (this.nsdecls[num].scopeId == this.scopeId)
			{
				if (this.useHashtable)
				{
					this.hashTable[this.nsdecls[num].prefix] = this.nsdecls[num].previousNsIndex;
				}
				num--;
			}
			this.lastDecl = num;
			this.scopeId--;
			return true;
		}

		/// <summary>
		///         Добавляет заданное пространство имен в коллекцию.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, который требуется связать с добавляемым пространством имен.
		///            Используйте String.Empty для добавления пространства имен по умолчанию.
		///
		///           ПримечаниеЕсли <see cref="T:System.Xml.XmlNamespaceManager" /> будет использоваться для разрешения пространств имен в выражении языка XML Path (XPath), должен быть указан префикс.
		///            Если выражение XPath не содержит префикс, предполагается, что универсальным кодом ресурса (URI) для пространства имен является пустое пространство имен.
		///            Дополнительные сведения о выражениях XPath и <see cref="T:System.Xml.XmlNamespaceManager" />, обратитесь к <see cref="M:System.Xml.XmlNode.SelectNodes(System.String)" /> и <see cref="M:System.Xml.XPath.XPathExpression.SetContext(System.Xml.XmlNamespaceManager)" /> методы.
		///         </param>
		/// <param name="uri">
		///           Добавляемое пространство имен.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Значение для <paramref name="prefix" /> «xml» или «xmlns».
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение для <paramref name="prefix" /> или <paramref name="uri" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600157E RID: 5502 RVA: 0x000841FC File Offset: 0x000823FC
		public virtual void AddNamespace(string prefix, string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			prefix = this.nameTable.Add(prefix);
			uri = this.nameTable.Add(uri);
			if (Ref.Equal(this.xml, prefix) && !uri.Equals("http://www.w3.org/XML/1998/namespace"))
			{
				throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
			}
			if (Ref.Equal(this.xmlNs, prefix))
			{
				throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
			}
			int num = this.LookupNamespaceDecl(prefix);
			int previousNsIndex = -1;
			if (num != -1)
			{
				if (this.nsdecls[num].scopeId == this.scopeId)
				{
					this.nsdecls[num].uri = uri;
					return;
				}
				previousNsIndex = num;
			}
			if (this.lastDecl == this.nsdecls.Length - 1)
			{
				XmlNamespaceManager.NamespaceDeclaration[] destinationArray = new XmlNamespaceManager.NamespaceDeclaration[this.nsdecls.Length * 2];
				Array.Copy(this.nsdecls, 0, destinationArray, 0, this.nsdecls.Length);
				this.nsdecls = destinationArray;
			}
			XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
			int num2 = this.lastDecl + 1;
			this.lastDecl = num2;
			array[num2].Set(prefix, uri, this.scopeId, previousNsIndex);
			if (this.useHashtable)
			{
				this.hashTable[prefix] = this.lastDecl;
				return;
			}
			if (this.lastDecl >= 16)
			{
				this.hashTable = new Dictionary<string, int>(this.lastDecl);
				for (int i = 0; i <= this.lastDecl; i++)
				{
					this.hashTable[this.nsdecls[i].prefix] = i;
				}
				this.useHashtable = true;
			}
		}

		/// <summary>
		///         Удаляет заданное пространство имен с указанным префиксом.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен. 
		///         </param>
		/// <param name="uri">
		///           Пространство имен, которое требуется удалить по указанному префиксу.
		///            Пространство имен удаляется из текущей области видимости пространств имен.
		///            Пространства имен вне текущей области видимости игнорируются.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="prefix" /> или <paramref name="uri" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600157F RID: 5503 RVA: 0x000843A0 File Offset: 0x000825A0
		public virtual void RemoveNamespace(string prefix, string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			for (int num = this.LookupNamespaceDecl(prefix); num != -1; num = this.nsdecls[num].previousNsIndex)
			{
				if (string.Equals(this.nsdecls[num].uri, uri) && this.nsdecls[num].scopeId == this.scopeId)
				{
					this.nsdecls[num].uri = null;
				}
			}
		}

		/// <summary>
		///         Возвращает перечислитель для прохода по пространствам имен в <see cref="T:System.Xml.XmlNamespaceManager" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Collections.IEnumerator" /> Содержащий префиксы, которые хранятся в <see cref="T:System.Xml.XmlNamespaceManager" />.
		///       </returns>
		// Token: 0x06001580 RID: 5504 RVA: 0x00084430 File Offset: 0x00082630
		public virtual IEnumerator GetEnumerator()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(this.lastDecl + 1);
			for (int i = 0; i <= this.lastDecl; i++)
			{
				if (this.nsdecls[i].uri != null)
				{
					dictionary[this.nsdecls[i].prefix] = this.nsdecls[i].prefix;
				}
			}
			return dictionary.Keys.GetEnumerator();
		}

		/// <summary>
		///         Возвращает коллекцию пространств имен, уникальными идентификаторами которых являются префиксы, используемые для перечисления пространств имен в текущей области видимости.
		///       </summary>
		/// <param name="scope">
		///           Значение перечисления, указывающее тип узлов пространств имен, которые требуется возвратить.
		///         </param>
		/// <returns>
		///         Коллекция пар префикс-пространство имен в текущей области видимости.
		///       </returns>
		// Token: 0x06001581 RID: 5505 RVA: 0x000844A8 File Offset: 0x000826A8
		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			int i = 0;
			switch (scope)
			{
			case XmlNamespaceScope.All:
				i = 2;
				break;
			case XmlNamespaceScope.ExcludeXml:
				i = 3;
				break;
			case XmlNamespaceScope.Local:
				i = this.lastDecl;
				while (this.nsdecls[i].scopeId == this.scopeId)
				{
					i--;
				}
				i++;
				break;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(this.lastDecl - i + 1);
			while (i <= this.lastDecl)
			{
				string prefix = this.nsdecls[i].prefix;
				string uri = this.nsdecls[i].uri;
				if (uri != null)
				{
					if (uri.Length > 0 || prefix.Length > 0 || scope == XmlNamespaceScope.Local)
					{
						dictionary[prefix] = uri;
					}
					else
					{
						dictionary.Remove(prefix);
					}
				}
				i++;
			}
			return dictionary;
		}

		/// <summary>
		///         Возвращает URI пространства имен для указанного префикса.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, для которого требуется разрешить URI пространства имен.
		///            Чтобы сопоставить пространство имен по умолчанию, необходимо передать String.Empty.
		///         </param>
		/// <returns>
		///         Возвращает URI пространства имен для <paramref name="prefix" /> или <see langword="null" /> Если соответствующее пространство имен отсутствует.
		///          Возвращаемая строка является атомизированной.
		///
		///         Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" /> класса.
		///       </returns>
		// Token: 0x06001582 RID: 5506 RVA: 0x0008456C File Offset: 0x0008276C
		public virtual string LookupNamespace(string prefix)
		{
			int num = this.LookupNamespaceDecl(prefix);
			if (num != -1)
			{
				return this.nsdecls[num].uri;
			}
			return null;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00084598 File Offset: 0x00082798
		private int LookupNamespaceDecl(string prefix)
		{
			if (!this.useHashtable)
			{
				for (int i = this.lastDecl; i >= 0; i--)
				{
					if (this.nsdecls[i].prefix == prefix && this.nsdecls[i].uri != null)
					{
						return i;
					}
				}
				for (int j = this.lastDecl; j >= 0; j--)
				{
					if (string.Equals(this.nsdecls[j].prefix, prefix) && this.nsdecls[j].uri != null)
					{
						return j;
					}
				}
				return -1;
			}
			int previousNsIndex;
			if (this.hashTable.TryGetValue(prefix, out previousNsIndex))
			{
				while (previousNsIndex != -1 && this.nsdecls[previousNsIndex].uri == null)
				{
					previousNsIndex = this.nsdecls[previousNsIndex].previousNsIndex;
				}
				return previousNsIndex;
			}
			return -1;
		}

		/// <summary>
		///         Находит префикс, объявленный для заданного URI пространства имен.
		///       </summary>
		/// <param name="uri">
		///           Пространство имен, чтобы разрешить для получения префикса.
		///         </param>
		/// <returns>
		///         Соответствующий префикс.
		///          Если нет сопоставленного префикса, данный метод возвращает String.Empty.
		///          Если указано значение null, затем <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x06001584 RID: 5508 RVA: 0x00084668 File Offset: 0x00082868
		public virtual string LookupPrefix(string uri)
		{
			for (int i = this.lastDecl; i >= 0; i--)
			{
				if (string.Equals(this.nsdecls[i].uri, uri))
				{
					string prefix = this.nsdecls[i].prefix;
					if (string.Equals(this.LookupNamespace(prefix), uri))
					{
						return prefix;
					}
				}
			}
			return null;
		}

		/// <summary>
		///         Возвращает значение, указывающее, определено ли пространство имен для указанного префикса в текущей области видимости, занесенной в стек.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен, которое требуется найти.
		///         </param>
		/// <returns>
		///         <see langword="true" />Если имеется определенное пространство имен; в противном случае <see langword="false" />.
		///       </returns>
		// Token: 0x06001585 RID: 5509 RVA: 0x000846C4 File Offset: 0x000828C4
		public virtual bool HasNamespace(string prefix)
		{
			int num = this.lastDecl;
			while (this.nsdecls[num].scopeId == this.scopeId)
			{
				if (string.Equals(this.nsdecls[num].prefix, prefix) && this.nsdecls[num].uri != null)
				{
					return prefix.Length > 0 || this.nsdecls[num].uri.Length > 0;
				}
				num--;
			}
			return false;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0008474C File Offset: 0x0008294C
		internal bool GetNamespaceDeclaration(int idx, out string prefix, out string uri)
		{
			idx = this.lastDecl - idx;
			if (idx < 0)
			{
				string text;
				uri = (text = null);
				prefix = text;
				return false;
			}
			prefix = this.nsdecls[idx].prefix;
			uri = this.nsdecls[idx].uri;
			return true;
		}

		// Token: 0x040012DF RID: 4831
		private static volatile IXmlNamespaceResolver s_EmptyResolver;

		// Token: 0x040012E0 RID: 4832
		private XmlNamespaceManager.NamespaceDeclaration[] nsdecls;

		// Token: 0x040012E1 RID: 4833
		private int lastDecl;

		// Token: 0x040012E2 RID: 4834
		private XmlNameTable nameTable;

		// Token: 0x040012E3 RID: 4835
		private int scopeId;

		// Token: 0x040012E4 RID: 4836
		private Dictionary<string, int> hashTable;

		// Token: 0x040012E5 RID: 4837
		private bool useHashtable;

		// Token: 0x040012E6 RID: 4838
		private string xml;

		// Token: 0x040012E7 RID: 4839
		private string xmlNs;

		// Token: 0x040012E8 RID: 4840
		private const int MinDeclsCountForHashtable = 16;

		// Token: 0x0200023F RID: 575
		private struct NamespaceDeclaration
		{
			// Token: 0x06001587 RID: 5511 RVA: 0x00084798 File Offset: 0x00082998
			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				this.prefix = prefix;
				this.uri = uri;
				this.scopeId = scopeId;
				this.previousNsIndex = previousNsIndex;
			}

			// Token: 0x040012E9 RID: 4841
			public string prefix;

			// Token: 0x040012EA RID: 4842
			public string uri;

			// Token: 0x040012EB RID: 4843
			public int scopeId;

			// Token: 0x040012EC RID: 4844
			public int previousNsIndex;
		}
	}
}
