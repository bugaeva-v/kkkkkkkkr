using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Представляет абстрактный базовый класс, из которого создаются все реализации групп кода.</summary>
	// Token: 0x02000407 RID: 1031
	[ComVisible(true)]
	[Serializable]
	public abstract class CodeGroup
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Policy.CodeGroup" />.</summary>
		/// <param name="membershipCondition">Условие членства, проверяющее свидетельство, чтобы определить, применяет ли политику эта группа кода.</param>
		/// <param name="policy">Инструкция политики для группы кода в форме набора разрешений и атрибутов, чтобы предоставить разрешение коду, который согласуется с условием членства.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="membershipCondition" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимый тип параметра <paramref name="membershipCondition" />.  
		///
		/// или - 
		/// Недопустимый тип параметра <paramref name="policy" />.</exception>
		// Token: 0x06002A23 RID: 10787 RVA: 0x00098A82 File Offset: 0x00096C82
		protected CodeGroup(IMembershipCondition membershipCondition, PolicyStatement policy)
		{
			if (membershipCondition == null)
			{
				throw new ArgumentNullException("membershipCondition");
			}
			if (policy != null)
			{
				this.m_policy = policy.Copy();
			}
			this.m_membershipCondition = membershipCondition.Copy();
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00098ABE File Offset: 0x00096CBE
		internal CodeGroup(SecurityElement e, PolicyLevel level)
		{
			this.FromXml(e, level);
		}

		/// <summary>При переопределении в производном классе производит глубокое копирование текущей группы кода.</summary>
		/// <returns>Эквивалентная копия текущей группы кода, включающая условия членства и дочерние группы кода.</returns>
		// Token: 0x06002A25 RID: 10789
		public abstract CodeGroup Copy();

		/// <summary>При переопределении в производном классе получает объединенную логику для группы кода.</summary>
		/// <returns>Описание объединенной логики для группы кода.</returns>
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002A26 RID: 10790
		public abstract string MergeLogic { get; }

		/// <summary>При переопределении в производном классе обрабатывает политику для группы кода и ее дочерних элементов, используя набор свидетельств.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Инструкция политики, состоящая из разрешений, предоставляемых группой кода, с дополнительными атрибутами или значение <see langword="null" />, если группа кода не применяется (условие членства не соответствует указанному свидетельству).</returns>
		// Token: 0x06002A27 RID: 10791
		public abstract PolicyStatement Resolve(Evidence evidence);

		/// <summary>При переопределении в производном классе обрабатывает соответствующие группы кода.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.CodeGroup" /> — это корень дерева соответствующих групп кода.</returns>
		// Token: 0x06002A28 RID: 10792
		public abstract CodeGroup ResolveMatchingCodeGroups(Evidence evidence);

		/// <summary>Возвращает или задает инструкцию политики, связанную с группой кода.</summary>
		/// <returns>Инструкция политики для группы кода.</returns>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x00098AD9 File Offset: 0x00096CD9
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x00098AE1 File Offset: 0x00096CE1
		public PolicyStatement PolicyStatement
		{
			get
			{
				return this.m_policy;
			}
			set
			{
				this.m_policy = value;
			}
		}

		/// <summary>Возвращает или задает описание группы кода.</summary>
		/// <returns>Описание группы кода.</returns>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x00098AEA File Offset: 0x00096CEA
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x00098AF2 File Offset: 0x00096CF2
		public string Description
		{
			get
			{
				return this.m_description;
			}
			set
			{
				this.m_description = value;
			}
		}

		/// <summary>Возвращает или задает условие членства группы кода.</summary>
		/// <returns>Условие членства, определяющее, к какому свидетельству применима данная группа кода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Была предпринята попытка установить для этого параметра значение <see langword="null" />.</exception>
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x00098AFB File Offset: 0x00096CFB
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x00098B03 File Offset: 0x00096D03
		public IMembershipCondition MembershipCondition
		{
			get
			{
				return this.m_membershipCondition;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentException("value");
				}
				this.m_membershipCondition = value;
			}
		}

		/// <summary>Возвращает или задает имя группы кода.</summary>
		/// <returns>Имя группы кода.</returns>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x00098B1A File Offset: 0x00096D1A
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00098B22 File Offset: 0x00096D22
		public string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		/// <summary>Возвращает или задает упорядоченный список дочерних элементов группы кода.</summary>
		/// <returns>Список дочерних групп кода.</returns>
		/// <exception cref="T:System.ArgumentNullException">Была предпринята попытка установить для этого свойства значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить это свойство с использованием списка дочерних элементов, которые не являются объектами <see cref="T:System.Security.Policy.CodeGroup" />.</exception>
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x00098B2B File Offset: 0x00096D2B
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00098B33 File Offset: 0x00096D33
		public IList Children
		{
			get
			{
				return this.m_children;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.m_children = new ArrayList(value);
			}
		}

		/// <summary>Получает строковое представление атрибутов инструкции политики для группы кода.</summary>
		/// <returns>Строковое представление атрибутов инструкции политики для группы кода.</returns>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x00098B4F File Offset: 0x00096D4F
		public virtual string AttributeString
		{
			get
			{
				if (this.m_policy != null)
				{
					return this.m_policy.AttributeString;
				}
				return null;
			}
		}

		/// <summary>Получает имя именованного набора разрешений для группы кода.</summary>
		/// <returns>Имя именованного набора разрешений уровня политики.</returns>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x00098B66 File Offset: 0x00096D66
		public virtual string PermissionSetName
		{
			get
			{
				if (this.m_policy == null)
				{
					return null;
				}
				if (this.m_policy.PermissionSet is NamedPermissionSet)
				{
					return ((NamedPermissionSet)this.m_policy.PermissionSet).Name;
				}
				return null;
			}
		}

		/// <summary>Добавляет дочернюю группу кода в текущую группу кода.</summary>
		/// <param name="group">Группа кода, добавляемая в качестве дочерней группы. Новая дочерняя группа кода добавляется в конец списка.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="group" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="group" /> — это недопустимая группа кода.</exception>
		// Token: 0x06002A35 RID: 10805 RVA: 0x00098B9B File Offset: 0x00096D9B
		public void AddChild(CodeGroup group)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			this.m_children.Add(group.Copy());
		}

		/// <summary>Определяет, эквивалентны ли заданная и текущая группы кода.</summary>
		/// <param name="o">Группа кода, которую необходимо сравнить с текущей группой кода.</param>
		/// <returns>Значение <see langword="true" />, если заданная и текущая группа кода эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A36 RID: 10806 RVA: 0x00098BC0 File Offset: 0x00096DC0
		public override bool Equals(object o)
		{
			CodeGroup codeGroup = o as CodeGroup;
			return codeGroup != null && this.Equals(codeGroup, false);
		}

		/// <summary>Определяет, эквивалентны ли заданная и текущая группа кода, проверяя, если это указано, также и дочерние группы кода.</summary>
		/// <param name="cg">Группа кода, которую необходимо сравнить с текущей группой кода.</param>
		/// <param name="compareChildren">Значение <see langword="true" />, чтобы сравнить также и дочерние группы кода; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если заданная и текущая группа кода эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002A37 RID: 10807 RVA: 0x00098BE4 File Offset: 0x00096DE4
		public bool Equals(CodeGroup cg, bool compareChildren)
		{
			if (cg.Name != this.Name)
			{
				return false;
			}
			if (cg.Description != this.Description)
			{
				return false;
			}
			if (!cg.MembershipCondition.Equals(this.m_membershipCondition))
			{
				return false;
			}
			if (compareChildren)
			{
				int count = cg.Children.Count;
				if (this.Children.Count != count)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					if (!((CodeGroup)this.Children[i]).Equals((CodeGroup)cg.Children[i], false))
					{
						return false;
					}
				}
			}
			return true;
		}

		/// <summary>Удаляет указанную дочернюю группу кода.</summary>
		/// <param name="group">Группа кода, удаляемая в качестве дочерней группы.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="group" /> не является непосредственной дочерней группой кода текущей группы.</exception>
		// Token: 0x06002A38 RID: 10808 RVA: 0x00098C88 File Offset: 0x00096E88
		public void RemoveChild(CodeGroup group)
		{
			if (group != null)
			{
				this.m_children.Remove(group);
			}
		}

		/// <summary>Получает хэш-код текущей группы кода.</summary>
		/// <returns>Хэш-код текущей группы кода.</returns>
		// Token: 0x06002A39 RID: 10809 RVA: 0x00098C9C File Offset: 0x00096E9C
		public override int GetHashCode()
		{
			int num = this.m_membershipCondition.GetHashCode();
			if (this.m_policy != null)
			{
				num += this.m_policy.GetHashCode();
			}
			return num;
		}

		/// <summary>Восстанавливает объект безопасности с данным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A3A RID: 10810 RVA: 0x00098CCC File Offset: 0x00096ECC
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с данным состоянием и уровнем политики из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Уровень политики, в котором существует группа кода.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002A3B RID: 10811 RVA: 0x00098CD8 File Offset: 0x00096ED8
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			string text = e.Attribute("PermissionSetName");
			PermissionSet permissionSet;
			if (text != null && level != null)
			{
				permissionSet = level.GetNamedPermissionSet(text);
			}
			else
			{
				SecurityElement securityElement = e.SearchForChildByTag("PermissionSet");
				if (securityElement != null)
				{
					permissionSet = (PermissionSet)Activator.CreateInstance(Type.GetType(securityElement.Attribute("class")), true);
					permissionSet.FromXml(securityElement);
				}
				else
				{
					permissionSet = new PermissionSet(new PermissionSet(PermissionState.None));
				}
			}
			this.m_policy = new PolicyStatement(permissionSet);
			this.m_children.Clear();
			if (e.Children != null && e.Children.Count > 0)
			{
				foreach (object obj in e.Children)
				{
					SecurityElement securityElement2 = (SecurityElement)obj;
					if (securityElement2.Tag == "CodeGroup")
					{
						this.AddChild(CodeGroup.CreateFromXml(securityElement2, level));
					}
				}
			}
			this.m_membershipCondition = null;
			SecurityElement securityElement3 = e.SearchForChildByTag("IMembershipCondition");
			if (securityElement3 != null)
			{
				string text2 = securityElement3.Attribute("class");
				Type type = Type.GetType(text2);
				if (type == null)
				{
					type = Type.GetType("System.Security.Policy." + text2);
				}
				this.m_membershipCondition = (IMembershipCondition)Activator.CreateInstance(type, true);
				this.m_membershipCondition.FromXml(securityElement3, level);
			}
			this.m_name = e.Attribute("Name");
			this.m_description = e.Attribute("Description");
			this.ParseXml(e, level);
		}

		/// <summary>При переопределении в производном классе восстанавливает свойства и внутреннее состояние, являющееся особым для производной группы кода, из указанного объекта <see cref="T:System.Security.SecurityElement" />.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Уровень политики, в котором существует группа кода.</param>
		// Token: 0x06002A3C RID: 10812 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void ParseXml(SecurityElement e, PolicyLevel level)
		{
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002A3D RID: 10813 RVA: 0x00098E80 File Offset: 0x00097080
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности, его текущего состояния и уровня политики, в рамках которой существует код.</summary>
		/// <param name="level">Уровень политики, в котором существует группа кода.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002A3E RID: 10814 RVA: 0x00098E8C File Offset: 0x0009708C
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = new SecurityElement("CodeGroup");
			securityElement.AddAttribute("class", base.GetType().AssemblyQualifiedName);
			securityElement.AddAttribute("version", "1");
			if (this.Name != null)
			{
				securityElement.AddAttribute("Name", this.Name);
			}
			if (this.Description != null)
			{
				securityElement.AddAttribute("Description", this.Description);
			}
			if (this.MembershipCondition != null)
			{
				securityElement.AddChild(this.MembershipCondition.ToXml());
			}
			if (this.PolicyStatement != null && this.PolicyStatement.PermissionSet != null)
			{
				securityElement.AddChild(this.PolicyStatement.PermissionSet.ToXml());
			}
			foreach (object obj in this.Children)
			{
				CodeGroup codeGroup = (CodeGroup)obj;
				securityElement.AddChild(codeGroup.ToXml());
			}
			this.CreateXml(securityElement, level);
			return securityElement;
		}

		/// <summary>При переопределении в производном классе производит сериализацию свойств и внутреннего состояния, являющегося особым для производной группы кода, а также добавляет сериализацию в заданный объект <see cref="T:System.Security.SecurityElement" />.</summary>
		/// <param name="element">Кодировка XML, к которой добавляется сериализация.</param>
		/// <param name="level">Уровень политики, в котором существует группа кода.</param>
		// Token: 0x06002A3F RID: 10815 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void CreateXml(SecurityElement element, PolicyLevel level)
		{
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00098F9C File Offset: 0x0009719C
		internal static CodeGroup CreateFromXml(SecurityElement se, PolicyLevel level)
		{
			string text = se.Attribute("class");
			string text2 = text;
			int num = text2.IndexOf(",");
			if (num > 0)
			{
				text2 = text2.Substring(0, num);
			}
			num = text2.LastIndexOf(".");
			if (num > 0)
			{
				text2 = text2.Substring(num + 1);
			}
			if (text2 == "FileCodeGroup")
			{
				return new FileCodeGroup(se, level);
			}
			if (text2 == "FirstMatchCodeGroup")
			{
				return new FirstMatchCodeGroup(se, level);
			}
			if (text2 == "NetCodeGroup")
			{
				return new NetCodeGroup(se, level);
			}
			if (!(text2 == "UnionCodeGroup"))
			{
				CodeGroup codeGroup = (CodeGroup)Activator.CreateInstance(Type.GetType(text), true);
				codeGroup.FromXml(se, level);
				return codeGroup;
			}
			return new UnionCodeGroup(se, level);
		}

		// Token: 0x04001F6A RID: 8042
		private PolicyStatement m_policy;

		// Token: 0x04001F6B RID: 8043
		private IMembershipCondition m_membershipCondition;

		// Token: 0x04001F6C RID: 8044
		private string m_description;

		// Token: 0x04001F6D RID: 8045
		private string m_name;

		// Token: 0x04001F6E RID: 8046
		private ArrayList m_children = new ArrayList();
	}
}
