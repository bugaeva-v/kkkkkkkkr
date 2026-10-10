using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName" /> диспетчера сериализации.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.Design.Serialization.ResolveNameEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000491 RID: 1169
	// (Invoke) Token: 0x06002554 RID: 9556
	public delegate void ResolveNameEventHandler(object sender, ResolveNameEventArgs e);
}
