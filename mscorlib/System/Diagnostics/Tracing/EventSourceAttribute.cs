using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Позволяет определить имя трассировки событий Windows (ETW) независимо от имени класса источника событий.</summary>
	// Token: 0x020009F9 RID: 2553
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class EventSourceAttribute : Attribute
	{
		/// <summary>Получает или задает идентификатор источника события.</summary>
		/// <returns>Идентификатор источника события.</returns>
		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x001347F6 File Offset: 0x001329F6
		// (set) Token: 0x06005B16 RID: 23318 RVA: 0x001347FE File Offset: 0x001329FE
		public string Guid { get; set; }

		/// <summary>Получает или задает имя локализованного файла ресурсов.</summary>
		/// <returns>Имя файла ресурсов локализации или <see langword="null" />, если файл ресурсов локализации не существует.</returns>
		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06005B17 RID: 23319 RVA: 0x00134807 File Offset: 0x00132A07
		// (set) Token: 0x06005B18 RID: 23320 RVA: 0x0013480F File Offset: 0x00132A0F
		public string LocalizationResources { get; set; }

		/// <summary>Получает или задает имя источника события.</summary>
		/// <returns>Имя источника событий.</returns>
		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x00134818 File Offset: 0x00132A18
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x00134820 File Offset: 0x00132A20
		public string Name { get; set; }
	}
}
