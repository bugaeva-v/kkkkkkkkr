using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.CONNECTDATA" />.</summary>
	// Token: 0x0200071F RID: 1823
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.CONNECTDATA instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CONNECTDATA
	{
		/// <summary>Предоставляет указатель на интерфейс <see langword="IUnknown" /> подключенного вспомогательного приемника. Когда необходимость в структуре <see langword="CONNECTDATA" /> отпадет, вызывающий объект должен вызвать метод <see langword="IUnknown::Release" /> для этого указателя.</summary>
		// Token: 0x04002B0B RID: 11019
		[MarshalAs(UnmanagedType.Interface)]
		public object pUnk;

		/// <summary>Представляет маркер соединения, возвращаемый из вызова метода <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		// Token: 0x04002B0C RID: 11020
		public int dwCookie;
	}
}
