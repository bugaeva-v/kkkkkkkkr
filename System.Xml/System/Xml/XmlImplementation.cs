using System;

namespace System.Xml
{
	/// <summary>
	///         Определяет контекст для набора <see cref="T:System.Xml.XmlDocument" /> объектов.
	///       </summary>
	// Token: 0x020001C8 RID: 456
	public class XmlImplementation
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlImplementation" />.
		///       </summary>
		// Token: 0x06001185 RID: 4485 RVA: 0x0006AD43 File Offset: 0x00068F43
		public XmlImplementation() : this(new NameTable())
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.XmlImplementation" /> класса <see cref="T:System.Xml.XmlNameTable" /> указанного.
		///       </summary>
		/// <param name="nt">
		///           Объект <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		// Token: 0x06001186 RID: 4486 RVA: 0x0006AD50 File Offset: 0x00068F50
		public XmlImplementation(XmlNameTable nt)
		{
			this.nameTable = nt;
		}

		/// <summary>
		///         Проверяет ли определенное средство в реализации объектной модели документов (DOM).
		///       </summary>
		/// <param name="strFeature">
		///           Имя пакета проверяемого средства.
		///            Это имя не учитывает регистр.
		///         </param>
		/// <param name="strVersion">
		///           Это имя пакета, чтобы проверить номер версии.
		///            Если версия не указана (<see langword="null" />), поддержка любой версии средства заставляет метод вернуть <see langword="true" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если эта функция реализована в указанной версии; в противном случае — <see langword="false" />.
		///
		///         В следующей таблице показаны сочетания, которые заставляют <see langword="HasFeature" /> для возврата <see langword="true" />.
		///
		///                 strFeature 
		///
		///                 strVersion 
		///
		///                 XML 
		///
		///                 1,0 
		///
		///                 XML 
		///
		///                 2.0 
		///               </returns>
		// Token: 0x06001187 RID: 4487 RVA: 0x0006AD5F File Offset: 0x00068F5F
		public bool HasFeature(string strFeature, string strVersion)
		{
			return string.Compare("XML", strFeature, StringComparison.OrdinalIgnoreCase) == 0 && (strVersion == null || strVersion == "1.0" || strVersion == "2.0");
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlDocument" />.
		///       </summary>
		/// <returns>
		///         Новый объект <see langword="XmlDocument" />.
		///       </returns>
		// Token: 0x06001188 RID: 4488 RVA: 0x0006AD8F File Offset: 0x00068F8F
		public virtual XmlDocument CreateDocument()
		{
			return new XmlDocument(this);
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0006AD97 File Offset: 0x00068F97
		internal XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x0400109F RID: 4255
		private XmlNameTable nameTable;
	}
}
