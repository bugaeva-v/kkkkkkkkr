using System;
using System.Collections;
using System.Threading;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	/// <summary>
	///         Содержит кэш языка определения схемы XML (XSD) и схем XDR.
	///          Класс <see cref="T:System.Xml.Schema.XmlSchemaCollection" /> устарел.
	///          Взамен рекомендуется использовать <see cref="T:System.Xml.Schema.XmlSchemaSet" />.
	///       </summary>
	// Token: 0x0200059C RID: 1436
	[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
	public sealed class XmlSchemaCollection : ICollection, IEnumerable
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlSchemaCollection" />.
		///       </summary>
		// Token: 0x06003A0A RID: 14858 RVA: 0x0014C239 File Offset: 0x0014A439
		public XmlSchemaCollection() : this(new NameTable())
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlSchemaCollection" /> указанным значением <see cref="T:System.Xml.XmlNameTable" />.
		///         <see langword="XmlNameTable" /> Используется при загрузке схем.
		///       </summary>
		/// <param name="nametable">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		// Token: 0x06003A0B RID: 14859 RVA: 0x0014C248 File Offset: 0x0014A448
		public XmlSchemaCollection(XmlNameTable nametable)
		{
			if (nametable == null)
			{
				throw new ArgumentNullException("nametable");
			}
			this.nameTable = nametable;
			this.collection = Hashtable.Synchronized(new Hashtable());
			this.xmlResolver = XmlReaderSection.CreateDefaultResolver();
			this.isThreadSafe = true;
			if (this.isThreadSafe)
			{
				this.wLock = new ReaderWriterLock();
			}
		}

		/// <summary>
		///         Возвращает количество пространств имен, определенных в данной коллекции.
		///       </summary>
		/// <returns>
		///         Количество пространств имен, определенных в данной коллекции.
		///       </returns>
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x0014C2B3 File Offset: 0x0014A4B3
		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		/// <summary>
		///         Возвращает значение по умолчанию <see langword="XmlNameTable" /> используется <see langword="XmlSchemaCollection" /> при загрузке новых схем.
		///       </summary>
		/// <returns>
		///         Объект <see langword="XmlNameTable" />.
		///       </returns>
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x0014C2C0 File Offset: 0x0014A4C0
		public XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		/// <summary>
		///         Задает обработчик событий на получение информации об ошибках проверки XDR- и XML-схем.
		///       </summary>
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003A0E RID: 14862 RVA: 0x0014C2C8 File Offset: 0x0014A4C8
		// (remove) Token: 0x06003A0F RID: 14863 RVA: 0x0014C2E1 File Offset: 0x0014A4E1
		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
				this.validationEventHandler = (ValidationEventHandler)Delegate.Combine(this.validationEventHandler, value);
			}
			remove
			{
				this.validationEventHandler = (ValidationEventHandler)Delegate.Remove(this.validationEventHandler, value);
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x0014C2FA File Offset: 0x0014A4FA
		internal XmlResolver XmlResolver
		{
			set
			{
				this.xmlResolver = value;
			}
		}

		/// <summary>
		///         Добавляет в коллекцию схему, находящуюся по указанному URL-адресу.
		///       </summary>
		/// <param name="ns">
		///           Связанный со схемой URI пространства имен.
		///            Для XML-схем, обычно это будет <see langword="targetNamespace" />.
		///         </param>
		/// <param name="uri">
		///           URL-адрес, ссылающийся на схему, которую необходимо загрузить.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchema" /> Добавить коллекцию схем; <see langword="null" /> Если добавляемая схема является XDR-схемой или в схеме присутствуют ошибки компиляции.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Схема не является допустимой схемой.
		///           </exception>
		// Token: 0x06003A11 RID: 14865 RVA: 0x0014C304 File Offset: 0x0014A504
		public XmlSchema Add(string ns, string uri)
		{
			if (uri == null || uri.Length == 0)
			{
				throw new ArgumentNullException("uri");
			}
			XmlTextReader xmlTextReader = new XmlTextReader(uri, this.nameTable);
			xmlTextReader.XmlResolver = this.xmlResolver;
			XmlSchema result = null;
			try
			{
				result = this.Add(ns, xmlTextReader, this.xmlResolver);
				while (xmlTextReader.Read())
				{
				}
			}
			finally
			{
				xmlTextReader.Close();
			}
			return result;
		}

		/// <summary>
		///         Добавляет схему, содержащуюся в <see cref="T:System.Xml.XmlReader" /> коллекцию схем.
		///       </summary>
		/// <param name="ns">
		///           Связанный со схемой URI пространства имен.
		///            Для XML-схем, обычно это будет <see langword="targetNamespace" />.
		///         </param>
		/// <param name="reader">
		///           <see cref="T:System.Xml.XmlReader" /> содержащий схему для добавления.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchema" /> Добавить коллекцию схем; <see langword="null" /> Если добавляемая схема является XDR-схемой или в схеме присутствуют ошибки компиляции.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Схема не является допустимой схемой.
		///           </exception>
		// Token: 0x06003A12 RID: 14866 RVA: 0x0014C374 File Offset: 0x0014A574
		public XmlSchema Add(string ns, XmlReader reader)
		{
			return this.Add(ns, reader, this.xmlResolver);
		}

		/// <summary>
		///         Добавляет схему, содержащуюся в <see cref="T:System.Xml.XmlReader" /> коллекцию схем.
		///          Указанный <see cref="T:System.Xml.XmlResolver" /> используется для разрешения внешних ресурсов.
		///       </summary>
		/// <param name="ns">
		///           Связанный со схемой URI пространства имен.
		///            Для XML-схем, обычно это будет <see langword="targetNamespace" />.
		///         </param>
		/// <param name="reader">
		///           <see cref="T:System.Xml.XmlReader" /> содержащий схему для добавления.
		///         </param>
		/// <param name="resolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для разрешения пространств имен, используемых в <see langword="include" /> и <see langword="import" /> элементы или <see langword="x-schema" /> атрибута (XDR-схемы).
		///            Если это <see langword="null" />, внешние ссылки не разрешаются.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchema" /> Добавить коллекцию схем; <see langword="null" /> Если добавляемая схема является XDR-схемой или в схеме присутствуют ошибки компиляции.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Схема не является допустимой схемой.
		///           </exception>
		// Token: 0x06003A13 RID: 14867 RVA: 0x0014C384 File Offset: 0x0014A584
		public XmlSchema Add(string ns, XmlReader reader, XmlResolver resolver)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			XmlNameTable nt = reader.NameTable;
			SchemaInfo schemaInfo = new SchemaInfo();
			Parser parser = new Parser(SchemaType.None, nt, this.GetSchemaNames(nt), this.validationEventHandler);
			parser.XmlResolver = resolver;
			SchemaType schemaType;
			try
			{
				schemaType = parser.Parse(reader, ns);
			}
			catch (XmlSchemaException e)
			{
				this.SendValidationEvent(e);
				return null;
			}
			if (schemaType == SchemaType.XSD)
			{
				schemaInfo.SchemaType = SchemaType.XSD;
				return this.Add(ns, schemaInfo, parser.XmlSchema, true, resolver);
			}
			SchemaInfo xdrSchema = parser.XdrSchema;
			return this.Add(ns, parser.XdrSchema, null, true, resolver);
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Schema.XmlSchema" /> в коллекцию.
		///       </summary>
		/// <param name="schema">
		///           Параметр <see langword="XmlSchema" /> для добавления в коллекцию.
		///         </param>
		/// <returns>
		///         Объект <see langword="XmlSchema" />.
		///       </returns>
		// Token: 0x06003A14 RID: 14868 RVA: 0x0014C428 File Offset: 0x0014A628
		public XmlSchema Add(XmlSchema schema)
		{
			return this.Add(schema, this.xmlResolver);
		}

		/// <summary>
		///         Добавляет <see cref="T:System.Xml.Schema.XmlSchema" /> в коллекцию.
		///          Указанный <see cref="T:System.Xml.XmlResolver" /> используется для разрешения внешних ссылок.
		///       </summary>
		/// <param name="schema">
		///           Параметр <see langword="XmlSchema" /> для добавления в коллекцию.
		///         </param>
		/// <param name="resolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для разрешения пространств имен, используемых в <see langword="include" /> и <see langword="import" /> элементы.
		///            Если это <see langword="null" />, внешние ссылки не разрешаются.
		///         </param>
		/// <returns>
		///         <see langword="XmlSchema" /> Добавлен в коллекцию схем.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Схема не является допустимой схемой.
		///           </exception>
		// Token: 0x06003A15 RID: 14869 RVA: 0x0014C438 File Offset: 0x0014A638
		public XmlSchema Add(XmlSchema schema, XmlResolver resolver)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			SchemaInfo schemaInfo = new SchemaInfo();
			schemaInfo.SchemaType = SchemaType.XSD;
			return this.Add(schema.TargetNamespace, schemaInfo, schema, true, resolver);
		}

		/// <summary>
		///         Добавляет в данную коллекцию все пространства имен, определенные в указанной коллекции (включая связанные с ними схемы).
		///       </summary>
		/// <param name="schema">
		///           <see langword="XmlSchemaCollection" /> Вы хотите добавить в эту коллекцию.
		///         </param>
		// Token: 0x06003A16 RID: 14870 RVA: 0x0014C470 File Offset: 0x0014A670
		public void Add(XmlSchemaCollection schema)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			if (this == schema)
			{
				return;
			}
			IDictionaryEnumerator enumerator = schema.collection.GetEnumerator();
			while (enumerator.MoveNext())
			{
				XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)enumerator.Value;
				this.Add(xmlSchemaCollectionNode.NamespaceURI, xmlSchemaCollectionNode);
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchema" /> связанные с URI пространства имен.
		///       </summary>
		/// <param name="ns">
		///           URI пространства имен, связанный со схемой, которую необходимо вернуть.
		///            Обычно это будет <see langword="targetNamespace" /> схемы.
		///         </param>
		/// <returns>
		///         <see langword="XmlSchema" /> Связанные с URI пространства имен; <see langword="null" /> Если нет загруженных схемы, связанный с заданным пространством имен или пространство имен связано с XDR-схемой.
		///       </returns>
		// Token: 0x17000AF8 RID: 2808
		public XmlSchema this[string ns]
		{
			get
			{
				XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)this.collection[(ns != null) ? ns : string.Empty];
				if (xmlSchemaCollectionNode == null)
				{
					return null;
				}
				return xmlSchemaCollectionNode.Schema;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли <see langword="targetNamespace" /> указанного <see cref="T:System.Xml.Schema.XmlSchema" /> в коллекции.
		///       </summary>
		/// <param name="schema">
		///           Объект <see langword="XmlSchema" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если есть схема, в коллекции с тем же <see langword="targetNamespace" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06003A18 RID: 14872 RVA: 0x0014C4F4 File Offset: 0x0014A6F4
		public bool Contains(XmlSchema schema)
		{
			if (schema == null)
			{
				throw new ArgumentNullException("schema");
			}
			return this[schema.TargetNamespace] != null;
		}

		/// <summary>
		///         Возвращает значение, которое показывает, присутствует ли схема с указанным пространством имен в коллекции.
		///       </summary>
		/// <param name="ns">
		///           Связанный со схемой URI пространства имен.
		///            Для XML-схем обычно используется целевое пространство имен.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если схема с указанным пространством имен в коллекции. в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06003A19 RID: 14873 RVA: 0x0014C513 File Offset: 0x0014A713
		public bool Contains(string ns)
		{
			return this.collection[(ns != null) ? ns : string.Empty] != null;
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.Schema.XmlSchemaCollection.GetEnumerator" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="T:System.Collections.IEnumerator" /> для коллекции.
		///       </returns>
		// Token: 0x06003A1A RID: 14874 RVA: 0x0014C52E File Offset: 0x0014A72E
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new XmlSchemaCollectionEnumerator(this.collection);
		}

		/// <summary>
		///         Предоставляет поддержку для итерации в стиле "for each" ("для каждого") по коллекции схем.
		///       </summary>
		/// <returns>
		///         Перечислитель для итерации по всем схемам в текущей коллекции.
		///       </returns>
		// Token: 0x06003A1B RID: 14875 RVA: 0x0014C52E File Offset: 0x0014A72E
		public XmlSchemaCollectionEnumerator GetEnumerator()
		{
			return new XmlSchemaCollectionEnumerator(this.collection);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.Schema.XmlSchemaCollection.CopyTo(System.Xml.Schema.XmlSchema[],System.Int32)" />.
		///       </summary>
		/// <param name="array">
		///           Массив, в который копируются объекты.
		///         </param>
		/// <param name="index">
		///           Индекс в <paramref name="array" /> которого начинается копирование.
		///         </param>
		// Token: 0x06003A1C RID: 14876 RVA: 0x0014C53C File Offset: 0x0014A73C
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			XmlSchemaCollectionEnumerator enumerator = this.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (index == array.Length && array.IsFixedSize)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				array.SetValue(enumerator.Current, index++);
			}
		}

		/// <summary>
		///         Копирует все <see langword="XmlSchema" /> объектов из этой коллекции в заданный массив, начиная с заданного индекса.
		///       </summary>
		/// <param name="array">
		///           Массив, в который копируются объекты.
		///         </param>
		/// <param name="index">
		///           Индекс в <paramref name="array" /> которого начинается копирование.
		///         </param>
		// Token: 0x06003A1D RID: 14877 RVA: 0x0014C5A8 File Offset: 0x0014A7A8
		public void CopyTo(XmlSchema[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			XmlSchemaCollectionEnumerator enumerator = this.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != null)
				{
					if (index == array.Length)
					{
						throw new ArgumentOutOfRangeException("index");
					}
					array[index++] = enumerator.Current;
				}
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.Schema.XmlSchemaCollection.System#Collections#ICollection#IsSynchronized" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see langword="true" /> если коллекция синхронизирована <see langword="false" />.
		///       </returns>
		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x0001222F File Offset: 0x0001042F
		bool ICollection.IsSynchronized
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.Schema.XmlSchemaCollection.System#Collections#ICollection#SyncRoot" />.
		///       </summary>
		/// <returns>
		///         Возвращает <see cref="P:System.Collections.ICollection.SyncRoot" /> объекта, который может использоваться для синхронизации доступа к коллекции.
		///       </returns>
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x00002068 File Offset: 0x00000268
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.Schema.XmlSchemaCollection.Count" />.
		///       </summary>
		/// <returns>
		///         Возвращает количество элементов в коллекции.
		///       </returns>
		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x0014C2B3 File Offset: 0x0014A4B3
		int ICollection.Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x0014C60C File Offset: 0x0014A80C
		internal SchemaInfo GetSchemaInfo(string ns)
		{
			XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)this.collection[(ns != null) ? ns : string.Empty];
			if (xmlSchemaCollectionNode == null)
			{
				return null;
			}
			return xmlSchemaCollectionNode.SchemaInfo;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x0014C640 File Offset: 0x0014A840
		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			if (this.nameTable != nt)
			{
				return new SchemaNames(nt);
			}
			if (this.schemaNames == null)
			{
				this.schemaNames = new SchemaNames(this.nameTable);
			}
			return this.schemaNames;
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x0014C671 File Offset: 0x0014A871
		internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile)
		{
			return this.Add(ns, schemaInfo, schema, compile, this.xmlResolver);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x0014C684 File Offset: 0x0014A884
		private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver)
		{
			int num = 0;
			if (schema != null)
			{
				if (schema.ErrorCount == 0 && compile)
				{
					if (!schema.CompileSchema(this, resolver, schemaInfo, ns, this.validationEventHandler, this.nameTable, true))
					{
						num = 1;
					}
					ns = ((schema.TargetNamespace == null) ? string.Empty : schema.TargetNamespace);
				}
				num += schema.ErrorCount;
			}
			else
			{
				num += schemaInfo.ErrorCount;
				ns = this.NameTable.Add(ns);
			}
			if (num == 0)
			{
				this.Add(ns, new XmlSchemaCollectionNode
				{
					NamespaceURI = ns,
					SchemaInfo = schemaInfo,
					Schema = schema
				});
				return schema;
			}
			return null;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x0014C724 File Offset: 0x0014A924
		private void Add(string ns, XmlSchemaCollectionNode node)
		{
			if (this.isThreadSafe)
			{
				this.wLock.AcquireWriterLock(this.timeout);
			}
			try
			{
				if (this.collection[ns] != null)
				{
					this.collection.Remove(ns);
				}
				this.collection.Add(ns, node);
			}
			finally
			{
				if (this.isThreadSafe)
				{
					this.wLock.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x0014C798 File Offset: 0x0014A998
		private void SendValidationEvent(XmlSchemaException e)
		{
			if (this.validationEventHandler != null)
			{
				this.validationEventHandler(this, new ValidationEventArgs(e));
				return;
			}
			throw e;
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x0014C7B6 File Offset: 0x0014A9B6
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x0014C7BE File Offset: 0x0014A9BE
		internal ValidationEventHandler EventHandler
		{
			get
			{
				return this.validationEventHandler;
			}
			set
			{
				this.validationEventHandler = value;
			}
		}

		// Token: 0x04002AEB RID: 10987
		private Hashtable collection;

		// Token: 0x04002AEC RID: 10988
		private XmlNameTable nameTable;

		// Token: 0x04002AED RID: 10989
		private SchemaNames schemaNames;

		// Token: 0x04002AEE RID: 10990
		private ReaderWriterLock wLock;

		// Token: 0x04002AEF RID: 10991
		private int timeout = -1;

		// Token: 0x04002AF0 RID: 10992
		private bool isThreadSafe = true;

		// Token: 0x04002AF1 RID: 10993
		private ValidationEventHandler validationEventHandler;

		// Token: 0x04002AF2 RID: 10994
		private XmlResolver xmlResolver;
	}
}
