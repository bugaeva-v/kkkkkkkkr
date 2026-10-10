using System;

namespace System.CodeDom
{
	/// <summary>Определяет идентификаторы для поддерживаемых бинарных операторов.</summary>
	// Token: 0x020002FA RID: 762
	public enum CodeBinaryOperatorType
	{
		/// <summary>Оператор сложения.</summary>
		// Token: 0x04000D5A RID: 3418
		Add,
		/// <summary>Оператор вычитания.</summary>
		// Token: 0x04000D5B RID: 3419
		Subtract,
		/// <summary>Оператор умножения.</summary>
		// Token: 0x04000D5C RID: 3420
		Multiply,
		/// <summary>Оператор деления.</summary>
		// Token: 0x04000D5D RID: 3421
		Divide,
		/// <summary>Оператор модуля.</summary>
		// Token: 0x04000D5E RID: 3422
		Modulus,
		/// <summary>Оператор присвоения.</summary>
		// Token: 0x04000D5F RID: 3423
		Assign,
		/// <summary>Оператор "Идентификатор не равен".</summary>
		// Token: 0x04000D60 RID: 3424
		IdentityInequality,
		/// <summary>Оператор "Идентификатор равен".</summary>
		// Token: 0x04000D61 RID: 3425
		IdentityEquality,
		/// <summary>Оператор "Значение равно".</summary>
		// Token: 0x04000D62 RID: 3426
		ValueEquality,
		/// <summary>Оператор "Битовое или".</summary>
		// Token: 0x04000D63 RID: 3427
		BitwiseOr,
		/// <summary>Оператор "Битовое и".</summary>
		// Token: 0x04000D64 RID: 3428
		BitwiseAnd,
		/// <summary>Оператор "Логическое или". Представляет оператор сокращенного вычисления. Оператор сокращенного вычисления вычисляет только то количество выражений, которое необходимо для возврата правильного значения.</summary>
		// Token: 0x04000D65 RID: 3429
		BooleanOr,
		/// <summary>Оператор "Логическое и". Представляет оператор сокращенного вычисления. Оператор сокращенного вычисления вычисляет только то количество выражений, которое необходимо для возврата правильного значения.</summary>
		// Token: 0x04000D66 RID: 3430
		BooleanAnd,
		/// <summary>Оператор "Меньше чем".</summary>
		// Token: 0x04000D67 RID: 3431
		LessThan,
		/// <summary>Оператор "Меньше чем или равно".</summary>
		// Token: 0x04000D68 RID: 3432
		LessThanOrEqual,
		/// <summary>Оператор "Больше чем".</summary>
		// Token: 0x04000D69 RID: 3433
		GreaterThan,
		/// <summary>Оператор "Больше чем или равно".</summary>
		// Token: 0x04000D6A RID: 3434
		GreaterThanOrEqual
	}
}
