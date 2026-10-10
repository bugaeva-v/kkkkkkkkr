using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	/// <summary>Контролирует точность кода, создаваемого JIT-компилятором среды CLR.</summary>
	// Token: 0x02000831 RID: 2097
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)]
	[ComVisible(true)]
	[Serializable]
	public class CompilationRelaxationsAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.CompilationRelaxationsAttribute" /> с заданными релаксациями компиляции.</summary>
		/// <param name="relaxations">Релаксации компиляции.</param>
		// Token: 0x060046B1 RID: 18097 RVA: 0x000E711B File Offset: 0x000E531B
		public CompilationRelaxationsAttribute(int relaxations)
		{
			this.m_relaxations = relaxations;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.CompilationRelaxationsAttribute" /> заданным значением <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" />.</summary>
		/// <param name="relaxations">Одно из значений перечисления <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" />.</param>
		// Token: 0x060046B2 RID: 18098 RVA: 0x000E711B File Offset: 0x000E531B
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
			this.m_relaxations = (int)relaxations;
		}

		/// <summary>Возвращает релаксации компиляции, заданные при построении текущего объекта.</summary>
		/// <returns>Релаксации компиляции, заданные при построении текущего объекта.  
		/// Перечисление <see cref="T:System.Runtime.CompilerServices.CompilationRelaxations" /> используется со свойством <see cref="P:System.Runtime.CompilerServices.CompilationRelaxationsAttribute.CompilationRelaxations" />.</returns>
		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x000E712A File Offset: 0x000E532A
		public int CompilationRelaxations
		{
			get
			{
				return this.m_relaxations;
			}
		}

		// Token: 0x04002D7B RID: 11643
		private int m_relaxations;
	}
}
