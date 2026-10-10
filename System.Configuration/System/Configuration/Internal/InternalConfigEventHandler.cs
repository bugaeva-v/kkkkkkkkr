using System;

namespace System.Configuration.Internal
{
	/// <summary>Определяет класс, используемый инфраструктурой платформы .NET Framework, для поддержки событий конфигурации.</summary>
	/// <param name="sender">Исходный объект события.</param>
	/// <param name="e">Аргумент события конфигурации.</param>
	// Token: 0x02000087 RID: 135
	// (Invoke) Token: 0x06000485 RID: 1157
	public delegate void InternalConfigEventHandler(object sender, InternalConfigEventArgs e);
}
