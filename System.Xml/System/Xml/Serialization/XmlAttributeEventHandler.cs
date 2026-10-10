using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет метод, обрабатывающий <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" />
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///         </param>
	/// <param name="e">
	///           Объект класса <see cref="T:System.Xml.Serialization.XmlAttributeEventArgs" />, содержащий данные события.
	///         </param>
	// Token: 0x0200030C RID: 780
	// (Invoke) Token: 0x06002082 RID: 8322
	public delegate void XmlAttributeEventHandler(object sender, XmlAttributeEventArgs e);
}
