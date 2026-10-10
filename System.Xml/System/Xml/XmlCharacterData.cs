using System;
using System.Text;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет методы обработки текста, которые используются несколькими классами.
	///       </summary>
	// Token: 0x020001B7 RID: 439
	public abstract class XmlCharacterData : XmlLinkedNode
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlCharacterData" />.
		///       </summary>
		/// <param name="data">
		///           Строка, содержащая символьные данные должны быть добавлены к документу.
		///         </param>
		/// <param name="doc">
		///           <see cref="T:System.Xml.XmlDocument" /> для хранения символьных данных.
		///         </param>
		// Token: 0x06001027 RID: 4135 RVA: 0x000673F4 File Offset: 0x000655F4
		protected internal XmlCharacterData(string data, XmlDocument doc) : base(doc)
		{
			this.data = data;
		}

		/// <summary>
		///         Возвращает или задает значение узла.
		///       </summary>
		/// <returns>
		///         Значение узла.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Узел доступен только для чтения.
		///           </exception>
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00067404 File Offset: 0x00065604
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x0006740C File Offset: 0x0006560C
		public override string Value
		{
			get
			{
				return this.Data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>
		///         Возвращает или задает сцепленные значения узла и всех дочерних элементов узла.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения узла и всех дочерних элементов узла.
		///       </returns>
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00067415 File Offset: 0x00065615
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x0006741D File Offset: 0x0006561D
		public override string InnerText
		{
			get
			{
				return this.Value;
			}
			set
			{
				this.Value = value;
			}
		}

		/// <summary>
		///         Содержит данные узла.
		///       </summary>
		/// <returns>
		///         Данные узла.
		///       </returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00067426 File Offset: 0x00065626
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x0006743C File Offset: 0x0006563C
		public virtual string Data
		{
			get
			{
				if (this.data != null)
				{
					return this.data;
				}
				return string.Empty;
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
		///         Возвращает длину данных в символах.
		///       </summary>
		/// <returns>
		///         Длина в символах, строки в <see cref="P:System.Xml.XmlCharacterData.Data" /> свойство.
		///          Длина может быть равно нулю; то есть узлы CharacterData может быть пустым.
		///       </returns>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0006747D File Offset: 0x0006567D
		public virtual int Length
		{
			get
			{
				if (this.data != null)
				{
					return this.data.Length;
				}
				return 0;
			}
		}

		/// <summary>
		///         Извлекает подстроку полной строки из заданного диапазона.
		///       </summary>
		/// <param name="offset">
		///           Позиция в строке, чтобы начать получение.
		///            Нулевое смещение указывает начальную точку в начале данных.
		///         </param>
		/// <param name="count">
		///           Число символов для извлечения.
		///         </param>
		/// <returns>
		///         Подстрока, соответствующая указанного диапазона.
		///       </returns>
		// Token: 0x0600102F RID: 4143 RVA: 0x00067494 File Offset: 0x00065694
		public virtual string Substring(int offset, int count)
		{
			int num = (this.data != null) ? this.data.Length : 0;
			if (num > 0)
			{
				if (num < offset + count)
				{
					count = num - offset;
				}
				return this.data.Substring(offset, count);
			}
			return string.Empty;
		}

		/// <summary>
		///         Добавляет указанную строку в конец знаковых данных узла.
		///       </summary>
		/// <param name="strData">
		///           Строка, вставляемая в существующую строку.
		///         </param>
		// Token: 0x06001030 RID: 4144 RVA: 0x000674DC File Offset: 0x000656DC
		public virtual void AppendData(string strData)
		{
			XmlNode parentNode = this.ParentNode;
			int num = (this.data != null) ? this.data.Length : 0;
			if (strData != null)
			{
				num += strData.Length;
			}
			string newValue = new StringBuilder(num).Append(this.data).Append(strData).ToString();
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, newValue, XmlNodeChangedAction.Change);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			this.data = newValue;
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
		}

		/// <summary>
		///         Вставляет указанную строку с позиции указанного символа.
		///       </summary>
		/// <param name="offset">
		///           Позиция в строке для вставки предлагаемых данных строки.
		///         </param>
		/// <param name="strData">
		///           Строковые данные, которые необходимо вставить в существующую строку.
		///         </param>
		// Token: 0x06001031 RID: 4145 RVA: 0x00067560 File Offset: 0x00065760
		public virtual void InsertData(int offset, string strData)
		{
			XmlNode parentNode = this.ParentNode;
			int num = (this.data != null) ? this.data.Length : 0;
			if (strData != null)
			{
				num += strData.Length;
			}
			string newValue = new StringBuilder(num).Append(this.data).Insert(offset, strData).ToString();
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, newValue, XmlNodeChangedAction.Change);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			this.data = newValue;
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
		}

		/// <summary>
		///         Удаляет диапазон символов из узла.
		///       </summary>
		/// <param name="offset">
		///           Позиция в строке, чтобы начать удаление.
		///         </param>
		/// <param name="count">
		///           Число символов для удаления.
		///         </param>
		// Token: 0x06001032 RID: 4146 RVA: 0x000675E4 File Offset: 0x000657E4
		public virtual void DeleteData(int offset, int count)
		{
			int num = (this.data != null) ? this.data.Length : 0;
			if (num > 0 && num < offset + count)
			{
				count = Math.Max(num - offset, 0);
			}
			string newValue = new StringBuilder(this.data).Remove(offset, count).ToString();
			XmlNode parentNode = this.ParentNode;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, newValue, XmlNodeChangedAction.Change);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			this.data = newValue;
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
		}

		/// <summary>
		///         Заменяет указанное число знаков, начиная с указанного смещения в заданной строке.
		///       </summary>
		/// <param name="offset">
		///           Позиция в строке, чтобы начать поиск и замену.
		///         </param>
		/// <param name="count">
		///           Число знаков для замены.
		///         </param>
		/// <param name="strData">
		///           Новые данные, заменяющие старые данные строки.
		///         </param>
		// Token: 0x06001033 RID: 4147 RVA: 0x0006766C File Offset: 0x0006586C
		public virtual void ReplaceData(int offset, int count, string strData)
		{
			int num = (this.data != null) ? this.data.Length : 0;
			if (num > 0 && num < offset + count)
			{
				count = Math.Max(num - offset, 0);
			}
			string newValue = new StringBuilder(this.data).Remove(offset, count).Insert(offset, strData).ToString();
			XmlNode parentNode = this.ParentNode;
			XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, newValue, XmlNodeChangedAction.Change);
			if (eventArgs != null)
			{
				this.BeforeEvent(eventArgs);
			}
			this.data = newValue;
			if (eventArgs != null)
			{
				this.AfterEvent(eventArgs);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000676F8 File Offset: 0x000658F8
		internal bool CheckOnData(string data)
		{
			return XmlCharType.Instance.IsOnlyWhitespace(data);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00067714 File Offset: 0x00065914
		internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt)
		{
			while (node != null)
			{
				XmlNodeType nodeType = node.NodeType;
				if (nodeType <= XmlNodeType.EntityReference)
				{
					if (nodeType - XmlNodeType.Text <= 1)
					{
						xnt = XPathNodeType.Text;
						return false;
					}
					if (nodeType != XmlNodeType.EntityReference)
					{
						return false;
					}
					if (!this.DecideXPNodeTypeForTextNodes(node.FirstChild, ref xnt))
					{
						return false;
					}
				}
				else if (nodeType != XmlNodeType.Whitespace)
				{
					if (nodeType != XmlNodeType.SignificantWhitespace)
					{
						return false;
					}
					xnt = XPathNodeType.SignificantWhitespace;
				}
				node = node.NextSibling;
			}
			return true;
		}

		// Token: 0x0400103C RID: 4156
		private string data;
	}
}
