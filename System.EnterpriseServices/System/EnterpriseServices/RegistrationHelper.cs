using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Устанавливает и настраивает сборки в каталоге COM+. Этот класс не наследуется.</summary>
	// Token: 0x0200003D RID: 61
	[Guid("89a86e7b-c229-4008-9baa-2f5c8411d7e0")]
	public sealed class RegistrationHelper : MarshalByRefObject, IRegistrationHelper
	{
		/// <summary>Устанавливает именованную сборку в приложении COM+.</summary>
		/// <param name="assembly">Имя файла устанавливаемой сборки.</param>
		/// <param name="application">Имя приложения COM+, в которое осуществляется установка. Этот параметр может иметь значение <see langword="null" />. Атрибут используется, если параметр имеет значение <see langword="null" /> и сборка содержит объект <see cref="T:System.EnterpriseServices.ApplicationNameAttribute" />. В противном случае, имя приложения создается на основе имени сборки, а затем возвращается.</param>
		/// <param name="tlb">Имя выходного файла инструмента для экспорта библиотек типов (Tlbexp.exe) или строка, содержащая значение <see langword="null" />, если предполагается, что имя создается помощником регистрации. При завершении вызова параметру присваивается фактическое имя.</param>
		/// <param name="installFlags">Поразрядное сочетание значений <see cref="T:System.EnterpriseServices.InstallationFlags" />.</param>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x060000CB RID: 203 RVA: 0x00002504 File Offset: 0x00000704
		public void InstallAssembly(string assembly, ref string application, ref string tlb, InstallationFlags installFlags)
		{
			application = string.Empty;
			tlb = string.Empty;
			this.InstallAssembly(assembly, ref application, null, ref tlb, installFlags);
		}

		/// <summary>Устанавливает именованную сборку в приложении COM+.</summary>
		/// <param name="assembly">Имя файла устанавливаемой сборки.</param>
		/// <param name="application">Имя приложения COM+, в которое осуществляется установка. Этот параметр может иметь значение <see langword="null" />. Атрибут используется, если параметр имеет значение <see langword="null" /> и сборка содержит объект <see cref="T:System.EnterpriseServices.ApplicationNameAttribute" />. В противном случае, имя приложения создается на основе имени сборки, а затем возвращается.</param>
		/// <param name="partition">Имя раздела. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <param name="tlb">Имя выходного файла инструмента для экспорта библиотек типов (Tlbexp.exe) или строка, содержащая значение <see langword="null" />, если предполагается, что имя создается помощником регистрации. При завершении вызова параметру присваивается фактическое имя.</param>
		/// <param name="installFlags">Поразрядное сочетание значений <see cref="T:System.EnterpriseServices.InstallationFlags" />.</param>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x060000CC RID: 204 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, InstallationFlags installFlags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает именованную сборку в приложении COM+.</summary>
		/// <param name="regConfig">Объект <see cref="T:System.EnterpriseServices.RegistrationConfig" />, определяющий устанавливаемую сборку.</param>
		// Token: 0x060000CD RID: 205 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void InstallAssemblyFromConfig([MarshalAs(UnmanagedType.IUnknown)] ref RegistrationConfig regConfig)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет сборку из заданного приложения.</summary>
		/// <param name="assembly">Имя файла удаляемой сборки.</param>
		/// <param name="application">Если это имя не имеет значение <see langword="null" />, оно является именем приложения, содержащего компоненты сборки.</param>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x060000CE RID: 206 RVA: 0x00002520 File Offset: 0x00000720
		public void UninstallAssembly(string assembly, string application)
		{
			this.UninstallAssembly(assembly, application, null);
		}

		/// <summary>Удаляет сборку из заданного приложения.</summary>
		/// <param name="assembly">Имя файла удаляемой сборки.</param>
		/// <param name="application">Если это имя не имеет значение <see langword="null" />, оно является именем приложения, содержащего компоненты сборки.</param>
		/// <param name="partition">Имя раздела. Этот параметр может иметь значение <see langword="null" />.</param>
		/// <exception cref="T:System.EnterpriseServices.RegistrationException">Входная сборка не имеет строгого имени.</exception>
		// Token: 0x060000CF RID: 207 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UninstallAssembly(string assembly, string application, string partition)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет сборку из заданного приложения.</summary>
		/// <param name="regConfig">Объект <see cref="T:System.EnterpriseServices.RegistrationConfig" />, определяющий удаляемую сборку.</param>
		// Token: 0x060000D0 RID: 208 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UninstallAssemblyFromConfig([MarshalAs(UnmanagedType.IUnknown)] ref RegistrationConfig regConfig)
		{
			throw new NotImplementedException();
		}
	}
}
