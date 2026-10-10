using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Используется инфраструктурой платформы .NET Framework для установки и настройки сборок в каталоге COM+ в процессе обслуживания вновь установленных транзакций.</summary>
	// Token: 0x0200003E RID: 62
	[Transaction(TransactionOption.RequiresNew)]
	[Guid("C89AC250-E18A-4FC7-ABD5-B8897B6A78A5")]
	public sealed class RegistrationHelperTx : ServicedComponent
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.RegistrationHelperTx" />.</summary>
		// Token: 0x060000D1 RID: 209 RVA: 0x0000252B File Offset: 0x0000072B
		[MonoTODO]
		public RegistrationHelperTx()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal override void Activate()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		protected internal override void Deactivate()
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает именованную сборку в каталог COM+, используя семантику транзакций.</summary>
		/// <param name="assembly">Имя файла устанавливаемой сборки.</param>
		/// <param name="application">Имя приложения COM+, в которое осуществляется установка, или значение <see langword="null" />.</param>
		/// <param name="tlb">Имя выходного файла инструмента для экспорта библиотек типов (Tlbexp.exe) или значение <see langword="null" />.</param>
		/// <param name="installFlags">Битовая комбинация значений флагов установки.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который может ожидать завершения настройки заданной сборки в каталоге COM+.</param>
		// Token: 0x060000D4 RID: 212 RVA: 0x00002533 File Offset: 0x00000733
		public void InstallAssembly(string assembly, ref string application, ref string tlb, InstallationFlags installFlags, object sync)
		{
			this.InstallAssembly(assembly, ref application, null, ref tlb, installFlags, sync);
		}

		/// <summary>Устанавливает именованную сборку в каталог COM+, используя семантику транзакций.</summary>
		/// <param name="assembly">Имя файла устанавливаемой сборки.</param>
		/// <param name="application">Имя приложения COM+, в которое производится установка, или строка, содержащая значение <see langword="null" />.</param>
		/// <param name="partition">Имя раздела или значение <see langword="null" />.</param>
		/// <param name="tlb">Имя выходного файла инструмента для экспорта библиотек типов (Tlbexp.exe) или значение <see langword="null" />.</param>
		/// <param name="installFlags">Битовая комбинация значений флагов установки.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который может ожидать завершения настройки заданной сборки в каталоге COM+.</param>
		// Token: 0x060000D5 RID: 213 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, InstallationFlags installFlags, object sync)
		{
			throw new NotImplementedException();
		}

		/// <summary>Устанавливает указанную сборку в каталог COM+, используя семантику транзакций.</summary>
		/// <param name="regConfig">Информация о конфигурации для установки сборки в каталог COM+.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который ожидает завершения настройки заданной сборки в каталоге COM+.</param>
		// Token: 0x060000D6 RID: 214 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void InstallAssemblyFromConfig([MarshalAs(UnmanagedType.IUnknown)] ref RegistrationConfig regConfig, object sync)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает значение, указывающее, является ли транзакционным текущий контекст для экземпляра класса <see cref="T:System.EnterpriseServices.RegistrationHelperTx" />.</summary>
		/// <returns>Значение <see langword="true" />, если текущий контекст эля экземпляра класса <see cref="T:System.EnterpriseServices.RegistrationHelperTx" /> является транзакционным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000D7 RID: 215 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public bool IsInTransaction()
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет сборку из приложения COM+, используя семантику транзакций.</summary>
		/// <param name="assembly">Имя файла удаляемой сборки.</param>
		/// <param name="application">Имя приложения COM+, содержащего компоненты в сборке, или значение <see langword="null" />.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который может ожидать завершения удаления заданной сборки.</param>
		// Token: 0x060000D8 RID: 216 RVA: 0x00002543 File Offset: 0x00000743
		public void UninstallAssembly(string assembly, string application, object sync)
		{
			this.UninstallAssembly(assembly, application, null, sync);
		}

		/// <summary>Удаляет сборку из приложения COM+, используя семантику транзакций.</summary>
		/// <param name="assembly">Имя файла удаляемой сборки.</param>
		/// <param name="application">Имя приложения COM+, содержащего компоненты в сборке, или значение <see langword="null" />.</param>
		/// <param name="partition">Имя раздела или значение <see langword="null" />.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который может ожидать завершения удаления заданной сборки.</param>
		// Token: 0x060000D9 RID: 217 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UninstallAssembly(string assembly, string application, string partition, object sync)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет заданную сборку из приложения COM+, используя семантику транзакций.</summary>
		/// <param name="regConfig">Информация о конфигурации, которая указывает сборку, удаляемую из приложения.</param>
		/// <param name="sync">Объект синхронизации, созданный инфраструктурой, который ожидает завершения удаления заданной сборки.</param>
		// Token: 0x060000DA RID: 218 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public void UninstallAssemblyFromConfig([MarshalAs(UnmanagedType.IUnknown)] ref RegistrationConfig regConfig, object sync)
		{
			throw new NotImplementedException();
		}
	}
}
