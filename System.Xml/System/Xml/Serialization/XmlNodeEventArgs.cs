using System;
using Unity;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Предоставляет данные для события <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" />.
	///       </summary>
	// Token: 0x02000311 RID: 785
	public class XmlNodeEventArgs : EventArgs
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x000D164A File Offset: 0x000CF84A
		internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o)
		{
			this.o = o;
			this.xmlNode = xmlNode;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		/// <summary>
		///         Получает Десериализуемый объект.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Object" /> Был десериализован.
		///       </returns>
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x000D166F File Offset: 0x000CF86F
		public object ObjectBeingDeserialized
		{
			get
			{
				return this.o;
			}
		}

		/// <summary>
		///         Получает тип десериализуемого узла XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNodeType" /> Представляющий десериализуемого узла XML.
		///       </returns>
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000D1677 File Offset: 0x000CF877
		public XmlNodeType NodeType
		{
			get
			{
				return this.xmlNode.NodeType;
			}
		}

		/// <summary>
		///         Получает имя десериализуемого узла XML.
		///       </summary>
		/// <returns>
		///         Имя десериализуемого узла.
		///       </returns>
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000D1684 File Offset: 0x000CF884
		public string Name
		{
			get
			{
				return this.xmlNode.Name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя XML десериализуемого узла XML.
		///       </summary>
		/// <returns>
		///         Локальное имя XML десериализуемого узла.
		///       </returns>
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000D1691 File Offset: 0x000CF891
		public string LocalName
		{
			get
			{
				return this.xmlNode.LocalName;
			}
		}

		/// <summary>
		///         Получает пространство имен URI, связанное с десериализуемого узла XML.
		///       </summary>
		/// <returns>
		///         Пространство имен URI, связанное с десериализуемого узла XML.
		///       </returns>
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000D169E File Offset: 0x000CF89E
		public string NamespaceURI
		{
			get
			{
				return this.xmlNode.NamespaceURI;
			}
		}

		/// <summary>
		///         Получает текст десериализуемого узла XML.
		///       </summary>
		/// <returns>
		///         Текст десериализуемого узла XML.
		///       </returns>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000D16AB File Offset: 0x000CF8AB
		public string Text
		{
			get
			{
				return this.xmlNode.Value;
			}
		}

		/// <summary>
		///         Получает номер строки неизвестного узла XML.
		///       </summary>
		/// <returns>
		///         Номер строки неизвестного узла XML.
		///       </returns>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000D16B8 File Offset: 0x000CF8B8
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		/// <summary>
		///         Возвращает позицию в строке неизвестного узла XML.
		///       </summary>
		/// <returns>
		///         Номер позиции неизвестного узла XML.
		///       </returns>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000D16C0 File Offset: 0x000CF8C0
		public int LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlNodeEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001B39 RID: 6969
		private object o;

		// Token: 0x04001B3A RID: 6970
		private XmlNode xmlNode;

		// Token: 0x04001B3B RID: 6971
		private int lineNumber;

		// Token: 0x04001B3C RID: 6972
		private int linePosition;
	}
}
