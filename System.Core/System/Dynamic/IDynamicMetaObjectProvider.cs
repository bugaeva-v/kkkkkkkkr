using System;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамический объект, операции которого могут быть связаны в среде выполнения.
	///       </summary>
	// Token: 0x0200031B RID: 795
	public interface IDynamicMetaObjectProvider
	{
		/// <summary>
		///         Возвращает <see cref="T:System.Dynamic.DynamicMetaObject" /> отвечает привязки операций выполняется для этого объекта.
		///       </summary>
		/// <param name="parameter">
		///           Представление дерева выражений значения среды выполнения.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Dynamic.DynamicMetaObject" /> Для привязки этого объекта.
		///       </returns>
		// Token: 0x060017F7 RID: 6135
		DynamicMetaObject GetMetaObject(Expression parameter);
	}
}
