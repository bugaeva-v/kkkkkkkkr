using System;

namespace System.Reflection
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Reflection.Assembly.ModuleResolve" /> для <see cref="T:System.Reflection.Assembly" />.</summary>
	/// <param name="sender">Сборка, которая служила источником события.</param>
	/// <param name="e">Аргументы, предоставленные объектом, описывающим событие.</param>
	/// <returns>Модуль, удовлетворяющий запросу.</returns>
	// Token: 0x020008B2 RID: 2226
	// (Invoke) Token: 0x060049AF RID: 18863
	public delegate Module ModuleResolveEventHandler(object sender, ResolveEventArgs e);
}
