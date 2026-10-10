using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение структуры <see langword="TYMED" />.</summary>
	// Token: 0x02000191 RID: 401
	[Flags]
	public enum TYMED
	{
		/// <summary>Среда хранения представляет собой глобальный дескриптор памяти (HGLOBAL). Глобальный дескриптор выделяется с помощью флага GMEM_SHARE. Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="GlobalFree" /> для освобождения памяти.</summary>
		// Token: 0x0400070D RID: 1805
		TYMED_HGLOBAL = 1,
		/// <summary>Среда хранения представляет собой файл на диске, заданный с помощью пути. Если элемент <see langword="STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="OpenFile" /> для удаления файла.</summary>
		// Token: 0x0400070E RID: 1806
		TYMED_FILE = 2,
		/// <summary>Среда хранения представляет собой объект потока, заданный указателем <see langword="IStream" />. <see langword="ISequentialStream::Read" /> служит для чтения данных. Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> не имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="IStream::Release" /> для освобождения компонента потока.</summary>
		// Token: 0x0400070F RID: 1807
		TYMED_ISTREAM = 4,
		/// <summary>Среда хранения представляет собой компонент хранения, заданный указателем <see langword="IStorage" />. Данные находятся в потоках и хранилищах, содержащихся в этом экземпляре <see langword="IStorage" />. Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> не имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="IStorage::Release" /> для освобождения компонента хранения.</summary>
		// Token: 0x04000710 RID: 1808
		TYMED_ISTORAGE = 8,
		/// <summary>Среда хранения представляет собой компонент "Интерфейс графических устройств" (GDI) (HBITMAP). Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="DeleteObject" /> для удаления растрового изображения.</summary>
		// Token: 0x04000711 RID: 1809
		TYMED_GDI = 16,
		/// <summary>Среда хранения представляет собой метафайл (HMETAFILE). Для доступа к данным метафайла используются функции Windows или WIN32. Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="DeleteMetaFile" /> для удаления растрового изображения.</summary>
		// Token: 0x04000712 RID: 1810
		TYMED_MFPICT = 32,
		/// <summary>Среда хранения представляет собой расширенный метафайл. Если элемент <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" /><see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> имеет значение <see langword="null" />, процесс назначения должен использовать <see langword="DeleteEnhMetaFile" /> для удаления растрового изображения.</summary>
		// Token: 0x04000713 RID: 1811
		TYMED_ENHMF = 64,
		/// <summary>Данные не передаются.</summary>
		// Token: 0x04000714 RID: 1812
		TYMED_NULL = 0
	}
}
