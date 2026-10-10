using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает способ создания сборки.</summary>
	// Token: 0x02000754 RID: 1876
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum TypeLibImporterFlags
	{
		/// <summary>Создает основную сборку взаимодействия. Дополнительные сведения см. в описании атрибута <see cref="T:System.Runtime.InteropServices.PrimaryInteropAssemblyAttribute" />. Должен быть задан ключевой файл.</summary>
		// Token: 0x04002C0F RID: 11279
		PrimaryInteropAssembly = 1,
		/// <summary>Импортирует все интерфейсы как интерфейсы, блокирующие сканирование стека среды CLR для разрешения <see cref="F:System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode" />. Внимание! При этом вся ответственность, связанная с блокировкой проверки безопасности, ложится на пользователя.</summary>
		// Token: 0x04002C10 RID: 11280
		UnsafeInterfaces = 2,
		/// <summary>Импортирует все экземпляры <see langword="SAFEARRAY" /> как <see cref="T:System.Array" />, а не как типизированные одномерные управляемые массивы, отсчитываемые от нуля. Этот параметр полезен при работе с многомерными экземплярами <see langword="SAFEARRAY" />, в которых нумерация индекса начинается не с нуля и которые в противном случае доступны только после редактирования результирующей сборки при помощи средств MSIL Disassembler (Ildasm.exe) и MSIL Assembler (Ilasm.exe).</summary>
		// Token: 0x04002C11 RID: 11281
		SafeArrayAsSystemArray = 4,
		/// <summary>Преобразует параметры <see langword="[out, retval]" /> методов для интерфейсов диспетчеризации (dispinterface) в возвращаемые значения.</summary>
		// Token: 0x04002C12 RID: 11282
		TransformDispRetVals = 8,
		/// <summary>Без специальных параметров. Это значение по умолчанию.</summary>
		// Token: 0x04002C13 RID: 11283
		None = 0,
		/// <summary>Не используется.</summary>
		// Token: 0x04002C14 RID: 11284
		PreventClassMembers = 16,
		/// <summary>Импортирует библиотеку типов для любой платформы.</summary>
		// Token: 0x04002C15 RID: 11285
		ImportAsAgnostic = 2048,
		/// <summary>Импортирует библиотеку типов для платформы Itanium.</summary>
		// Token: 0x04002C16 RID: 11286
		ImportAsItanium = 1024,
		/// <summary>Импортирует библиотеку типов для 64-разрядной платформы x86.</summary>
		// Token: 0x04002C17 RID: 11287
		ImportAsX64 = 512,
		/// <summary>Импортирует библиотеку типов для платформы x86.</summary>
		// Token: 0x04002C18 RID: 11288
		ImportAsX86 = 256,
		/// <summary>Используется загрузка только для отражения.</summary>
		// Token: 0x04002C19 RID: 11289
		ReflectionOnlyLoading = 4096,
		/// <summary>Использует сериализуемые классы.</summary>
		// Token: 0x04002C1A RID: 11290
		SerializableValueClasses = 32,
		/// <summary>Предотвращает включение ресурса версии в сборку взаимодействия. Дополнительные сведения см. в описании метода <see cref="M:System.Reflection.Emit.AssemblyBuilder.DefineVersionInfoResource" />.</summary>
		// Token: 0x04002C1B RID: 11291
		NoDefineVersionResource = 8192,
		/// <summary>Импортирует библиотеку для платформы ARM.</summary>
		// Token: 0x04002C1C RID: 11292
		ImportAsArm = 16384
	}
}
