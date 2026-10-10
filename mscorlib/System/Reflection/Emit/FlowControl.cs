using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Описывает, каким образом инструкция меняет поток управления.</summary>
	// Token: 0x02000927 RID: 2343
	[ComVisible(true)]
	[Serializable]
	public enum FlowControl
	{
		/// <summary>Инструкция перехода.</summary>
		// Token: 0x0400316E RID: 12654
		Branch,
		/// <summary>Инструкция приостановки.</summary>
		// Token: 0x0400316F RID: 12655
		Break,
		/// <summary>Инструкция вызова.</summary>
		// Token: 0x04003170 RID: 12656
		Call,
		/// <summary>Инструкция условного перехода.</summary>
		// Token: 0x04003171 RID: 12657
		Cond_Branch,
		/// <summary>Предоставляет сведения о последующих инструкциях. Например, относящаяся к <see langword="Unaligned" /> инструкция <see langword="Reflection.Emit.Opcodes" /> имеет <see langword="FlowControl.Meta" /> и указывает, что следующая инструкция, использующая указатель, может быть не выровненной.</summary>
		// Token: 0x04003172 RID: 12658
		Meta,
		/// <summary>Обычное следование команд управления.</summary>
		// Token: 0x04003173 RID: 12659
		Next,
		/// <summary>Это значение перечислителя зарезервировано и не должно использоваться.</summary>
		// Token: 0x04003174 RID: 12660
		[Obsolete("This API has been deprecated.")]
		Phi,
		/// <summary>Инструкция возврата.</summary>
		// Token: 0x04003175 RID: 12661
		Return,
		/// <summary>Инструкция создания исключения.</summary>
		// Token: 0x04003176 RID: 12662
		Throw
	}
}
