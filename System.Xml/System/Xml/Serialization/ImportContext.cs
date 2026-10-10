using System;
using System.Collections;
using System.Collections.Specialized;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Описывает контекст, в котором набор схемы привязан к сущностям кода .NET Framework.
	///       </summary>
	// Token: 0x0200027D RID: 637
	public class ImportContext
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.ImportContext" /> класса для данного кода идентификаторов, заданного параметром совместное использование типов.
		///       </summary>
		/// <param name="identifiers">
		///           Код сущности, к которым применяется данный контекст.
		///         </param>
		/// <param name="shareTypes">
		///           A <see cref="T:System.Boolean" /> значение, определяющее наличие в схеме общих пользовательских типов.
		///         </param>
		// Token: 0x06001814 RID: 6164 RVA: 0x0008D857 File Offset: 0x0008BA57
		public ImportContext(CodeIdentifiers identifiers, bool shareTypes)
		{
			this.typeIdentifiers = identifiers;
			this.shareTypes = shareTypes;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0008D86D File Offset: 0x0008BA6D
		internal ImportContext() : this(null, false)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0008D877 File Offset: 0x0008BA77
		internal SchemaObjectCache Cache
		{
			get
			{
				if (this.cache == null)
				{
					this.cache = new SchemaObjectCache();
				}
				return this.cache;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x0008D892 File Offset: 0x0008BA92
		internal Hashtable Elements
		{
			get
			{
				if (this.elements == null)
				{
					this.elements = new Hashtable();
				}
				return this.elements;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0008D8AD File Offset: 0x0008BAAD
		internal Hashtable Mappings
		{
			get
			{
				if (this.mappings == null)
				{
					this.mappings = new Hashtable();
				}
				return this.mappings;
			}
		}

		/// <summary>
		///         Возвращает набор сущностей кода, к которым применяется данный контекст.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Serialization.CodeIdentifiers" /> указывающий сущностей кода, к которым применяется данный контекст.
		///       </returns>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x0008D8C8 File Offset: 0x0008BAC8
		public CodeIdentifiers TypeIdentifiers
		{
			get
			{
				if (this.typeIdentifiers == null)
				{
					this.typeIdentifiers = new CodeIdentifiers();
				}
				return this.typeIdentifiers;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее наличие общих пользовательских типов.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если пользовательские типы являются общими для схемы; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0008D8E3 File Offset: 0x0008BAE3
		public bool ShareTypes
		{
			get
			{
				return this.shareTypes;
			}
		}

		/// <summary>
		///         Возвращает коллекцию предупреждений, создаваемых при импортировании описаний кодовых сущностей.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Specialized.StringCollection" /> содержащий предупреждения, созданные при импортировании описаний кодовых сущностей.
		///       </returns>
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0008D8EB File Offset: 0x0008BAEB
		public StringCollection Warnings
		{
			get
			{
				return this.Cache.Warnings;
			}
		}

		// Token: 0x040018A1 RID: 6305
		private bool shareTypes;

		// Token: 0x040018A2 RID: 6306
		private SchemaObjectCache cache;

		// Token: 0x040018A3 RID: 6307
		private Hashtable mappings;

		// Token: 0x040018A4 RID: 6308
		private Hashtable elements;

		// Token: 0x040018A5 RID: 6309
		private CodeIdentifiers typeIdentifiers;
	}
}
