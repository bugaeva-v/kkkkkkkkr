using System;

namespace System
{
	/// <summary>Перечисление, которое используется с классом <see cref="T:System.LoaderOptimizationAttribute" /> для указания оптимизаций загрузчика для исполняемого файла.</summary>
	// Token: 0x020001CA RID: 458
	public enum LoaderOptimization
	{
		/// <summary>Игнорируется общей средой CLR.</summary>
		// Token: 0x0400144E RID: 5198
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		DisallowBindings = 4,
		/// <summary>Не используется. Эта маска выбирает доменные значения, отсеивая неиспользуемый флаг <see cref="F:System.LoaderOptimization.DisallowBindings" />.</summary>
		// Token: 0x0400144F RID: 5199
		[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		DomainMask = 3,
		/// <summary>Указывает, что приложение может иметь множество доменов, которые используют одинаковый код, а загрузчик должен предоставлять общий доступ к максимальному числу внутренних ресурсов в доменах приложений.</summary>
		// Token: 0x04001450 RID: 5200
		MultiDomain = 2,
		/// <summary>Указывает, что в приложении может размещаться уникальный код в нескольких доменах, а загрузчик должен предоставлять доступ к ресурсам в доменах приложения только для глобально доступных сборок (со строгими именами), которые не были добавлены в глобальный кэш сборок.</summary>
		// Token: 0x04001451 RID: 5201
		MultiDomainHost,
		/// <summary>Указывает, что нет заданных оптимизаций для общего доступа к внутренним ресурсам. Если домен или интерфейс размещения по умолчанию указан в оптимизации, загрузчик использует его; в противном случае загрузчик использует <see cref="F:System.LoaderOptimization.SingleDomain" />.</summary>
		// Token: 0x04001452 RID: 5202
		NotSpecified = 0,
		/// <summary>Указывает, что приложение может иметь один домен, а загрузчик не должен предоставлять общий доступ к внутренним ресурсам в доменах приложений.</summary>
		// Token: 0x04001453 RID: 5203
		SingleDomain
	}
}
