using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumString" />.</summary>
	// Token: 0x0200075A RID: 1882
	[Guid("00000101-0000-0000-c000-000000000046")]
	[Obsolete]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIEnumString
	{
		/// <summary>Возвращает заданное число элементов последовательности перечисления.</summary>
		/// <param name="celt">Число строк для возвращения в параметре <paramref name="rgelt" />.</param>
		/// <param name="rgelt">При успешном возвращении — ссылка на перечисленные строки.</param>
		/// <param name="pceltFetched">При успешном возвращении — ссылка на действительное число срок, перечисленных в параметре <paramref name="rgelt" />.</param>
		/// <returns>Значение <see langword="S_OK" />, если параметр <paramref name="pceltFetched" /> равен параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004262 RID: 16994
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] [Out] string[] rgelt, out int pceltFetched);

		/// <summary>Пропускает заданное число элементов в последовательности перечисления.</summary>
		/// <param name="celt">Число элементов, пропускаемых при перечислении.</param>
		/// <returns>Значение <see langword="S_OK" />, если число пропущенных элементов соответствует параметру <paramref name="celt" />; в противном случае — значение <see langword="S_FALSE" />.</returns>
		// Token: 0x06004263 RID: 16995
		[PreserveSig]
		int Skip(int celt);

		/// <summary>Сбрасывает последовательность перечисления в начало.</summary>
		/// <returns>HRESULT со значением <see langword="S_OK" />.</returns>
		// Token: 0x06004264 RID: 16996
		[PreserveSig]
		int Reset();

		/// <summary>Создает другой перечислитель с тем же состоянием перечисления, что и текущий.</summary>
		/// <param name="ppenum">При успешном возвращении — ссылка на созданный перечислитель.</param>
		// Token: 0x06004265 RID: 16997
		void Clone(out UCOMIEnumString ppenum);
	}
}
