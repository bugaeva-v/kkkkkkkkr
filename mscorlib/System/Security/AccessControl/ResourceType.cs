using System;

namespace System.Security.AccessControl
{
	/// <summary>Задает предварительно определенные собственные типы объектов.</summary>
	// Token: 0x02000548 RID: 1352
	public enum ResourceType
	{
		/// <summary>Объект неизвестного типа.</summary>
		// Token: 0x040024ED RID: 9453
		Unknown,
		/// <summary>Файл или каталог.</summary>
		// Token: 0x040024EE RID: 9454
		FileObject,
		/// <summary>Служба Windows.</summary>
		// Token: 0x040024EF RID: 9455
		Service,
		/// <summary>Принтер.</summary>
		// Token: 0x040024F0 RID: 9456
		Printer,
		/// <summary>Раздел реестра.</summary>
		// Token: 0x040024F1 RID: 9457
		RegistryKey,
		/// <summary>Сетевая папка.</summary>
		// Token: 0x040024F2 RID: 9458
		LMShare,
		/// <summary>Локальный объект ядра.</summary>
		// Token: 0x040024F3 RID: 9459
		KernelObject,
		/// <summary>Объект рабочей станции Windows на локальном компьютере.</summary>
		// Token: 0x040024F4 RID: 9460
		WindowObject,
		/// <summary>Объект службы каталогов или набор свойств или свойство объекта службы каталогов.</summary>
		// Token: 0x040024F5 RID: 9461
		DSObject,
		/// <summary>Объект службы каталогов и все его наборы свойств и свойства.</summary>
		// Token: 0x040024F6 RID: 9462
		DSObjectAll,
		/// <summary>Объект, определенный поставщиком.</summary>
		// Token: 0x040024F7 RID: 9463
		ProviderDefined,
		/// <summary>Объект инструментария управления Windows (WMI)</summary>
		// Token: 0x040024F8 RID: 9464
		WmiGuidObject,
		/// <summary>Объект записи реестра в подсистеме WOW64.</summary>
		// Token: 0x040024F9 RID: 9465
		RegistryWow6432Key
	}
}
