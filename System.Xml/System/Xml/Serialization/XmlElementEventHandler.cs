using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет метод, обрабатывающий <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> событие <see cref="T:System.Xml.Serialization.XmlSerializer" />.
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///         </param>
	/// <param name="e">
	///           Объект <see cref="T:System.Xml.Serialization.XmlElementEventArgs" />  содержащий данные события.
	///         </param>
	// Token: 0x0200030E RID: 782
	// (Invoke) Token: 0x0600208D RID: 8333
	public delegate void XmlElementEventHandler(object sender, XmlElementEventArgs e);
}
