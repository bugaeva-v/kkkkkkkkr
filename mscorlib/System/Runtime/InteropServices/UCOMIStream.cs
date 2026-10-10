using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IStream" />.</summary>
	// Token: 0x0200075F RID: 1887
	[Obsolete]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000000c-0000-0000-c000-000000000046")]
	[ComImport]
	public interface UCOMIStream
	{
		/// <summary>Считывает заданное число байтов из объекта-потока в память, начиная с текущего указателя поиска.</summary>
		/// <param name="pv">При удачном возвращении содержит данные, считанные из потока.</param>
		/// <param name="cb">Число байтов, которое требуется считать из объекта-потока.</param>
		/// <param name="pcbRead">Указатель на переменную <see langword="ULONG" />, получающую фактическое число байтов, считанное из объекта-потока.</param>
		// Token: 0x0600428B RID: 17035
		void Read([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] byte[] pv, int cb, IntPtr pcbRead);

		/// <summary>Записывает заданное число байтов в объект-поток, начиная с текущего указателя поиска.</summary>
		/// <param name="pv">Буфер для записи потока.</param>
		/// <param name="cb">Число байтов для записи в поток.</param>
		/// <param name="pcbWritten">При удачном возвращении содержит фактическое число байтов, записанных в объект-поток. Вызывающий оператор может установить указатель на <see langword="null" />. В этом случае метод не предоставляет фактическое число записанных байтов.</param>
		// Token: 0x0600428C RID: 17036
		void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, int cb, IntPtr pcbWritten);

		/// <summary>Изменяет положение указателя поиска относительно начала потока, конца потока или текущего указателя поиска.</summary>
		/// <param name="dlibMove">Смещение, добавляемое к <paramref name="dwOrigin" />.</param>
		/// <param name="dwOrigin">Задает исходное положение поиска. Исходное положение может быть началом файла, текущим положением указателя поиска или концом файла.</param>
		/// <param name="plibNewPosition">При удачном возвращении содержит смещение указателя поиска от начала потока.</param>
		// Token: 0x0600428D RID: 17037
		void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);

		/// <summary>Изменяет размер объекта-потока.</summary>
		/// <param name="libNewSize">Задает новый размер потока в байтах.</param>
		// Token: 0x0600428E RID: 17038
		void SetSize(long libNewSize);

		/// <summary>Копирует указанное число байтов из текущего указателя поиска данного потока в текущий указатель поиска другого потока.</summary>
		/// <param name="pstm">Ссылка на поток назначения.</param>
		/// <param name="cb">Число байтов, копируемых из потока-источника.</param>
		/// <param name="pcbRead">При удачном возвращении содержит фактическое число байтов, считанных из источника.</param>
		/// <param name="pcbWritten">При удачном возвращении содержит фактическое число байтов, записанных в поток назначения.</param>
		// Token: 0x0600428F RID: 17039
		void CopyTo(UCOMIStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);

		/// <summary>Следует убедиться, что все изменения, внесенные в объект-поток, открытый в режиме транзакций, отражены в родительском хранилище.</summary>
		/// <param name="grfCommitFlags">Необходимо проследить за фиксацией изменений объекта-потока.</param>
		// Token: 0x06004290 RID: 17040
		void Commit(int grfCommitFlags);

		/// <summary>Отменяет все изменения, выполненные в потоке, с которым шел обмен данными, с момента последнего вызова метода <see cref="M:System.Runtime.InteropServices.UCOMIStream.Commit(System.Int32)" />.</summary>
		// Token: 0x06004291 RID: 17041
		void Revert();

		/// <summary>Ограничивает доступ к указанному диапазону байтов в потоке.</summary>
		/// <param name="libOffset">Смещение в байтах для начала диапазона.</param>
		/// <param name="cb">Длина диапазона, доступ к которому ограничен, в байтах.</param>
		/// <param name="dwLockType">Запрошенные ограничения для доступа к диапазону.</param>
		// Token: 0x06004292 RID: 17042
		void LockRegion(long libOffset, long cb, int dwLockType);

		/// <summary>Удаляет ограничения доступа к диапазону байтов, установленные ранее <see cref="M:System.Runtime.InteropServices.UCOMIStream.LockRegion(System.Int64,System.Int64,System.Int32)" />.</summary>
		/// <param name="libOffset">Смещение в байтах для начала диапазона.</param>
		/// <param name="cb">Длина диапазона, доступ к которому ограничен, в байтах.</param>
		/// <param name="dwLockType">Ограничения доступа, заданные ранее для диапазона.</param>
		// Token: 0x06004293 RID: 17043
		void UnlockRegion(long libOffset, long cb, int dwLockType);

		/// <summary>Извлекает структуру <see cref="T:System.Runtime.InteropServices.STATSTG" /> для этого потока.</summary>
		/// <param name="pstatstg">При удачном возвращении содержит структуру <see langword="STATSTG" />, описывающую этот объект-поток.</param>
		/// <param name="grfStatFlag">Задает некоторые элементы структуры <see langword="STATSTG" />, не возвращаемые этим методом, позволяя сэкономить на операциях по выделению памяти.</param>
		// Token: 0x06004294 RID: 17044
		void Stat(out STATSTG pstatstg, int grfStatFlag);

		/// <summary>Создает новый объект-поток с собственным указателем поиска, ссылающимся на те же байты, что и исходный поток.</summary>
		/// <param name="ppstm">При удачном возвращении содержит новый объект-поток.</param>
		// Token: 0x06004295 RID: 17045
		void Clone(out UCOMIStream ppstm);
	}
}
