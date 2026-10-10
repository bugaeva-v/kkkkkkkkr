using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Определяет свойство для доступа к значению, на которое ссылается объект.
	///       </summary>
	// Token: 0x020002EC RID: 748
	public interface IStrongBox
	{
		/// <summary>
		///         Возвращает или задает значение, которое ссылается объект.
		///       </summary>
		/// <returns>
		///         Значение, которое ссылается на объект.
		///       </returns>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060016B3 RID: 5811
		// (set) Token: 0x060016B4 RID: 5812
		object Value { get; set; }
	}
}
