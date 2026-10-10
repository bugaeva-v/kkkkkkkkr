using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет модуль привязки символов для управляемого кода.</summary>
	// Token: 0x020009D6 RID: 2518
	[ComVisible(true)]
	public interface ISymbolBinder1
	{
		/// <summary>Возвращает интерфейс средства чтения символов для текущего файла.</summary>
		/// <param name="importer">Объект <see cref="T:System.IntPtr" />, ссылающийся на интерфейс импорта метаданных.</param>
		/// <param name="filename">Имя файла, для которого требуется интерфейс средства чтения.</param>
		/// <param name="searchPath">Путь поиска, используемый для поиска файла символов.</param>
		/// <returns>Интерфейс <see cref="T:System.Diagnostics.SymbolStore.ISymbolReader" /> для чтения символов отладки.</returns>
		// Token: 0x06005A44 RID: 23108
		ISymbolReader GetReader(IntPtr importer, string filename, string searchPath);
	}
}
