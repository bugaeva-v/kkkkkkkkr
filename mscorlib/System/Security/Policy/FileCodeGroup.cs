using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Предоставляет разрешение по управлению файлами, расположенными в сборках кода, для тех сборок кода, которые соответствуют условию членства. Этот класс не наследуется.</summary>
	// Token: 0x0200040E RID: 1038
	[ComVisible(true)]
	[Serializable]
	public sealed class FileCodeGroup : CodeGroup
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.FileCodeGroup" />.</summary>
		/// <param name="membershipCondition">Условие членства, проверяющее свидетельство, чтобы определить, применяет ли политику эта группа кода.</param>
		/// <param name="access">Одно из значений перечисления <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />. Это значение используется для создания предоставляемого разрешения <see cref="T:System.Security.Permissions.FileIOPermission" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="membershipCondition" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимый тип параметра <paramref name="membershipCondition" />.  
		///
		/// или - 
		/// Недопустимый тип параметра <paramref name="access" />.</exception>
		// Token: 0x06002A76 RID: 10870 RVA: 0x00099BDE File Offset: 0x00097DDE
		public FileCodeGroup(IMembershipCondition membershipCondition, FileIOPermissionAccess access) : base(membershipCondition, null)
		{
			this.m_access = access;
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00099BEF File Offset: 0x00097DEF
		internal FileCodeGroup(SecurityElement e, PolicyLevel level) : base(e, level)
		{
		}

		/// <summary>Производит глубокое копирование текущей группы кода.</summary>
		/// <returns>Эквивалентная копия текущей группы кода, включающая условия членства и дочерние группы кода.</returns>
		// Token: 0x06002A78 RID: 10872 RVA: 0x00099BFC File Offset: 0x00097DFC
		public override CodeGroup Copy()
		{
			FileCodeGroup fileCodeGroup = new FileCodeGroup(base.MembershipCondition, this.m_access);
			fileCodeGroup.Name = base.Name;
			fileCodeGroup.Description = base.Description;
			foreach (object obj in base.Children)
			{
				CodeGroup codeGroup = (CodeGroup)obj;
				fileCodeGroup.AddChild(codeGroup.Copy());
			}
			return fileCodeGroup;
		}

		/// <summary>Получает объединенную логику.</summary>
		/// <returns>Строка "Union".</returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x00099C88 File Offset: 0x00097E88
		public override string MergeLogic
		{
			get
			{
				return "Union";
			}
		}

		/// <summary>Обрабатывает политику для группы кода и ее дочерних элементов, используя набор свидетельств.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Инструкция политики, состоящая из разрешений, предоставляемых группой кода с необязательными атрибутами, или значение <see langword="null" />, если группа кода не применяется (условие членства не соответствует указанному свидетельству).</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Текущая политика имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Более чем одна группа кода (включая родительские и любые дочерние группы кода) помечается свойством <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />.</exception>
		// Token: 0x06002A7A RID: 10874 RVA: 0x00099C90 File Offset: 0x00097E90
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
			PermissionSet permissionSet = null;
			if (base.PolicyStatement == null)
			{
				permissionSet = new PermissionSet(PermissionState.None);
			}
			else
			{
				permissionSet = base.PolicyStatement.PermissionSet.Copy();
			}
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
			PolicyStatement policyStatement2;
			if (base.PolicyStatement != null)
			{
				policyStatement2 = base.PolicyStatement.Copy();
			}
			else
			{
				policyStatement2 = PolicyStatement.Empty();
			}
			policyStatement2.PermissionSet = permissionSet;
			return policyStatement2;
		}

		/// <summary>Обрабатывает согласующиеся группы кода.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.CodeGroup" /> — это корень дерева соответствующих групп кода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A7B RID: 10875 RVA: 0x00099D74 File Offset: 0x00097F74
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
			FileCodeGroup fileCodeGroup = new FileCodeGroup(base.MembershipCondition, this.m_access);
			foreach (object obj in base.Children)
			{
				CodeGroup codeGroup = ((CodeGroup)obj).ResolveMatchingCodeGroups(evidence);
				if (codeGroup != null)
				{
					fileCodeGroup.AddChild(codeGroup);
				}
			}
			return fileCodeGroup;
		}

		/// <summary>Получает строковое представление атрибутов инструкции политики для группы кода.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string AttributeString
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает имя именованного набора разрешений для группы кода.</summary>
		/// <returns>Объединение строки "Same directory FileIO – » и типа доступа.</returns>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x00099E08 File Offset: 0x00098008
		public override string PermissionSetName
		{
			get
			{
				return "Same directory FileIO - " + this.m_access.ToString();
			}
		}

		/// <summary>Определяет, эквивалентны ли заданная и текущая группы кода.</summary>
		/// <param name="o">Группа кода, которую необходимо сравнить с текущей группой кода.</param>
		/// <returns>Значение <see langword="true" />, если заданная и текущая группа кода эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A7E RID: 10878 RVA: 0x00099E25 File Offset: 0x00098025
		public override bool Equals(object o)
		{
			return o is FileCodeGroup && this.m_access == ((FileCodeGroup)o).m_access && base.Equals((CodeGroup)o, false);
		}

		/// <summary>Получает хэш-код текущей группы кода.</summary>
		/// <returns>Хэш-код текущей группы кода.</returns>
		// Token: 0x06002A7F RID: 10879 RVA: 0x00099E53 File Offset: 0x00098053
		public override int GetHashCode()
		{
			return this.m_access.GetHashCode();
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00099E68 File Offset: 0x00098068
		protected override void ParseXml(SecurityElement e, PolicyLevel level)
		{
			string text = e.Attribute("Access");
			if (text != null)
			{
				this.m_access = (FileIOPermissionAccess)Enum.Parse(typeof(FileIOPermissionAccess), text, true);
				return;
			}
			this.m_access = FileIOPermissionAccess.NoAccess;
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00099EA8 File Offset: 0x000980A8
		protected override void CreateXml(SecurityElement element, PolicyLevel level)
		{
			element.AddAttribute("Access", this.m_access.ToString());
		}

		// Token: 0x04001F96 RID: 8086
		private FileIOPermissionAccess m_access;
	}
}
