using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет коллекцию объектов <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" />.
	///       </summary>
	// Token: 0x020002C8 RID: 712
	public class XmlArrayItemAttributes : CollectionBase
	{
		/// <summary>
		///         Возвращает или устанавливает элемент с указанным индексом.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс получаемого или задаваемого элемента коллекции.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> по указанному индексу.
		///       </returns>
		// Token: 0x17000547 RID: 1351
		public XmlArrayItemAttribute this[int index]
		{
			get
			{
				return (XmlArrayItemAttribute)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> в коллекцию.
		///       </summary>
		/// <param name="attribute">
		///           Параметр <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> для добавления в коллекцию.
		///         </param>
		/// <returns>
		///         Индекс добавляемого элемента.
		///       </returns>
		// Token: 0x06001B13 RID: 6931 RVA: 0x0009B522 File Offset: 0x00099722
		public int Add(XmlArrayItemAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		/// <summary>
		///         Вставляет <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> в коллекцию по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Индекс, по которому вставлен атрибут.
		///         </param>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" />  Для вставки.
		///         </param>
		// Token: 0x06001B14 RID: 6932 RVA: 0x0009B530 File Offset: 0x00099730
		public void Insert(int index, XmlArrayItemAttribute attribute)
		{
			base.List.Insert(index, attribute);
		}

		/// <summary>
		///         Возвращает отсчитываемый от нуля индекс первого вхождения указанного <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> в коллекции или -1, если атрибут не найден в коллекции.
		///       </summary>
		/// <param name="attribute">
		///           Объект <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> для поиска в коллекции.
		///         </param>
		/// <returns>
		///         Первый индекс <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> в коллекции или -1, если атрибут не найден в коллекции.
		///       </returns>
		// Token: 0x06001B15 RID: 6933 RVA: 0x0009B53F File Offset: 0x0009973F
		public int IndexOf(XmlArrayItemAttribute attribute)
		{
			return base.List.IndexOf(attribute);
		}

		/// <summary>
		///         Определяет, содержит ли коллекция указанный <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" />.
		///       </summary>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> Для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если коллекция содержит указанный <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001B16 RID: 6934 RVA: 0x0009B54D File Offset: 0x0009974D
		public bool Contains(XmlArrayItemAttribute attribute)
		{
			return base.List.Contains(attribute);
		}

		/// <summary>
		///         Удаляет <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> из коллекции, если он имеется.
		///       </summary>
		/// <param name="attribute">
		///           Объект <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> для удаления.
		///         </param>
		// Token: 0x06001B17 RID: 6935 RVA: 0x0009B55B File Offset: 0x0009975B
		public void Remove(XmlArrayItemAttribute attribute)
		{
			base.List.Remove(attribute);
		}

		/// <summary>
		///         Копирует <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> массива в коллекцию, начиная с указанного целевого индекса.
		///       </summary>
		/// <param name="array">
		///           Массив <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> объектов для копирования в коллекцию.
		///         </param>
		/// <param name="index">
		///           Индекс, по которому начинаться скопированные атрибуты.
		///         </param>
		// Token: 0x06001B18 RID: 6936 RVA: 0x0009B569 File Offset: 0x00099769
		public void CopyTo(XmlArrayItemAttribute[] array, int index)
		{
			base.List.CopyTo(array, index);
		}
	}
}
