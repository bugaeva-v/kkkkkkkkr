using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет подэлемент <see langword="&lt;KeyName&gt;" /> элемента <see langword="&lt;KeyInfo&gt;" /> подписи XMLDSIG или XML-шифрования.</summary>
	// Token: 0x02000043 RID: 67
	public class KeyInfoName : KeyInfoClause
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" />.</summary>
		// Token: 0x060001B7 RID: 439 RVA: 0x000082A1 File Offset: 0x000064A1
		public KeyInfoName() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" /> путем указания строкового идентификатора, который является значением элемента <see langword="&lt;KeyName&gt;" />.</summary>
		/// <param name="keyName">Строковый идентификатор, являющийся значением элемента <see langword="&lt;KeyName&gt;" />.</param>
		// Token: 0x060001B8 RID: 440 RVA: 0x000082AA File Offset: 0x000064AA
		public KeyInfoName(string keyName)
		{
			this.Value = keyName;
		}

		/// <summary>Получает или задает строковый идентификатор, содержащийся в элементе <see langword="&lt;KeyName&gt;" />.</summary>
		/// <returns>Строковый идентификатор, являющийся значением элемента <see langword="&lt;KeyName&gt;" />.</returns>
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000082B9 File Offset: 0x000064B9
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000082C1 File Offset: 0x000064C1
		public string Value
		{
			get
			{
				return this._keyName;
			}
			set
			{
				this._keyName = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" />.</returns>
		// Token: 0x060001BB RID: 443 RVA: 0x000082CC File Offset: 0x000064CC
		public override XmlElement GetXml()
		{
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000082ED File Offset: 0x000064ED
		internal override XmlElement GetXml(XmlDocument xmlDocument)
		{
			XmlElement xmlElement = xmlDocument.CreateElement("KeyName", "http://www.w3.org/2000/09/xmldsig#");
			xmlElement.AppendChild(xmlDocument.CreateTextNode(this._keyName));
			return xmlElement;
		}

		/// <summary>Выполняет анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" /> для сопоставления.</summary>
		/// <param name="value">Объект <see cref="T:System.Xml.XmlElement" />, определяющий состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060001BD RID: 445 RVA: 0x00008314 File Offset: 0x00006514
		public override void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this._keyName = value.InnerText.Trim();
		}

		// Token: 0x040001A7 RID: 423
		private string _keyName;
	}
}
