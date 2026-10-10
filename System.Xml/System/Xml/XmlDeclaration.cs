using System;
using System.Text;

namespace System.Xml
{
	/// <summary>
	///         Представляет узел объявления XML &lt;?версия xml="1.0"...?&gt;.
	///       </summary>
	// Token: 0x020001BB RID: 443
	public class XmlDeclaration : XmlLinkedNode
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlDeclaration" />.
		///       </summary>
		/// <param name="version">
		///           В версии XML; в разделе <see cref="P:System.Xml.XmlDeclaration.Version" /> свойство.
		///         </param>
		/// <param name="encoding">
		///           Схема кодирования; в разделе <see cref="P:System.Xml.XmlDeclaration.Encoding" /> свойство.
		///         </param>
		/// <param name="standalone">
		///           Указывает, зависит ли XML-документа от внешнего DTD; в разделе <see cref="P:System.Xml.XmlDeclaration.Standalone" /> свойство.
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x06001048 RID: 4168 RVA: 0x000678FC File Offset: 0x00065AFC
		protected internal XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc) : base(doc)
		{
			if (!this.IsValidXmlVersion(version))
			{
				throw new ArgumentException(Res.GetString("Wrong XML version information. The XML must match production \"VersionNum ::= '1.' [0-9]+\"."));
			}
			if (standalone != null && standalone.Length > 0 && standalone != "yes" && standalone != "no")
			{
				throw new ArgumentException(Res.GetString("Wrong value for the XML declaration standalone attribute of '{0}'.", new object[]
				{
					standalone
				}));
			}
			this.Encoding = encoding;
			this.Standalone = standalone;
			this.Version = version;
		}

		/// <summary>
		///         Возвращает XML-версию документа.
		///       </summary>
		/// <returns>
		///         Это значение всегда равно <see langword="1.0" />.
		///       </returns>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0006797F File Offset: 0x00065B7F
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00067987 File Offset: 0x00065B87
		public string Version
		{
			get
			{
				return this.version;
			}
			internal set
			{
				this.version = value;
			}
		}

		/// <summary>
		///         Возвращает или задает уровень кодировки XML-документа.
		///       </summary>
		/// <returns>
		///         Допустимое имя кодировки знаков.
		///          Ниже перечислены имена кодировок символов, наиболее часто поддерживаются для XML.
		///
		///                 Категория 
		///
		///                 Имена кодировок 
		///
		///                 Юникод 
		///
		///                 UTF-8, UTF-16 
		///
		///                 СТАНДАРТ ISO 10646 
		///
		///                 ISO-10646-UCS-2, ISO-10646-UCS-4 
		///
		///                 ISO 8859 
		///
		///                 ISO-8859-n (где «n» — цифра от 1 до 9) 
		///
		///                 JIS X 0208 1997 Г. 
		///
		///                 ISO-2022-JP, Shift_JIS, EUC-JP 
		///
		///         Это значение является необязательным.
		///          Если значение не задано, это свойство возвращает String.Empty.
		///
		///         Если атрибут кодировки не включен, кодировка UTF-8 используется при записи или сохранении документа.
		///       </returns>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00067990 File Offset: 0x00065B90
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00067998 File Offset: 0x00065B98
		public string Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				this.encoding = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает значение автономного атрибута.
		///       </summary>
		/// <returns>
		///         Допустимые значения: <see langword="yes" /> Если объявления сущности, требуемые документом XML содержащиеся в документе или <see langword="no" /> при необходимости определения типа внешнего документа (DTD).
		///          Если отдельный атрибут не присутствует в объявлении XML, это свойство возвращает String.Empty.
		///       </returns>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x000679AB File Offset: 0x00065BAB
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x000679B4 File Offset: 0x00065BB4
		public string Standalone
		{
			get
			{
				return this.standalone;
			}
			set
			{
				if (value == null)
				{
					this.standalone = string.Empty;
					return;
				}
				if (value.Length == 0 || value == "yes" || value == "no")
				{
					this.standalone = value;
					return;
				}
				throw new ArgumentException(Res.GetString("Wrong value for the XML declaration standalone attribute of '{0}'.", new object[]
				{
					value
				}));
			}
		}

		/// <summary>
		///         Возвращает или задает значение <see langword="XmlDeclaration" />.
		///       </summary>
		/// <returns>
		///         Содержимое <see langword="XmlDeclaration" /> (то есть все значения между &lt;?xml и ?&gt;).
		///       </returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00066758 File Offset: 0x00064958
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00066760 File Offset: 0x00064960
		public override string Value
		{
			get
			{
				return this.InnerText;
			}
			set
			{
				this.InnerText = value;
			}
		}

		/// <summary>
		///         Возвращает или задает сцепленные значения <see langword="XmlDeclaration" />.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения <see langword="XmlDeclaration" /> (то есть все значения между &lt;?xml и ?&gt;).
		///       </returns>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00067A14 File Offset: 0x00065C14
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x00067AA8 File Offset: 0x00065CA8
		public override string InnerText
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder("version=\"" + this.Version + "\"");
				if (this.Encoding.Length > 0)
				{
					stringBuilder.Append(" encoding=\"");
					stringBuilder.Append(this.Encoding);
					stringBuilder.Append("\"");
				}
				if (this.Standalone.Length > 0)
				{
					stringBuilder.Append(" standalone=\"");
					stringBuilder.Append(this.Standalone);
					stringBuilder.Append("\"");
				}
				return stringBuilder.ToString();
			}
			set
			{
				string text = null;
				string text2 = null;
				string text3 = null;
				string text4 = this.Encoding;
				string text5 = this.Standalone;
				string text6 = this.Version;
				XmlLoader.ParseXmlDeclarationValue(value, out text, out text2, out text3);
				try
				{
					if (text != null && !this.IsValidXmlVersion(text))
					{
						throw new ArgumentException(Res.GetString("Wrong XML version information. The XML must match production \"VersionNum ::= '1.' [0-9]+\"."));
					}
					this.Version = text;
					if (text2 != null)
					{
						this.Encoding = text2;
					}
					if (text3 != null)
					{
						this.Standalone = text3;
					}
				}
				catch
				{
					this.Encoding = text4;
					this.Standalone = text5;
					this.Version = text6;
					throw;
				}
			}
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlDeclaration" /> узлов, называется <see langword="xml" />.
		///       </returns>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00067B44 File Offset: 0x00065D44
		public override string Name
		{
			get
			{
				return "xml";
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlDeclaration" /> имеет локальное имя узлов, <see langword="xml" />.
		///       </returns>
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00067B4B File Offset: 0x00065D4B
		public override string LocalName
		{
			get
			{
				return this.Name;
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlDeclaration" /> узлов, это значение является XmlNodeType.XmlDeclaration.
		///       </returns>
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00067B53 File Offset: 0x00065D53
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Поскольку <see langword="XmlDeclaration" /> узлы не имеют дочерних узлов, точная копия узла всегда включает значение данных независимо от значения параметра.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x06001056 RID: 4182 RVA: 0x00067B57 File Offset: 0x00065D57
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateXmlDeclaration(this.Version, this.Encoding, this.Standalone);
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001057 RID: 4183 RVA: 0x00067B76 File Offset: 0x00065D76
		public override void WriteTo(XmlWriter w)
		{
			w.WriteProcessingInstruction(this.Name, this.InnerText);
		}

		/// <summary>
		///         Сохраняет дочерние узлы в заданном классе <see cref="T:System.Xml.XmlWriter" />.
		///          Поскольку <see langword="XmlDeclaration" /> узлы не имеют дочерних элементов, этот метод не оказывает влияния.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001058 RID: 4184 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00067B8A File Offset: 0x00065D8A
		private bool IsValidXmlVersion(string ver)
		{
			return ver.Length >= 3 && ver[0] == '1' && ver[1] == '.' && XmlCharType.IsOnlyDigits(ver, 2, ver.Length - 2);
		}

		// Token: 0x04001041 RID: 4161
		private const string YES = "yes";

		// Token: 0x04001042 RID: 4162
		private const string NO = "no";

		// Token: 0x04001043 RID: 4163
		private string version;

		// Token: 0x04001044 RID: 4164
		private string encoding;

		// Token: 0x04001045 RID: 4165
		private string standalone;
	}
}
