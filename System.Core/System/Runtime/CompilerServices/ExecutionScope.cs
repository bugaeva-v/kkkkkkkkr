using System;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Представляет состояние выполнения динамически создаваемого метода.
	///       </summary>
	// Token: 0x020002EE RID: 750
	[Obsolete("do not use this type", true)]
	public class ExecutionScope
	{
		// Token: 0x060016B8 RID: 5816 RVA: 0x0004C847 File Offset: 0x0004AA47
		internal ExecutionScope()
		{
			this.Parent = null;
			this.Globals = null;
			this.Locals = null;
		}

		/// <summary>
		///         Создает массив для хранения поднятые локальные переменные.
		///       </summary>
		/// <returns>
		///         Массив для хранения поднятые локальные переменные.
		///       </returns>
		// Token: 0x060016B9 RID: 5817 RVA: 0x000080E3 File Offset: 0x000062E3
		public object[] CreateHoistedLocals()
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Создает делегат, который может использоваться для выполнения динамически создаваемого метода.
		///       </summary>
		/// <param name="indexLambda">
		///           Индекс объекта, который хранит сведения о связанном лямбда-выражении динамического метода.
		///         </param>
		/// <param name="locals">
		///           Массив, содержащий поднятые локальные переменные из родительского контекста.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Delegate" /> можно выполнить динамически создаваемый метод.
		///       </returns>
		// Token: 0x060016BA RID: 5818 RVA: 0x000080E3 File Offset: 0x000062E3
		public Delegate CreateDelegate(int indexLambda, object[] locals)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Освобождает указанное дерево выражений от ссылок на внешние параметры, заменяя параметр его текущим значением.
		///       </summary>
		/// <param name="expression">
		///           Дерево выражения, которое требуется освободить от ссылок на внешние параметры.
		///         </param>
		/// <param name="locals">
		///           Массив, содержащий поднятые локальные переменные.
		///         </param>
		/// <returns>
		///         Дерево выражения, которое не содержит ссылок на внешние параметры.
		///       </returns>
		// Token: 0x060016BB RID: 5819 RVA: 0x000080E3 File Offset: 0x000062E3
		public Expression IsolateExpression(Expression expression, object[] locals)
		{
			throw new NotSupportedException();
		}

		/// <summary>
		///         Представляет область выполнения вызывающего делегата.
		///       </summary>
		// Token: 0x04000B65 RID: 2917
		public ExecutionScope Parent;

		/// <summary>
		///         Представляет нетривиальные константы и локально выполняемые выражения, на которые ссылается динамически создаваемый метод.
		///       </summary>
		// Token: 0x04000B66 RID: 2918
		public object[] Globals;

		/// <summary>
		///         Представляет поднятые локальные переменные из родительского контекста.
		///       </summary>
		// Token: 0x04000B67 RID: 2919
		public object[] Locals;
	}
}
