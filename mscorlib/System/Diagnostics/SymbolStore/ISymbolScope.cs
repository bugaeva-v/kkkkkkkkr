using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет лексическую область видимости в объекте <see cref="T:System.Diagnostics.SymbolStore.ISymbolMethod" />, обеспечивая доступ к начальному и конечному смещениям этой области, а также к ее дочерним и родительской областям.</summary>
	// Token: 0x020009DC RID: 2524
	[ComVisible(true)]
	public interface ISymbolScope
	{
		/// <summary>Возвращает конечное смещение текущей лексической области видимости.</summary>
		/// <returns>Конечное смещение текущей лексической области.</returns>
		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06005A68 RID: 23144
		int EndOffset { get; }

		/// <summary>Возвращает метод, содержащий текущую лексическую область видимости.</summary>
		/// <returns>Метод, содержащий текущую лексическую область видимости.</returns>
		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06005A69 RID: 23145
		ISymbolMethod Method { get; }

		/// <summary>Возвращает родительскую лексическую область видимости текущей области видимости.</summary>
		/// <returns>Родительская лексическая область текущей области.</returns>
		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06005A6A RID: 23146
		ISymbolScope Parent { get; }

		/// <summary>Возвращает начальное смещение текущей лексической области видимости.</summary>
		/// <returns>Начальное смещение текущей лексической области.</returns>
		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06005A6B RID: 23147
		int StartOffset { get; }

		/// <summary>Возвращает дочерние лексические области видимости текущей лексической области видимости.</summary>
		/// <returns>Дочерние лексические области текущей лексической области.</returns>
		// Token: 0x06005A6C RID: 23148
		ISymbolScope[] GetChildren();

		/// <summary>Возвращает локальные переменные в текущей лексической области видимости.</summary>
		/// <returns>Локальные переменные в текущей лексической области видимости.</returns>
		// Token: 0x06005A6D RID: 23149
		ISymbolVariable[] GetLocals();

		/// <summary>Получает пространства имен, используемые в текущей области.</summary>
		/// <returns>Пространства имен, используемые в текущей области.</returns>
		// Token: 0x06005A6E RID: 23150
		ISymbolNamespace[] GetNamespaces();
	}
}
