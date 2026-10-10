using System;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет данные для <see cref="E:System.Xml.XmlDocument.NodeChanged" />, <see cref="E:System.Xml.XmlDocument.NodeChanging" />, <see cref="E:System.Xml.XmlDocument.NodeInserted" />, <see cref="E:System.Xml.XmlDocument.NodeInserting" />, <see cref="E:System.Xml.XmlDocument.NodeRemoved" /> и <see cref="E:System.Xml.XmlDocument.NodeRemoving" /> события.
	///       </summary>
	// Token: 0x020001D2 RID: 466
	public class XmlNodeChangedEventArgs : EventArgs
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlNodeChangedEventArgs" />.
		///       </summary>
		/// <param name="node">
		///           <see cref="T:System.Xml.XmlNode" /> Создавший событие.
		///         </param>
		/// <param name="oldParent">
		///           Старый родительский элемент <see cref="T:System.Xml.XmlNode" /> из <see cref="T:System.Xml.XmlNode" /> создавший событие.
		///         </param>
		/// <param name="newParent">
		///           Новый родительский <see cref="T:System.Xml.XmlNode" /> из <see cref="T:System.Xml.XmlNode" /> создавший событие.
		///         </param>
		/// <param name="oldValue">
		///           Старое значение <see cref="T:System.Xml.XmlNode" /> создавший событие.
		///         </param>
		/// <param name="newValue">
		///           Новое значение <see cref="T:System.Xml.XmlNode" /> создавший событие.
		///         </param>
		/// <param name="action">
		///           <see cref="T:System.Xml.XmlNodeChangedAction" />.
		///         </param>
		// Token: 0x06001238 RID: 4664 RVA: 0x0006E4AA File Offset: 0x0006C6AA
		public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			this.node = node;
			this.oldParent = oldParent;
			this.newParent = newParent;
			this.action = action;
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		/// <summary>
		///         Возвращает значение, указывающее тип события изменения узла происходящих.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNodeChangedAction" /> Значение, описывающее узел события изменения.
		///
		///                 Значение XmlNodeChangedAction 
		///
		///                 Описание 
		///
		///                 Insert 
		///
		///                 Узел был или будет вставлен.
		///
		///                 Удалить 
		///
		///                 Узел был или будет удален.
		///
		///                 Изменение 
		///
		///                 Узел был или будет изменен.
		///
		///           <see langword="Action" /> Значение не различает, когда произошло событие (до или после).
		///            Можно создать отдельные обработчики событий для обработки обоих экземпляров.
		///         </returns>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0006E4DF File Offset: 0x0006C6DF
		public XmlNodeChangedAction Action
		{
			get
			{
				return this.action;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNode" /> был добавлен, удален или изменен.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNode" /> Был добавлен, удален или изменен, и это свойство никогда не возвращает <see langword="null" />.
		///       </returns>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0006E4E7 File Offset: 0x0006C6E7
		public XmlNode Node
		{
			get
			{
				return this.node;
			}
		}

		/// <summary>
		///         Возвращает значение <see cref="P:System.Xml.XmlNode.ParentNode" /> перед началом операции.
		///       </summary>
		/// <returns>
		///         Значение <see langword="ParentNode" /> перед началом операции.
		///          Это свойство возвращает <see langword="null" /> если узел не имеет родительского узла.
		///
		///           Для узлов атрибутов это свойство возвращает <see cref="P:System.Xml.XmlAttribute.OwnerElement" />.
		///         </returns>
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x0006E4EF File Offset: 0x0006C6EF
		public XmlNode OldParent
		{
			get
			{
				return this.oldParent;
			}
		}

		/// <summary>
		///         Возвращает значение <see cref="P:System.Xml.XmlNode.ParentNode" /> после завершения операции.
		///       </summary>
		/// <returns>
		///         Значение <see langword="ParentNode" /> после завершения операции.
		///          Это свойство возвращает <see langword="null" /> Если удаленный узел.
		///
		///           Для узлов атрибутов это свойство возвращает <see cref="P:System.Xml.XmlAttribute.OwnerElement" />.
		///         </returns>
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0006E4F7 File Offset: 0x0006C6F7
		public XmlNode NewParent
		{
			get
			{
				return this.newParent;
			}
		}

		/// <summary>
		///         Возвращает исходное значение узла.
		///       </summary>
		/// <returns>
		///         Исходное значение узла.
		///          Это свойство возвращает <see langword="null" /> если узел не является атрибутом или узлом текста или при вставке узла.
		///
		///         При вызове <see cref="E:System.Xml.XmlDocument.NodeChanging" /> событий, <see langword="OldValue" /> возвращает текущее значение узла, который будет заменен, если изменение выполнено успешно.
		///          При вызове <see cref="E:System.Xml.XmlDocument.NodeChanged" /> событий, <see langword="OldValue" /> возвращает значение узла до внесения изменения.
		///       </returns>
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0006E4FF File Offset: 0x0006C6FF
		public string OldValue
		{
			get
			{
				return this.oldValue;
			}
		}

		/// <summary>
		///         Возвращает новое значение узла.
		///       </summary>
		/// <returns>
		///         Новое значение узла.
		///          Это свойство возвращает <see langword="null" /> Если узел не является ни атрибутом, ни текстовым узлом или если узел удаляется.
		///
		///         При вызове <see cref="E:System.Xml.XmlDocument.NodeChanging" /> событий, <see langword="NewValue" /> возвращает значение узла, если изменение выполнено успешно.
		///          При вызове <see cref="E:System.Xml.XmlDocument.NodeChanged" /> событий, <see langword="NewValue" /> возвращает значение текущего узла.
		///       </returns>
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0006E507 File Offset: 0x0006C707
		public string NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x040010B9 RID: 4281
		private XmlNodeChangedAction action;

		// Token: 0x040010BA RID: 4282
		private XmlNode node;

		// Token: 0x040010BB RID: 4283
		private XmlNode oldParent;

		// Token: 0x040010BC RID: 4284
		private XmlNode newParent;

		// Token: 0x040010BD RID: 4285
		private string oldValue;

		// Token: 0x040010BE RID: 4286
		private string newValue;
	}
}
