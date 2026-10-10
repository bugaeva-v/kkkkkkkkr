using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает способ маршалинга элементов массива при маршалинге массива из управляемого кода в неуправляемый код как массива <see cref="F:System.Runtime.InteropServices.UnmanagedType.SafeArray" />.</summary>
	// Token: 0x020006FC RID: 1788
	[ComVisible(true)]
	[Serializable]
	public enum VarEnum
	{
		/// <summary>Показывает, что значение не задано.</summary>
		// Token: 0x04002A74 RID: 10868
		VT_EMPTY,
		/// <summary>Показывает значение null, аналогичное значению null в SQL.</summary>
		// Token: 0x04002A75 RID: 10869
		VT_NULL,
		/// <summary>Показывает целое число <see langword="short" />.</summary>
		// Token: 0x04002A76 RID: 10870
		VT_I2,
		/// <summary>Показывает целое число <see langword="long" />.</summary>
		// Token: 0x04002A77 RID: 10871
		VT_I4,
		/// <summary>Показывает значение <see langword="float" />.</summary>
		// Token: 0x04002A78 RID: 10872
		VT_R4,
		/// <summary>Показывает значение <see langword="double" />.</summary>
		// Token: 0x04002A79 RID: 10873
		VT_R8,
		/// <summary>Показывает денежное значение.</summary>
		// Token: 0x04002A7A RID: 10874
		VT_CY,
		/// <summary>Показывает значение DATE.</summary>
		// Token: 0x04002A7B RID: 10875
		VT_DATE,
		/// <summary>Показывает строку BSTR.</summary>
		// Token: 0x04002A7C RID: 10876
		VT_BSTR,
		/// <summary>Показывает указатель <see langword="IDispatch" />.</summary>
		// Token: 0x04002A7D RID: 10877
		VT_DISPATCH,
		/// <summary>Показывает SCODE.</summary>
		// Token: 0x04002A7E RID: 10878
		VT_ERROR,
		/// <summary>Показывает логическое значение (Boolean).</summary>
		// Token: 0x04002A7F RID: 10879
		VT_BOOL,
		/// <summary>Показывает указатель <see langword="far" /> типа VARIANT.</summary>
		// Token: 0x04002A80 RID: 10880
		VT_VARIANT,
		/// <summary>Показывает указатель <see langword="IUnknown" />.</summary>
		// Token: 0x04002A81 RID: 10881
		VT_UNKNOWN,
		/// <summary>Показывает значение <see langword="decimal" />.</summary>
		// Token: 0x04002A82 RID: 10882
		VT_DECIMAL,
		/// <summary>Показывает значение <see langword="char" />.</summary>
		// Token: 0x04002A83 RID: 10883
		VT_I1 = 16,
		/// <summary>Показывает <see langword="byte" />.</summary>
		// Token: 0x04002A84 RID: 10884
		VT_UI1,
		/// <summary>Показывает <see langword="unsigned" /><see langword="short" />.</summary>
		// Token: 0x04002A85 RID: 10885
		VT_UI2,
		/// <summary>Показывает <see langword="unsigned" /><see langword="long" />.</summary>
		// Token: 0x04002A86 RID: 10886
		VT_UI4,
		/// <summary>Показывает 64-разрядное целое число.</summary>
		// Token: 0x04002A87 RID: 10887
		VT_I8,
		/// <summary>Показывает 64-разрядное целое число без знака.</summary>
		// Token: 0x04002A88 RID: 10888
		VT_UI8,
		/// <summary>Показывает целочисленное значение.</summary>
		// Token: 0x04002A89 RID: 10889
		VT_INT,
		/// <summary>Показывает целое число <see langword="unsigned" />.</summary>
		// Token: 0x04002A8A RID: 10890
		VT_UINT,
		/// <summary>Показывает <see langword="void" /> в стиле языка C.</summary>
		// Token: 0x04002A8B RID: 10891
		VT_VOID,
		/// <summary>Показывает значение HRESULT.</summary>
		// Token: 0x04002A8C RID: 10892
		VT_HRESULT,
		/// <summary>Показывает тип указателя.</summary>
		// Token: 0x04002A8D RID: 10893
		VT_PTR,
		/// <summary>Показывает SAFEARRAY. Не допустимо для значений типа VARIANT.</summary>
		// Token: 0x04002A8E RID: 10894
		VT_SAFEARRAY,
		/// <summary>Показывает массив в стиле языка C.</summary>
		// Token: 0x04002A8F RID: 10895
		VT_CARRAY,
		/// <summary>Показывает тип, определенный пользователем.</summary>
		// Token: 0x04002A90 RID: 10896
		VT_USERDEFINED,
		/// <summary>Показывает строку, заканчивающуюся нулем.</summary>
		// Token: 0x04002A91 RID: 10897
		VT_LPSTR,
		/// <summary>Показывает двухбайтную строку, завершенную <see langword="null" />.</summary>
		// Token: 0x04002A92 RID: 10898
		VT_LPWSTR,
		/// <summary>Показывает тип, определенный пользователем.</summary>
		// Token: 0x04002A93 RID: 10899
		VT_RECORD = 36,
		/// <summary>Показывает значение FILETIME.</summary>
		// Token: 0x04002A94 RID: 10900
		VT_FILETIME = 64,
		/// <summary>Показывает длину префикса в байтах.</summary>
		// Token: 0x04002A95 RID: 10901
		VT_BLOB,
		/// <summary>Показывает, что далее следует имя потока.</summary>
		// Token: 0x04002A96 RID: 10902
		VT_STREAM,
		/// <summary>Показывает, что далее следует имя хранилища.</summary>
		// Token: 0x04002A97 RID: 10903
		VT_STORAGE,
		/// <summary>Показывает, что поток содержит объект.</summary>
		// Token: 0x04002A98 RID: 10904
		VT_STREAMED_OBJECT,
		/// <summary>Показывает, что хранилище содержит объект.</summary>
		// Token: 0x04002A99 RID: 10905
		VT_STORED_OBJECT,
		/// <summary>Показывает, что BLOB-объект содержит объект.</summary>
		// Token: 0x04002A9A RID: 10906
		VT_BLOB_OBJECT,
		/// <summary>Показывает формат буфера.</summary>
		// Token: 0x04002A9B RID: 10907
		VT_CF,
		/// <summary>Показывает идентификатор ID класса.</summary>
		// Token: 0x04002A9C RID: 10908
		VT_CLSID,
		/// <summary>Показывает одномерный сосчитанный массив.</summary>
		// Token: 0x04002A9D RID: 10909
		VT_VECTOR = 4096,
		/// <summary>Показывает указатель <see langword="SAFEARRAY" />.</summary>
		// Token: 0x04002A9E RID: 10910
		VT_ARRAY = 8192,
		/// <summary>Показывает, что значение является ссылкой.</summary>
		// Token: 0x04002A9F RID: 10911
		VT_BYREF = 16384
	}
}
