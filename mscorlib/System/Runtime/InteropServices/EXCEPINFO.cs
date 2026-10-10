using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.EXCEPINFO" />.</summary>
	// Token: 0x02000730 RID: 1840
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.EXCEPINFO instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct EXCEPINFO
	{
		/// <summary>Представляет код ошибки, определяющий ошибку.</summary>
		// Token: 0x04002B6F RID: 11119
		public short wCode;

		/// <summary>Это поле зарезервировано. Его значение должно быть равно 0.</summary>
		// Token: 0x04002B70 RID: 11120
		public short wReserved;

		/// <summary>Указывает имя источника исключения. Обычно это имя приложения.</summary>
		// Token: 0x04002B71 RID: 11121
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrSource;

		/// <summary>Описывает ошибку, предназначенную для заказчика.</summary>
		// Token: 0x04002B72 RID: 11122
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrDescription;

		/// <summary>Содержит полный путь (диск, путь и имя файла) к файлу справки с дополнительными сведениями об ошибке.</summary>
		// Token: 0x04002B73 RID: 11123
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrHelpFile;

		/// <summary>Указывает идентификатор контекста справки для раздела справки в файле справки.</summary>
		// Token: 0x04002B74 RID: 11124
		public int dwHelpContext;

		/// <summary>Это поле зарезервировано. Его значение должно быть равно <see langword="null" />.</summary>
		// Token: 0x04002B75 RID: 11125
		public IntPtr pvReserved;

		/// <summary>Представляет указатель на функцию, использующую в качестве аргумента структуру <see cref="T:System.Runtime.InteropServices.EXCEPINFO" /> и возвращающую значение HRESULT. Чтобы избежать задержки при заполнении, этому полю присваивается значение <see langword="null" />.</summary>
		// Token: 0x04002B76 RID: 11126
		public IntPtr pfnDeferredFillIn;
	}
}
