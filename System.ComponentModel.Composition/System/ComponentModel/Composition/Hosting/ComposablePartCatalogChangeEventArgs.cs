using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using Microsoft.Internal;
using Microsoft.Internal.Collections;

namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged.Changed" />.</summary>
	// Token: 0x020000BE RID: 190
	public class ComposablePartCatalogChangeEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs" /> заданными изменениями.</summary>
		/// <param name="addedDefinitions">Определения частей, добавленные в каталог.</param>
		/// <param name="removedDefinitions">Определения частей, удаленные из каталога.</param>
		/// <param name="atomicComposition">Используемая транзакция композиции или значение <see langword="null" /> для отключения транзакционной композиции.</param>
		// Token: 0x060004DB RID: 1243 RVA: 0x0000E372 File Offset: 0x0000C572
		public ComposablePartCatalogChangeEventArgs(IEnumerable<ComposablePartDefinition> addedDefinitions, IEnumerable<ComposablePartDefinition> removedDefinitions, AtomicComposition atomicComposition)
		{
			Requires.NotNull<IEnumerable<ComposablePartDefinition>>(addedDefinitions, "addedDefinitions");
			Requires.NotNull<IEnumerable<ComposablePartDefinition>>(removedDefinitions, "removedDefinitions");
			this._addedDefinitions = addedDefinitions.AsArray<ComposablePartDefinition>();
			this._removedDefinitions = removedDefinitions.AsArray<ComposablePartDefinition>();
			this.AtomicComposition = atomicComposition;
		}

		/// <summary>Получает коллекцию определений, добавленных в каталог <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" /> в ходе данного изменения.</summary>
		/// <returns>Коллекция определений, добавленных в каталог.</returns>
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000E3AF File Offset: 0x0000C5AF
		public IEnumerable<ComposablePartDefinition> AddedDefinitions
		{
			get
			{
				return this._addedDefinitions;
			}
		}

		/// <summary>Получает коллекцию определений, удаленных из каталога <see cref="T:System.ComponentModel.Composition.Primitives.ComposablePartCatalog" /> в ходе данного изменения.</summary>
		/// <returns>Коллекция определений, удаленных из каталога в ходе данного изменения.</returns>
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000E3B7 File Offset: 0x0000C5B7
		public IEnumerable<ComposablePartDefinition> RemovedDefinitions
		{
			get
			{
				return this._removedDefinitions;
			}
		}

		/// <summary>Получает транзакцию композиции для данного изменения.</summary>
		/// <returns>Транзакция композиции для данного изменения.</returns>
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000E3BF File Offset: 0x0000C5BF
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x0000E3C7 File Offset: 0x0000C5C7
		public AtomicComposition AtomicComposition { get; private set; }

		// Token: 0x040001FF RID: 511
		private readonly IEnumerable<ComposablePartDefinition> _addedDefinitions;

		// Token: 0x04000200 RID: 512
		private readonly IEnumerable<ComposablePartDefinition> _removedDefinitions;
	}
}
