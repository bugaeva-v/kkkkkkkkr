using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение структуры <see langword="STGMEDIUM" />.</summary>
	// Token: 0x02000190 RID: 400
	public struct STGMEDIUM
	{
		/// <summary>Представляет указатель на экземпляр интерфейса, который позволяет отправляющему процессу контролировать способ освобождения хранилища при вызове функции <see langword="ReleaseStgMedium" /> получающим процессом. Если <see cref="F:System.Runtime.InteropServices.ComTypes.STGMEDIUM.pUnkForRelease" /> равняется <see langword="null" />, <see langword="ReleaseStgMedium" /> использует процедуры по умолчанию для освобождения хранилища; в противном случае <see langword="ReleaseStgMedium" /> использует заданный интерфейс <see langword="IUnknown" />.</summary>
		// Token: 0x04000709 RID: 1801
		[MarshalAs(UnmanagedType.IUnknown)]
		public object pUnkForRelease;

		/// <summary>Задает тип среды хранения. Процедура маршалинга и процедура распаковки используют это значение, чтобы определить, какой элемент объединения использовался. Это значение должно быть одним из элементов перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.TYMED" />.</summary>
		// Token: 0x0400070A RID: 1802
		public TYMED tymed;

		/// <summary>Представляет дескриптор, строку или указатель интерфейса, которые получающий процесс может использовать для доступа к передаваемым данным.</summary>
		// Token: 0x0400070B RID: 1803
		public IntPtr unionmember;
	}
}
