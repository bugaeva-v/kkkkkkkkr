using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.LIBFLAGS" />.</summary>
	// Token: 0x02000746 RID: 1862
	[Obsolete]
	[Flags]
	[Serializable]
	public enum LIBFLAGS : short
	{
		/// <summary>Библиотека типов ограничена и не должна отображаться для пользователей.</summary>
		// Token: 0x04002BC7 RID: 11207
		LIBFLAG_FRESTRICTED = 1,
		/// <summary>Библиотеки типов описывают элементы управления и не отображаются в обозревателях типов, предназначенных для неотображаемых объектов.</summary>
		// Token: 0x04002BC8 RID: 11208
		LIBFLAG_FCONTROL = 2,
		/// <summary>Библиотеку типов не следует отображать для пользователей, хотя ее использование не ограничено. Должна использоваться элементами управления. узлы должны создавать новую библиотеку типов, инкапсулирующую элемент управления с расширенными свойствами.</summary>
		// Token: 0x04002BC9 RID: 11209
		LIBFLAG_FHIDDEN = 4,
		/// <summary>Библиотека типов хранится на диске.</summary>
		// Token: 0x04002BCA RID: 11210
		LIBFLAG_FHASDISKIMAGE = 8
	}
}
