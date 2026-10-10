using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Задает соглашение о вызовах, которое требуется для вызова методов, реализованных в неуправляемом коде.</summary>
	// Token: 0x02000714 RID: 1812
	[ComVisible(true)]
	[Serializable]
	public enum CallingConvention
	{
		/// <summary>Этот член фактически не является соглашением о вызове, а вместо этого используется стандартное соглашение о вызове платформы. Например, в Windows по умолчанию используется <see cref="F:System.Runtime.InteropServices.CallingConvention.StdCall" />, а в Windows CE .NET — <see cref="F:System.Runtime.InteropServices.CallingConvention.Cdecl" />.</summary>
		// Token: 0x04002AF3 RID: 10995
		Winapi = 1,
		/// <summary>Вызывающий объект очищает стек. Это позволяет вызывать функции с <see langword="varargs" />, чтобы использовать их для методов, работающих с переменным числом параметров, таких как <see langword="Printf" />.</summary>
		// Token: 0x04002AF4 RID: 10996
		Cdecl,
		/// <summary>Вызываемый объект очищает стек. Это соглашение, используемое по умолчанию для вызова неуправляемых функций с вызовом неуправляемого кода.</summary>
		// Token: 0x04002AF5 RID: 10997
		StdCall,
		/// <summary>Первый параметр — это указатель <see langword="this" />, хранящийся в регистре ECX. Другие параметры помещаются в стек. Это соглашение о вызове используется для вызова методов в классах, экспортируемых из неуправляемой динамической библиотеки DLL.</summary>
		// Token: 0x04002AF6 RID: 10998
		ThisCall,
		/// <summary>Это соглашение о вызове не поддерживается.</summary>
		// Token: 0x04002AF7 RID: 10999
		FastCall
	}
}
