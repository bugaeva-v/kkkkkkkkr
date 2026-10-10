using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Позволяет определить политику безопасности посредством объединения инструкции политики группы кода и ее первой согласующейся дочерней группы кода. Этот класс не наследуется.</summary>
	// Token: 0x0200040F RID: 1039
	[ComVisible(true)]
	[Serializable]
	public sealed class FirstMatchCodeGroup : CodeGroup
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.FirstMatchCodeGroup" />.</summary>
		/// <param name="membershipCondition">Условие членства, проверяющее свидетельство, чтобы определить, применяет ли политику эта группа кода.</param>
		/// <param name="policy">Инструкция политики для группы кода в форме набора разрешений и атрибутов, чтобы предоставить разрешение коду, который согласуется с условием членства.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимый тип параметра <paramref name="membershipCondition" />.  
		/// -или- 
		/// Недопустимый тип параметра <paramref name="policy" />.</exception>
		// Token: 0x06002A82 RID: 10882 RVA: 0x00099EC6 File Offset: 0x000980C6
		public FirstMatchCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy) : base(membershipCondition, policy)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00099BEF File Offset: 0x00097DEF
		internal FirstMatchCodeGroup(SecurityElement e, PolicyLevel level) : base(e, level)
		{
		}

		/// <summary>Получает объединенную логику.</summary>
		/// <returns>Строка "First Match".</returns>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x00099ED0 File Offset: 0x000980D0
		public override string MergeLogic
		{
			get
			{
				return "First Match";
			}
		}

		/// <summary>Производит глубокое копирование группы кода.</summary>
		/// <returns>Эквивалентная копия группы кода, включающая условия членства и дочерние группы кода.</returns>
		// Token: 0x06002A85 RID: 10885 RVA: 0x00099ED8 File Offset: 0x000980D8
		public override CodeGroup Copy()
		{
			FirstMatchCodeGroup firstMatchCodeGroup = this.CopyNoChildren();
			foreach (object obj in base.Children)
			{
				CodeGroup codeGroup = (CodeGroup)obj;
				firstMatchCodeGroup.AddChild(codeGroup.Copy());
			}
			return firstMatchCodeGroup;
		}

		/// <summary>Обрабатывает политику для группы кода и ее дочерних элементов, используя набор свидетельств.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Инструкция политики, состоящая из разрешений, предоставляемых группой кода с необязательными атрибутами, или значение <see langword="null" />, если группа кода не применяется (условие членства не соответствует указанному свидетельству).</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Более чем одна группа кода (включая родительские и любые дочерние группы кода) помечается свойством <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />.</exception>
		// Token: 0x06002A86 RID: 10886 RVA: 0x00099F40 File Offset: 0x00098140
		public override PolicyStatement Resolve(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new ArgumentNullException("evidence");
			}
			if (!base.MembershipCondition.Check(evidence))
			{
				return null;
			}
			foreach (object obj in base.Children)
			{
				PolicyStatement policyStatement = ((CodeGroup)obj).Resolve(evidence);
				if (policyStatement != null)
				{
					return policyStatement;
				}
			}
			return base.PolicyStatement;
		}

		/// <summary>Обрабатывает согласующиеся группы кода.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.CodeGroup" /> — это корень дерева соответствующих групп кода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A87 RID: 10887 RVA: 0x00099FC8 File Offset: 0x000981C8
		public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new ArgumentNullException("evidence");
			}
			if (!base.MembershipCondition.Check(evidence))
			{
				return null;
			}
			foreach (object obj in base.Children)
			{
				CodeGroup codeGroup = (CodeGroup)obj;
				if (codeGroup.Resolve(evidence) != null)
				{
					return codeGroup.Copy();
				}
			}
			return this.CopyNoChildren();
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0009A054 File Offset: 0x00098254
		private FirstMatchCodeGroup CopyNoChildren()
		{
			return new FirstMatchCodeGroup(base.MembershipCondition, base.PolicyStatement)
			{
				Name = base.Name,
				Description = base.Description
			};
		}
	}
}
