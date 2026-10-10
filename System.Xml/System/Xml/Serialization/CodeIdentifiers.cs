using System;
using System.Collections;
using System.Globalization;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Поддерживает группу имен для связанных сущностей кода или сопоставлений типов, создаваемых инфраструктурой сериализации XML платформы .NET Framework.
	///       </summary>
	// Token: 0x02000273 RID: 627
	public class CodeIdentifiers
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.CodeIdentifiers" />.
		///       </summary>
		// Token: 0x060017CC RID: 6092 RVA: 0x0008BA1B File Offset: 0x00089C1B
		public CodeIdentifiers() : this(true)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> класса и определяет, являются ли идентификаторы кода с учетом регистра.
		///       </summary>
		/// <param name="caseSensitive">
		///           <see langword="true" /> Если идентификаторы чувствительны к регистру; в противном случае — <see langword="false" />.
		///         </param>
		// Token: 0x060017CD RID: 6093 RVA: 0x0008BA24 File Offset: 0x00089C24
		public CodeIdentifiers(bool caseSensitive)
		{
			if (caseSensitive)
			{
				this.identifiers = new Hashtable();
				this.reservedIdentifiers = new Hashtable();
			}
			else
			{
				IEqualityComparer equalityComparer = new CaseInsensitiveKeyComparer();
				this.identifiers = new Hashtable(equalityComparer);
				this.reservedIdentifiers = new Hashtable(equalityComparer);
			}
			this.list = new ArrayList();
		}

		/// <summary>
		///         Удаляет все сущности кода или сопоставления типов, включая их имена из <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///       </summary>
		// Token: 0x060017CE RID: 6094 RVA: 0x0008BA7B File Offset: 0x00089C7B
		public void Clear()
		{
			this.identifiers.Clear();
			this.list.Clear();
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, использует ли экземпляр верхний регистр.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Чтобы указать, что экземпляр использует регистра Pascal. <see langword="false" /> для указания, что экземпляр использует верхнего регистра.
		///       </returns>
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0008BA93 File Offset: 0x00089C93
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0008BA9B File Offset: 0x00089C9B
		public bool UseCamelCasing
		{
			get
			{
				return this.camelCase;
			}
			set
			{
				this.camelCase = value;
			}
		}

		/// <summary>
		///         Гарантирует, что входные данные имеют правильный регистр, изменив имя в соответствии со значением <see cref="P:System.Xml.Serialization.CodeIdentifiers.UseCamelCasing" /> свойство.
		///       </summary>
		/// <param name="identifier">
		///           Имя для возможного изменения.
		///         </param>
		/// <returns>
		///         Изменить строки, которая совпадает с входным идентификатором или имеет регистром первой буквы.
		///       </returns>
		// Token: 0x060017D1 RID: 6097 RVA: 0x0008BAA4 File Offset: 0x00089CA4
		public string MakeRightCase(string identifier)
		{
			if (this.camelCase)
			{
				return CodeIdentifier.MakeCamel(identifier);
			}
			return CodeIdentifier.MakePascal(identifier);
		}

		/// <summary>
		///         Определяет, является ли входное имя конфликтует с другим именем в <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляр области и если да, создает измененной строки.
		///       </summary>
		/// <param name="identifier">
		///           Имя для изменения, если он не является уникальным.
		///         </param>
		/// <returns>
		///         Значение параметра идентификатора или измененная строка, если существует конфликт имен.
		///       </returns>
		// Token: 0x060017D2 RID: 6098 RVA: 0x0008BABC File Offset: 0x00089CBC
		public string MakeUnique(string identifier)
		{
			if (this.IsInUse(identifier))
			{
				int num = 1;
				string text;
				for (;;)
				{
					text = identifier + num.ToString(CultureInfo.InvariantCulture);
					if (!this.IsInUse(text))
					{
						break;
					}
					num++;
				}
				identifier = text;
			}
			if (identifier.Length > 511)
			{
				return this.MakeUnique("Item");
			}
			return identifier;
		}

		/// <summary>
		///         Предотвращает использование в указанное имя <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///       </summary>
		/// <param name="identifier">
		///           Имя, которое будет недоступен в <see cref="T:System.Xml.Serialization.CodeIdentifiers" />экземпляра.
		///         </param>
		// Token: 0x060017D3 RID: 6099 RVA: 0x0008BB15 File Offset: 0x00089D15
		public void AddReserved(string identifier)
		{
			this.reservedIdentifiers.Add(identifier, identifier);
		}

		/// <summary>
		///         Удаляет имя входа из <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляр зарезервированная имена.
		///       </summary>
		/// <param name="identifier">
		///           Имя, которое станет доступным в <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///         </param>
		// Token: 0x060017D4 RID: 6100 RVA: 0x0008BB24 File Offset: 0x00089D24
		public void RemoveReserved(string identifier)
		{
			this.reservedIdentifiers.Remove(identifier);
		}

		/// <summary>
		///         Добавляет именованный код сущности или типа сопоставление <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра области, гарантируя, что имя является уникальным в пределах области.
		///       </summary>
		/// <param name="identifier">
		///           Допустимое имя, используемое для индексации сущности кода.
		///         </param>
		/// <param name="value">
		///           Код сущности или типа сведения о сопоставлении.
		///         </param>
		/// <returns>
		///         Значение параметра идентификатора или измененная строка, если существует конфликт имен.
		///       </returns>
		// Token: 0x060017D5 RID: 6101 RVA: 0x0008BB32 File Offset: 0x00089D32
		public string AddUnique(string identifier, object value)
		{
			identifier = this.MakeUnique(identifier);
			this.Add(identifier, value);
			return identifier;
		}

		/// <summary>
		///         Определяет, является ли указанное имя уже используется в <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///       </summary>
		/// <param name="identifier">
		///           Имя для проверки для использования в пределах <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если имя уже используется; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060017D6 RID: 6102 RVA: 0x0008BB46 File Offset: 0x00089D46
		public bool IsInUse(string identifier)
		{
			return this.identifiers.Contains(identifier) || this.reservedIdentifiers.Contains(identifier);
		}

		/// <summary>
		///         Добавляет именованный код сущности или типа сопоставление <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///       </summary>
		/// <param name="identifier">
		///           Имя, используемое для индексации сущности кода.
		///         </param>
		/// <param name="value">
		///           Код сущности или типа сведения о сопоставлении.
		///         </param>
		// Token: 0x060017D7 RID: 6103 RVA: 0x0008BB64 File Offset: 0x00089D64
		public void Add(string identifier, object value)
		{
			this.identifiers.Add(identifier, value);
			this.list.Add(value);
		}

		/// <summary>
		///         Удаляет из <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра области идентифицируется по имени входного сопоставление сущности или типа кода.
		///       </summary>
		/// <param name="identifier">
		///           Имя кода сущности или типа сведений о сопоставлении для удаления.
		///         </param>
		// Token: 0x060017D8 RID: 6104 RVA: 0x0008BB80 File Offset: 0x00089D80
		public void Remove(string identifier)
		{
			this.list.Remove(this.identifiers[identifier]);
			this.identifiers.Remove(identifier);
		}

		/// <summary>
		///         Возвращает массив сущностей кода или сопоставлений типов в <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> экземпляра.
		///       </summary>
		/// <param name="type">
		///           Тип всех сущностей кода или сопоставлений типа для экземпляра.
		///         </param>
		/// <returns>
		///         Массив сущностей кода или сопоставлений типов, хранятся с <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> объекта.
		///       </returns>
		// Token: 0x060017D9 RID: 6105 RVA: 0x0008BBA8 File Offset: 0x00089DA8
		public object ToArray(Type type)
		{
			Array array = Array.CreateInstance(type, this.list.Count);
			this.list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0008BBD8 File Offset: 0x00089DD8
		internal CodeIdentifiers Clone()
		{
			return new CodeIdentifiers
			{
				identifiers = (Hashtable)this.identifiers.Clone(),
				reservedIdentifiers = (Hashtable)this.reservedIdentifiers.Clone(),
				list = (ArrayList)this.list.Clone(),
				camelCase = this.camelCase
			};
		}

		// Token: 0x04001885 RID: 6277
		private Hashtable identifiers;

		// Token: 0x04001886 RID: 6278
		private Hashtable reservedIdentifiers;

		// Token: 0x04001887 RID: 6279
		private ArrayList list;

		// Token: 0x04001888 RID: 6280
		private bool camelCase;
	}
}
