using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Сообщает подробные сведения о реализации метода.</summary>
	// Token: 0x02000843 RID: 2115
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum MethodImplOptions
	{
		/// <summary>Метод реализован в неуправляемом коде.</summary>
		// Token: 0x04002D7F RID: 11647
		Unmanaged = 4,
		/// <summary>Метод объявлен, но его реализация находится в другом месте.</summary>
		// Token: 0x04002D80 RID: 11648
		ForwardRef = 16,
		/// <summary>Подпись метода должна экспортироваться в точном соответствии с объявленной.</summary>
		// Token: 0x04002D81 RID: 11649
		PreserveSig = 128,
		/// <summary>Вызов является внутренним, то есть вызывает метод, который реализован в пределах той же среды CLR.</summary>
		// Token: 0x04002D82 RID: 11650
		InternalCall = 4096,
		/// <summary>В определенный момент времени метод может выполняться только одним потоком. Статические методы выполняют блокировку по типу, а методы экземпляра — по экземпляру. Только один поток может выполняться для любой из функций экземпляра, и только один поток может выполняться для любой из статических функций класса.</summary>
		// Token: 0x04002D83 RID: 11651
		Synchronized = 32,
		/// <summary>Метод нельзя выполнять как встроенный. Встраивание — это способ оптимизации, при котором вместо вызова метода в код вставляется тело метода.</summary>
		// Token: 0x04002D84 RID: 11652
		NoInlining = 8,
		/// <summary>Метод должен по возможности выполняться как встроенный.</summary>
		// Token: 0x04002D85 RID: 11653
		[ComVisible(false)]
		AggressiveInlining = 256,
		/// <summary>Метод не оптимизирован JIT-компилятором или службой создания машинного кода (см. Ngen.exe) при отладке потенциальных проблем с созданием кода.</summary>
		// Token: 0x04002D86 RID: 11654
		NoOptimization = 64,
		/// <summary>The JIT compiler should look for security mitigation attributes, such as the user-defined <see langword="System.Runtime.CompilerServices.SecurityMitigationsAttribute" />. If found, the JIT compiler applies any related security mitigations. Available starting with .NET Framework 4.8.</summary>
		// Token: 0x04002D87 RID: 11655
		SecurityMitigations = 1024
	}
}
