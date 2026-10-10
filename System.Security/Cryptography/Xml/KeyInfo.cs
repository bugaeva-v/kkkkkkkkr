using System;
using System.Collections;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет элемент <see langword="&lt;KeyInfo&gt;" /> цифровой XML-подписи или XML-шифрования.</summary>
	// Token: 0x02000040 RID: 64
	public class KeyInfo : IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		// Token: 0x060001A2 RID: 418 RVA: 0x00007F75 File Offset: 0x00006175
		public KeyInfo()
		{
			this._keyInfoClauses = new ArrayList();
		}

		/// <summary>Получает или задает сведения об удостоверении ключа.</summary>
		/// <returns>Удостоверение сведений о ключе.</returns>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00007F88 File Offset: 0x00006188
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00007F90 File Offset: 0x00006190
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</returns>
		// Token: 0x060001A5 RID: 421 RVA: 0x00007F9C File Offset: 0x0000619C
		public XmlElement GetXml()
		{
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007FC0 File Offset: 0x000061C0
		internal XmlElement GetXml(XmlDocument xmlDocument)
		{
			XmlElement xmlElement = xmlDocument.CreateElement("KeyInfo", "http://www.w3.org/2000/09/xmldsig#");
			if (!string.IsNullOrEmpty(this._id))
			{
				xmlElement.SetAttribute("Id", this._id);
			}
			for (int i = 0; i < this._keyInfoClauses.Count; i++)
			{
				XmlElement xml = ((KeyInfoClause)this._keyInfoClauses[i]).GetXml(xmlDocument);
				if (xml != null)
				{
					xmlElement.AppendChild(xml);
				}
			}
			return xmlElement;
		}

		/// <summary>Загружает состояние <see cref="T:System.Security.Cryptography.Xml.KeyInfo" /> из элемента XML.</summary>
		/// <param name="value">XML-элемент, из которого загружается состояние <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060001A7 RID: 423 RVA: 0x00008038 File Offset: 0x00006238
		public void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this._id = Utils.GetAttribute(value, "Id", "http://www.w3.org/2000/09/xmldsig#");
			if (!Utils.VerifyAttributes(value, "Id"))
			{
				throw new CryptographicException("Malformed element {0}.", "KeyInfo");
			}
			for (XmlNode xmlNode = value.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				XmlElement xmlElement = xmlNode as XmlElement;
				if (xmlElement != null)
				{
					string text = xmlElement.NamespaceURI + " " + xmlElement.LocalName;
					if (text == "http://www.w3.org/2000/09/xmldsig# KeyValue")
					{
						if (!Utils.VerifyAttributes(xmlElement, null))
						{
							throw new CryptographicException("Malformed element {0}.", "KeyInfo/KeyValue");
						}
						foreach (object obj in xmlElement.ChildNodes)
						{
							XmlElement xmlElement2 = ((XmlNode)obj) as XmlElement;
							if (xmlElement2 != null)
							{
								text = text + "/" + xmlElement2.LocalName;
								break;
							}
						}
					}
					KeyInfoClause keyInfoClause = CryptoHelpers.CreateFromName<KeyInfoClause>(text);
					if (keyInfoClause == null)
					{
						keyInfoClause = new KeyInfoNode();
					}
					keyInfoClause.LoadXml(xmlElement);
					this.AddClause(keyInfoClause);
				}
			}
		}

		/// <summary>Получает число объектов <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		/// <returns>Число объектов <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />, содержащихся в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000817C File Offset: 0x0000637C
		public int Count
		{
			get
			{
				return this._keyInfoClauses.Count;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />, представляющий определенный тип сведений <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />, в объект <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		/// <param name="clause">Объект <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />, для добавления в коллекцию <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</param>
		// Token: 0x060001A9 RID: 425 RVA: 0x00008189 File Offset: 0x00006389
		public void AddClause(KeyInfoClause clause)
		{
			this._keyInfoClauses.Add(clause);
		}

		/// <summary>Возвращает перечислитель объектов <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" /> в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		/// <returns>Перечислитель подэлементов объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />, который может использоваться для перебора элементов коллекции.</returns>
		// Token: 0x060001AA RID: 426 RVA: 0x00008198 File Offset: 0x00006398
		public IEnumerator GetEnumerator()
		{
			return this._keyInfoClauses.GetEnumerator();
		}

		/// <summary>Возвращает перечислитель объектов <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" /> указанного типа в объекте <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
		/// <param name="requestedObjectType">Тип перечисляемого объекта.</param>
		/// <returns>Перечислитель подэлементов объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />, который может использоваться для перебора элементов коллекции.</returns>
		// Token: 0x060001AB RID: 427 RVA: 0x000081A8 File Offset: 0x000063A8
		public IEnumerator GetEnumerator(Type requestedObjectType)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this._keyInfoClauses)
			{
				if (requestedObjectType.Equals(obj.GetType()))
				{
					arrayList.Add(obj);
				}
			}
			return arrayList.GetEnumerator();
		}

		// Token: 0x040001A4 RID: 420
		private string _id;

		// Token: 0x040001A5 RID: 421
		private ArrayList _keyInfoClauses;
	}
}
