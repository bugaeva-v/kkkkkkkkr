using System;

namespace System
{
	/// <summary>Представляет метод, который будет обрабатывать событие, вызванное исключением, которое не обрабатывается доменом приложения.</summary>
	/// <param name="sender">Источник события необработанного исключения.</param>
	/// <param name="e">Объект UnhandledExceptionEventArgs, содержащий данные события.</param>
	// Token: 0x020001AB RID: 427
	// (Invoke) Token: 0x06001267 RID: 4711
	[Serializable]
	public delegate void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e);
}
