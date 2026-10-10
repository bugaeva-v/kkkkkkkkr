using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeComp" />.</summary>
	// Token: 0x02000760 RID: 1888
	[Obsolete]
	[Guid("00020403-0000-0000-c000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMITypeComp
	{
		/// <summary>Сопоставляет имя с типом элемента или связывает глобальные переменные и функции, содержащиеся в библиотеке типов.</summary>
		/// <param name="szName">Привязываемое имя.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szName" />, рассчитанное при помощи <see langword="LHashValOfNameSys" />.</param>
		/// <param name="wFlags">Слово флагов, содержащее один или несколько используемых флагов, определенных в перечислении <see langword="INVOKEKIND" />.</param>
		/// <param name="ppTInfo">При удачном возвращении, если возвращены значения <see langword="FUNCDESC" /> или <see langword="VARDESC" /> — ссылка на описание типа, содержащее элемент, с которым этот тип связан.</param>
		/// <param name="pDescKind">Ссылка на перечисление <see langword="DESCKIND" />, показывающая, является ли привязанное имя <see langword="VARDESC" />, <see langword="FUNCDESC" /> или <see langword="TYPECOMP" />.</param>
		/// <param name="pBindPtr">Ссылка на интерфейс <see langword="VARDESC" />, <see langword="FUNCDESC" /> или <see langword="ITypeComp" />, к которому выполнена привязка.</param>
		// Token: 0x06004296 RID: 17046
		void Bind([MarshalAs(UnmanagedType.LPWStr)] string szName, int lHashVal, short wFlags, out UCOMITypeInfo ppTInfo, out DESCKIND pDescKind, out BINDPTR pBindPtr);

		/// <summary>Выполняет привязку к описаниям типов, содержащимся в библиотеке типов.</summary>
		/// <param name="szName">Привязываемое имя.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szName" />, определенное при помощи <see langword="LHashValOfNameSys" />.</param>
		/// <param name="ppTInfo">При успешном возвращении — ссылка на переменную <see langword="ITypeInfo" /> типа, к которому привязан параметр <paramref name="szName" />.</param>
		/// <param name="ppTComp">При успешном возвращении — ссылка на переменную <see langword="ITypeComp" />.</param>
		// Token: 0x06004297 RID: 17047
		void BindType([MarshalAs(UnmanagedType.LPWStr)] string szName, int lHashVal, out UCOMITypeInfo ppTInfo, out UCOMITypeComp ppTComp);
	}
}
