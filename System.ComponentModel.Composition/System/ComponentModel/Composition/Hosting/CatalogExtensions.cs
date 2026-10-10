using System;
using System.ComponentModel.Composition.Primitives;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Предоставляет методы расширения для построения служб композиции.</summary>
	// Token: 0x020000BD RID: 189
	public static class CatalogExtensions
	{
		/// <summary>Создает новую службу композиции с помощью указанного каталога в качестве источника экспортов.</summary>
		/// <param name="composablePartCatalog">Каталог, в котором содержатся экспорты.</param>
		/// <returns>Новая служба композиции.</returns>
		// Token: 0x060004DA RID: 1242 RVA: 0x0000E35F File Offset: 0x0000C55F
		public static CompositionService CreateCompositionService(this ComposablePartCatalog composablePartCatalog)
		{
			Requires.NotNull<ComposablePartCatalog>(composablePartCatalog, "composablePartCatalog");
			return new CompositionService(composablePartCatalog);
		}
	}
}
