using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.STATSTG" />.</summary>
	// Token: 0x0200074F RID: 1871
	[Obsolete]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct STATSTG
	{
		/// <summary>Указатель на строку с завершающим нулем, содержащую имя объекта, описанного этой структурой.</summary>
		// Token: 0x04002BF2 RID: 11250
		public string pwcsName;

		/// <summary>Показывает тип хранилища объекта, являющегося одним из значений перечисления <see langword="STGTY" />.</summary>
		// Token: 0x04002BF3 RID: 11251
		public int type;

		/// <summary>Указывает размер в байтах для потока или массива байтов.</summary>
		// Token: 0x04002BF4 RID: 11252
		public long cbSize;

		/// <summary>Показывает время последнего изменения хранилища, потока или массива байтов.</summary>
		// Token: 0x04002BF5 RID: 11253
		public FILETIME mtime;

		/// <summary>Показывает время создания хранилища, потока или массива байтов.</summary>
		// Token: 0x04002BF6 RID: 11254
		public FILETIME ctime;

		/// <summary>Показывает время последнего обращения к хранилищу, потоку или массиву байтов.</summary>
		// Token: 0x04002BF7 RID: 11255
		public FILETIME atime;

		/// <summary>Показывает режим доступа, заданный при открытии объекта.</summary>
		// Token: 0x04002BF8 RID: 11256
		public int grfMode;

		/// <summary>Показывает типы региональных блокировок, поддерживаемые потоком или массивом байтов.</summary>
		// Token: 0x04002BF9 RID: 11257
		public int grfLocksSupported;

		/// <summary>Указывает идентификатор класса для объекта хранилища.</summary>
		// Token: 0x04002BFA RID: 11258
		public Guid clsid;

		/// <summary>Показывает текущие биты состояния объекта хранилища (значение чаще всего устанавливается методом <see langword="IStorage::SetStateBits" />).</summary>
		// Token: 0x04002BFB RID: 11259
		public int grfStateBits;

		/// <summary>Зарезервировано для будущего использования.</summary>
		// Token: 0x04002BFC RID: 11260
		public int reserved;
	}
}
