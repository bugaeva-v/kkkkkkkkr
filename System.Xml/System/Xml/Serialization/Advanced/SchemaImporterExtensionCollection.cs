using System;
using System.Collections;

namespace System.Xml.Serialization.Advanced
{
	/// <summary>
	///         Представляет коллекцию объектов <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" />.
	///       </summary>
	// Token: 0x02000321 RID: 801
	public class SchemaImporterExtensionCollection : CollectionBase
	{
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000D20C9 File Offset: 0x000D02C9
		internal Hashtable Names
		{
			get
			{
				if (this.exNames == null)
				{
					this.exNames = new Hashtable();
				}
				return this.exNames;
			}
		}

		/// <summary>
		///         Добавляет указанное расширение импортера в коллекцию.
		///       </summary>
		/// <param name="extension">
		///           Добавляемый объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" />.
		///         </param>
		/// <returns>
		///         Индекс добавляемого расширения.
		///       </returns>
		// Token: 0x060020F5 RID: 8437 RVA: 0x000D20E4 File Offset: 0x000D02E4
		public int Add(SchemaImporterExtension extension)
		{
			return this.Add(extension.GetType().FullName, extension);
		}

		/// <summary>
		///         Добавляет указанное расширение импортера в коллекцию.
		///         Имя позволяет задавать пользовательское имя для расширения.
		///       </summary>
		/// <param name="name">
		///           Пользовательское имя для расширения.
		///         </param>
		/// <param name="type">
		///           Добавляемый объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" />.
		///         </param>
		/// <returns>
		///         Индекс добавляемого элемента.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Значение тип не наследует от <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" />.
		///           </exception>
		// Token: 0x060020F6 RID: 8438 RVA: 0x000D20F8 File Offset: 0x000D02F8
		public int Add(string name, Type type)
		{
			if (type.IsSubclassOf(typeof(SchemaImporterExtension)))
			{
				return this.Add(name, (SchemaImporterExtension)Activator.CreateInstance(type));
			}
			throw new ArgumentException(Res.GetString("'{0}' is not a valid SchemaExtensionType.", new object[]
			{
				type
			}));
		}

		/// <summary>
		///         Удаляет <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" />, указанного именем из коллекции.
		///       </summary>
		/// <param name="name">
		///           Имя удаляемого объекта <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" />.
		///            Имя задается с помощью <see cref="M:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection.Add(System.String,System.Type)" /> метод.
		///         </param>
		// Token: 0x060020F7 RID: 8439 RVA: 0x000D2138 File Offset: 0x000D0338
		public void Remove(string name)
		{
			if (this.Names[name] != null)
			{
				base.List.Remove(this.Names[name]);
				this.Names[name] = null;
			}
		}

		/// <summary>
		///         Очищает коллекцию расширений импорта.
		///       </summary>
		// Token: 0x060020F8 RID: 8440 RVA: 0x000D216C File Offset: 0x000D036C
		public new void Clear()
		{
			this.Names.Clear();
			base.List.Clear();
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000D2184 File Offset: 0x000D0384
		internal SchemaImporterExtensionCollection Clone()
		{
			SchemaImporterExtensionCollection schemaImporterExtensionCollection = new SchemaImporterExtensionCollection();
			schemaImporterExtensionCollection.exNames = (Hashtable)this.Names.Clone();
			foreach (object value in base.List)
			{
				schemaImporterExtensionCollection.List.Add(value);
			}
			return schemaImporterExtensionCollection;
		}

		/// <summary>
		///         Возвращает объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" /> по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Индекс элемента для поиска.
		///         </param>
		/// <returns>
		///         Параметр <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" /> по указанному индексу.
		///       </returns>
		// Token: 0x17000657 RID: 1623
		public SchemaImporterExtension this[int index]
		{
			get
			{
				return (SchemaImporterExtension)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000D2210 File Offset: 0x000D0410
		internal int Add(string name, SchemaImporterExtension extension)
		{
			if (this.Names[name] == null)
			{
				this.Names[name] = extension;
				return base.List.Add(extension);
			}
			if (this.Names[name].GetType() != extension.GetType())
			{
				throw new InvalidOperationException(Res.GetString("Duplicate extension name.  schemaImporterExtension with name '{0}' already been added.", new object[]
				{
					name
				}));
			}
			return -1;
		}

		/// <summary>
		///         Вставляет указанный <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" /> в коллекцию по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс, по которому <paramref name="extension" /> следует вставить.
		///         </param>
		/// <param name="extension">
		///           Вставляемый объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" />.
		///         </param>
		// Token: 0x060020FD RID: 8445 RVA: 0x0009B530 File Offset: 0x00099730
		public void Insert(int index, SchemaImporterExtension extension)
		{
			base.List.Insert(index, extension);
		}

		/// <summary>
		///         Выполняет поиск указанного элемента и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию.
		///       </summary>
		/// <param name="extension">
		///           Объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" />, который требуется найти.
		///         </param>
		/// <returns>
		///         Индекс найденного элемента.
		///       </returns>
		// Token: 0x060020FE RID: 8446 RVA: 0x0009B53F File Offset: 0x0009973F
		public int IndexOf(SchemaImporterExtension extension)
		{
			return base.List.IndexOf(extension);
		}

		/// <summary>
		///         Возвращает значение, указывающее, существует ли в коллекции указанное расширение импортера.
		///       </summary>
		/// <param name="extension">
		///           Объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" />, который требуется найти.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если расширение обнаружено; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060020FF RID: 8447 RVA: 0x0009B54D File Offset: 0x0009974D
		public bool Contains(SchemaImporterExtension extension)
		{
			return base.List.Contains(extension);
		}

		/// <summary>
		///         Удаляет указанный объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" /> из коллекции.
		///       </summary>
		/// <param name="extension">
		///           Объект <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" /> для удаления.
		///         </param>
		// Token: 0x06002100 RID: 8448 RVA: 0x0009B55B File Offset: 0x0009975B
		public void Remove(SchemaImporterExtension extension)
		{
			base.List.Remove(extension);
		}

		/// <summary>
		///         Копирует все элементы текущего <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtensionCollection" /> указанный массив <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" /> объектов по указанному индексу.
		///       </summary>
		/// <param name="array">
		///           <see cref="T:System.Xml.Serialization.Advanced.SchemaImporterExtension" /> Копирование текущей коллекции.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс, по которому добавляется коллекция.
		///         </param>
		// Token: 0x06002101 RID: 8449 RVA: 0x0009B569 File Offset: 0x00099769
		public void CopyTo(SchemaImporterExtension[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x04001B75 RID: 7029
		private Hashtable exNames;
	}
}
