using System;

namespace System.Reflection
{
	/// <summary>Предоставляет сведения о ссылке <see cref="T:System.Reflection.Assembly" />.</summary>
	// Token: 0x0200088C RID: 2188
	[Flags]
	public enum AssemblyNameFlags
	{
		/// <summary>Указывает, что ни один из флагов не применяется.</summary>
		// Token: 0x04002E5C RID: 11868
		None = 0,
		/// <summary>Определяет, что открытый ключ образуется из полного открытого ключа, а не из токена открытого ключа.</summary>
		// Token: 0x04002E5D RID: 11869
		PublicKey = 1,
		/// <summary>Указывает, что для данной сборки отключена оптимизация JIT-компилятора. Это состояние прямо противоположно смыслу имени члена.</summary>
		// Token: 0x04002E5E RID: 11870
		EnableJITcompileOptimizer = 16384,
		/// <summary>Указывает, что для JIT-компилятора данной сборки включено отслеживание.</summary>
		// Token: 0x04002E5F RID: 11871
		EnableJITcompileTracking = 32768,
		/// <summary>Определяет, что во время выполнения сборка может быть перенацелена на сборку от другого издателя. Это значение поддерживает инфраструктуру платформы .NET Framework, оно не предназначено для прямого использования в вашем коде.</summary>
		// Token: 0x04002E60 RID: 11872
		Retargetable = 256
	}
}
