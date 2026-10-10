using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Предоставляет сведения о привязке сборок, которые могут быть добавлены в экземпляр класса <see cref="T:System.AppDomain" />.</summary>
	// Token: 0x02000203 RID: 515
	[Guid("27FFF232-A7A8-40dd-8D4A-734AD59FCD41")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	public interface IAppDomainSetup
	{
		/// <summary>Возвращает или задает имя каталога, содержащего приложение.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя базового каталога приложений.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600165B RID: 5723
		// (set) Token: 0x0600165C RID: 5724
		string ApplicationBase { get; set; }

		/// <summary>Возвращает или задает имя приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, предоставляющий имя приложения.</returns>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600165D RID: 5725
		// (set) Token: 0x0600165E RID: 5726
		string ApplicationName { get; set; }

		/// <summary>Возвращает или задает имя области, определенной для приложения, где создаются теневые копии файлов.</summary>
		/// <returns>Объект <see cref="T:System.String" />, в котором содержится полный путь к каталогу и полное имя файла, соответствующие создаваемой теневой копии.</returns>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600165F RID: 5727
		// (set) Token: 0x06001660 RID: 5728
		string CachePath { get; set; }

		/// <summary>Возвращает или задает имя файла конфигурации для домена приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, определяющий имя файла конфигурации.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06001661 RID: 5729
		// (set) Token: 0x06001662 RID: 5730
		string ConfigurationFile { get; set; }

		/// <summary>Возвращает или задает каталог, в котором хранятся доступные динамически создаваемые файлы.</summary>
		/// <returns>Объект <see cref="T:System.String" />, который определяет каталог, содержащий динамические сборки.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001663 RID: 5731
		// (set) Token: 0x06001664 RID: 5732
		string DynamicBase { get; set; }

		/// <summary>Возвращает или задает расположение файла лицензии, связанного с этим доменом.</summary>
		/// <returns>Объект <see cref="T:System.String" />, определяющий имя файла лицензии.</returns>
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06001665 RID: 5733
		// (set) Token: 0x06001666 RID: 5734
		string LicenseFile { get; set; }

		/// <summary>Возвращает или задает список каталогов, которые объединяются с каталогом <see cref="P:System.AppDomainSetup.ApplicationBase" /> для проверки наличия закрытых сборок.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий список имен каталогов, разделенных знаком точки с запятой.</returns>
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001667 RID: 5735
		// (set) Token: 0x06001668 RID: 5736
		string PrivateBinPath { get; set; }

		/// <summary>Возвращает или задает путь к закрытому каталогу двоичных файлов, используемому для размещения приложения.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий список имен каталогов, разделенных знаком точки с запятой.</returns>
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001669 RID: 5737
		// (set) Token: 0x0600166A RID: 5738
		string PrivateBinPathProbe { get; set; }

		/// <summary>Возвращает или задает имена каталогов, содержащих сборки, для которых будут созданы теневые копии.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий список имен каталогов, разделенных знаком точки с запятой.</returns>
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600166B RID: 5739
		// (set) Token: 0x0600166C RID: 5740
		string ShadowCopyDirectories { get; set; }

		/// <summary>Возвращает или задает строку, позволяющую определить, включено ли теневое копирование.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий значение true, свидетельствующее о том, что теневое копирование включено, или значение false, указывающее на то, что оно отключено.</returns>
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600166D RID: 5741
		// (set) Token: 0x0600166E RID: 5742
		string ShadowCopyFiles { get; set; }
	}
}
