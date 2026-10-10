using System;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет пробел в содержимом элемента.
	///       </summary>
	// Token: 0x020001DD RID: 477
	public class XmlWhitespace : XmlCharacterData
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlWhitespace" />.
		///       </summary>
		/// <param name="strData">
		///           Пробелы узла.
		///         </param>
		/// <param name="doc">
		///           Объект <see cref="T:System.Xml.XmlDocument" />.
		///         </param>
		// Token: 0x060012FD RID: 4861 RVA: 0x0007079D File Offset: 0x0006E99D
		protected internal XmlWhitespace(string strData, XmlDocument doc) : base(strData, doc)
		{
			if (!doc.IsLoading && !base.CheckOnData(strData))
			{
				throw new ArgumentException(Res.GetString("The string for white space contains an invalid character."));
			}
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlWhitespace" /> узлов, это свойство возвращает <see langword="#whitespace" />.
		///       </returns>
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00070A8E File Offset: 0x0006EC8E
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strNonSignificantWhitespaceName;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlWhitespace" /> узлов, это свойство возвращает <see langword="#whitespace" />.
		///       </returns>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00070A8E File Offset: 0x0006EC8E
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strNonSignificantWhitespaceName;
			}
		}

		/// <summary>
		///         Возвращает тип узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlWhitespace" /> узлов, значение равно <see cref="F:System.Xml.XmlNodeType.Whitespace" />.
		///       </returns>
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00070A9B File Offset: 0x0006EC9B
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Whitespace;
			}
		}

		/// <summary>
		///         Возвращает родительский узел текущего узла.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Родительский узел текущего узла.
		///       </returns>
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00070AA0 File Offset: 0x0006ECA0
		public override XmlNode ParentNode
		{
			get
			{
				XmlNodeType nodeType = this.parentNode.NodeType;
				if (nodeType - XmlNodeType.Text > 1)
				{
					if (nodeType == XmlNodeType.Document)
					{
						return base.ParentNode;
					}
					if (nodeType - XmlNodeType.Whitespace > 1)
					{
						return this.parentNode;
					}
				}
				XmlNode parentNode = this.parentNode.parentNode;
				while (parentNode.IsText)
				{
					parentNode = parentNode.parentNode;
				}
				return parentNode;
			}
		}

		/// <summary>
		///         Возвращает или задает значение узла.
		///       </summary>
		/// <returns>
		///         Пробелы, найденные в узле.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр <see cref="P:System.Xml.XmlWhitespace.Value" /> для недопустимые пробелы.
		///           </exception>
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00067404 File Offset: 0x00065604
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x00070848 File Offset: 0x0006EA48
		public override string Value
		{
			get
			{
				return this.Data;
			}
			set
			{
				if (base.CheckOnData(value))
				{
					this.Data = value;
					return;
				}
				throw new ArgumentException(Res.GetString("The string for white space contains an invalid character."));
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Для узлов пробелов точная копия узла всегда включает значение данных независимо от значения параметра.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x06001304 RID: 4868 RVA: 0x00070AF9 File Offset: 0x0006ECF9
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateWhitespace(this.Data);
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see cref="T:System.Xml.XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001305 RID: 4869 RVA: 0x00070B0C File Offset: 0x0006ED0C
		public override void WriteTo(XmlWriter w)
		{
			w.WriteWhitespace(this.Data);
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see cref="T:System.Xml.XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001306 RID: 4870 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00070B1C File Offset: 0x0006ED1C
		internal override XPathNodeType XPNodeType
		{
			get
			{
				XPathNodeType result = XPathNodeType.Whitespace;
				base.DecideXPNodeTypeForTextNodes(this, ref result);
				return result;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0001222F File Offset: 0x0001042F
		internal override bool IsText
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает текстовый узел, непосредственно предшествующий данному.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Xml.XmlNode" />.
		///       </returns>
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000673DD File Offset: 0x000655DD
		public override XmlNode PreviousText
		{
			get
			{
				if (this.parentNode.IsText)
				{
					return this.parentNode;
				}
				return null;
			}
		}
	}
}
