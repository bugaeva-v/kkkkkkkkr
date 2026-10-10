using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Описывает исключения, происходящие в процессе <see langword="IDispatch::Invoke" />.</summary>
	// Token: 0x020007C3 RID: 1987
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct EXCEPINFO
	{
		/// <summary>Представляет код ошибки, определяющий ошибку.</summary>
		// Token: 0x04002CC8 RID: 11464
		public short wCode;

		/// <summary>Это поле зарезервировано, его значение должно быть равно 0.</summary>
		// Token: 0x04002CC9 RID: 11465
		public short wReserved;

		/// <summary>Указывает имя источника исключения. Обычно это имя приложения.</summary>
		// Token: 0x04002CCA RID: 11466
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrSource;

		/// <summary>Описывает ошибку, предназначенную для заказчика.</summary>
		// Token: 0x04002CCB RID: 11467
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrDescription;

		/// <summary>Содержит полный путь (диск, путь и имя файла) к файлу справки, содержащему дополнительные сведения об ошибке.</summary>
		// Token: 0x04002CCC RID: 11468
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrHelpFile;

		/// <summary>Указывает идентификатор контекста справки для раздела справки в файле справки.</summary>
		// Token: 0x04002CCD RID: 11469
		public int dwHelpContext;

		/// <summary>Это поле зарезервировано, его значение должно быть равно <see langword="null" />.</summary>
		// Token: 0x04002CCE RID: 11470
		public IntPtr pvReserved;

		/// <summary>Представляет указатель на функцию, использующую в качестве аргумента структуру <see cref="T:System.Runtime.InteropServices.EXCEPINFO" /> и возвращающую значение HRESULT. Чтобы избежать задержки при заполнении, этому полю присваивается значение <see langword="null" />.</summary>
		// Token: 0x04002CCF RID: 11471
		public IntPtr pfnDeferredFillIn;

		/// <summary>Возвращаемое значение, описывающее ошибку.</summary>
		// Token: 0x04002CD0 RID: 11472
		public int scode;
	}
}
