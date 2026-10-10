using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет документ, на который ссылается хранилище символов.</summary>
	// Token: 0x020009D7 RID: 2519
	[ComVisible(true)]
	public interface ISymbolDocument
	{
		/// <summary>Возвращает идентификатор алгоритма подсчета контрольной суммы.</summary>
		/// <returns>Идентификатор GUID алгоритма подсчета контрольной суммы. Все значения равны нулю, если контрольная сумма отсутствует.</returns>
		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06005A45 RID: 23109
		Guid CheckSumAlgorithmId { get; }

		/// <summary>Возвращает тип текущего документа.</summary>
		/// <returns>Тип текущего документа.</returns>
		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06005A46 RID: 23110
		Guid DocumentType { get; }

		/// <summary>Проверяет, хранится ли текущий документ в хранилище символов.</summary>
		/// <returns>Возвращает значение <see langword="true" />, если текущий документ хранится в хранилище символов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06005A47 RID: 23111
		bool HasEmbeddedSource { get; }

		/// <summary>Возвращает язык текущего документа.</summary>
		/// <returns>Язык текущего документа.</returns>
		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06005A48 RID: 23112
		Guid Language { get; }

		/// <summary>Возвращает поставщика языка текущего документа.</summary>
		/// <returns>Поставщик языка текущего документа.</returns>
		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06005A49 RID: 23113
		Guid LanguageVendor { get; }

		/// <summary>Возвращает длину внедренного источника в байтах.</summary>
		/// <returns>Длина источника текущего документа.</returns>
		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06005A4A RID: 23114
		int SourceLength { get; }

		/// <summary>Возвращает URL-адрес текущего документа.</summary>
		/// <returns>URL-адрес текущего документа.</returns>
		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06005A4B RID: 23115
		string URL { get; }

		/// <summary>Возвращает ближайшую строку, являющуюся точкой следования, для заданной строки документа, которая может являться или не являться точкой следования.</summary>
		/// <param name="line">Заданная строка в документе.</param>
		/// <returns>Ближайшая строка, являющаяся точкой следования.</returns>
		// Token: 0x06005A4C RID: 23116
		int FindClosestLine(int line);

		/// <summary>Возвращает контрольную сумму.</summary>
		/// <returns>Контрольная сумма.</returns>
		// Token: 0x06005A4D RID: 23117
		byte[] GetCheckSum();

		/// <summary>Возвращает внедренный источник документа для указанного диапазона.</summary>
		/// <param name="startLine">Начальная строка текущего документа.</param>
		/// <param name="startColumn">Начальный столбец текущего документа.</param>
		/// <param name="endLine">Конечная строка текущего документа.</param>
		/// <param name="endColumn">Конечный столбец текущего документа.</param>
		/// <returns>Источник документа для указанного диапазона.</returns>
		// Token: 0x06005A4E RID: 23118
		byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn);
	}
}
