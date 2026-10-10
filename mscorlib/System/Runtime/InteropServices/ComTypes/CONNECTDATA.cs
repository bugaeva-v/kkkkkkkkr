using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает имеющееся подключение к заданной точке подключения.</summary>
	// Token: 0x020007A1 RID: 1953
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CONNECTDATA
	{
		/// <summary>Предоставляет указатель на интерфейс <see langword="IUnknown" /> подключенного вспомогательного приемника. Когда необходимость в структуре <see langword="CONNECTDATA" /> отпадет, вызывающий объект должен вызвать метод <see langword="IUnknown::Release" /> для этого указателя.</summary>
		// Token: 0x04002C47 RID: 11335
		[MarshalAs(UnmanagedType.Interface)]
		public object pUnk;

		/// <summary>Представляет маркер соединения, возвращаемый из вызова метода <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		// Token: 0x04002C48 RID: 11336
		public int dwCookie;
	}
}
