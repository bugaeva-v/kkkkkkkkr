using System;
using System.ComponentModel.Composition.Primitives;

namespace System.ComponentModel.Composition
{
	/// <summary>Предоставляет методы для удовлетворения импортов существующего экземпляра части.</summary>
	// Token: 0x02000042 RID: 66
	public interface ICompositionService
	{
		/// <summary>Выполняет композицию заданной части с выключенными рекомпозицией и проверкой.</summary>
		/// <param name="part">Часть, для которой выполняется композиция.</param>
		// Token: 0x060001E1 RID: 481
		void SatisfyImportsOnce(ComposablePart part);
	}
}
