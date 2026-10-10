using System;

namespace System.Reflection
{
	/// <summary>Задает флаги для атрибутов реализации метода.</summary>
	// Token: 0x020008AE RID: 2222
	public enum MethodImplAttributes
	{
		/// <summary>Задает флаги для типа кода.</summary>
		// Token: 0x04002EDE RID: 11998
		CodeTypeMask = 3,
		/// <summary>Указывает, что метод реализуется на языке MSIL.</summary>
		// Token: 0x04002EDF RID: 11999
		IL = 0,
		/// <summary>Указывает, что для метода используется стандартная реализация.</summary>
		// Token: 0x04002EE0 RID: 12000
		Native,
		/// <summary>Указывает, что метод реализуется на языке OPIL.</summary>
		// Token: 0x04002EE1 RID: 12001
		OPTIL,
		/// <summary>Указывает, что реализация метода предоставляется средой выполнения.</summary>
		// Token: 0x04002EE2 RID: 12002
		Runtime,
		/// <summary>Указывает, реализуется ли метод в управляемом или неуправляемом коде.</summary>
		// Token: 0x04002EE3 RID: 12003
		ManagedMask,
		/// <summary>Указывает, что метод реализуется в неуправляемом коде.</summary>
		// Token: 0x04002EE4 RID: 12004
		Unmanaged = 4,
		/// <summary>Указывает, что метод реализуется в управляемом коде.</summary>
		// Token: 0x04002EE5 RID: 12005
		Managed = 0,
		/// <summary>Указывает, что метод не определен.</summary>
		// Token: 0x04002EE6 RID: 12006
		ForwardRef = 16,
		/// <summary>Указывает, что подпись метода должна экспортироваться в точном соответствии с объявленной.</summary>
		// Token: 0x04002EE7 RID: 12007
		PreserveSig = 128,
		/// <summary>Указывает внутренний вызов.</summary>
		// Token: 0x04002EE8 RID: 12008
		InternalCall = 4096,
		/// <summary>Указывает, что метод полностью выполняется как однопотоковый. Статические методы (<see langword="Shared" /> в Visual Basic) выполняют блокировку по типу, а методы экземпляра — по экземпляру. Для этой цели можно также использовать оператор lock в C# или оператор SyncLock в Visual Basic.</summary>
		// Token: 0x04002EE9 RID: 12009
		Synchronized = 32,
		/// <summary>Указывает, что метод нельзя выполнять как встроенный.</summary>
		// Token: 0x04002EEA RID: 12010
		NoInlining = 8,
		/// <summary>Указывает, что метод должен по возможности выполняться как встроенный.</summary>
		// Token: 0x04002EEB RID: 12011
		AggressiveInlining = 256,
		/// <summary>Указывает, что метод не оптимизирован JIT-компилятором или службой генерирования машинного кода (см. Ngen.exe) при отладке потенциальных проблем с генерированием кода.</summary>
		// Token: 0x04002EEC RID: 12012
		NoOptimization = 64,
		/// <summary>Указывает значение диапазона проверки.</summary>
		// Token: 0x04002EED RID: 12013
		MaxMethodImplVal = 65535,
		/// <summary>Specifies that the JIT compiler should look for security mitigation attributes, such as the user-defined <see langword="System.Runtime.CompilerServices.SecurityMitigationsAttribute" />. If found, the JIT compiler applies any related security mitigations. Available starting with .NET Framework 4.8.</summary>
		// Token: 0x04002EEE RID: 12014
		SecurityMitigations = 1024
	}
}
