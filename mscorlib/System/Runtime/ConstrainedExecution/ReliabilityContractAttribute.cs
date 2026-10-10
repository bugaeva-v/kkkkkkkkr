using System;

namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Определяет контракт надежности между автором кода и разработчиками, зависящими от этого кода.</summary>
	// Token: 0x020007D5 RID: 2005
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
	public sealed class ReliabilityContractAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute" /> с указанной гарантией <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> и значением <see cref="T:System.Runtime.ConstrainedExecution.Cer" />.</summary>
		/// <param name="consistencyGuarantee">Одно из значений перечисления <see cref="T:System.Runtime.ConstrainedExecution.Consistency" />.</param>
		/// <param name="cer">Одно из значений перечисления <see cref="T:System.Runtime.ConstrainedExecution.Cer" />.</param>
		// Token: 0x060045B2 RID: 17842 RVA: 0x000E510F File Offset: 0x000E330F
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
			this.ConsistencyGuarantee = consistencyGuarantee;
			this.Cer = cer;
		}

		/// <summary>Возвращает значение контракта надежности <see cref="T:System.Runtime.ConstrainedExecution.Consistency" />.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Runtime.ConstrainedExecution.Consistency" />.</returns>
		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x000E5125 File Offset: 0x000E3325
		public Consistency ConsistencyGuarantee { get; }

		/// <summary>Получает значение, определяющее поведение метода, типа или сборки при вызове в области ограниченного исполнения (CER).</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Runtime.ConstrainedExecution.Cer" />.</returns>
		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x000E512D File Offset: 0x000E332D
		public Cer Cer { get; }
	}
}
