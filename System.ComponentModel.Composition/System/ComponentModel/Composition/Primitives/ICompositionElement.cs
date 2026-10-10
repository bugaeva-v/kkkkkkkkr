using System;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Представляет элемент, участвующий в композиции.</summary>
	// Token: 0x02000096 RID: 150
	public interface ICompositionElement
	{
		/// <summary>Получает отображаемое имя элемента композиции.</summary>
		/// <returns>Доступное для чтения отображаемое имя элемента <see cref="T:System.ComponentModel.Composition.Primitives.ICompositionElement" />.</returns>
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003F5 RID: 1013
		string DisplayName { get; }

		/// <summary>Получает элемент композиции, от которого происходит текущий элемент композиции.</summary>
		/// <returns>Элемент композиции, от которого происходит текущий элемент <see cref="T:System.ComponentModel.Composition.Primitives.ICompositionElement" />, или значение <see langword="null" />, если элемент <see cref="T:System.ComponentModel.Composition.Primitives.ICompositionElement" /> является корневым элементом композиции.</returns>
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003F6 RID: 1014
		ICompositionElement Origin { get; }
	}
}
