using System;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Описывает типы привязок, которые используются в <see cref="T:System.Linq.Expressions.MemberInitExpression" /> объектов.
	///       </summary>
	// Token: 0x02000276 RID: 630
	public enum MemberBindingType
	{
		/// <summary>
		///         Привязка, представляющая инициализацию элемента со значением выражения.
		///       </summary>
		// Token: 0x04000A1E RID: 2590
		Assignment,
		/// <summary>
		///         Привязка, которая представляет инициализацию элементов элемента рекурсивно.
		///       </summary>
		// Token: 0x04000A1F RID: 2591
		MemberBinding,
		/// <summary>
		///         Привязка, которая представляет инициализацию члена типа <see cref="T:System.Collections.IList" /> или <see cref="T:System.Collections.Generic.ICollection`1" /> из списка элементов.
		///       </summary>
		// Token: 0x04000A20 RID: 2592
		ListBinding
	}
}
