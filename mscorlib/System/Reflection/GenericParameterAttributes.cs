using System;

namespace System.Reflection
{
	/// <summary>Описывает ограничения параметра универсального типа для универсального типа или метода.</summary>
	// Token: 0x020008A0 RID: 2208
	[Flags]
	public enum GenericParameterAttributes
	{
		/// <summary>Специальные флаги отсутствуют.</summary>
		// Token: 0x04002EA6 RID: 11942
		None = 0,
		/// <summary>Выбирает комбинацию всех флагов расхождения. Это значение является результатом операции логического оператора OR для объединения флагов <see cref="F:System.Reflection.GenericParameterAttributes.Contravariant" /> и <see cref="F:System.Reflection.GenericParameterAttributes.Covariant" />.</summary>
		// Token: 0x04002EA7 RID: 11943
		VarianceMask = 3,
		/// <summary>Параметр универсального типа является ковариантным. Параметр ковариантного типа может иметь тип результата выполнения метода, тип поля только для чтения, декларируемый базовый тип или представлять реализованный интерфейс.</summary>
		// Token: 0x04002EA8 RID: 11944
		Covariant = 1,
		/// <summary>Параметр универсального типа является контрвариантным. Параметр контравариантного типа может представлять тип параметра в подписи метода.</summary>
		// Token: 0x04002EA9 RID: 11945
		Contravariant = 2,
		/// <summary>Выбирает комбинацию всех флагов особых ограничений. Это значение является результатом операции логического оператора OR для объединения флагов <see cref="F:System.Reflection.GenericParameterAttributes.DefaultConstructorConstraint" />, <see cref="F:System.Reflection.GenericParameterAttributes.ReferenceTypeConstraint" /> и <see cref="F:System.Reflection.GenericParameterAttributes.NotNullableValueTypeConstraint" />.</summary>
		// Token: 0x04002EAA RID: 11946
		SpecialConstraintMask = 28,
		/// <summary>Тип может заменить параметр универсального типа, только если он является ссылочным типом.</summary>
		// Token: 0x04002EAB RID: 11947
		ReferenceTypeConstraint = 4,
		/// <summary>Тип может заменить параметр универсального типа, только если он является типом значения и не может иметь значение null.</summary>
		// Token: 0x04002EAC RID: 11948
		NotNullableValueTypeConstraint = 8,
		/// <summary>Тип может заменить параметр универсального типа, только если он имеет конструктор без параметров.</summary>
		// Token: 0x04002EAD RID: 11949
		DefaultConstructorConstraint = 16
	}
}
