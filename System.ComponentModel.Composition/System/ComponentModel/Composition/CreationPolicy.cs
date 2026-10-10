using System;

namespace System.ComponentModel.Composition
{
	/// <summary>Указывает, когда и как будет создаваться экземпляр части.</summary>
	// Token: 0x02000032 RID: 50
	public enum CreationPolicy
	{
		/// <summary>Указывает, что объектом <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> будет использоваться наиболее подходящая политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" /> для части с учетом текущего контекста. Это политика <see cref="T:System.ComponentModel.Composition.CreationPolicy" /> по умолчанию. По умолчанию объектом <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> используется значение политики <see cref="F:System.ComponentModel.Composition.CreationPolicy.Shared" />, если частью <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> или импортером не запрашивается значение <see cref="F:System.ComponentModel.Composition.CreationPolicy.NonShared" />.</summary>
		// Token: 0x040000AA RID: 170
		Any,
		/// <summary>Указывает, что объектом <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> будет создан один общий экземпляр связанной части <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" />, который будет совместно использоваться всеми инициаторами запросов.</summary>
		// Token: 0x040000AB RID: 171
		Shared,
		/// <summary>Указывает, что новый, не являющийся общим экземпляр связанной части <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePart" /> будет создан объектом <see cref="T:System.ComponentModel.Composition.Hosting.CompositionContainer" /> для каждого инициатора запроса.</summary>
		// Token: 0x040000AC RID: 172
		NonShared,
		// Token: 0x040000AD RID: 173
		NewScope
	}
}
