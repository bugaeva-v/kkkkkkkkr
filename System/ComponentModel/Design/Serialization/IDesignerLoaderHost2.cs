using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет интерфейс для расширения <see cref="T:System.ComponentModel.Design.Serialization.IDesignerLoaderHost" />, чтобы указать, допускаются ли ошибки в процессе загрузки документа проекта.</summary>
	// Token: 0x02000486 RID: 1158
	public interface IDesignerLoaderHost2 : IDesignerLoaderHost, IDesignerHost, IServiceContainer, IServiceProvider
	{
		/// <summary>Возвращает или задает значение, указывающее, следует ли игнорировать ошибки при вызове метода <see cref="M:System.ComponentModel.Design.Serialization.IDesignerLoaderHost.Reload" />.</summary>
		/// <returns>Значение <see langword="true" />, если загрузчик конструктора игнорирует ошибки при загрузке; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002517 RID: 9495
		// (set) Token: 0x06002518 RID: 9496
		bool IgnoreErrorsDuringReload { get; set; }

		/// <summary>Возвращает или задает значение, указывающее, возможна ли повторная загрузка с ошибками.</summary>
		/// <returns>Значение <see langword="true" />, если загрузчик конструктора может выполнить повторную загрузку документа проекта с обнаруженными ошибками; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002519 RID: 9497
		// (set) Token: 0x0600251A RID: 9498
		bool CanReloadWithErrors { get; set; }
	}
}
