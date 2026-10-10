using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет метод, обрабатывающий <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> событие <see cref="T:System.Xml.Serialization.XmlSerializer" />.
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///         </param>
	/// <param name="e">
	///           Объект класса <see cref="T:System.Xml.Serialization.XmlNodeEventArgs" />, содержащий данные события.
	///         </param>
	// Token: 0x02000310 RID: 784
	// (Invoke) Token: 0x06002098 RID: 8344
	public delegate void XmlNodeEventHandler(object sender, XmlNodeEventArgs e);
}
