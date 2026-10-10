using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Определяет способ создания манифеста трассировки событий Windows для источника событий.</summary>
	// Token: 0x020009F6 RID: 2550
	[Flags]
	public enum EventManifestOptions
	{
		/// <summary>Создает узел ресурсов в папке локализации для каждой предоставленной вспомогательной сборки.</summary>
		// Token: 0x0400382A RID: 14378
		AllCultures = 2,
		/// <summary>Переопределяет поведение по умолчанию, в соответствии с которым текущий класс <see cref="T:System.Diagnostics.Tracing.EventSource" /> должен быть базовым классом для пользовательского типа, передаваемого методу записи. Это позволяет проверять источники событий .NET.</summary>
		// Token: 0x0400382B RID: 14379
		AllowEventSourceOverride = 8,
		/// <summary>Параметры не указаны.</summary>
		// Token: 0x0400382C RID: 14380
		None = 0,
		/// <summary>При создании манифеста только источник событий должен регистрироваться на главном компьютере.</summary>
		// Token: 0x0400382D RID: 14381
		OnlyIfNeededForRegistration = 4,
		/// <summary>Вызывает исключение, если при записи файла манифеста обнаружена несогласованность.</summary>
		// Token: 0x0400382E RID: 14382
		Strict = 1
	}
}
