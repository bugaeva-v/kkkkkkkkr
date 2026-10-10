using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет флаги, применяемые к библиотекам и типам.</summary>
	// Token: 0x020007CC RID: 1996
	[Flags]
	[Serializable]
	public enum LIBFLAGS : short
	{
		/// <summary>Библиотека типов ограничена и не должна отображаться для пользователей.</summary>
		// Token: 0x04002D09 RID: 11529
		LIBFLAG_FRESTRICTED = 1,
		/// <summary>Библиотеки типов описывают элементы управления и не отображаются в обозревателях типов, предназначенных для невизуальных объектов.</summary>
		// Token: 0x04002D0A RID: 11530
		LIBFLAG_FCONTROL = 2,
		/// <summary>Библиотеку типов не следует отображать для пользователей, хотя ее использование не ограничено. Библиотеку типов не следует использовать с помощью элементов управления. узлы должны создавать новую библиотеку типов, инкапсулирующую элемент управления с расширенными свойствами.</summary>
		// Token: 0x04002D0B RID: 11531
		LIBFLAG_FHIDDEN = 4,
		/// <summary>Библиотека типов хранится на диске.</summary>
		// Token: 0x04002D0C RID: 11532
		LIBFLAG_FHASDISKIMAGE = 8
	}
}
