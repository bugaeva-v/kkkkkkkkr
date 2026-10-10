using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Представляет коллекцию атрибутов.</summary>
	// Token: 0x0200037D RID: 893
	public class AttributeCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AttributeCollection" />.</summary>
		/// <param name="attributes">Массив элементов типа <see cref="T:System.Attribute" />, предоставляющий атрибуты для этой коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributes" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001D5C RID: 7516 RVA: 0x00068A38 File Offset: 0x00066C38
		public AttributeCollection(params Attribute[] attributes)
		{
			this._attributes = (attributes ?? Array.Empty<Attribute>());
			for (int i = 0; i < this._attributes.Length; i++)
			{
				if (this._attributes[i] == null)
				{
					throw new ArgumentNullException("attributes");
				}
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.AttributeCollection" />.</summary>
		// Token: 0x06001D5D RID: 7517 RVA: 0x0000219B File Offset: 0x0000039B
		protected AttributeCollection()
		{
		}

		/// <summary>Создает новую коллекцию <see cref="T:System.ComponentModel.AttributeCollection" /> из существующей коллекции <see cref="T:System.ComponentModel.AttributeCollection" />.</summary>
		/// <param name="existing">Коллекция <see cref="T:System.ComponentModel.AttributeCollection" />, используемая для создания копии.</param>
		/// <param name="newAttributes">Массив элементов типа <see cref="T:System.Attribute" />, предоставляющий атрибуты для этой коллекции. Может иметь значение <see langword="null" />.</param>
		/// <returns>Новая коллекция <see cref="T:System.ComponentModel.AttributeCollection" />, являющаяся копией коллекции <paramref name="existing" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="existing" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001D5E RID: 7518 RVA: 0x00068A84 File Offset: 0x00066C84
		public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
		{
			if (existing == null)
			{
				throw new ArgumentNullException("existing");
			}
			if (newAttributes == null)
			{
				newAttributes = Array.Empty<Attribute>();
			}
			Attribute[] array = new Attribute[existing.Count + newAttributes.Length];
			int count = existing.Count;
			existing.CopyTo(array, 0);
			for (int i = 0; i < newAttributes.Length; i++)
			{
				if (newAttributes[i] == null)
				{
					throw new ArgumentNullException("newAttributes");
				}
				bool flag = false;
				for (int j = 0; j < existing.Count; j++)
				{
					if (array[j].TypeId.Equals(newAttributes[i].TypeId))
					{
						flag = true;
						array[j] = newAttributes[i];
						break;
					}
				}
				if (!flag)
				{
					array[count++] = newAttributes[i];
				}
			}
			Attribute[] array2;
			if (count < array.Length)
			{
				array2 = new Attribute[count];
				Array.Copy(array, 0, array2, 0, count);
			}
			else
			{
				array2 = array;
			}
			return new AttributeCollection(array2);
		}

		/// <summary>Получает коллекцию атрибутов.</summary>
		/// <returns>Коллекция атрибутов.</returns>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00068B51 File Offset: 0x00066D51
		protected virtual Attribute[] Attributes
		{
			get
			{
				return this._attributes;
			}
		}

		/// <summary>Возвращает количество атрибутов.</summary>
		/// <returns>Количество атрибутов.</returns>
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00068B59 File Offset: 0x00066D59
		public int Count
		{
			get
			{
				return this.Attributes.Length;
			}
		}

		/// <summary>Возвращает атрибут с указанным номером индекса.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента <see cref="T:System.ComponentModel.AttributeCollection" />.</param>
		/// <returns>Объект <see cref="T:System.Attribute" /> с заданным индексом.</returns>
		// Token: 0x170005EA RID: 1514
		public virtual Attribute this[int index]
		{
			get
			{
				return this.Attributes[index];
			}
		}

		/// <summary>Возвращает атрибут указанного типа.</summary>
		/// <param name="attributeType">Тип <see cref="T:System.Type" /> атрибута <see cref="T:System.Attribute" />, извлекаемого из коллекции.</param>
		/// <returns>Возвращает атрибут <see cref="T:System.Attribute" /> указанного типа, а если такого атрибута не существует, то значение по умолчанию для типа этого атрибута.</returns>
		// Token: 0x170005EB RID: 1515
		public virtual Attribute this[Type attributeType]
		{
			get
			{
				object obj = AttributeCollection.s_internalSyncObject;
				Attribute defaultAttribute;
				lock (obj)
				{
					if (this._foundAttributeTypes == null)
					{
						this._foundAttributeTypes = new AttributeCollection.AttributeEntry[5];
					}
					int i = 0;
					while (i < 5)
					{
						if (this._foundAttributeTypes[i].type == attributeType)
						{
							int index = this._foundAttributeTypes[i].index;
							if (index != -1)
							{
								return this.Attributes[index];
							}
							return this.GetDefaultAttribute(attributeType);
						}
						else
						{
							if (this._foundAttributeTypes[i].type == null)
							{
								break;
							}
							i++;
						}
					}
					int index2 = this._index;
					this._index = index2 + 1;
					i = index2;
					if (this._index >= 5)
					{
						this._index = 0;
					}
					this._foundAttributeTypes[i].type = attributeType;
					int num = this.Attributes.Length;
					for (int j = 0; j < num; j++)
					{
						Attribute attribute = this.Attributes[j];
						if (attribute.GetType() == attributeType)
						{
							this._foundAttributeTypes[i].index = j;
							return attribute;
						}
					}
					for (int k = 0; k < num; k++)
					{
						Attribute attribute2 = this.Attributes[k];
						if (attributeType.IsInstanceOfType(attribute2))
						{
							this._foundAttributeTypes[i].index = k;
							return attribute2;
						}
					}
					this._foundAttributeTypes[i].index = -1;
					defaultAttribute = this.GetDefaultAttribute(attributeType);
				}
				return defaultAttribute;
			}
		}

		/// <summary>Определяет, содержит ли коллекция атрибутов указанный атрибут.</summary>
		/// <param name="attribute">Элемент класса <see cref="T:System.Attribute" />, который нужно найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит атрибут или является атрибутом по умолчанию для этого типа атрибута; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D63 RID: 7523 RVA: 0x00068D1C File Offset: 0x00066F1C
		public bool Contains(Attribute attribute)
		{
			Attribute attribute2 = this[attribute.GetType()];
			return attribute2 != null && attribute2.Equals(attribute);
		}

		/// <summary>Определяет, содержит ли коллекция атрибутов все указанные атрибуты в массиве атрибутов.</summary>
		/// <param name="attributes">Массив элементов типа <see cref="T:System.Attribute" />, которые нужно найти в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если коллекция содержит все атрибуты; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D64 RID: 7524 RVA: 0x00068D44 File Offset: 0x00066F44
		public bool Contains(Attribute[] attributes)
		{
			if (attributes == null)
			{
				return true;
			}
			for (int i = 0; i < attributes.Length; i++)
			{
				if (!this.Contains(attributes[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает <see cref="T:System.Attribute" /> по умолчанию с заданным типом <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">Тип <see cref="T:System.Type" /> извлекаемого атрибута.</param>
		/// <returns>
		///   <see cref="T:System.Attribute" /> по умолчанию с заданным типом <paramref name="attributeType" />.</returns>
		// Token: 0x06001D65 RID: 7525 RVA: 0x00068D74 File Offset: 0x00066F74
		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			object obj = AttributeCollection.s_internalSyncObject;
			Attribute result;
			lock (obj)
			{
				if (AttributeCollection.s_defaultAttributes == null)
				{
					AttributeCollection.s_defaultAttributes = new Hashtable();
				}
				if (AttributeCollection.s_defaultAttributes.ContainsKey(attributeType))
				{
					result = (Attribute)AttributeCollection.s_defaultAttributes[attributeType];
				}
				else
				{
					Attribute attribute = null;
					Type reflectionType = TypeDescriptor.GetReflectionType(attributeType);
					FieldInfo field = reflectionType.GetField("Default", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField);
					if (field != null && field.IsStatic)
					{
						attribute = (Attribute)field.GetValue(null);
					}
					else
					{
						ConstructorInfo constructor = reflectionType.UnderlyingSystemType.GetConstructor(Array.Empty<Type>());
						if (constructor != null)
						{
							attribute = (Attribute)constructor.Invoke(Array.Empty<object>());
							if (!attribute.IsDefaultAttribute())
							{
								attribute = null;
							}
						}
					}
					AttributeCollection.s_defaultAttributes[attributeType] = attribute;
					result = attribute;
				}
			}
			return result;
		}

		/// <summary>Возвращает перечислитель для этой коллекции.</summary>
		/// <returns>Перечислитель типа <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06001D66 RID: 7526 RVA: 0x00068E6C File Offset: 0x0006706C
		public IEnumerator GetEnumerator()
		{
			return this.Attributes.GetEnumerator();
		}

		/// <summary>Определяет, совпадает ли указанный атрибут с атрибутом в коллекции.</summary>
		/// <param name="attribute">Экземпляр атрибута <see cref="T:System.Attribute" />, сравниваемый с атрибутами в коллекции.</param>
		/// <returns>Значение <see langword="true" />, если атрибут содержится в коллекции и имеет то же значение, что и атрибут в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D67 RID: 7527 RVA: 0x00068E7C File Offset: 0x0006707C
		public bool Matches(Attribute attribute)
		{
			for (int i = 0; i < this.Attributes.Length; i++)
			{
				if (this.Attributes[i].Match(attribute))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, совпадают ли атрибуты в указанном массиве атрибутов с атрибутами в коллекции.</summary>
		/// <param name="attributes">Массив атрибутов <see cref="T:System.CodeDom.MemberAttributes" />, сравниваемых с атрибутами в этой коллекции.</param>
		/// <returns>Значение <see langword="true" />, если все атрибуты, входящие в массив, содержатся в коллекции и их значения совпадают со значениями атрибутов в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D68 RID: 7528 RVA: 0x00068EB0 File Offset: 0x000670B0
		public bool Matches(Attribute[] attributes)
		{
			for (int i = 0; i < attributes.Length; i++)
			{
				if (!this.Matches(attributes[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает значение, указывающее на то, синхронизирован ли доступ к коллекции (потокобезопасный).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к коллекции является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00068ED9 File Offset: 0x000670D9
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IEnumerator" /> для словаря <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06001D6C RID: 7532 RVA: 0x00068EE1 File Offset: 0x000670E1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Копирует коллекцию в массив, начиная с указанного индекса.</summary>
		/// <param name="array">Массив <see cref="T:System.Array" />, в который копируется коллекция.</param>
		/// <param name="index">Начальный индекс.</param>
		// Token: 0x06001D6D RID: 7533 RVA: 0x00068EE9 File Offset: 0x000670E9
		public void CopyTo(Array array, int index)
		{
			Array.Copy(this.Attributes, 0, array, index, this.Attributes.Length);
		}

		/// <summary>Определяет пустую коллекцию, которую можно использовать, не прибегая к созданию новой. Это поле доступно только для чтения.</summary>
		// Token: 0x04000ED1 RID: 3793
		public static readonly AttributeCollection Empty = new AttributeCollection(null);

		// Token: 0x04000ED2 RID: 3794
		private static Hashtable s_defaultAttributes;

		// Token: 0x04000ED3 RID: 3795
		private readonly Attribute[] _attributes;

		// Token: 0x04000ED4 RID: 3796
		private static readonly object s_internalSyncObject = new object();

		// Token: 0x04000ED5 RID: 3797
		private const int FOUND_TYPES_LIMIT = 5;

		// Token: 0x04000ED6 RID: 3798
		private AttributeCollection.AttributeEntry[] _foundAttributeTypes;

		// Token: 0x04000ED7 RID: 3799
		private int _index;

		// Token: 0x0200037E RID: 894
		private struct AttributeEntry
		{
			// Token: 0x04000ED8 RID: 3800
			public Type type;

			// Token: 0x04000ED9 RID: 3801
			public int index;
		}
	}
}
