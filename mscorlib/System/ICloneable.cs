using System;

namespace System
{
	/// <summary>Поддерживает копирование, при котором создается новый экземпляр класса с тем же значением, что и у существующего экземпляра.</summary>
	// Token: 0x02000138 RID: 312
	public interface ICloneable
	{
		/// <summary>Создает новый объект, являющийся копией текущего экземпляра.</summary>
		/// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
		// Token: 0x06000BE8 RID: 3048
		object Clone();
	}
}
