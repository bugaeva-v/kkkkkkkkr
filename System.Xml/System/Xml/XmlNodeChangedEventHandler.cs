using System;

namespace System.Xml
{
	/// <summary>
	///         Представляет метод, обрабатывающий <see cref="E:System.Xml.XmlDocument.NodeChanged" />, <see cref="E:System.Xml.XmlDocument.NodeChanging" />, <see cref="E:System.Xml.XmlDocument.NodeInserted" />, <see cref="E:System.Xml.XmlDocument.NodeInserting" />, <see cref="E:System.Xml.XmlDocument.NodeRemoved" /> и <see cref="E:System.Xml.XmlDocument.NodeRemoving" /> события.
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///         </param>
	/// <param name="e">
	///           Объект <see cref="T:System.Xml.XmlNodeChangedEventArgs" />, содержащий данные события.
	///         </param>
	// Token: 0x020001D3 RID: 467
	// (Invoke) Token: 0x06001240 RID: 4672
	public delegate void XmlNodeChangedEventHandler(object sender, XmlNodeChangedEventArgs e);
}
