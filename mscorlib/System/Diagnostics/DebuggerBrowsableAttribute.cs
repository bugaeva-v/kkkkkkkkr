using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Определяет наличие и способ отображения членов в окнах переменных отладчика. Этот класс не наследуется.</summary>
	// Token: 0x020009BB RID: 2491
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerBrowsableAttribute" />.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Diagnostics.DebuggerBrowsableState" />, определяющее способ отображения члена.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="state" /> не является одним из значений <see cref="T:System.Diagnostics.DebuggerBrowsableState" />.</exception>
		// Token: 0x060059A2 RID: 22946 RVA: 0x0013300C File Offset: 0x0013120C
		public DebuggerBrowsableAttribute(DebuggerBrowsableState state)
		{
			if (state < DebuggerBrowsableState.Never || state > DebuggerBrowsableState.RootHidden)
			{
				throw new ArgumentOutOfRangeException("state");
			}
			this.state = state;
		}

		/// <summary>Получает состояние отображения атрибута.</summary>
		/// <returns>Одно из значений <see cref="T:System.Diagnostics.DebuggerBrowsableState" />.</returns>
		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x0013302E File Offset: 0x0013122E
		public DebuggerBrowsableState State
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x0400377F RID: 14207
		private DebuggerBrowsableState state;
	}
}
