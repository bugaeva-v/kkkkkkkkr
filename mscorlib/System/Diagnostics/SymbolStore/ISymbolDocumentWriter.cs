using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Представляет документ, на который ссылается хранилище символов.</summary>
	// Token: 0x020009D8 RID: 2520
	[ComVisible(true)]
	public interface ISymbolDocumentWriter
	{
		/// <summary>Задает сведения о контрольной сумме.</summary>
		/// <param name="algorithmId">Идентификатор GUID, представляющий идентификатор алгоритма.</param>
		/// <param name="checkSum">Контрольная сумма.</param>
		// Token: 0x06005A4F RID: 23119
		void SetCheckSum(Guid algorithmId, byte[] checkSum);

		/// <summary>Сохраняет необработанный источник документа в хранилище символов.</summary>
		/// <param name="source">Источник документа, представленный байтами без знака.</param>
		// Token: 0x06005A50 RID: 23120
		void SetSource(byte[] source);
	}
}
