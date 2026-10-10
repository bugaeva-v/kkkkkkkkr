using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет коллекцию объектов <see cref="T:System.Xml.Serialization.XmlElementAttribute" />, используемых классом <see cref="T:System.Xml.Serialization.XmlSerializer" /> для переопределения стандартного способа сериализации класса.
	///       </summary>
	// Token: 0x020002D1 RID: 721
	public class XmlElementAttributes : CollectionBase
	{
		/// <summary>
		///         Возвращает или задает элемент по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.
		///         </param>
		/// <returns>
		///         Элемент, расположенный по указанному индексу.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Xml.Serialization.XmlElementAttributes" />.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             Свойство задано, и список <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> доступен только для чтения.
		///           </exception>
		// Token: 0x1700058A RID: 1418
		public XmlElementAttribute this[int index]
		{
			get
			{
				return (XmlElementAttribute)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> в коллекцию.
		///       </summary>
		/// <param name="attribute">
		///           Добавляемый объект <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///         </param>
		/// <returns>
		///         Отсчитываемый от нуля индекс вновь добавленного элемента.
		///       </returns>
		// Token: 0x06001BF1 RID: 7153 RVA: 0x0009B522 File Offset: 0x00099722
		public int Add(XmlElementAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		/// <summary>
		///         Вставляет <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> в коллекцию.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс места вставки элемента.
		///         </param>
		/// <param name="attribute">
		///           Вставляемый объект <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///         </param>
		// Token: 0x06001BF2 RID: 7154 RVA: 0x0009B530 File Offset: 0x00099730
		public void Insert(int index, XmlElementAttribute attribute)
		{
			base.List.Insert(index, attribute);
		}

		/// <summary>
		///         Возвращает индекс указанного <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///       </summary>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> Индекс которого извлекается.
		///         </param>
		/// <returns>
		///         Отсчитываемый от нуля индекс <see cref="T:System.Xml.Serialization.XmlElementAttribute" />.
		///       </returns>
		// Token: 0x06001BF3 RID: 7155 RVA: 0x0009B53F File Offset: 0x0009973F
		public int IndexOf(XmlElementAttribute attribute)
		{
			return base.List.IndexOf(attribute);
		}

		/// <summary>
		///         Определяет, содержит ли коллекция указанный объект.
		///       </summary>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> Для поиска.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если объект существует в коллекции. в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001BF4 RID: 7156 RVA: 0x0009B54D File Offset: 0x0009974D
		public bool Contains(XmlElementAttribute attribute)
		{
			return base.List.Contains(attribute);
		}

		/// <summary>
		///         Удаляет указанный объект из коллекции.
		///       </summary>
		/// <param name="attribute">
		///           Объект <see cref="T:System.Xml.Serialization.XmlElementAttribute" />, который требуется удалить из коллекции.
		///         </param>
		// Token: 0x06001BF5 RID: 7157 RVA: 0x0009B55B File Offset: 0x0009975B
		public void Remove(XmlElementAttribute attribute)
		{
			base.List.Remove(attribute);
		}

		/// <summary>
		///         Копирует <see cref="T:System.Xml.Serialization.XmlElementAttributes" />, или его часть в одномерный массив.
		///       </summary>
		/// <param name="array">
		///           <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> Массив для хранения скопированных элементов.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.
		///         </param>
		// Token: 0x06001BF6 RID: 7158 RVA: 0x0009B569 File Offset: 0x00099769
		public void CopyTo(XmlElementAttribute[] array, int index)
		{
			base.List.CopyTo(array, index);
		}
	}
}
