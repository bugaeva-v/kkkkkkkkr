using System;
using System.Configuration;

namespace System.Runtime.Serialization.Configuration
{
	/// <summary>Обрабатывает XML-элементы, используемые для настройки сериализации XML с помощью <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x020001A2 RID: 418
	[ConfigurationCollection(typeof(DeclaredTypeElement))]
	public sealed class DeclaredTypeElementCollection : ConfigurationElementCollection
	{
		/// <summary>Получает или задает элемент конфигурации в указанном расположении индекса.</summary>
		/// <param name="index">Расположение индекса возвращаемого элемента конфигурации.</param>
		/// <returns>Параметр <see cref="T:System.Runtime.Serialization.Configuration.DeclaredTypeElement" /> по указанному индексу.</returns>
		// Token: 0x17000464 RID: 1124
		public DeclaredTypeElement this[int index]
		{
			get
			{
				return (DeclaredTypeElement)base.BaseGet(index);
			}
			set
			{
				if (!this.IsReadOnly())
				{
					if (value == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
					}
					if (base.BaseGet(index) != null)
					{
						base.BaseRemoveAt(index);
					}
				}
				this.BaseAdd(index, value);
			}
		}

		/// <summary>Получает или задает элемент в коллекции типов по его ключу.</summary>
		/// <param name="typeName">Возвращаемое или задаваемое имя типа (выполняющее функцию ключа).</param>
		/// <returns>Заданный элемент (при возвращении элемента).</returns>
		// Token: 0x17000465 RID: 1125
		public DeclaredTypeElement this[string typeName]
		{
			get
			{
				if (string.IsNullOrEmpty(typeName))
				{
					throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeName");
				}
				return (DeclaredTypeElement)base.BaseGet(typeName);
			}
			set
			{
				if (!this.IsReadOnly())
				{
					if (string.IsNullOrEmpty(typeName))
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeName");
					}
					if (value == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("value");
					}
					if (base.BaseGet(typeName) == null)
					{
						throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new IndexOutOfRangeException(SR.GetString("For type '{0}', configuration index is out of range.", new object[]
						{
							typeName
						})));
					}
					base.BaseRemove(typeName);
				}
				this.Add(value);
			}
		}

		/// <summary>Добавляет заданный элемент конфигурации в коллекцию.</summary>
		/// <param name="element">Добавляемый элемент конфигурации.</param>
		// Token: 0x0600152B RID: 5419 RVA: 0x00053FFA File Offset: 0x000521FA
		public void Add(DeclaredTypeElement element)
		{
			if (!this.IsReadOnly() && element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			this.BaseAdd(element);
		}

		/// <summary>Удаляет все элементы из коллекции.</summary>
		// Token: 0x0600152C RID: 5420 RVA: 0x00054019 File Offset: 0x00052219
		public void Clear()
		{
			base.BaseClear();
		}

		/// <summary>Возвращает значение, указывающее, содержит ли коллекция заданный элемент.</summary>
		/// <param name="typeName">Имя типа, наличие которого проверяется.</param>
		/// <returns>Значение <see langword="true" />, если элемент имеется в коллекции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600152D RID: 5421 RVA: 0x00054021 File Offset: 0x00052221
		public bool Contains(string typeName)
		{
			if (string.IsNullOrEmpty(typeName))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeName");
			}
			return base.BaseGet(typeName) != null;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00054040 File Offset: 0x00052240
		protected override ConfigurationElement CreateNewElement()
		{
			return new DeclaredTypeElement();
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00054047 File Offset: 0x00052247
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			return ((DeclaredTypeElement)element).Type;
		}

		/// <summary>Возвращает позицию указанного элемента конфигурации.</summary>
		/// <param name="element">Элемент, который требуется найти в коллекции.</param>
		/// <returns>Индекс указанного элемента конфигурации; в противном случае — значение "-1".</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="element" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001530 RID: 5424 RVA: 0x00054062 File Offset: 0x00052262
		public int IndexOf(DeclaredTypeElement element)
		{
			if (element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет указанный элемент конфигурации из коллекции.</summary>
		/// <param name="element">Объект <see cref="T:System.Runtime.Serialization.Configuration.DeclaredTypeElement" /> для удаления.</param>
		// Token: 0x06001531 RID: 5425 RVA: 0x00054079 File Offset: 0x00052279
		public void Remove(DeclaredTypeElement element)
		{
			if (!this.IsReadOnly() && element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			base.BaseRemove(this.GetElementKey(element));
		}

		/// <summary>Удаляет элемент с указанным ключом из коллекции.</summary>
		/// <param name="typeName">Задает имя типа (выполняющего функцию ключа), удаляемого из коллекции.</param>
		// Token: 0x06001532 RID: 5426 RVA: 0x0005409E File Offset: 0x0005229E
		public void Remove(string typeName)
		{
			if (!this.IsReadOnly() && string.IsNullOrEmpty(typeName))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("typeName");
			}
			base.BaseRemove(typeName);
		}

		/// <summary>Удаляет элемент конфигурации, находящийся на заданной позиции.</summary>
		/// <param name="index">Позиция удаляемого элемента конфигурации.</param>
		// Token: 0x06001533 RID: 5427 RVA: 0x000540C2 File Offset: 0x000522C2
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
