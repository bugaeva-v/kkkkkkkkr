using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Unity;

namespace System.Xml
{
	/// <summary>
	///         Представляет коллекцию атрибутов, к которым можно обращаться по имени или индексу.
	///       </summary>
	// Token: 0x020001B5 RID: 437
	public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x00066B3C File Offset: 0x00064D3C
		internal XmlAttributeCollection(XmlNode parent) : base(parent)
		{
		}

		/// <summary>
		///         Возвращает атрибут с указанным индексом.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.XmlAttribute" /> по указанному индексу.
		///       </returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///             Передаваемый индекс находится вне диапазона.
		///           </exception>
		// Token: 0x1700028B RID: 651
		[IndexerName("ItemOf")]
		public XmlAttribute this[int i]
		{
			get
			{
				XmlAttribute result;
				try
				{
					result = (XmlAttribute)this.nodes[i];
				}
				catch (ArgumentOutOfRangeException)
				{
					throw new IndexOutOfRangeException(Res.GetString("The index being passed in is out of range."));
				}
				return result;
			}
		}

		/// <summary>
		///         Возвращает атрибут с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.XmlAttribute" /> с указанным именем.
		///          Если атрибут отсутствует, это свойство возвращает <see langword="null" />.
		///       </returns>
		// Token: 0x1700028C RID: 652
		[IndexerName("ItemOf")]
		public XmlAttribute this[string name]
		{
			get
			{
				int hashCode = XmlName.GetHashCode(name);
				for (int i = 0; i < this.nodes.Count; i++)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
					if (hashCode == xmlAttribute.LocalNameHash && name == xmlAttribute.Name)
					{
						return xmlAttribute;
					}
				}
				return null;
			}
		}

		/// <summary>
		///         Возвращает атрибут с заданным локальным именем и пространством имен универсальный код ресурса (URI).
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlAttribute" /> С заданным локальным именем и URI пространства имен.
		///          Если атрибут отсутствует, это свойство возвращает <see langword="null" />.
		///       </returns>
		// Token: 0x1700028D RID: 653
		[IndexerName("ItemOf")]
		public XmlAttribute this[string localName, string namespaceURI]
		{
			get
			{
				int hashCode = XmlName.GetHashCode(localName);
				for (int i = 0; i < this.nodes.Count; i++)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
					if (hashCode == xmlAttribute.LocalNameHash && localName == xmlAttribute.LocalName && namespaceURI == xmlAttribute.NamespaceURI)
					{
						return xmlAttribute;
					}
				}
				return null;
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00066C48 File Offset: 0x00064E48
		internal int FindNodeOffset(XmlAttribute node)
		{
			for (int i = 0; i < this.nodes.Count; i++)
			{
				XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
				if (xmlAttribute.LocalNameHash == node.LocalNameHash && xmlAttribute.Name == node.Name && xmlAttribute.NamespaceURI == node.NamespaceURI)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00066CB4 File Offset: 0x00064EB4
		internal int FindNodeOffsetNS(XmlAttribute node)
		{
			for (int i = 0; i < this.nodes.Count; i++)
			{
				XmlAttribute xmlAttribute = (XmlAttribute)this.nodes[i];
				if (xmlAttribute.LocalNameHash == node.LocalNameHash && xmlAttribute.LocalName == node.LocalName && xmlAttribute.NamespaceURI == node.NamespaceURI)
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.XmlNode" /> с помощью его <see cref="P:System.Xml.XmlNode.Name" /> свойство 
		///       </summary>
		/// <param name="node">
		///           Узел атрибута для хранения в этой коллекции.
		///            Позже этот узел будет доступен по своему имени узла.
		///            Если узел с таким именем уже существует в коллекции, он замещается новый; в противном случае — узел добавляется в конец коллекции.
		///         </param>
		/// <returns>
		///         Если <paramref name="node" /> заменяет существующий узел с таким же именем, старый узел возвращен; в противном случае, возвращается добавленный узел.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="node" /> был создан из другого <see cref="T:System.Xml.XmlDocument" /> от того, который создал данную коллекцию.
		///
		///             Это <see langword="XmlAttributeCollection" /> доступно только для чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="node" /> — <see cref="T:System.Xml.XmlAttribute" /> уже является атрибутом другого <see cref="T:System.Xml.XmlElement" /> объекта.
		///              Для повторного использования атрибутов в других элементах необходимо клонировать <see langword="XmlAttribute" /> объектов вы хотите повторно использовать.
		///           </exception>
		// Token: 0x06001004 RID: 4100 RVA: 0x00066D20 File Offset: 0x00064F20
		public override XmlNode SetNamedItem(XmlNode node)
		{
			if (node != null && !(node is XmlAttribute))
			{
				throw new ArgumentException(Res.GetString("An 'Attributes' collection can only contain 'Attribute' objects."));
			}
			int num = base.FindNodeOffset(node.LocalName, node.NamespaceURI);
			if (num == -1)
			{
				return this.InternalAppendAttribute((XmlAttribute)node);
			}
			XmlNode result = base.RemoveNodeAt(num);
			this.InsertNodeAt(num, node);
			return result;
		}

		/// <summary>
		///         Вставляет указанный атрибут как первый узел в коллекции.
		///       </summary>
		/// <param name="node">
		///           Вставляемый объект <see cref="T:System.Xml.XmlAttribute" />.
		///         </param>
		/// <returns>
		///         <see langword="XmlAttribute" /> Добавляются в коллекцию.
		///       </returns>
		// Token: 0x06001005 RID: 4101 RVA: 0x00066D7C File Offset: 0x00064F7C
		public XmlAttribute Prepend(XmlAttribute node)
		{
			if (node.OwnerDocument != null && node.OwnerDocument != this.parent.OwnerDocument)
			{
				throw new ArgumentException(Res.GetString("The named node is from a different document context."));
			}
			if (node.OwnerElement != null)
			{
				this.Detach(node);
			}
			this.RemoveDuplicateAttribute(node);
			this.InsertNodeAt(0, node);
			return node;
		}

		/// <summary>
		///         Вставляет указанный атрибут как последний узел в коллекции.
		///       </summary>
		/// <param name="node">
		///           Вставляемый объект <see cref="T:System.Xml.XmlAttribute" />.
		///         </param>
		/// <returns>
		///         <see langword="XmlAttribute" /> Для добавления в коллекцию.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="node" /> был создан из документа, отличающегося от того, который создал данную коллекцию.
		///           </exception>
		// Token: 0x06001006 RID: 4102 RVA: 0x00066DD8 File Offset: 0x00064FD8
		public XmlAttribute Append(XmlAttribute node)
		{
			XmlDocument ownerDocument = node.OwnerDocument;
			if (ownerDocument == null || !ownerDocument.IsLoading)
			{
				if (ownerDocument != null && ownerDocument != this.parent.OwnerDocument)
				{
					throw new ArgumentException(Res.GetString("The named node is from a different document context."));
				}
				if (node.OwnerElement != null)
				{
					this.Detach(node);
				}
				this.AddNode(node);
			}
			else
			{
				base.AddNodeForLoad(node, ownerDocument);
				this.InsertParentIntoElementIdAttrMap(node);
			}
			return node;
		}

		/// <summary>
		///         Вставляет указанный атрибут непосредственно перед заданным атрибутом ссылки.
		///       </summary>
		/// <param name="newNode">
		///           Вставляемый объект <see cref="T:System.Xml.XmlAttribute" />.
		///         </param>
		/// <param name="refNode">
		///           <see cref="T:System.Xml.XmlAttribute" /> Это ссылочный атрибут.
		///           <paramref name="newNode" /> размещен перед <paramref name="refNode" />.
		///         </param>
		/// <returns>
		///         <see langword="XmlAttribute" /> Для вставки в коллекцию.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newNode" /> Был создан из документа, отличающегося от того, который создал данную коллекцию.
		///              Или <paramref name="refNode" /> не является членом данной коллекции.
		///           </exception>
		// Token: 0x06001007 RID: 4103 RVA: 0x00066E44 File Offset: 0x00065044
		public XmlAttribute InsertBefore(XmlAttribute newNode, XmlAttribute refNode)
		{
			if (newNode == refNode)
			{
				return newNode;
			}
			if (refNode == null)
			{
				return this.Append(newNode);
			}
			if (refNode.OwnerElement != this.parent)
			{
				throw new ArgumentException(Res.GetString("The reference node must be a child of the current node."));
			}
			if (newNode.OwnerDocument != null && newNode.OwnerDocument != this.parent.OwnerDocument)
			{
				throw new ArgumentException(Res.GetString("The named node is from a different document context."));
			}
			if (newNode.OwnerElement != null)
			{
				this.Detach(newNode);
			}
			int num = base.FindNodeOffset(refNode.LocalName, refNode.NamespaceURI);
			int num2 = this.RemoveDuplicateAttribute(newNode);
			if (num2 >= 0 && num2 < num)
			{
				num--;
			}
			this.InsertNodeAt(num, newNode);
			return newNode;
		}

		/// <summary>
		///         Вставляет указанный атрибут непосредственно после заданного атрибута ссылки.
		///       </summary>
		/// <param name="newNode">
		///           Вставляемый объект <see cref="T:System.Xml.XmlAttribute" />.
		///         </param>
		/// <param name="refNode">
		///           <see cref="T:System.Xml.XmlAttribute" /> Это ссылочный атрибут.
		///           <paramref name="newNode" /> располагается после <paramref name="refNode" />.
		///         </param>
		/// <returns>
		///         <see langword="XmlAttribute" /> Для вставки в коллекцию.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newNode" /> Был создан из документа, отличающегося от того, который создал данную коллекцию.
		///              Или <paramref name="refNode" /> не является членом данной коллекции.
		///           </exception>
		// Token: 0x06001008 RID: 4104 RVA: 0x00066EEC File Offset: 0x000650EC
		public XmlAttribute InsertAfter(XmlAttribute newNode, XmlAttribute refNode)
		{
			if (newNode == refNode)
			{
				return newNode;
			}
			if (refNode == null)
			{
				return this.Prepend(newNode);
			}
			if (refNode.OwnerElement != this.parent)
			{
				throw new ArgumentException(Res.GetString("The reference node must be a child of the current node."));
			}
			if (newNode.OwnerDocument != null && newNode.OwnerDocument != this.parent.OwnerDocument)
			{
				throw new ArgumentException(Res.GetString("The named node is from a different document context."));
			}
			if (newNode.OwnerElement != null)
			{
				this.Detach(newNode);
			}
			int num = base.FindNodeOffset(refNode.LocalName, refNode.NamespaceURI);
			int num2 = this.RemoveDuplicateAttribute(newNode);
			if (num2 >= 0 && num2 < num)
			{
				num--;
			}
			this.InsertNodeAt(num + 1, newNode);
			return newNode;
		}

		/// <summary>
		///         Удаляет указанный атрибут из коллекции.
		///       </summary>
		/// <param name="node">
		///           Объект <see cref="T:System.Xml.XmlAttribute" /> для удаления.
		///         </param>
		/// <returns>
		///         Удаленный узел или <see langword="null" /> если он не найден в коллекции.
		///       </returns>
		// Token: 0x06001009 RID: 4105 RVA: 0x00066F98 File Offset: 0x00065198
		public XmlAttribute Remove(XmlAttribute node)
		{
			int count = this.nodes.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.nodes[i] == node)
				{
					this.RemoveNodeAt(i);
					return node;
				}
			}
			return null;
		}

		/// <summary>
		///         Удаляет атрибут, соответствующий указанному индексу из коллекции.
		///       </summary>
		/// <param name="i">
		///           Индекс удаляемого узла.
		///            Первый узел имеет индекс 0.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="null" /> если не существует атрибута с указанным индексом.
		///       </returns>
		// Token: 0x0600100A RID: 4106 RVA: 0x00066FD7 File Offset: 0x000651D7
		public XmlAttribute RemoveAt(int i)
		{
			if (i < 0 || i >= this.Count)
			{
				return null;
			}
			return (XmlAttribute)this.RemoveNodeAt(i);
		}

		/// <summary>
		///         Удаляет все атрибуты из коллекции.
		///       </summary>
		// Token: 0x0600100B RID: 4107 RVA: 0x00066FF4 File Offset: 0x000651F4
		public void RemoveAll()
		{
			int i = this.Count;
			while (i > 0)
			{
				i--;
				this.RemoveAt(i);
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.XmlAttributeCollection.CopyTo(System.Xml.XmlAttribute[],System.Int32)" />.
		///       </summary>
		/// <param name="array">
		///           Массив, который является конечным для объектов, копируемых из этой коллекции.
		///         </param>
		/// <param name="index">
		///           Индекс в массиве, с которого начинается копирование.
		///         </param>
		// Token: 0x0600100C RID: 4108 RVA: 0x0006701C File Offset: 0x0006521C
		void ICollection.CopyTo(Array array, int index)
		{
			int i = 0;
			int count = this.Count;
			while (i < count)
			{
				array.SetValue(this.nodes[i], index);
				i++;
				index++;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#IsSynchronized" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> если коллекция синхронизирована.
		///       </returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#SyncRoot" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Object" /> это корень коллекции.
		///       </returns>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00002068 File Offset: 0x00000268
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.XmlAttributeCollection.System#Collections#ICollection#Count" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="int" /> содержащий количество атрибутов.
		///       </returns>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00067054 File Offset: 0x00065254
		int ICollection.Count
		{
			get
			{
				return base.Count;
			}
		}

		/// <summary>
		///         Копирует все <see cref="T:System.Xml.XmlAttribute" /> объектов из этой коллекции в заданный массив.
		///       </summary>
		/// <param name="array">
		///           Массив, который является конечным для объектов, копируемых из этой коллекции.
		///         </param>
		/// <param name="index">
		///           Индекс в массиве, с которого начинается копирование.
		///         </param>
		// Token: 0x06001010 RID: 4112 RVA: 0x0006705C File Offset: 0x0006525C
		public void CopyTo(XmlAttribute[] array, int index)
		{
			int i = 0;
			int count = this.Count;
			while (i < count)
			{
				array[index] = (XmlAttribute)((XmlNode)this.nodes[i]).CloneNode(true);
				i++;
				index++;
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000670A0 File Offset: 0x000652A0
		internal override XmlNode AddNode(XmlNode node)
		{
			this.RemoveDuplicateAttribute((XmlAttribute)node);
			XmlNode result = base.AddNode(node);
			this.InsertParentIntoElementIdAttrMap((XmlAttribute)node);
			return result;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000670C2 File Offset: 0x000652C2
		internal override XmlNode InsertNodeAt(int i, XmlNode node)
		{
			XmlNode result = base.InsertNodeAt(i, node);
			this.InsertParentIntoElementIdAttrMap((XmlAttribute)node);
			return result;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000670D8 File Offset: 0x000652D8
		internal override XmlNode RemoveNodeAt(int i)
		{
			XmlNode xmlNode = base.RemoveNodeAt(i);
			this.RemoveParentFromElementIdAttrMap((XmlAttribute)xmlNode);
			XmlAttribute defaultAttribute = this.parent.OwnerDocument.GetDefaultAttribute((XmlElement)this.parent, xmlNode.Prefix, xmlNode.LocalName, xmlNode.NamespaceURI);
			if (defaultAttribute != null)
			{
				this.InsertNodeAt(i, defaultAttribute);
			}
			return xmlNode;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00067134 File Offset: 0x00065334
		internal void Detach(XmlAttribute attr)
		{
			attr.OwnerElement.Attributes.Remove(attr);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00067148 File Offset: 0x00065348
		internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			if (xmlElement != null)
			{
				if (this.parent.OwnerDocument == null)
				{
					return;
				}
				XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
				if (idinfoByElement != null && idinfoByElement.Prefix == attr.XmlName.Prefix && idinfoByElement.LocalName == attr.XmlName.LocalName)
				{
					this.parent.OwnerDocument.AddElementWithId(attr.Value, xmlElement);
				}
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000671D4 File Offset: 0x000653D4
		internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			if (xmlElement != null)
			{
				if (this.parent.OwnerDocument == null)
				{
					return;
				}
				XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
				if (idinfoByElement != null && idinfoByElement.Prefix == attr.XmlName.Prefix && idinfoByElement.LocalName == attr.XmlName.LocalName)
				{
					this.parent.OwnerDocument.RemoveElementWithId(attr.Value, xmlElement);
				}
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00067260 File Offset: 0x00065460
		internal int RemoveDuplicateAttribute(XmlAttribute attr)
		{
			int num = base.FindNodeOffset(attr.LocalName, attr.NamespaceURI);
			if (num != -1)
			{
				XmlAttribute attr2 = (XmlAttribute)this.nodes[num];
				base.RemoveNodeAt(num);
				this.RemoveParentFromElementIdAttrMap(attr2);
			}
			return num;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000672A8 File Offset: 0x000654A8
		internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName)
		{
			XmlElement xmlElement = this.parent as XmlElement;
			XmlName idinfoByElement = this.parent.OwnerDocument.GetIDInfoByElement(xmlElement.XmlName);
			return idinfoByElement != null && idinfoByElement.Prefix == attrPrefix && idinfoByElement.LocalName == attrLocalName;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000672FC File Offset: 0x000654FC
		internal void ResetParentInElementIdAttrMap(string oldVal, string newVal)
		{
			XmlElement elem = this.parent as XmlElement;
			XmlDocument ownerDocument = this.parent.OwnerDocument;
			ownerDocument.RemoveElementWithId(oldVal, elem);
			ownerDocument.AddElementWithId(newVal, elem);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0006732F File Offset: 0x0006552F
		internal XmlAttribute InternalAppendAttribute(XmlAttribute node)
		{
			XmlNode xmlNode = base.AddNode(node);
			this.InsertParentIntoElementIdAttrMap(node);
			return (XmlAttribute)xmlNode;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlAttributeCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
