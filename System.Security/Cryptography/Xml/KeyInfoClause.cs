using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все реализации подэлементов <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />.</summary>
	// Token: 0x02000041 RID: 65
	public abstract class KeyInfoClause
	{
		/// <summary>При переопределении в производном классе возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />.</returns>
		// Token: 0x060001AD RID: 429
		public abstract XmlElement GetXml();

		// Token: 0x060001AE RID: 430 RVA: 0x000081F4 File Offset: 0x000063F4
		internal virtual XmlElement GetXml(XmlDocument xmlDocument)
		{
			XmlElement xml = this.GetXml();
			return (XmlElement)xmlDocument.ImportNode(xml, true);
		}

		/// <summary>При переопределении в производный класс выполняет синтаксический анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" /> таким образом, чтобы оно совпадало с состоянием проанализированного объекта.</summary>
		/// <param name="element">Объект <see cref="T:System.Xml.XmlElement" />, указывающий состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoClause" />.</param>
		// Token: 0x060001AF RID: 431
		public abstract void LoadXml(XmlElement element);
	}
}
