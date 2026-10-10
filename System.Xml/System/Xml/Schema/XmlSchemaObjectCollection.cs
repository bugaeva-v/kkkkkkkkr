using System;
using System.Collections;

namespace System.Xml.Schema
{
	/// <summary>
	///         Коллекция объектов <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
	///       </summary>
	// Token: 0x020005CB RID: 1483
	public class XmlSchemaObjectCollection : CollectionBase
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		// Token: 0x06003B8D RID: 15245 RVA: 0x0009B578 File Offset: 0x00099778
		public XmlSchemaObjectCollection()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XmlSchemaObjectCollection" /> класс, который принимает <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </summary>
		/// <param name="parent">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		// Token: 0x06003B8E RID: 15246 RVA: 0x0014E544 File Offset: 0x0014C744
		public XmlSchemaObjectCollection(XmlSchemaObject parent)
		{
			this.parent = parent;
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.Schema.XmlSchemaObject" /> по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Индекс <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.Schema.XmlSchemaObject" /> по указанному индексу.
		///       </returns>
		// Token: 0x17000B8A RID: 2954
		public virtual XmlSchemaObject this[int index]
		{
			get
			{
				return (XmlSchemaObject)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>
		///         Возвращает перечислитель для прохода по <see langword="XmlSchemaObjects" /> содержится в <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		/// <returns>
		///         Возвращает итератор <see cref="T:System.Xml.Schema.XmlSchemaObjectEnumerator" />.
		///       </returns>
		// Token: 0x06003B91 RID: 15249 RVA: 0x0014E566 File Offset: 0x0014C766
		public new XmlSchemaObjectEnumerator GetEnumerator()
		{
			return new XmlSchemaObjectEnumerator(base.InnerList.GetEnumerator());
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Schema.XmlSchemaObject" /> к <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		/// <param name="item">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <returns>
		///         Индекс, по которому добавлен элемент.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> меньше нуля.
		///
		///             -или- 
		///
		///             Значение <paramref name="index" /> больше значения <see langword="Count" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             <see cref="T:System.Xml.Schema.XmlSchemaObject" /> Типа не указан параметр <see cref="T:System.Xml.Schema.XmlSchemaExternal" /> или его производных типов <see cref="T:System.Xml.Schema.XmlSchemaImport" />, <see cref="T:System.Xml.Schema.XmlSchemaInclude" />, и <see cref="T:System.Xml.Schema.XmlSchemaRedefine" />.
		///           </exception>
		// Token: 0x06003B92 RID: 15250 RVA: 0x0009B522 File Offset: 0x00099722
		public int Add(XmlSchemaObject item)
		{
			return base.List.Add(item);
		}

		/// <summary>
		///         Вставляет <see cref="T:System.Xml.Schema.XmlSchemaObject" /> в <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс, по которому следует вставить элемент.
		///         </param>
		/// <param name="item">
		///           Вставляемый объект <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> меньше нуля.
		///
		///             -или- 
		///
		///             Значение <paramref name="index" /> больше значения <see langword="Count" />.
		///           </exception>
		// Token: 0x06003B93 RID: 15251 RVA: 0x0009B530 File Offset: 0x00099730
		public void Insert(int index, XmlSchemaObject item)
		{
			base.List.Insert(index, item);
		}

		/// <summary>
		///         Получает индекс коллекции, соответствующий указанному <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </summary>
		/// <param name="item">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" /> Индекс которого требуется возвратить.
		///         </param>
		/// <returns>
		///         Индекс, соответствующий указанному <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </returns>
		// Token: 0x06003B94 RID: 15252 RVA: 0x0009B53F File Offset: 0x0009973F
		public int IndexOf(XmlSchemaObject item)
		{
			return base.List.IndexOf(item);
		}

		/// <summary>
		///         Указывает, если указанный <see cref="T:System.Xml.Schema.XmlSchemaObject" /> в <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		/// <param name="item">
		///           <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если указанное полное имя входит в коллекцию; в противном случае — возвращает <see langword="false" />.
		///          Если указано значение null, <see langword="false" /> возвращается, поскольку отсутствует полное имя с нулевым значением.
		///       </returns>
		// Token: 0x06003B95 RID: 15253 RVA: 0x0009B54D File Offset: 0x0009974D
		public bool Contains(XmlSchemaObject item)
		{
			return base.List.Contains(item);
		}

		/// <summary>
		///         Удаляет <see cref="T:System.Xml.Schema.XmlSchemaObject" /> из <see langword="XmlSchemaObjectCollection" />.
		///       </summary>
		/// <param name="item">
		///           Объект <see cref="T:System.Xml.Schema.XmlSchemaObject" /> для удаления.
		///         </param>
		// Token: 0x06003B96 RID: 15254 RVA: 0x0009B55B File Offset: 0x0009975B
		public void Remove(XmlSchemaObject item)
		{
			base.List.Remove(item);
		}

		/// <summary>
		///         Копирует все <see cref="T:System.Xml.Schema.XmlSchemaObject" />s из коллекции в заданный массив, начиная с заданного индекса.
		///       </summary>
		/// <param name="array">
		///           Одномерный массив, в который копируются элементы из коллекции <see langword="XmlSchemaObjectCollection" />.
		///            Индекс в массиве должен начинаться с нуля.
		///         </param>
		/// <param name="index">
		///           Индекс (отсчет с нуля) в массиве, с которого начинается копирование.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="array" /> является пустой ссылкой (<see langword="Nothing" /> в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> меньше нуля.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="array" /> является многомерным.
		///
		///             -или- 
		///
		///             Значение параметра <paramref name="index" /> больше или равно длине массива <paramref name="array" />.
		///
		///             -или- 
		///
		///             Число элементов в исходной коллекции <see cref="T:System.Xml.Schema.XmlSchemaObject" /> больше доступного места от положения, заданного значением индекса, до конца массива назначения.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Тип источника <see cref="T:System.Xml.Schema.XmlSchemaObject" /> не может быть автоматически приведен к типу массива назначения.
		///           </exception>
		// Token: 0x06003B97 RID: 15255 RVA: 0x0009B569 File Offset: 0x00099769
		public void CopyTo(XmlSchemaObject[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		/// <summary>
		///         <see langword="OnInsert" /> Вызывается перед стандартным <see langword="Insert" /> поведение.
		///          Дополнительные сведения см. в разделе <see langword="OnInsert" /> метод <see cref="T:System.Collections.CollectionBase" />.
		///       </summary>
		/// <param name="index">
		///           Индекс <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <param name="item">
		///           Элемент.
		///         </param>
		// Token: 0x06003B98 RID: 15256 RVA: 0x0014E578 File Offset: 0x0014C778
		protected override void OnInsert(int index, object item)
		{
			if (this.parent != null)
			{
				this.parent.OnAdd(this, item);
			}
		}

		/// <summary>
		///         <see langword="OnSet" /> Вызывается перед стандартным <see langword="Set" /> поведение.
		///          Дополнительные сведения см <see cref="T:System.Collections.CollectionBase" />.
		///       </summary>
		/// <param name="index">
		///           Индекс <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <param name="oldValue">
		///           Старое значение.
		///         </param>
		/// <param name="newValue">
		///           Новое значение.
		///         </param>
		// Token: 0x06003B99 RID: 15257 RVA: 0x0014E58F File Offset: 0x0014C78F
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			if (this.parent != null)
			{
				this.parent.OnRemove(this, oldValue);
				this.parent.OnAdd(this, newValue);
			}
		}

		/// <summary>
		///         <see langword="OnClear" /> Вызывается перед стандартным <see langword="Clear" /> поведение.
		///          Дополнительные сведения см <see cref="T:System.Collections.CollectionBase" />.
		///       </summary>
		// Token: 0x06003B9A RID: 15258 RVA: 0x0014E5B3 File Offset: 0x0014C7B3
		protected override void OnClear()
		{
			if (this.parent != null)
			{
				this.parent.OnClear(this);
			}
		}

		/// <summary>
		///         <see langword="OnRemove" /> Вызывается перед стандартным <see langword="Remove" /> поведение.
		///          Дополнительные сведения см. в разделе <see langword="OnRemove" /> метод <see cref="T:System.Collections.CollectionBase" />.
		///       </summary>
		/// <param name="index">
		///           Индекс <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///         </param>
		/// <param name="item">
		///           Элемент.
		///         </param>
		// Token: 0x06003B9B RID: 15259 RVA: 0x0014E5C9 File Offset: 0x0014C7C9
		protected override void OnRemove(int index, object item)
		{
			if (this.parent != null)
			{
				this.parent.OnRemove(this, item);
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x0014E5E0 File Offset: 0x0014C7E0
		internal XmlSchemaObjectCollection Clone()
		{
			return new XmlSchemaObjectCollection
			{
				this
			};
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x0014E5EE File Offset: 0x0014C7EE
		private void Add(XmlSchemaObjectCollection collToAdd)
		{
			base.InnerList.InsertRange(0, collToAdd);
		}

		// Token: 0x04002B87 RID: 11143
		private XmlSchemaObject parent;
	}
}
