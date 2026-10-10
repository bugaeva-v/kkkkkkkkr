using System;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет раздел CDATA.
	///       </summary>
	// Token: 0x020001B6 RID: 438
	public class XmlCDataSection : XmlCharacterData
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlCDataSection" />.
		///       </summary>
		/// <param name="data">
		///           <see cref="T:System.String" /> содержащий символьные данные.
		///         </param>
		/// <param name="doc">
		///           Объект <see cref="T:System.Xml.XmlDocument" />.
		///         </param>
		// Token: 0x0600101C RID: 4124 RVA: 0x0006734B File Offset: 0x0006554B
		protected internal XmlCDataSection(string data, XmlDocument doc) : base(data, doc)
		{
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Узлы CDATA имеют ЛОКАЛЬНОЕ имя — <see langword="#cdata-section" />.
		///       </returns>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00067355 File Offset: 0x00065555
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strCDataSectionName;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов CDATA, локальное имя равно <see langword="#cdata-section" />.
		///       </returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00067355 File Offset: 0x00065555
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strCDataSectionName;
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Тип узла.
		///          Для узлов CDATA значение равно XmlNodeType.CDATA.
		///       </returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00067362 File Offset: 0x00065562
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.CDATA;
			}
		}

		/// <summary>
		///         Возвращает родительский узел для данного узла (только для тех узлов, которые могут иметь родительские узлы).
		///       </summary>
		/// <returns>
		///         Объект <see langword="XmlNode" />, являющийся родительским по отношению к текущему узлу.
		///          Если узел уже создан, но еще не добавлен в дерево или если узел был из дерева удален, родительский узел равен <see langword="null" />.
		///          Для всех других узлов возвращаемое значение зависит от свойства <see cref="P:System.Xml.XmlNode.NodeType" /> узла.
		///          В следующей таблице описаны возможные возвращаемые значения для свойства <see langword="ParentNode" />.
		///       </returns>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00067368 File Offset: 0x00065568
		public override XmlNode ParentNode
		{
			get
			{
				XmlNodeType nodeType = this.parentNode.NodeType;
				if (nodeType - XmlNodeType.Text > 1)
				{
					if (nodeType == XmlNodeType.Document)
					{
						return null;
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
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Поскольку узлы CDATA не имеют дочерних узлов, независимо от настройки параметра точная копия узла всегда будет включать содержимое данных.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x06001021 RID: 4129 RVA: 0x000673BC File Offset: 0x000655BC
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateCDataSection(this.Data);
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001022 RID: 4130 RVA: 0x000673CF File Offset: 0x000655CF
		public override void WriteTo(XmlWriter w)
		{
			w.WriteCData(this.Data);
		}

		/// <summary>
		///         Сохраняет дочерние узлы в заданном классе <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001023 RID: 4131 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00067362 File Offset: 0x00065562
		internal override XPathNodeType XPNodeType
		{
			get
			{
				return XPathNodeType.Text;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0001222F File Offset: 0x0001042F
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
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000673DD File Offset: 0x000655DD
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
