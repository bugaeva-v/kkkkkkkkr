using System;

namespace System.ComponentModel.Composition.Primitives
{
	/// <summary>Определяет количество элементов объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" />, необходимых для <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
	// Token: 0x02000098 RID: 152
	public enum ImportCardinality
	{
		/// <summary>Нуль или один объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> требуется для <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
		// Token: 0x0400018A RID: 394
		ZeroOrOne,
		/// <summary>Ровно один объект <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> требуется для <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
		// Token: 0x0400018B RID: 395
		ExactlyOne,
		/// <summary>Нуль или несколько объектов <see cref="T:System.ComponentModel.Composition.Primitives.Export" /> требуется для <see cref="T:System.ComponentModel.Composition.Primitives.ImportDefinition" />.</summary>
		// Token: 0x0400018C RID: 396
		ZeroOrMore
	}
}
