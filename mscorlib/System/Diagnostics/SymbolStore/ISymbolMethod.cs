using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет метод в хранилище символов.</summary>
	// Token: 0x020009D9 RID: 2521
	[ComVisible(true)]
	public interface ISymbolMethod
	{
		/// <summary>Получает корневую лексическую область для текущего метода. Эта область включает весь метод.</summary>
		/// <returns>Корневая лексическая область, которая включает весь метод.</returns>
		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06005A51 RID: 23121
		ISymbolScope RootScope { get; }

		/// <summary>Возвращает число точек следования в методе.</summary>
		/// <returns>Число точек следования в методе.</returns>
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06005A52 RID: 23122
		int SequencePointCount { get; }

		/// <summary>Возвращает объект <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" />, содержащий метаданные для текущего метода.</summary>
		/// <returns>маркер метаданных для текущего метода.</returns>
		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06005A53 RID: 23123
		SymbolToken Token { get; }

		/// <summary>Получает пространство имен, в котором определен текущий метод.</summary>
		/// <returns>Пространство имен, в котором определен текущий метод.</returns>
		// Token: 0x06005A54 RID: 23124
		ISymbolNamespace GetNamespace();

		/// <summary>Получает смещение на языке MSIL в методе, соответствующее заданной позиции.</summary>
		/// <param name="document">Документ, для которого запрашивается смещение.</param>
		/// <param name="line">Строка документа, соответствующая смещению.</param>
		/// <param name="column">Столбец документа, соответствующий смещению.</param>
		/// <returns>Смещение в заданном документе.</returns>
		// Token: 0x06005A55 RID: 23125
		int GetOffset(ISymbolDocument document, int line, int column);

		/// <summary>Получает параметры текущего метода.</summary>
		/// <returns>Массив параметров текущего метода.</returns>
		// Token: 0x06005A56 RID: 23126
		ISymbolVariable[] GetParameters();

		/// <summary>Получает массив пар начального и конечного смещения, соответствующих диапазонам на языке MSIL, занимаемым данной позицией в этом методе.</summary>
		/// <param name="document">Документ, для которого запрашивается смещение.</param>
		/// <param name="line">Строка документа, соответствующая этим диапазонам.</param>
		/// <param name="column">Столбец документа, соответствующий этим диапазонам.</param>
		/// <returns>Массив пар начального и конечного смещения.</returns>
		// Token: 0x06005A57 RID: 23127
		int[] GetRanges(ISymbolDocument document, int line, int column);

		/// <summary>Для заданного смещения в методе возвращает наиболее узкую внешнюю лексическую область.</summary>
		/// <param name="offset">Смещение в байтах лексической области в методе.</param>
		/// <returns>Наиболее узкая внешняя лексическая область для заданного смещения в байтах в методе.</returns>
		// Token: 0x06005A58 RID: 23128
		ISymbolScope GetScope(int offset);

		/// <summary>Получает точки следования для текущего метода.</summary>
		/// <param name="offsets">Массив смещений в байтах от начала метода для точек следования.</param>
		/// <param name="documents">Массив документов, в которых находятся точки следования.</param>
		/// <param name="lines">Массив строк в документах, в которых находятся точки следования.</param>
		/// <param name="columns">Массив столбцов в документах, в которых находятся точки следования.</param>
		/// <param name="endLines">Массив строк в документах, в которых заканчиваются точки следования.</param>
		/// <param name="endColumns">Массив столбцов в документах, в которых заканчиваются точки следования.</param>
		// Token: 0x06005A59 RID: 23129
		void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns);

		/// <summary>Получает начальную и конечную позицию для исходных документов текущего метода.</summary>
		/// <param name="docs">Начальный и конечный исходные документы.</param>
		/// <param name="lines">Начальная и конечная строки соответствующих исходных документов.</param>
		/// <param name="columns">Начальный и конечный столбцы соответствующих исходных документов.</param>
		/// <returns>Значение <see langword="true" />, если эти позиции определены; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005A5A RID: 23130
		bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns);
	}
}
