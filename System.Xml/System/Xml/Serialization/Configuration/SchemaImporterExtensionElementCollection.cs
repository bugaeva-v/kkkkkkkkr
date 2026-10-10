using System;
using System.Configuration;

namespace System.Xml.Serialization.Configuration
{
	/// <summary>
	///         Обрабатывает элементы XML, используемые для настройки работы <see cref="T:System.Xml.Serialization.XmlSchemaImporter" />.
	///          Этот класс не наследуется.
	///       </summary>
	// Token: 0x0200031B RID: 795
	[ConfigurationCollection(typeof(SchemaImporterExtensionElement))]
	public sealed class SchemaImporterExtensionElementCollection : ConfigurationElementCollection
	{
		/// <summary>
		///         Возвращает или задает объект, который представляет XML-элемент по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс получаемого или задаваемого элемента XML.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> по указанному индексу.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> меньше нуля.
		///
		///             -или- 
		///
		///             Значение параметра <paramref name="index" /> больше или равно значению свойства <see langword="Count" />.
		///           </exception>
		// Token: 0x1700064A RID: 1610
		public SchemaImporterExtensionElement this[int index]
		{
			get
			{
				return (SchemaImporterExtensionElement)base.BaseGet(index);
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}

		/// <summary>
		///         Возвращает или задает элемент с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Имя получаемого или задаваемого элемента.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> с указанным именем.
		///       </returns>
		// Token: 0x1700064B RID: 1611
		public SchemaImporterExtensionElement this[string name]
		{
			get
			{
				return (SchemaImporterExtensionElement)base.BaseGet(name);
			}
			set
			{
				if (base.BaseGet(name) != null)
				{
					base.BaseRemove(name);
				}
				this.BaseAdd(value);
			}
		}

		/// <summary>
		///         Добавляет элемент в конец коллекции.
		///       </summary>
		/// <param name="element">
		///           Параметр <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> для добавления в коллекцию.
		///         </param>
		// Token: 0x060020D2 RID: 8402 RVA: 0x000D1ADC File Offset: 0x000CFCDC
		public void Add(SchemaImporterExtensionElement element)
		{
			this.BaseAdd(element);
		}

		/// <summary>
		///         Удаляет все элементы из коллекции.
		///       </summary>
		// Token: 0x060020D3 RID: 8403 RVA: 0x000D1AE5 File Offset: 0x000CFCE5
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000D1AED File Offset: 0x000CFCED
		protected override ConfigurationElement CreateNewElement()
		{
			return new SchemaImporterExtensionElement();
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000D1AF4 File Offset: 0x000CFCF4
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((SchemaImporterExtensionElement)element).Key;
		}

		/// <summary>
		///         Возвращает отсчитываемый от нуля индекс первого элемента в коллекции с указанным значением.
		///       </summary>
		/// <param name="element">
		///           Искомый объект <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" />.
		///         </param>
		/// <returns>
		///         Индекс найденного элемента.
		///       </returns>
		// Token: 0x060020D6 RID: 8406 RVA: 0x000D1B01 File Offset: 0x000CFD01
		public int IndexOf(SchemaImporterExtensionElement element)
		{
			return base.BaseIndexOf(element);
		}

		/// <summary>
		///         Удаляет первое вхождение заданного элемента из коллекции.
		///       </summary>
		/// <param name="element">
		///           Объект <see cref="T:System.Xml.Serialization.Configuration.SchemaImporterExtensionElement" /> для удаления.
		///         </param>
		// Token: 0x060020D7 RID: 8407 RVA: 0x000D1B0A File Offset: 0x000CFD0A
		public void Remove(SchemaImporterExtensionElement element)
		{
			base.BaseRemove(element.Key);
		}

		/// <summary>
		///         Удаляет элемент с указанным именем из коллекции.
		///       </summary>
		/// <param name="name">
		///           Имя удаляемого элемента.
		///         </param>
		// Token: 0x060020D8 RID: 8408 RVA: 0x000D1B18 File Offset: 0x000CFD18
		public void Remove(string name)
		{
			base.BaseRemove(name);
		}

		/// <summary>
		///         Удаляет элемент по указанному индексу из коллекции.
		///       </summary>
		/// <param name="index">
		///           Индекс удаляемого объекта.
		///         </param>
		// Token: 0x060020D9 RID: 8409 RVA: 0x000D1B21 File Offset: 0x000CFD21
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}
	}
}
