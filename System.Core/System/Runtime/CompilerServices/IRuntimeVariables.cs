using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Представляет значения переменных во время выполнения.
	///       </summary>
	// Token: 0x020002E4 RID: 740
	public interface IRuntimeVariables
	{
		/// <summary>
		///         Возвращает количество переменных времени выполнения.
		///       </summary>
		/// <returns>
		///         Количество переменных во время выполнения.
		///       </returns>
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001673 RID: 5747
		int Count { get; }

		/// <summary>
		///         Возвращает значение переменной среды выполнения по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс переменной времени выполнения, значение которого равно должны быть возвращены.
		///         </param>
		/// <returns>
		///         Значение переменной времени выполнения.
		///       </returns>
		// Token: 0x170003D8 RID: 984
		object this[int index]
		{
			get;
			set;
		}
	}
}
