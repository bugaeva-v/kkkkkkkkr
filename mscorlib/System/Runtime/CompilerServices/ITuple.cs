using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Определяет реализацию кортежа общего назначения, предоставляющую доступ к членам экземпляра кортежа без сведений о базовом типе кортежа.</summary>
	// Token: 0x020007F8 RID: 2040
	public interface ITuple
	{
		/// <summary>Получает число элементов в экземпляре <see langword="Tuple" />.</summary>
		/// <returns>Количество элементов в этом экземпляре <see langword="Tuple" />.</returns>
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600460A RID: 17930
		int Length { get; }

		/// <summary>Возвращает значение указанного элемента <see langword="Tuple" />.</summary>
		/// <param name="index">Индекс указанного элемента <see langword="Tuple" />. <paramref name="index" /> может находиться в диапазоне от 0 для <see langword="Item1" /><see langword="Tuple" /> до значения, на единицу меньше, чем число элементов в <see langword="Tuple" />.</param>
		/// <returns>Значение указанного элемента <see langword="Tuple" />.</returns>
		// Token: 0x17000AC4 RID: 2756
		object this[int index]
		{
			get;
		}
	}
}
