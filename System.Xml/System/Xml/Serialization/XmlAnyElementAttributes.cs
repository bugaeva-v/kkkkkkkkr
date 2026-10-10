using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет коллекцию объектов <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
	///       </summary>
	// Token: 0x020002C5 RID: 709
	public class XmlAnyElementAttributes : CollectionBase
	{
		/// <summary>
		///         Возвращает или задает объект <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> с заданным индексом.
		///       </summary>
		/// <param name="index">
		///           Индекс <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> По указанному индексу.
		///       </returns>
		// Token: 0x17000539 RID: 1337
		public XmlAnyElementAttribute this[int index]
		{
			get
			{
				return (XmlAnyElementAttribute)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> в коллекцию.
		///       </summary>
		/// <param name="attribute">
		///           Добавляемый объект <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///         </param>
		/// <returns>
		///         Индекс только что добавленного <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///       </returns>
		// Token: 0x06001AEB RID: 6891 RVA: 0x0009B522 File Offset: 0x00099722
		public int Add(XmlAnyElementAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		/// <summary>
		///         Вставляет <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> в коллекцию по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Индекс где <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> вставляется.
		///         </param>
		/// <param name="attribute">
		///           Вставляемый объект <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///         </param>
		// Token: 0x06001AEC RID: 6892 RVA: 0x0009B530 File Offset: 0x00099730
		public void Insert(int index, XmlAnyElementAttribute attribute)
		{
			base.List.Insert(index, attribute);
		}

		/// <summary>
		///         Возвращает индекс указанного <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///       </summary>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> Индекс которого требуется.
		///         </param>
		/// <returns>
		///         Индекс указанного <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.
		///       </returns>
		// Token: 0x06001AED RID: 6893 RVA: 0x0009B53F File Offset: 0x0009973F
		public int IndexOf(XmlAnyElementAttribute attribute)
		{
			return base.List.IndexOf(attribute);
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли указанный <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> существует в коллекции.
		///       </summary>
		/// <param name="attribute">
		///           <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> Вас интересуют.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> существует в коллекции; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001AEE RID: 6894 RVA: 0x0009B54D File Offset: 0x0009974D
		public bool Contains(XmlAnyElementAttribute attribute)
		{
			return base.List.Contains(attribute);
		}

		/// <summary>
		///         Удаляет указанный объект <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> из коллекции.
		///       </summary>
		/// <param name="attribute">
		///           Объект <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> для удаления.
		///         </param>
		// Token: 0x06001AEF RID: 6895 RVA: 0x0009B55B File Offset: 0x0009975B
		public void Remove(XmlAnyElementAttribute attribute)
		{
			base.List.Remove(attribute);
		}

		/// <summary>
		///         Копирует всю коллекцию в совместимый одномерный массив <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> объектов, начиная с указанного индекса целевого массива.
		///       </summary>
		/// <param name="array">
		///           Одномерный массив <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> объекты назначения для элементов, копируемых из коллекции.
		///            Индекс в массиве должен начинаться с нуля.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.
		///         </param>
		// Token: 0x06001AF0 RID: 6896 RVA: 0x0009B569 File Offset: 0x00099769
		public void CopyTo(XmlAnyElementAttribute[] array, int index)
		{
			base.List.CopyTo(array, index);
		}
	}
}
