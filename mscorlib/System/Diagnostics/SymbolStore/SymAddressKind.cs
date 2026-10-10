using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Задает типы адресов локальных переменных, параметров и полей в методах <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.DefineLocalVariable(System.String,System.Reflection.FieldAttributes,System.Byte[],System.Diagnostics.SymbolStore.SymAddressKind,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)" />, <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.DefineParameter(System.String,System.Reflection.ParameterAttributes,System.Int32,System.Diagnostics.SymbolStore.SymAddressKind,System.Int32,System.Int32,System.Int32)" /> и <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.DefineField(System.Diagnostics.SymbolStore.SymbolToken,System.String,System.Reflection.FieldAttributes,System.Byte[],System.Diagnostics.SymbolStore.SymAddressKind,System.Int32,System.Int32,System.Int32)" /> интерфейса <see cref="T:System.Diagnostics.SymbolStore.ISymbolWriter" />.</summary>
	// Token: 0x020009DF RID: 2527
	[ComVisible(true)]
	[Serializable]
	public enum SymAddressKind
	{
		/// <summary>Смещение на языке MSIL. Параметр <paramref name="addr1" /> представляет индекс локальной переменной или параметра языка MSIL.</summary>
		// Token: 0x040037BF RID: 14271
		ILOffset = 1,
		/// <summary>Исходный относительный виртуальный адрес (RVA). Параметр <paramref name="addr1" /> — RVA-адрес в модуле.</summary>
		// Token: 0x040037C0 RID: 14272
		NativeRVA,
		/// <summary>Адрес машинного регистра. Параметр <paramref name="addr1" /> — это регистр, в котором хранится переменная.</summary>
		// Token: 0x040037C1 RID: 14273
		NativeRegister,
		/// <summary>Относительный адрес регистра. Параметр <paramref name="addr1" /> — регистр, параметр <paramref name="addr2" /> — смещение.</summary>
		// Token: 0x040037C2 RID: 14274
		NativeRegisterRelative,
		/// <summary>Исходное смещение. Параметр <paramref name="addr1" /> — это смещение от начала родительского объекта.</summary>
		// Token: 0x040037C3 RID: 14275
		NativeOffset,
		/// <summary>Относительный адрес регистра. Параметр <paramref name="addr1" /> — младший регистр, параметр <paramref name="addr2" /> — старший регистр.</summary>
		// Token: 0x040037C4 RID: 14276
		NativeRegisterRegister,
		/// <summary>Относительный адрес регистра. Параметр <paramref name="addr1" /> — младший регистр, параметр <paramref name="addr2" /> — регистр стека, а параметр <paramref name="addr3" /> — смещение от указателя стека до старшей части значения.</summary>
		// Token: 0x040037C5 RID: 14277
		NativeRegisterStack,
		/// <summary>Относительный адрес регистра. Параметр <paramref name="addr1" /> — регистр стека, параметр <paramref name="addr2" /> — смещение от указателя стека до младшей части значения, параметр <paramref name="addr3" /> — старший регистр.</summary>
		// Token: 0x040037C6 RID: 14278
		NativeStackRegister,
		/// <summary>Битовое поле. Параметр <paramref name="addr1" /> представляет позицию, с которой начинается поле, а параметр <paramref name="addr2" /> — длину поля.</summary>
		// Token: 0x040037C7 RID: 14279
		BitField,
		/// <summary>Исходное смещение раздела. Параметр <paramref name="addr1" /> представляет раздел, а параметр <paramref name="addr2" /> — смещение.</summary>
		// Token: 0x040037C8 RID: 14280
		NativeSectionOffset
	}
}
