using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет модуль привязки символов для управляемого кода.</summary>
	// Token: 0x020009D5 RID: 2517
	[ComVisible(true)]
	public interface ISymbolBinder
	{
		/// <summary>Возвращает интерфейс средства чтения символов для текущего файла.</summary>
		/// <param name="importer">Интерфейс импорта метаданных.</param>
		/// <param name="filename">Имя файла, для которого требуется интерфейс средства чтения.</param>
		/// <param name="searchPath">Путь поиска, используемый для поиска файла символов.</param>
		/// <returns>Интерфейс <see cref="T:System.Diagnostics.SymbolStore.ISymbolReader" /> для чтения символов отладки.</returns>
		// Token: 0x06005A43 RID: 23107
		[Obsolete("This interface is not 64-bit clean.  Use ISymbolBinder1 instead")]
		ISymbolReader GetReader(int importer, string filename, string searchPath);
	}
}
