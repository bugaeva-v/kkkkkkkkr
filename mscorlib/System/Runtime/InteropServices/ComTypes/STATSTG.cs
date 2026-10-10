using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Содержит статистические данные об открытом объекте хранилища, потока или массива байтов.</summary>
	// Token: 0x020007AE RID: 1966
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct STATSTG
	{
		/// <summary>Представляет указатель на строку с завершающим нулем, содержащую имя объекта, описанного этой структурой.</summary>
		// Token: 0x04002C4B RID: 11339
		public string pwcsName;

		/// <summary>Показывает тип объекта хранилища, являющегося одним из значений перечисления <see langword="STGTY" />.</summary>
		// Token: 0x04002C4C RID: 11340
		public int type;

		/// <summary>Задает размер в байтах для потока или массива байтов.</summary>
		// Token: 0x04002C4D RID: 11341
		public long cbSize;

		/// <summary>Показывает время последнего изменения хранилища, потока или массива байтов.</summary>
		// Token: 0x04002C4E RID: 11342
		public FILETIME mtime;

		/// <summary>Показывает время создания хранилища, потока или массива байтов.</summary>
		// Token: 0x04002C4F RID: 11343
		public FILETIME ctime;

		/// <summary>Задает время последнего обращения к хранилищу, потоку или массиву байтов.</summary>
		// Token: 0x04002C50 RID: 11344
		public FILETIME atime;

		/// <summary>Показывает режим доступа, заданный при открытии объекта.</summary>
		// Token: 0x04002C51 RID: 11345
		public int grfMode;

		/// <summary>Показывает типы региональных блокировок, поддерживаемые потоком или массивом байтов.</summary>
		// Token: 0x04002C52 RID: 11346
		public int grfLocksSupported;

		/// <summary>Указывает идентификатор класса для объекта хранилища.</summary>
		// Token: 0x04002C53 RID: 11347
		public Guid clsid;

		/// <summary>Показывает текущие биты состояния объекта хранилища (значение чаще всего устанавливается методом <see langword="IStorage::SetStateBits" />).</summary>
		// Token: 0x04002C54 RID: 11348
		public int grfStateBits;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002C55 RID: 11349
		public int reserved;
	}
}
