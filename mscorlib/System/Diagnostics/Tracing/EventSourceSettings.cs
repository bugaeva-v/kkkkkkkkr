using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Задает параметры конфигурации для источника события.</summary>
	// Token: 0x020009FB RID: 2555
	[Flags]
	public enum EventSourceSettings
	{
		/// <summary>Особые параметры конфигурации не включены.</summary>
		// Token: 0x04003839 RID: 14393
		Default = 0,
		/// <summary>Источник события создает исключение при возникновении ошибки.</summary>
		// Token: 0x0400383A RID: 14394
		ThrowOnEventWriteErrors = 1,
		/// <summary>Прослушиватель трассировки событий Windows должен использовать формат на основе манифеста при создании событий. Задание этого параметра указывает прослушивателю трассировки событий Windows на то, что при создании событий необходимо использовать формат на основе манифеста. Это параметр по умолчанию при определении типа, наследуемого от <see cref="T:System.Diagnostics.Tracing.EventSource" /> с помощью одного из защищенных конструкторов <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
		// Token: 0x0400383B RID: 14395
		EtwManifestEventFormat = 4,
		/// <summary>Прослушиватель трассировки событий Windows должен использовать формат событий с самоописанием. Это параметр по умолчанию при создании экземпляра <see cref="T:System.Diagnostics.Tracing.EventSource" /> с помощью одного из общих конструкторов <see cref="T:System.Diagnostics.Tracing.EventSource" />.</summary>
		// Token: 0x0400383C RID: 14396
		EtwSelfDescribingEventFormat = 8
	}
}
