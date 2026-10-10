using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace System.Xml
{
	/// <summary>
	///         Представляет полное имя XML.
	///       </summary>
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class XmlQualifiedName
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		// Token: 0x0600158C RID: 5516 RVA: 0x000847D4 File Offset: 0x000829D4
		public XmlQualifiedName() : this(string.Empty, string.Empty)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlQualifiedName" /> с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Локальное имя для использования в качестве имени <see cref="T:System.Xml.XmlQualifiedName" /> объекта.
		///         </param>
		// Token: 0x0600158D RID: 5517 RVA: 0x000847E6 File Offset: 0x000829E6
		public XmlQualifiedName(string name) : this(name, string.Empty)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlQualifiedName" /> указанными именем и пространством имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя для использования в качестве имени <see cref="T:System.Xml.XmlQualifiedName" /> объекта.
		///         </param>
		/// <param name="ns">
		///           Пространство имен для <see cref="T:System.Xml.XmlQualifiedName" /> объекта.
		///         </param>
		// Token: 0x0600158E RID: 5518 RVA: 0x000847F4 File Offset: 0x000829F4
		public XmlQualifiedName(string name, string ns)
		{
			this.ns = ((ns == null) ? string.Empty : ns);
			this.name = ((name == null) ? string.Empty : name);
		}

		/// <summary>
		///         Возвращает строковое представление пространства имен <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <returns>
		///         Строковое представление пространства имен или String.Empty, если пространство имен для объекта не определено.
		///       </returns>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0008481E File Offset: 0x00082A1E
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		/// <summary>
		///         Возвращает строковое представление полного имени <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <returns>
		///         Строковое представление полного имени или String.Empty, если имя не указано для объекта.
		///       </returns>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00084826 File Offset: 0x00082A26
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает хэш-код для <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <returns>
		///         Хэш-код для этого объекта.
		///       </returns>
		// Token: 0x06001591 RID: 5521 RVA: 0x00084830 File Offset: 0x00082A30
		public override int GetHashCode()
		{
			if (this.hash == 0)
			{
				if (XmlQualifiedName.hashCodeDelegate == null)
				{
					XmlQualifiedName.hashCodeDelegate = XmlQualifiedName.GetHashCodeDelegate();
				}
				this.hash = XmlQualifiedName.hashCodeDelegate(this.Name, this.Name.Length, 0L);
			}
			return this.hash;
		}

		/// <summary>
		///         Получает значение, указывающее, пуст ли объект <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если имя и пространство имен являются пустыми строками; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0008487F File Offset: 0x00082A7F
		public bool IsEmpty
		{
			get
			{
				return this.Name.Length == 0 && this.Namespace.Length == 0;
			}
		}

		/// <summary>
		///         Возвращает строковое значение <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <returns>
		///         Строковое значение <see cref="T:System.Xml.XmlQualifiedName" /> в формате <see langword="namespace:localname" />.
		///          Если объект не имеет определенное пространство имен, этот метод возвращает только локальное имя.
		///       </returns>
		// Token: 0x06001593 RID: 5523 RVA: 0x0008489E File Offset: 0x00082A9E
		public override string ToString()
		{
			if (this.Namespace.Length != 0)
			{
				return this.Namespace + ":" + this.Name;
			}
			return this.Name;
		}

		/// <summary>
		///         Определяет, является ли указанный <see cref="T:System.Xml.XmlQualifiedName" /> объект равен текущему объекту <see cref="T:System.Xml.XmlQualifiedName" /> объекта.
		///       </summary>
		/// <param name="other">
		///           Сравниваемый шаблон <see cref="T:System.Xml.XmlQualifiedName" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если они тем же экземпляром объекта; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001594 RID: 5524 RVA: 0x000848CC File Offset: 0x00082ACC
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			XmlQualifiedName xmlQualifiedName = other as XmlQualifiedName;
			return xmlQualifiedName != null && this.Name == xmlQualifiedName.Name && this.Namespace == xmlQualifiedName.Namespace;
		}

		/// <summary>
		///         Сравнивает два объекта <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <param name="a">
		///           Объект <see cref="T:System.Xml.XmlQualifiedName" /> для сравнения.
		///         </param>
		/// <param name="b">
		///           Объект <see cref="T:System.Xml.XmlQualifiedName" /> для сравнения.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если оба объекта имеют одинаковые имя и пространство имен в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001595 RID: 5525 RVA: 0x00084917 File Offset: 0x00082B17
		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			return a == b || (a != null && b != null && a.Name == b.Name && a.Namespace == b.Namespace);
		}

		/// <summary>
		///         Сравнивает два объекта <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <param name="a">
		///           Объект <see cref="T:System.Xml.XmlQualifiedName" /> для сравнения.
		///         </param>
		/// <param name="b">
		///           Объект <see cref="T:System.Xml.XmlQualifiedName" /> для сравнения.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если оба объекта имеют разные имена и пространства имен; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001596 RID: 5526 RVA: 0x0008494D File Offset: 0x00082B4D
		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			return !(a == b);
		}

		/// <summary>
		///         Возвращает строковое значение <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		/// <param name="name">
		///           Имя объекта.
		///         </param>
		/// <param name="ns">
		///           Пространство имен объекта.
		///         </param>
		/// <returns>
		///         Строковое значение <see cref="T:System.Xml.XmlQualifiedName" /> в формате <see langword="namespace:localname" />.
		///          Если объект не имеет определенное пространство имен, этот метод возвращает только локальное имя.
		///       </returns>
		// Token: 0x06001597 RID: 5527 RVA: 0x00084959 File Offset: 0x00082B59
		public static string ToString(string name, string ns)
		{
			if (ns != null && ns.Length != 0)
			{
				return ns + ":" + name;
			}
			return name;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00084974 File Offset: 0x00082B74
		[SecuritySafeCritical]
		[ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
		private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			if (!XmlQualifiedName.IsRandomizedHashingDisabled())
			{
				MethodInfo method = typeof(string).GetMethod("InternalMarvin32HashString", BindingFlags.Static | BindingFlags.NonPublic);
				if (method != null)
				{
					return (XmlQualifiedName.HashCodeOfStringDelegate)Delegate.CreateDelegate(typeof(XmlQualifiedName.HashCodeOfStringDelegate), method);
				}
			}
			return new XmlQualifiedName.HashCodeOfStringDelegate(XmlQualifiedName.GetHashCodeOfString);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		private static bool IsRandomizedHashingDisabled()
		{
			return false;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000849CA File Offset: 0x00082BCA
		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			return s.GetHashCode();
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000849D2 File Offset: 0x00082BD2
		internal void Init(string name, string ns)
		{
			this.name = name;
			this.ns = ns;
			this.hash = 0;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000849E9 File Offset: 0x00082BE9
		internal void SetNamespace(string ns)
		{
			this.ns = ns;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000849F2 File Offset: 0x00082BF2
		internal void Verify()
		{
			XmlConvert.VerifyNCName(this.name);
			if (this.ns.Length != 0)
			{
				XmlConvert.ToUri(this.ns);
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00084A19 File Offset: 0x00082C19
		internal void Atomize(XmlNameTable nameTable)
		{
			this.name = nameTable.Add(this.name);
			this.ns = nameTable.Add(this.ns);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00084A40 File Offset: 0x00082C40
		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			string text;
			ValidateNames.ParseQNameThrow(s, out prefix, out text);
			string text2 = nsmgr.LookupNamespace(prefix);
			if (text2 == null)
			{
				if (prefix.Length != 0)
				{
					throw new XmlException("'{0}' is an undeclared prefix.", prefix);
				}
				text2 = string.Empty;
			}
			return new XmlQualifiedName(text, text2);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00084A85 File Offset: 0x00082C85
		internal XmlQualifiedName Clone()
		{
			return (XmlQualifiedName)base.MemberwiseClone();
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00084A94 File Offset: 0x00082C94
		internal static int Compare(XmlQualifiedName a, XmlQualifiedName b)
		{
			if (null == a)
			{
				if (!(null == b))
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (null == b)
				{
					return 1;
				}
				int num = string.CompareOrdinal(a.Namespace, b.Namespace);
				if (num == 0)
				{
					num = string.CompareOrdinal(a.Name, b.Name);
				}
				return num;
			}
		}

		// Token: 0x04001306 RID: 4870
		private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate = null;

		// Token: 0x04001307 RID: 4871
		private string name;

		// Token: 0x04001308 RID: 4872
		private string ns;

		// Token: 0x04001309 RID: 4873
		[NonSerialized]
		private int hash;

		/// <summary>
		///         Предоставляет пустой <see cref="T:System.Xml.XmlQualifiedName" />.
		///       </summary>
		// Token: 0x0400130A RID: 4874
		public static readonly XmlQualifiedName Empty = new XmlQualifiedName(string.Empty);

		// Token: 0x02000244 RID: 580
		// (Invoke) Token: 0x060015A4 RID: 5540
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
