using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Создает COM-объект.</summary>
	/// <param name="aggregator">Указатель на интерфейс <see langword="IUnknown" /> управляемого объекта.</param>
	/// <returns>Объект <see cref="T:System.IntPtr" />, представляющий интерфейс <see langword="IUnknown" /> COM-объекта.</returns>
	// Token: 0x0200071B RID: 1819
	// (Invoke) Token: 0x060040E1 RID: 16609
	[ComVisible(true)]
	public delegate IntPtr ObjectCreationDelegate(IntPtr aggregator);
}
