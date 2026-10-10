using System;
using System.Text;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет все контекстные данные, необходимые <see cref="T:System.Xml.XmlReader" /> для синтаксического анализа фрагмента XML.
	///       </summary>
	// Token: 0x02000098 RID: 152
	public class XmlParserContext
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XmlParserContext" /> с заданным <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, <see langword="xml:lang" />, и <see langword="xml:space" /> значения.
		///       </summary>
		/// <param name="nt">
		///           <see cref="T:System.Xml.XmlNameTable" /> Для разъединения строк.
		///            Если это <see langword="null" />, имя таблицы, используемой для создания <paramref name="nsMgr" /> вместо него используется.
		///            Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		/// <param name="nsMgr">
		///           <see cref="T:System.Xml.XmlNamespaceManager" /> Для поиска сведений о пространстве имен, или <see langword="null" />.
		///         </param>
		/// <param name="xmlLang">
		///           <see langword="xml:lang" /> Области.
		///         </param>
		/// <param name="xmlSpace">
		///           <see cref="T:System.Xml.XmlSpace" /> Значение, указывающее, <see langword="xml:space" /> области.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="nt" /> не то же самое <see langword="XmlNameTable" /> используется для создания <paramref name="nsMgr" />.
		///           </exception>
		// Token: 0x06000565 RID: 1381 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) : this(nt, nsMgr, null, null, null, null, string.Empty, xmlLang, xmlSpace)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XmlParserContext" /> с заданным <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, <see langword="xml:lang" />, <see langword="xml:space" />, а также кодирование.
		///       </summary>
		/// <param name="nt">
		///           <see cref="T:System.Xml.XmlNameTable" /> Для разъединения строк.
		///            Если это <see langword="null" />, имя таблицы, используемой для создания <paramref name="nsMgr" /> вместо него используется.
		///            Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		/// <param name="nsMgr">
		///           <see cref="T:System.Xml.XmlNamespaceManager" /> Для поиска сведений о пространстве имен, или <see langword="null" />.
		///         </param>
		/// <param name="xmlLang">
		///           <see langword="xml:lang" /> Области.
		///         </param>
		/// <param name="xmlSpace">
		///           <see cref="T:System.Xml.XmlSpace" /> Значение, указывающее, <see langword="xml:space" /> области.
		///         </param>
		/// <param name="enc">
		///           <see cref="T:System.Text.Encoding" /> Показывающий кодировки параметра.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="nt" /> не то же самое <see langword="XmlNameTable" /> используется для создания <paramref name="nsMgr" />.
		///           </exception>
		// Token: 0x06000566 RID: 1382 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace, Encoding enc) : this(nt, nsMgr, null, null, null, null, string.Empty, xmlLang, xmlSpace, enc)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XmlParserContext" /> с заданным <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, базового URI, <see langword="xml:lang" />, <see langword="xml:space" />, и значений типов документов.
		///       </summary>
		/// <param name="nt">
		///           <see cref="T:System.Xml.XmlNameTable" /> Для разъединения строк.
		///            Если это <see langword="null" />, имя таблицы, используемой для создания <paramref name="nsMgr" /> вместо него используется.
		///            Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		/// <param name="nsMgr">
		///           <see cref="T:System.Xml.XmlNamespaceManager" /> Для поиска сведений о пространстве имен, или <see langword="null" />.
		///         </param>
		/// <param name="docTypeName">
		///           Имя объявления типа документа.
		///         </param>
		/// <param name="pubId">
		///           Общий идентификатор.
		///         </param>
		/// <param name="sysId">
		///           Идентификатор системы.
		///         </param>
		/// <param name="internalSubset">
		///           Внутреннее подмножество DTD.
		///            Набор DTD используется для разрешения сущностей, но не для проверки документа.
		///         </param>
		/// <param name="baseURI">
		///           Базовый URI для XML-фрагмент (расположение, из которого загружен фрагмент).
		///         </param>
		/// <param name="xmlLang">
		///           <see langword="xml:lang" /> Области.
		///         </param>
		/// <param name="xmlSpace">
		///           <see cref="T:System.Xml.XmlSpace" /> Значение, указывающее, <see langword="xml:space" /> области.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="nt" /> не то же самое <see langword="XmlNameTable" /> используется для создания <paramref name="nsMgr" />.
		///           </exception>
		// Token: 0x06000567 RID: 1383 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) : this(nt, nsMgr, docTypeName, pubId, sysId, internalSubset, baseURI, xmlLang, xmlSpace, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see langword="XmlParserContext" /> с заданным <see cref="T:System.Xml.XmlNameTable" />, <see cref="T:System.Xml.XmlNamespaceManager" />, базового URI, <see langword="xml:lang" />, <see langword="xml:space" />, кодировки и значений типов документов.
		///       </summary>
		/// <param name="nt">
		///           <see cref="T:System.Xml.XmlNameTable" /> Для разъединения строк.
		///            Если это <see langword="null" />, имя таблицы, используемой для создания <paramref name="nsMgr" /> вместо него используется.
		///            Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" />.
		///         </param>
		/// <param name="nsMgr">
		///           <see cref="T:System.Xml.XmlNamespaceManager" /> Для поиска сведений о пространстве имен, или <see langword="null" />.
		///         </param>
		/// <param name="docTypeName">
		///           Имя объявления типа документа.
		///         </param>
		/// <param name="pubId">
		///           Общий идентификатор.
		///         </param>
		/// <param name="sysId">
		///           Идентификатор системы.
		///         </param>
		/// <param name="internalSubset">
		///           Внутреннее подмножество DTD.
		///            DTD используется для разрешения сущностей, но не для проверки документа.
		///         </param>
		/// <param name="baseURI">
		///           Базовый URI для XML-фрагмент (расположение, из которого загружен фрагмент).
		///         </param>
		/// <param name="xmlLang">
		///           <see langword="xml:lang" /> Области.
		///         </param>
		/// <param name="xmlSpace">
		///           <see cref="T:System.Xml.XmlSpace" /> Значение, указывающее, <see langword="xml:space" /> области.
		///         </param>
		/// <param name="enc">
		///           <see cref="T:System.Text.Encoding" /> Показывающий кодировки параметра.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="nt" /> не то же самое <see langword="XmlNameTable" /> используется для создания <paramref name="nsMgr" />.
		///           </exception>
		// Token: 0x06000568 RID: 1384 RVA: 0x0001DF0C File Offset: 0x0001C10C
		public XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
		{
			if (nsMgr != null)
			{
				if (nt == null)
				{
					this._nt = nsMgr.NameTable;
				}
				else
				{
					if (nt != nsMgr.NameTable)
					{
						throw new XmlException("Not the same name table.", string.Empty);
					}
					this._nt = nt;
				}
			}
			else
			{
				this._nt = nt;
			}
			this._nsMgr = nsMgr;
			this._docTypeName = ((docTypeName == null) ? string.Empty : docTypeName);
			this._pubId = ((pubId == null) ? string.Empty : pubId);
			this._sysId = ((sysId == null) ? string.Empty : sysId);
			this._internalSubset = ((internalSubset == null) ? string.Empty : internalSubset);
			this._baseURI = ((baseURI == null) ? string.Empty : baseURI);
			this._xmlLang = ((xmlLang == null) ? string.Empty : xmlLang);
			this._xmlSpace = xmlSpace;
			this._encoding = enc;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNameTable" /> используемый для разъединения строк.
		///          Дополнительные сведения о разъединенных строках см. в разделе <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNameTable" />.
		///       </returns>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001E025 File Offset: 0x0001C225
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0001E02D File Offset: 0x0001C22D
		public XmlNameTable NameTable
		{
			get
			{
				return this._nt;
			}
			set
			{
				this._nt = value;
			}
		}

		/// <summary>
		///         Возвращает или задает класс <see cref="T:System.Xml.XmlNamespaceManager" />.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNamespaceManager" />.
		///       </returns>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001E036 File Offset: 0x0001C236
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001E03E File Offset: 0x0001C23E
		public XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this._nsMgr;
			}
			set
			{
				this._nsMgr = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя объявления типа документа.
		///       </summary>
		/// <returns>
		///         Имя объявления типа документа.
		///       </returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0001E047 File Offset: 0x0001C247
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0001E04F File Offset: 0x0001C24F
		public string DocTypeName
		{
			get
			{
				return this._docTypeName;
			}
			set
			{
				this._docTypeName = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает общий идентификатор.
		///       </summary>
		/// <returns>
		///         Общий идентификатор.
		///       </returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0001E062 File Offset: 0x0001C262
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0001E06A File Offset: 0x0001C26A
		public string PublicId
		{
			get
			{
				return this._pubId;
			}
			set
			{
				this._pubId = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает идентификатор системы.
		///       </summary>
		/// <returns>
		///         Идентификатор системы.
		///       </returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001E07D File Offset: 0x0001C27D
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0001E085 File Offset: 0x0001C285
		public string SystemId
		{
			get
			{
				return this._sysId;
			}
			set
			{
				this._sysId = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает базовый URI.
		///       </summary>
		/// <returns>
		///         Базовый URI, используемый для разрешения файла DTD.
		///       </returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001E098 File Offset: 0x0001C298
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		public string BaseURI
		{
			get
			{
				return this._baseURI;
			}
			set
			{
				this._baseURI = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает внутреннее подмножество DTD.
		///       </summary>
		/// <returns>
		///         Внутреннее подмножество DTD.
		///          Например, это свойство возвращает все содержимое внутри квадратных скобок &lt;!DOCTYPE doc [...]&gt;.
		///       </returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001E0B3 File Offset: 0x0001C2B3
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0001E0BB File Offset: 0x0001C2BB
		public string InternalSubset
		{
			get
			{
				return this._internalSubset;
			}
			set
			{
				this._internalSubset = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает текущий <see langword="xml:lang" /> области.
		///       </summary>
		/// <returns>
		///         Текущая область действия <see langword="xml:lang" />.
		///          Если не <see langword="xml:lang" /> в области видимости, <see langword="String.Empty" /> возвращается.
		///       </returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001E0CE File Offset: 0x0001C2CE
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0001E0D6 File Offset: 0x0001C2D6
		public string XmlLang
		{
			get
			{
				return this._xmlLang;
			}
			set
			{
				this._xmlLang = ((value == null) ? string.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает текущий <see langword="xml:space" /> области.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlSpace" /> Значение, указывающее, <see langword="xml:space" /> области.
		///       </returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001E0E9 File Offset: 0x0001C2E9
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0001E0F1 File Offset: 0x0001C2F1
		public XmlSpace XmlSpace
		{
			get
			{
				return this._xmlSpace;
			}
			set
			{
				this._xmlSpace = value;
			}
		}

		/// <summary>
		///         Возвращает или задает тип кодировки.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Text.Encoding" /> Показывающий тип кодировки.
		///       </returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0001E0FA File Offset: 0x0001C2FA
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0001E102 File Offset: 0x0001C302
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0001E10B File Offset: 0x0001C30B
		internal bool HasDtdInfo
		{
			get
			{
				return this._internalSubset != string.Empty || this._pubId != string.Empty || this._sysId != string.Empty;
			}
		}

		// Token: 0x0400082A RID: 2090
		private XmlNameTable _nt;

		// Token: 0x0400082B RID: 2091
		private XmlNamespaceManager _nsMgr;

		// Token: 0x0400082C RID: 2092
		private string _docTypeName = string.Empty;

		// Token: 0x0400082D RID: 2093
		private string _pubId = string.Empty;

		// Token: 0x0400082E RID: 2094
		private string _sysId = string.Empty;

		// Token: 0x0400082F RID: 2095
		private string _internalSubset = string.Empty;

		// Token: 0x04000830 RID: 2096
		private string _xmlLang = string.Empty;

		// Token: 0x04000831 RID: 2097
		private XmlSpace _xmlSpace;

		// Token: 0x04000832 RID: 2098
		private string _baseURI = string.Empty;

		// Token: 0x04000833 RID: 2099
		private Encoding _encoding;
	}
}
