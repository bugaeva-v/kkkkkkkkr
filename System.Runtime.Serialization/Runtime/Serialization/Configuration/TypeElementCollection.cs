using System;
using System.Configuration;

namespace System.Runtime.Serialization.Configuration
{
	/// <summary>Обрабатывает XML-элементы, используемые для настройки известных типов, применяемых для сериализации с помощью <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
	// Token: 0x020001AA RID: 426
	[ConfigurationCollection(typeof(TypeElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
	public sealed class TypeElementCollection : ConfigurationElementCollection
	{
		/// <summary>Возвращает конкретный элемент коллекции с указанной позицией.</summary>
		/// <param name="index">Позиция возвращаемого элемента.</param>
		/// <returns>Элемент на заданной позиции.</returns>
		// Token: 0x17000477 RID: 1143
		public TypeElement this[int index]
		{
			get
			{
				return (TypeElement)base.BaseGet(index);
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

		/// <summary>Добавляет указанный элемент в коллекцию.</summary>
		/// <param name="element">Тип <see cref="T:System.Runtime.Serialization.Configuration.TypeElement" />, представляющий добавляемый известный тип.</param>
		// Token: 0x0600156A RID: 5482 RVA: 0x00053FFA File Offset: 0x000521FA
		public void Add(TypeElement element)
		{
			if (!this.IsReadOnly() && element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			this.BaseAdd(element);
		}

		/// <summary>Удаляет все элементы из коллекции.</summary>
		// Token: 0x0600156B RID: 5483 RVA: 0x00054019 File Offset: 0x00052219
		public void Clear()
		{
			base.BaseClear();
		}

		/// <summary>Возвращает коллекцию элементов, представляющую типы, использующие известные типы.</summary>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationElementCollectionType" />, содержащий объекты элемента.</returns>
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00003127 File Offset: 0x00001327
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000546F4 File Offset: 0x000528F4
		protected override ConfigurationElement CreateNewElement()
		{
			return new TypeElement();
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000546FB File Offset: 0x000528FB
		protected override string ElementName
		{
			get
			{
				return "knownType";
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00054702 File Offset: 0x00052902
		protected override object GetElementKey(ConfigurationElement element)
		{
			if (element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			return ((TypeElement)element).Key;
		}

		/// <summary>Возвращает позицию указанного элемента.</summary>
		/// <param name="element">Параметр <see cref="T:System.Runtime.Serialization.Configuration.TypeElement" /> для поиска в коллекции.</param>
		/// <returns>Позиция указанного элемента.</returns>
		// Token: 0x06001570 RID: 5488 RVA: 0x00054062 File Offset: 0x00052262
		public int IndexOf(TypeElement element)
		{
			if (element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			return base.BaseIndexOf(element);
		}

		/// <summary>Удаляет из коллекции указанный элемент.</summary>
		/// <param name="element">Объект <see cref="T:System.Runtime.Serialization.Configuration.TypeElement" /> для удаления.</param>
		// Token: 0x06001571 RID: 5489 RVA: 0x00054079 File Offset: 0x00052279
		public void Remove(TypeElement element)
		{
			if (!this.IsReadOnly() && element == null)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("element");
			}
			base.BaseRemove(this.GetElementKey(element));
		}

		/// <summary>Удаляет элемент на заданной позиции.</summary>
		/// <param name="index">Позиция в коллекции, из которой удаляется элемент.</param>
		// Token: 0x06001572 RID: 5490 RVA: 0x000540C2 File Offset: 0x000522C2
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}

		// Token: 0x04000A8A RID: 2698
		private const string KnownTypeConfig = "knownType";
	}
}
