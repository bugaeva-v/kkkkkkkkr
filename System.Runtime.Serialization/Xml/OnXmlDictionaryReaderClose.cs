using System;

namespace System.Xml
{
	/// <summary>
	///   <see langword="delegate" /> для метода обратного вызова при закрытии модуля чтения.</summary>
	/// <param name="reader">Объект <see cref="T:System.Xml.XmlDictionaryReader" />, который инициирует событие <c>OnClose</c>.</param>
	// Token: 0x0200005F RID: 95
	// (Invoke) Token: 0x06000473 RID: 1139
	public delegate void OnXmlDictionaryReaderClose(XmlDictionaryReader reader);
}
