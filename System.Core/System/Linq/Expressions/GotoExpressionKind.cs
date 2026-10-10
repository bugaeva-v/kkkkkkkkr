using System;

namespace System.Linq.Expressions
{
	/// <summary>
	///         Указывает, какой тип перехода это <see cref="T:System.Linq.Expressions.GotoExpression" /> представляет.
	///       </summary>
	// Token: 0x0200025B RID: 603
	public enum GotoExpressionKind
	{
		/// <summary>
		///         Объект <see cref="T:System.Linq.Expressions.GotoExpression" /> представляющий ссылку в нужное расположение.
		///       </summary>
		// Token: 0x040009EC RID: 2540
		Goto,
		/// <summary>
		///         Объект <see cref="T:System.Linq.Expressions.GotoExpression" /> представляющий оператор return.
		///       </summary>
		// Token: 0x040009ED RID: 2541
		Return,
		/// <summary>
		///         Объект <see cref="T:System.Linq.Expressions.GotoExpression" /> представляющий оператор break.
		///       </summary>
		// Token: 0x040009EE RID: 2542
		Break,
		/// <summary>
		///         Объект <see cref="T:System.Linq.Expressions.GotoExpression" /> представляющий оператор continue.
		///       </summary>
		// Token: 0x040009EF RID: 2543
		Continue
	}
}
