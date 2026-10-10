using System;

namespace System.Configuration.Internal
{
	/// <summary>Представляет метод для узелов, который позволяет делать вызов при контролируемом изменении потока.</summary>
	/// <param name="streamName">Имя объекта <see cref="T:System.IO.Stream" />, выполняющего операции ввода-вывода при работе с файлом конфигурации.</param>
	// Token: 0x02000088 RID: 136
	// (Invoke) Token: 0x06000489 RID: 1161
	public delegate void StreamChangeCallback(string streamName);
}
