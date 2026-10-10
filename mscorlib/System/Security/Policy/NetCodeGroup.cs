using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Предоставляет доступ к веб-узлу, с которого была загружена сборка. Этот класс не наследуется.</summary>
	// Token: 0x02000419 RID: 1049
	[ComVisible(true)]
	[Serializable]
	public sealed class NetCodeGroup : CodeGroup
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.NetCodeGroup" />.</summary>
		/// <param name="membershipCondition">Условие членства, проверяющее свидетельство для определения, применяет ли эта группа кода политику безопасности доступа кода.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="membershipCondition" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимый тип параметра <paramref name="membershipCondition" />.</exception>
		// Token: 0x06002ACA RID: 10954 RVA: 0x0009A856 File Offset: 0x00098A56
		public NetCodeGroup(IMembershipCondition membershipCondition) : base(membershipCondition, null)
		{
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0009A86B File Offset: 0x00098A6B
		internal NetCodeGroup(SecurityElement e, PolicyLevel level) : base(e, level)
		{
		}

		/// <summary>Получает строковое представление атрибутов инструкции политики для группы кода.</summary>
		/// <returns>Всегда <see langword="null" />.</returns>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string AttributeString
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает алгоритм, используемый для объединенных групп.</summary>
		/// <returns>Строка "Union".</returns>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x00099C88 File Offset: 0x00097E88
		public override string MergeLogic
		{
			get
			{
				return "Union";
			}
		}

		/// <summary>Получает имя <see cref="T:System.Security.NamedPermissionSet" /> для группы кода.</summary>
		/// <returns>Всегда строка "Same site Web".</returns>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x0009A880 File Offset: 0x00098A80
		public override string PermissionSetName
		{
			get
			{
				return "Same site Web";
			}
		}

		/// <summary>Добавляет заданный доступ для подключения в текущую группу кода.</summary>
		/// <param name="originScheme">Объект <see cref="T:System.String" />, содержащий схему для сравнения со схемой кода.</param>
		/// <param name="connectAccess">Объект <see cref="T:System.Security.Policy.CodeConnectAccess" />, задающий схему и порт для кода, которые могут использоваться для подключения обратно к исходному серверу.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="originScheme" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="originScheme" /> содержит символы, которые не разрешены в схемах.  
		///
		/// или - 
		/// <paramref name="originScheme" /> = <see cref="F:System.Security.Policy.NetCodeGroup.AbsentOriginScheme" /> и <paramref name="connectAccess" /> задает <see cref="F:System.Security.Policy.CodeConnectAccess.OriginScheme" /> в качестве схемы.</exception>
		// Token: 0x06002ACF RID: 10959 RVA: 0x0009A888 File Offset: 0x00098A88
		[MonoTODO("(2.0) missing validations")]
		public void AddConnectAccess(string originScheme, CodeConnectAccess connectAccess)
		{
			if (originScheme == null)
			{
				throw new ArgumentException("originScheme");
			}
			if (originScheme == NetCodeGroup.AbsentOriginScheme && connectAccess.Scheme == CodeConnectAccess.OriginScheme)
			{
				throw new ArgumentOutOfRangeException("connectAccess", Locale.GetText("Schema == CodeConnectAccess.OriginScheme"));
			}
			if (this._rules.ContainsKey(originScheme))
			{
				if (connectAccess != null)
				{
					CodeConnectAccess[] array = (CodeConnectAccess[])this._rules[originScheme];
					CodeConnectAccess[] array2 = new CodeConnectAccess[array.Length + 1];
					Array.Copy(array, 0, array2, 0, array.Length);
					array2[array.Length] = connectAccess;
					this._rules[originScheme] = array2;
					return;
				}
			}
			else
			{
				CodeConnectAccess[] value = new CodeConnectAccess[]
				{
					connectAccess
				};
				this._rules.Add(originScheme, value);
			}
		}

		/// <summary>Производит глубокое копирование текущей группы кода.</summary>
		/// <returns>Эквивалентная копия текущей группы кода, включающая условия членства и дочерние группы кода.</returns>
		// Token: 0x06002AD0 RID: 10960 RVA: 0x0009A940 File Offset: 0x00098B40
		public override CodeGroup Copy()
		{
			NetCodeGroup netCodeGroup = new NetCodeGroup(base.MembershipCondition);
			netCodeGroup.Name = base.Name;
			netCodeGroup.Description = base.Description;
			netCodeGroup.PolicyStatement = base.PolicyStatement;
			foreach (object obj in base.Children)
			{
				CodeGroup codeGroup = (CodeGroup)obj;
				netCodeGroup.AddChild(codeGroup.Copy());
			}
			return netCodeGroup;
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0009A9D0 File Offset: 0x00098BD0
		private bool Equals(CodeConnectAccess[] rules1, CodeConnectAccess[] rules2)
		{
			for (int i = 0; i < rules1.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < rules2.Length; j++)
				{
					if (rules1[i].Equals(rules2[j]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Определяет, эквивалентны ли заданная и текущая группы кода.</summary>
		/// <param name="o">Объект <see cref="T:System.Security.Policy.NetCodeGroup" />, используемый для сравнения с текущей группой кода.</param>
		/// <returns>Значение <see langword="true" />, если заданная и текущая группа кода эквивалентны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002AD2 RID: 10962 RVA: 0x0009AA14 File Offset: 0x00098C14
		public override bool Equals(object o)
		{
			if (!base.Equals(o))
			{
				return false;
			}
			NetCodeGroup netCodeGroup = o as NetCodeGroup;
			if (netCodeGroup == null)
			{
				return false;
			}
			foreach (object obj in this._rules)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				CodeConnectAccess[] array = (CodeConnectAccess[])netCodeGroup._rules[dictionaryEntry.Key];
				bool flag;
				if (array != null)
				{
					flag = this.Equals((CodeConnectAccess[])dictionaryEntry.Value, array);
				}
				else
				{
					flag = (dictionaryEntry.Value == null);
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Получает информацию доступа для подключения для текущей группы кода.</summary>
		/// <returns>Массив <see cref="T:System.Collections.DictionaryEntry" />, содержащий информацию доступа для подключения.</returns>
		// Token: 0x06002AD3 RID: 10963 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		public DictionaryEntry[] GetConnectAccessRules()
		{
			DictionaryEntry[] array = new DictionaryEntry[this._rules.Count];
			this._rules.CopyTo(array, 0);
			return array;
		}

		/// <summary>Получает хэш-код текущей группы кода.</summary>
		/// <returns>Хэш-код текущей группы кода.</returns>
		// Token: 0x06002AD4 RID: 10964 RVA: 0x0009AAFC File Offset: 0x00098CFC
		public override int GetHashCode()
		{
			if (this._hashcode == 0)
			{
				this._hashcode = base.GetHashCode();
				foreach (object obj in this._rules)
				{
					CodeConnectAccess[] array = (CodeConnectAccess[])((DictionaryEntry)obj).Value;
					if (array != null)
					{
						foreach (CodeConnectAccess codeConnectAccess in array)
						{
							this._hashcode ^= codeConnectAccess.GetHashCode();
						}
					}
				}
			}
			return this._hashcode;
		}

		/// <summary>Обрабатывает политику для группы кода и ее дочерних элементов, используя набор свидетельств.</summary>
		/// <param name="evidence">Свидетельство <see cref="T:System.Security.Policy.Evidence" /> для сборки.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.PolicyStatement" />, включающий в свой состав разрешения, предоставляемых группой кода, с дополнительными атрибутами или значение <see langword="null" />, если группа кода не применяется (условие членства не соответствует указанному свидетельству).</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Более чем одна группа кода (включая родительские и любые дочерние группы кода) помечается свойством <see cref="F:System.Security.Policy.PolicyStatementAttribute.Exclusive" />.</exception>
		// Token: 0x06002AD5 RID: 10965 RVA: 0x0009ABAC File Offset: 0x00098DAC
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
			PolicyStatement policyStatement2 = base.PolicyStatement.Copy();
			policyStatement2.PermissionSet = permissionSet;
			return policyStatement2;
		}

		/// <summary>Удаляет всю информацию доступа для подключения для текущей группы кода.</summary>
		// Token: 0x06002AD6 RID: 10966 RVA: 0x0009AC78 File Offset: 0x00098E78
		public void ResetConnectAccess()
		{
			this._rules.Clear();
		}

		/// <summary>Обрабатывает согласующиеся группы кода.</summary>
		/// <param name="evidence">Свидетельство для сборки.</param>
		/// <returns>Полный набор групп кода, соответствующих свидетельству.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AD7 RID: 10967 RVA: 0x0009AC88 File Offset: 0x00098E88
		public override CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new ArgumentNullException("evidence");
			}
			CodeGroup codeGroup = null;
			if (base.MembershipCondition.Check(evidence))
			{
				codeGroup = this.Copy();
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

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0009AD10 File Offset: 0x00098F10
		[MonoTODO("(2.0) Add new stuff (CodeConnectAccess) into XML")]
		protected override void CreateXml(SecurityElement element, PolicyLevel level)
		{
			base.CreateXml(element, level);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0009AD1A File Offset: 0x00098F1A
		[MonoTODO("(2.0) Parse new stuff (CodeConnectAccess) from XML")]
		protected override void ParseXml(SecurityElement e, PolicyLevel level)
		{
			base.ParseXml(e, level);
		}

		/// <summary>Содержит значение, используемое для задания доступа для подключения для кода с неизвестной или нераспознанной схемой источника.</summary>
		// Token: 0x04001FA1 RID: 8097
		public static readonly string AbsentOriginScheme = string.Empty;

		/// <summary>Содержит значение, используемое для задания любой точно не установленной схемы источника.</summary>
		// Token: 0x04001FA2 RID: 8098
		public static readonly string AnyOtherOriginScheme = "*";

		// Token: 0x04001FA3 RID: 8099
		private Hashtable _rules = new Hashtable();

		// Token: 0x04001FA4 RID: 8100
		private int _hashcode;
	}
}
