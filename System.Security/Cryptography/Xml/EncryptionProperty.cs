using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;EncryptionProperty&gt;" />, который используется при шифровании XML. Этот класс не наследуется.</summary>
	// Token: 0x0200003A RID: 58
	public sealed class EncryptionProperty
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		// Token: 0x0600016C RID: 364 RVA: 0x00002145 File Offset: 0x00000345
		public EncryptionProperty()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> с помощью объекта <see cref="T:System.Xml.XmlElement" />.</summary>
		/// <param name="elementProperty">Объект <see cref="T:System.Xml.XmlElement" />, используемый для инициализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="elementProperty" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Xml.XmlElement.LocalName" /> параметра <paramref name="elementProperty" /> не равно "EncryptionProperty".  
		/// -или- 
		/// Свойство <see cref="P:System.Xml.XmlElement.NamespaceURI" /> параметра <paramref name="elementProperty" /> не равно "http://www.w3.org/2001/04/xmlenc#".</exception>
		// Token: 0x0600016D RID: 365 RVA: 0x00007784 File Offset: 0x00005984
		public EncryptionProperty(XmlElement elementProperty)
		{
			if (elementProperty == null)
			{
				throw new ArgumentNullException("elementProperty");
			}
			if (elementProperty.LocalName != "EncryptionProperty" || elementProperty.NamespaceURI != "http://www.w3.org/2001/04/xmlenc#")
			{
				throw new CryptographicException("Malformed encryption property element.");
			}
			this._elemProp = elementProperty;
			this._cachedXml = null;
		}

		/// <summary>Получает идентификатор текущего объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		/// <returns>Идентификатор текущего объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</returns>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000077E2 File Offset: 0x000059E2
		public string Id
		{
			get
			{
				return this._id;
			}
		}

		/// <summary>Получает целевой объект объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		/// <returns>Целевой объект объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</returns>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000077EA File Offset: 0x000059EA
		public string Target
		{
			get
			{
				return this._target;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Xml.XmlElement" />, представляющий объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, представляющий объект <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства <see cref="P:System.Security.Cryptography.Xml.EncryptionProperty.PropertyElement" /> задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Xml.XmlElement.LocalName" /> значения, заданного для свойства <see cref="P:System.Security.Cryptography.Xml.EncryptionProperty.PropertyElement" />, не равно "EncryptionProperty".  
		/// -или- 
		/// Значение свойства <see cref="P:System.Xml.XmlElement.NamespaceURI" /> значения, заданного для свойства <see cref="P:System.Security.Cryptography.Xml.EncryptionProperty.PropertyElement" />, не равно "http://www.w3.org/2001/04/xmlenc#".</exception>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000077F2 File Offset: 0x000059F2
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000077FC File Offset: 0x000059FC
		public XmlElement PropertyElement
		{
			get
			{
				return this._elemProp;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.LocalName != "EncryptionProperty" || value.NamespaceURI != "http://www.w3.org/2001/04/xmlenc#")
				{
					throw new CryptographicException("Malformed encryption property element.");
				}
				this._elemProp = value;
				this._cachedXml = null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007854 File Offset: 0x00005A54
		private bool CacheValid
		{
			get
			{
				return this._cachedXml != null;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Xml.XmlElement" />, который инкапсулирует экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, который инкапсулирует экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" />.</returns>
		// Token: 0x06000173 RID: 371 RVA: 0x00007860 File Offset: 0x00005A60
		public XmlElement GetXml()
		{
			if (this.CacheValid)
			{
				return this._cachedXml;
			}
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007890 File Offset: 0x00005A90
		internal XmlElement GetXml(XmlDocument document)
		{
			return document.ImportNode(this._elemProp, true) as XmlElement;
		}

		/// <summary>Выполняет синтаксический анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.EncryptionProperty" /> таким образом, чтобы оно совпадало с состоянием проанализированного объекта.</summary>
		/// <param name="value">Анализируемый объект <see cref="T:System.Xml.XmlElement" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Xml.XmlElement.LocalName" /> параметра <paramref name="value" /> не равно "EncryptionProperty".  
		/// -или- 
		/// Свойство <see cref="P:System.Xml.XmlElement.NamespaceURI" /> параметра <paramref name="value" /> не равно "http://www.w3.org/2001/04/xmlenc#".</exception>
		// Token: 0x06000175 RID: 373 RVA: 0x000078A4 File Offset: 0x00005AA4
		public void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.LocalName != "EncryptionProperty" || value.NamespaceURI != "http://www.w3.org/2001/04/xmlenc#")
			{
				throw new CryptographicException("Malformed encryption property element.");
			}
			this._cachedXml = value;
			this._id = Utils.GetAttribute(value, "Id", "http://www.w3.org/2001/04/xmlenc#");
			this._target = Utils.GetAttribute(value, "Target", "http://www.w3.org/2001/04/xmlenc#");
			this._elemProp = value;
		}

		// Token: 0x0400019C RID: 412
		private string _target;

		// Token: 0x0400019D RID: 413
		private string _id;

		// Token: 0x0400019E RID: 414
		private XmlElement _elemProp;

		// Token: 0x0400019F RID: 415
		private XmlElement _cachedXml;
	}
}
