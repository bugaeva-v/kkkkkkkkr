using System;

namespace System.Security.Policy
{
	/// <summary>Задает проверку, чтобы определить, является ли сборка кода членом группы кода.</summary>
	// Token: 0x020003FA RID: 1018
	public interface IMembershipCondition : ISecurityEncodable, ISecurityPolicyEncodable
	{
		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060029AF RID: 10671
		bool Check(Evidence evidence);

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		// Token: 0x060029B0 RID: 10672
		IMembershipCondition Copy();

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Object" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060029B1 RID: 10673
		bool Equals(object obj);

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление состояния текущего условия членства.</returns>
		// Token: 0x060029B2 RID: 10674
		string ToString();
	}
}
