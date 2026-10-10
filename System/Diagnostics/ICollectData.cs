using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Подготавливает данные о производительности для библиотеки производительности DLL, которая загружается системой при работе со счетчиками производительности.</summary>
	// Token: 0x02000268 RID: 616
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("73386977-D6FD-11D2-BED5-00C04F79E3AE")]
	[ComImport]
	public interface ICollectData
	{
		/// <summary>Вызывается функцией закрытия данных о производительности библиотеки производительности DLL.</summary>
		// Token: 0x0600136A RID: 4970
		void CloseData();

		/// <summary>Собирает данные о производительности для библиотеки производительности DLL.</summary>
		/// <param name="id">Индекс вызова.</param>
		/// <param name="valueName">Указатель на список строк в формате Юникод с запрашиваемыми идентификаторами объектов.</param>
		/// <param name="data">Указатель на буфер данных.</param>
		/// <param name="totalBytes">Указатель на число байтов.</param>
		/// <param name="res">Возвращаемые этим методом данные содержат в первом байте после данных структуру <see cref="T:System.IntPtr" /> (-1 для ошибки или -2, если требуется буфер большего размера). Этот параметр передается неинициализированным.</param>
		// Token: 0x0600136B RID: 4971
		[return: MarshalAs(UnmanagedType.I4)]
		void CollectData([MarshalAs(UnmanagedType.I4)] [In] int id, [MarshalAs(UnmanagedType.SysInt)] [In] IntPtr valueName, [MarshalAs(UnmanagedType.SysInt)] [In] IntPtr data, [MarshalAs(UnmanagedType.I4)] [In] int totalBytes, [MarshalAs(UnmanagedType.SysInt)] out IntPtr res);
	}
}
