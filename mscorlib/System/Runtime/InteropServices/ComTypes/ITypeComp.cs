using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="ITypeComp" />.</summary>
	// Token: 0x020007B2 RID: 1970
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00020403-0000-0000-C000-000000000046")]
	[ComImport]
	public interface ITypeComp
	{
		/// <summary>Сопоставляет имя с типом элемента или связывает глобальные переменные и функции, содержащиеся в библиотеке типов.</summary>
		/// <param name="szName">Привязываемое имя.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szName" />, рассчитанное при помощи <see langword="LHashValOfNameSys" />.</param>
		/// <param name="wFlags">Слово флагов, содержащее один или несколько используемых флагов, определенных в перечислении <see langword="INVOKEKIND" />.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит ссылку на описание типа, содержащее элемент, с которым этот тип связан, если возвращено значение <see langword="FUNCDESC" /> или <see langword="VARDESC" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pDescKind">При возвращении данного метода содержит ссылку на перечислитель <see langword="DESCKIND" />, указывающий, является ли имя, к которому выполняется привязка, <see langword="VARDESC" />, <see langword="FUNCDESC" /> или <see langword="TYPECOMP" />. Этот параметр передается неинициализированным.</param>
		/// <param name="pBindPtr">При возвращении данного метода содержит ссылку на интерфейс <see langword="VARDESC" />, <see langword="FUNCDESC" /> или <see langword="ITypeComp" />, к которому выполняется привязка. Этот параметр передается неинициализированным.</param>
		// Token: 0x06004559 RID: 17753
		void Bind([MarshalAs(UnmanagedType.LPWStr)] string szName, int lHashVal, short wFlags, out ITypeInfo ppTInfo, out DESCKIND pDescKind, out BINDPTR pBindPtr);

		/// <summary>Выполняет привязку к описаниям типов, содержащимся в библиотеке типов.</summary>
		/// <param name="szName">Привязываемое имя.</param>
		/// <param name="lHashVal">Хэш-значение для <paramref name="szName" />, определенное при помощи <see langword="LHashValOfNameSys" />.</param>
		/// <param name="ppTInfo">При возвращении данного метода содержит ссылку на <see langword="ITypeInfo" /> типа, к которому был привязан параметр <paramref name="szName" />. Этот параметр передается неинициализированным.</param>
		/// <param name="ppTComp">При возвращении данного метода содержит ссылку на переменную <see langword="ITypeComp" />. Этот параметр передается неинициализированным.</param>
		// Token: 0x0600455A RID: 17754
		void BindType([MarshalAs(UnmanagedType.LPWStr)] string szName, int lHashVal, out ITypeInfo ppTInfo, out ITypeComp ppTComp);
	}
}
