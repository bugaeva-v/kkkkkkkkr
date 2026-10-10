using System;
using System.Runtime.InteropServices;

namespace System.Security.Policy
{
	/// <summary>Представляет группу кода, у которой инструкция политики является объединением инструкций политики текущей группы кода и соответствующих дочерних групп. Этот класс не наследуется.</summary>
	// Token: 0x02000424 RID: 1060
	[ComVisible(true)]
	[Serializable]
	public sealed class UnionCodeGroup : CodeGroup
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.UnionCodeGroup" />.</summary>
		/// <param name="membershipCondition">Условие членства, проверяющее свидетельство, чтобы определить, применяет ли политику эта группа кода.</param>
		/// <param name="policy">Инструкция политики для группы кода в форме набора разрешений и атрибутов, чтобы предоставить разрешение коду, который согласуется с условием членства.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимый тип параметра <paramref name="membershipCondition" />.  
		///
		/// или - 
		/// Недопустимый тип параметра <paramref name="policy" />.</exception>
		// Token: 0x06002B5F RID: 11103 RVA: 0x00099EC6 File Offset: 0x000980C6
		public UnionCodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy) : base(membershipCondition, policy)
		{
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00099BEF File Offset: 0x00097DEF
		internal UnionCodeGroup(SecurityElement e, PolicyLevel level) : base(e, level)
		{
		}

		/// <summary>Производит глубокое копирование текущей группы кода.</summary>
		/// <returns>Эквивалентная копия текущей группы кода, включающая условия членства и дочерние группы кода.</returns>
		// Token: 0x06002B61 RID: 11105 RVA: 0x0009CBE8 File Offset: 0x0009ADE8
		public override CodeGroup Copy()
		{
			return this.Copy(true);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0009CBF4 File Offset: 0x0009ADF4
		internal CodeGroup Copy(bool childs)
		{
			UnionCodeGroup unionCodeGroup = new UnionCodeGroup(base.MembershipCondition, base.PolicyStatement);
			unionCodeGroup.Name = base.Name;
			unionCodeGroup.Description = base.Description;
			if (childs)
			{
				foreach (object obj in base.Children)
				{
					CodeGroup codeGroup = (CodeGroup)obj;
					unionCodeGroup.AddChild(codeGroup.Copy());
				}
			}
			return unionCodeGroup;
		}

		/// <summary>Обрабатывает политику для группы кода и ее дочерних элементов, используя набор свидетельств.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Инструкция политики, состоящая из разрешений, предоставляемых группой кода с необязательными атрибутами, или значение <see langword="null" />, если группа кода не применяется (условие членства не соответствует указанному свидетельству).</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Более чем одна группа кода (включая родительские и любые дочерние группы кода) помечается свойством <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />.</exception>
		// Token: 0x06002B63 RID: 11107 RVA: 0x0009CC80 File Offset: 0x0009AE80
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
			PermissionSet permissionSet = base.PolicyStatement.PermissionSet.Copy();
			if (base.Children.Count > 0)
			{
				foreach (object obj in base.Children)
				{
					PolicyStatement policyStatement = ((CodeGroup)obj).Resolve(evidence);
					if (policyStatement != null)
					{
						permissionSet = permissionSet.Union(policyStatement.PermissionSet);
					}
				}
			}
			PolicyStatement policyStatement2 = base.PolicyStatement.Copy();
			policyStatement2.PermissionSet = permissionSet;
			return policyStatement2;
		}

		/// <summary>Обрабатывает согласующиеся группы кода.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Полный набор групп кода, соответствующих свидетельству.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B64 RID: 11108 RVA: 0x0009CD38 File Offset: 0x0009AF38
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
			CodeGroup codeGroup = this.Copy(false);
			if (base.Children.Count > 0)
			{
				foreach (object obj in base.Children)
				{
					CodeGroup codeGroup2 = ((CodeGroup)obj).ResolveMatchingCodeGroups(evidence);
					if (codeGroup2 != null)
					{
						codeGroup.AddChild(codeGroup2);
					}
				}
			}
			return codeGroup;
		}

		/// <summary>Получает объединенную логику.</summary>
		/// <returns>Всегда строка "Union".</returns>
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x00099C88 File Offset: 0x00097E88
		public override string MergeLogic
		{
			get
			{
				return "Union";
			}
		}
	}
}
