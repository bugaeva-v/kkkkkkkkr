using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет метод, обрабатывающий <see cref="E:System.Xml.Serialization.XmlSerializer.UnreferencedObject" /> событие <see cref="T:System.Xml.Serialization.XmlSerializer" />.
	///       </summary>
	/// <param name="sender">
	///           Источник события.
	///         </param>
	/// <param name="e">
	///           Объект класса <see cref="T:System.Xml.Serialization.UnreferencedObjectEventArgs" />, содержащий данные события.
	///         </param>
	// Token: 0x02000312 RID: 786
	// (Invoke) Token: 0x060020A6 RID: 8358
	public delegate void UnreferencedObjectEventHandler(object sender, UnreferencedObjectEventArgs e);
}
