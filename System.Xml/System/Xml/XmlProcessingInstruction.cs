using System;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет инструкцию по обработке, которая определяется в XML для хранения в тексте документа сведений, относящихся к обработчику.
	///       </summary>
	// Token: 0x020001D9 RID: 473
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlProcessingInstruction" />.
		///       </summary>
		/// <param name="target">
		///           Цель инструкции обработки; в разделе <see cref="P:System.Xml.XmlProcessingInstruction.Target" /> свойство.
		///         </param>
		/// <param name="data">
		///           Содержимое инструкции; в разделе <see cref="P:System.Xml.XmlProcessingInstruction.Data" /> свойство.
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x060012C6 RID: 4806 RVA: 0x000706E6 File Offset: 0x0006E8E6
		protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc) : base(doc)
		{
			this.target = target;
			this.data = data;
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов инструкций по обработке это свойство возвращает цель инструкции по обработке.
		///       </returns>
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000706FD File Offset: 0x0006E8FD
		public override string Name
		{
			get
			{
				if (this.target != null)
				{
					return this.target;
				}
				return string.Empty;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов инструкций по обработке это свойство возвращает цель инструкции по обработке.
		///       </returns>
		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00067B4B File Offset: 0x00065D4B
		public override string LocalName
		{
			get
			{
				return this.Name;
			}
		}

		/// <summary>
		///         Возвращает или задает значение узла.
		///       </summary>
		/// <returns>
		///         Все содержимое инструкции по обработке, исключая цель.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Узел доступен только для чтения.
		///           </exception>
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00070713 File Offset: 0x0006E913
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x0007071B File Offset: 0x0006E91B
		public override string Value
		{
			get
			{
				return this.data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>
		///         Получает цель инструкции по обработке.
		///       </summary>
		/// <returns>
		///         Цель инструкции по обработке.
		///       </returns>
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00070724 File Offset: 0x0006E924
		public string Target
		{
			get
			{
				return this.target;
			}
		}

		/// <summary>
		///         Возвращает или задает содержимое инструкции по обработке, исключая цель.
		///       </summary>
		/// <returns>
		///         Содержимое инструкции по обработке, исключая цель.
		///       </returns>
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00070713 File Offset: 0x0006E913
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x0007072C File Offset: 0x0006E92C
		public string Data
		{
			get
			{
				return this.data;
			}
			set
			{
				XmlNode parentNode = this.ParentNode;
				XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, value, XmlNodeChangedAction.Change);
				if (eventArgs != null)
				{
					this.BeforeEvent(eventArgs);
				}
				this.data = value;
				if (eventArgs != null)
				{
					this.AfterEvent(eventArgs);
				}
			}
		}

		/// <summary>
		///         Возвращает или задает сцепленные значения узла и всех его дочерних узлов.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения узла и его дочерних узлов.
		///       </returns>
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00070713 File Offset: 0x0006E913
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x0007071B File Offset: 0x0006E91B
		public override string InnerText
		{
			get
			{
				return this.data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlProcessingInstruction" /> узлов, это значение равно XmlNodeType.ProcessingInstruction.
		///       </returns>
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x0007076D File Offset: 0x0006E96D
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.ProcessingInstruction;
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///         </param>
		/// <returns>
		///         Узел-дубликат.
		///       </returns>
		// Token: 0x060012D1 RID: 4817 RVA: 0x00070770 File Offset: 0x0006E970
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateProcessingInstruction(this.target, this.data);
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x060012D2 RID: 4818 RVA: 0x00070789 File Offset: 0x0006E989
		public override void WriteTo(XmlWriter w)
		{
			w.WriteProcessingInstruction(this.target, this.data);
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///          У узлов ProcessingInstruction отсутствуют дочерние узлы, поэтому этот метод не выполняет никаких действий.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x060012D3 RID: 4819 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00067B4B File Offset: 0x00065D4B
		internal override string XPLocalName
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0007076D File Offset: 0x0006E96D
		internal override XPathNodeType XPNodeType
		{
			get
			{
				return XPathNodeType.ProcessingInstruction;
			}
		}

		// Token: 0x040010E3 RID: 4323
		private string target;

		// Token: 0x040010E4 RID: 4324
		private string data;
	}
}
