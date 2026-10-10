using System;
using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Представляет состояние выполнения динамически создаваемого метода.
	///       </summary>
	// Token: 0x020002E2 RID: 738
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public sealed class Closure
	{
		/// <summary>
		///         Создает объект, содержащий состояние динамически создаваемого метода.
		///       </summary>
		/// <param name="constants">
		///           Константы, используемые методом.
		///         </param>
		/// <param name="locals">
		///           Поднятые локальные переменные из родительского контекста.
		///         </param>
		// Token: 0x0600166D RID: 5741 RVA: 0x0004BD57 File Offset: 0x00049F57
		public Closure(object[] constants, object[] locals)
		{
			this.Constants = constants;
			this.Locals = locals;
		}

		/// <summary>
		///         Представляет нетривиальные константы и локально выполняемые выражения, на которые ссылается динамически создаваемый метод.
		///       </summary>
		// Token: 0x04000B54 RID: 2900
		public readonly object[] Constants;

		/// <summary>
		///         Представляет поднятые локальные переменные из родительского контекста.
		///       </summary>
		// Token: 0x04000B55 RID: 2901
		public readonly object[] Locals;
	}
}
