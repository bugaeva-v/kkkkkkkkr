using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Представляет метод для обработки заголовков в потоке при десериализации.</summary>
	/// <param name="headers">Заголовки события.</param>
	/// <returns>
	///   <see cref="T:System.Object" />, передающий информацию об удаленном вызове функции.</returns>
	// Token: 0x02000619 RID: 1561
	// (Invoke) Token: 0x06003AF0 RID: 15088
	[ComVisible(true)]
	public delegate object HeaderHandler(Header[] headers);
}
