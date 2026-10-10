using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IStream" /> с функциональными возможностями <see langword="ISequentialStream" />.</summary>
	// Token: 0x020007AF RID: 1967
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000000c-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IStream
	{
		/// <summary>Считывает заданное число байтов из объекта-потока в память, начиная с текущего указателя поиска.</summary>
		/// <param name="pv">При возвращении данного метода содержит данные, считанные из потока. Этот параметр передается неинициализированным.</param>
		/// <param name="cb">Число байтов, которое требуется считать из объекта-потока.</param>
		/// <param name="pcbRead">Указатель на переменную <see langword="ULONG" />, получающую фактическое число байтов, считанное из объекта потока.</param>
		// Token: 0x0600454E RID: 17742
		void Read([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] byte[] pv, int cb, IntPtr pcbRead);

		/// <summary>Записывает заданное число байтов в объект-поток, начиная с текущего указателя поиска.</summary>
		/// <param name="pv">Буфер для записи потока.</param>
		/// <param name="cb">Число байтов, записываемое в поток.</param>
		/// <param name="pcbWritten">При удачном возвращении содержит фактическое число байтов, записанных в объект-поток. Если вызывающий объект задает для этого указателя значение <see cref="F:System.IntPtr.Zero" />, данный метод не предоставляет фактическое число записанных байтов.</param>
		// Token: 0x0600454F RID: 17743
		void Write([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, int cb, IntPtr pcbWritten);

		/// <summary>Изменяет положение указателя поиска относительно начала потока, конца потока или текущего указателя поиска.</summary>
		/// <param name="dlibMove">Смещение, добавляемое к <paramref name="dwOrigin" />.</param>
		/// <param name="dwOrigin">Исходное положение поиска. Исходное положение может быть началом файла, текущим положением указателя поиска или концом файла.</param>
		/// <param name="plibNewPosition">При удачном возвращении содержит смещение указателя поиска от начала потока.</param>
		// Token: 0x06004550 RID: 17744
		void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition);

		/// <summary>Изменяет размер объекта-потока.</summary>
		/// <param name="libNewSize">Новый размер потока в байтах.</param>
		// Token: 0x06004551 RID: 17745
		void SetSize(long libNewSize);

		/// <summary>Копирует указанное число байтов из текущего указателя поиска данного потока в текущий указатель поиска другого потока.</summary>
		/// <param name="pstm">Ссылка на поток назначения.</param>
		/// <param name="cb">Число байтов, копируемых из потока-источника.</param>
		/// <param name="pcbRead">При удачном возвращении содержит фактическое число байтов, считанных из источника.</param>
		/// <param name="pcbWritten">При удачном возвращении содержит фактическое число байтов, записанных в поток назначения.</param>
		// Token: 0x06004552 RID: 17746
		void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten);

		/// <summary>Следует убедиться, что все изменения, внесенные в объект потока, открытый в режиме транзакций, отражены в родительском хранилище.</summary>
		/// <param name="grfCommitFlags">Значение, контролирующее выполнение изменений объекта потока.</param>
		// Token: 0x06004553 RID: 17747
		void Commit(int grfCommitFlags);

		/// <summary>Отменяет все изменения, выполненные в потоке, с которым шел обмен данными, с момента последнего вызова метода <see cref="M:System.Runtime.InteropServices.ComTypes.IStream.Commit(System.Int32)" />.</summary>
		// Token: 0x06004554 RID: 17748
		void Revert();

		/// <summary>Ограничивает доступ к указанному диапазону байтов в потоке.</summary>
		/// <param name="libOffset">Смещение в байтах для начала диапазона.</param>
		/// <param name="cb">Длина диапазона, доступ к которому ограничен, в байтах.</param>
		/// <param name="dwLockType">Запрошенные ограничения для доступа к диапазону.</param>
		// Token: 0x06004555 RID: 17749
		void LockRegion(long libOffset, long cb, int dwLockType);

		/// <summary>Удаляет ограничения доступа к диапазону байтов, установленные ранее с помощью метода <see cref="M:System.Runtime.InteropServices.ComTypes.IStream.LockRegion(System.Int64,System.Int64,System.Int32)" />.</summary>
		/// <param name="libOffset">Смещение в байтах для начала диапазона.</param>
		/// <param name="cb">Длина диапазона, доступ к которому ограничен, в байтах.</param>
		/// <param name="dwLockType">Ограничения доступа, заданные ранее для диапазона.</param>
		// Token: 0x06004556 RID: 17750
		void UnlockRegion(long libOffset, long cb, int dwLockType);

		/// <summary>Извлекает структуру <see cref="T:System.Runtime.InteropServices.STATSTG" /> для этого потока.</summary>
		/// <param name="pstatstg">При возвращении данного метода содержит структуру <see langword="STATSTG" />, описывающую этот объект потока. Этот параметр передается неинициализированным.</param>
		/// <param name="grfStatFlag">Элементы структуры <see langword="STATSTG" />, не возвращаемые этим методом, таким образом получается сэкономить на операциях по выделению памяти.</param>
		// Token: 0x06004557 RID: 17751
		void Stat(out STATSTG pstatstg, int grfStatFlag);

		/// <summary>Создает новый объект-поток с собственным указателем поиска, ссылающимся на те же байты, что и исходный поток.</summary>
		/// <param name="ppstm">При возвращении данного метода содержит новый объект потока. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004558 RID: 17752
		void Clone(out IStream ppstm);
	}
}
