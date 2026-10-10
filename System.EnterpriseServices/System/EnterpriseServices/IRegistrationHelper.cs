using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Устанавливает и настраивает сборки в каталоге COM+.</summary>
	// Token: 0x02000024 RID: 36
	[Guid("55e3ea25-55cb-4650-8887-18e8d30bb4bc")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IRegistrationHelper
	{
		/// <summary>Устанавливает сборку в каталог COM+.</summary>
		/// <param name="assembly">Имя сборки в виде имени файла или строгого имени сборки в глобальном кэше сборок (GAC).</param>
		/// <param name="application">Параметр приложения может иметь значение <see langword="null" />. В этом случае имя приложения создается автоматически на основе имени сборки или атрибута <see langword="ApplicationName" />. Если приложение содержит атрибут <see langword="ApplicationID" />, атрибут имеет приоритет.</param>
		/// <param name="tlb">Имя выходного файла библиотеки типов (TLB) или строка, содержащая значение <see langword="null" />, если помощник регистрации должен создать имя. При завершении вызова параметру присваивается фактическое имя.</param>
		/// <param name="installFlags">Параметры установки, указанные в перечислении.</param>
		// Token: 0x06000077 RID: 119
		void InstallAssembly([MarshalAs(UnmanagedType.BStr)] [In] string assembly, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string application, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string tlb, [In] InstallationFlags installFlags);

		/// <summary>Удаляет сборку из каталога COM+.</summary>
		/// <param name="assembly">Имя сборки в виде имени файла или строгого имени сборки в глобальном кэше сборок (GAC).</param>
		/// <param name="application">Имя приложения COM+.</param>
		// Token: 0x06000078 RID: 120
		void UninstallAssembly([MarshalAs(UnmanagedType.BStr)] [In] string assembly, [MarshalAs(UnmanagedType.BStr)] [In] string application);
	}
}
