using System;

namespace System.Security
{
	/// <summary>Указывает набор правил безопасности, которые применяются средой CLR к сборке.</summary>
	// Token: 0x020003D8 RID: 984
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SecurityRulesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityRulesAttribute" />, используя указанное значение набора правил.</summary>
		/// <param name="ruleSet">Одно из значений перечисления, определяющее набор правил прозрачности.</param>
		// Token: 0x0600286C RID: 10348 RVA: 0x00092A79 File Offset: 0x00090C79
		public SecurityRulesAttribute(SecurityRuleSet ruleSet)
		{
			this.m_ruleSet = ruleSet;
		}

		/// <summary>Определяет, пропускается ли проверка MSIL для полностью доверенного прозрачного кода.</summary>
		/// <returns>Значение <see langword="true" />, если проверка MSIL пропускается; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x00092A88 File Offset: 0x00090C88
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x00092A90 File Offset: 0x00090C90
		public bool SkipVerificationInFullTrust
		{
			get
			{
				return this.m_skipVerificationInFullTrust;
			}
			set
			{
				this.m_skipVerificationInFullTrust = value;
			}
		}

		/// <summary>Получает применяемый набор правил.</summary>
		/// <returns>Одно из значений перечисления, определяющее применяемые правила прозрачности.</returns>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x00092A99 File Offset: 0x00090C99
		public SecurityRuleSet RuleSet
		{
			get
			{
				return this.m_ruleSet;
			}
		}

		// Token: 0x04001EA6 RID: 7846
		private SecurityRuleSet m_ruleSet;

		// Token: 0x04001EA7 RID: 7847
		private bool m_skipVerificationInFullTrust;
	}
}
