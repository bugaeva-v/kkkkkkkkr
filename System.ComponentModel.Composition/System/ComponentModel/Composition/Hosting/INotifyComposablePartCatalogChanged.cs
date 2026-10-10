using System;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Предоставляет уведомления при изменении каталога <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />.</summary>
	// Token: 0x020000E8 RID: 232
	public interface INotifyComposablePartCatalogChanged
	{
		/// <summary>Происходит при изменении каталога <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />.</summary>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000628 RID: 1576
		// (remove) Token: 0x06000629 RID: 1577
		event EventHandler<ComposablePartCatalogChangeEventArgs> Changed;

		/// <summary>Происходит при изменении объекта <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" />.</summary>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600062A RID: 1578
		// (remove) Token: 0x0600062B RID: 1579
		event EventHandler<ComposablePartCatalogChangeEventArgs> Changing;
	}
}
