using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Mono.Xml;
using Unity;

namespace System.Security.Policy
{
	/// <summary>Предоставляет уровни политики безопасности для среды CLR. Этот класс не наследуется.</summary>
	// Token: 0x0200041C RID: 1052
	[ComVisible(true)]
	[Serializable]
	public sealed class PolicyLevel
	{
		// Token: 0x06002AE8 RID: 10984 RVA: 0x0009AEF6 File Offset: 0x000990F6
		internal PolicyLevel(string label, PolicyLevelType type)
		{
			this.label = label;
			this._type = type;
			this.full_trust_assemblies = new ArrayList();
			this.named_permission_sets = new ArrayList();
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x0009AF24 File Offset: 0x00099124
		internal void LoadFromFile(string filename)
		{
			try
			{
				if (!File.Exists(filename))
				{
					string text = filename + ".default";
					if (File.Exists(text))
					{
						File.Copy(text, filename);
					}
				}
				if (File.Exists(filename))
				{
					using (StreamReader streamReader = File.OpenText(filename))
					{
						this.xml = this.FromString(streamReader.ReadToEnd());
					}
					try
					{
						SecurityManager.ResolvingPolicyLevel = this;
						this.FromXml(this.xml);
						goto IL_8A;
					}
					finally
					{
						SecurityManager.ResolvingPolicyLevel = this;
					}
				}
				this.CreateDefaultFullTrustAssemblies();
				this.CreateDefaultNamedPermissionSets();
				this.CreateDefaultLevel(this._type);
				this.Save();
				IL_8A:;
			}
			catch
			{
			}
			finally
			{
				this._location = filename;
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0009AFFC File Offset: 0x000991FC
		internal void LoadFromString(string xml)
		{
			this.FromXml(this.FromString(xml));
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x0009B00C File Offset: 0x0009920C
		private SecurityElement FromString(string xml)
		{
			SecurityParser securityParser = new SecurityParser();
			securityParser.LoadXml(xml);
			SecurityElement securityElement = securityParser.ToXml();
			if (securityElement.Tag != "configuration")
			{
				throw new ArgumentException(Locale.GetText("missing <configuration> root element"));
			}
			SecurityElement securityElement2 = (SecurityElement)securityElement.Children[0];
			if (securityElement2.Tag != "mscorlib")
			{
				throw new ArgumentException(Locale.GetText("missing <mscorlib> tag"));
			}
			SecurityElement securityElement3 = (SecurityElement)securityElement2.Children[0];
			if (securityElement3.Tag != "security")
			{
				throw new ArgumentException(Locale.GetText("missing <security> tag"));
			}
			SecurityElement securityElement4 = (SecurityElement)securityElement3.Children[0];
			if (securityElement4.Tag != "policy")
			{
				throw new ArgumentException(Locale.GetText("missing <policy> tag"));
			}
			return (SecurityElement)securityElement4.Children[0];
		}

		/// <summary>Получает список объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, применяемых для оценки политики безопасности.</summary>
		/// <returns>Список объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, применяемых для оценки политики безопасности. Этим сборкам предоставляется полное доверие во время оценки политики безопасности сборок, не содержащихся в списке.</returns>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x0009B0F2 File Offset: 0x000992F2
		[Obsolete("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
		public IList FullTrustAssemblies
		{
			get
			{
				return this.full_trust_assemblies;
			}
		}

		/// <summary>Получает описательную метку для уровня политики.</summary>
		/// <returns>Метка, связанная с уровнем политики.</returns>
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06002AED RID: 10989 RVA: 0x0009B0FA File Offset: 0x000992FA
		public string Label
		{
			get
			{
				return this.label;
			}
		}

		/// <summary>Получает список именованных наборов разрешений, определенных для уровня политики.</summary>
		/// <returns>Список именованных наборов разрешений, определенных для уровня политики.</returns>
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x0009B102 File Offset: 0x00099302
		public IList NamedPermissionSets
		{
			get
			{
				return this.named_permission_sets;
			}
		}

		/// <summary>Возвращает или задает корневую группу кода для уровня политики.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.CodeGroup" /> — это корень дерева групп кода уровня политики.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение <see cref="P:System.Security.Policy.PolicyLevel.RootCodeGroup" /> равно <see langword="null" />.</exception>
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06002AEF RID: 10991 RVA: 0x0009B10A File Offset: 0x0009930A
		// (set) Token: 0x06002AF0 RID: 10992 RVA: 0x0009B112 File Offset: 0x00099312
		public CodeGroup RootCodeGroup
		{
			get
			{
				return this.root_code_group;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.root_code_group = value;
			}
		}

		/// <summary>Получает путь к файлу политики.</summary>
		/// <returns>Путь к файлу политики, или значение <see langword="null" />, если объект <see cref="T:System.Security.Policy.PolicyLevel" /> не сохранен в файле.</returns>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x0009B129 File Offset: 0x00099329
		public string StoreLocation
		{
			get
			{
				return this._location;
			}
		}

		/// <summary>Возвращает тип уровня политики.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.PolicyLevelType" />.</returns>
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002AF2 RID: 10994 RVA: 0x0009B131 File Offset: 0x00099331
		[ComVisible(false)]
		public PolicyLevelType Type
		{
			get
			{
				return this._type;
			}
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, соответствующий заданному имени <see cref="T:System.Security.Policy.StrongName" />, к списку объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, которые не должны оцениваться.</summary>
		/// <param name="sn">Объект <see cref="T:System.Security.Policy.StrongName" />, используемый для создания <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, чтобы произвести добавление в список объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, которые не должны оцениваться.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Security.Policy.StrongName" />, задаваемый с помощью параметра <paramref name="sn" />, уже считается полностью надежным.</exception>
		// Token: 0x06002AF3 RID: 10995 RVA: 0x0009B13C File Offset: 0x0009933C
		[Obsolete("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
		public void AddFullTrustAssembly(StrongName sn)
		{
			if (sn == null)
			{
				throw new ArgumentNullException("sn");
			}
			StrongNameMembershipCondition snMC = new StrongNameMembershipCondition(sn.PublicKey, sn.Name, sn.Version);
			this.AddFullTrustAssembly(snMC);
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> к списку объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, которые не должны оцениваться.</summary>
		/// <param name="snMC">Объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, добавляемый к списку объектов <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, используемых для определения, является ли сборка членом группы сборок, которые не должны оцениваться.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="snMC" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, задаваемый с помощью параметра <paramref name="snMC" />, уже считается полностью надежным.</exception>
		// Token: 0x06002AF4 RID: 10996 RVA: 0x0009B178 File Offset: 0x00099378
		[Obsolete("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
		public void AddFullTrustAssembly(StrongNameMembershipCondition snMC)
		{
			if (snMC == null)
			{
				throw new ArgumentNullException("snMC");
			}
			using (IEnumerator enumerator = this.full_trust_assemblies.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((StrongNameMembershipCondition)enumerator.Current).Equals(snMC))
					{
						throw new ArgumentException(Locale.GetText("sn already has full trust."));
					}
				}
			}
			this.full_trust_assemblies.Add(snMC);
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.NamedPermissionSet" /> к текущему уровню политики.</summary>
		/// <param name="permSet">Объект <see cref="T:System.Security.NamedPermissionSet" />, добавляемый к текущему уровню политики.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="permSet" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="permSet" /> имеет такое же имя, как и существующий объект <see cref="T:System.Security.NamedPermissionSet" /> в объекте <see cref="T:System.Security.Policy.PolicyLevel" />.</exception>
		// Token: 0x06002AF5 RID: 10997 RVA: 0x0009B1FC File Offset: 0x000993FC
		public void AddNamedPermissionSet(NamedPermissionSet permSet)
		{
			if (permSet == null)
			{
				throw new ArgumentNullException("permSet");
			}
			foreach (object obj in this.named_permission_sets)
			{
				NamedPermissionSet namedPermissionSet = (NamedPermissionSet)obj;
				if (permSet.Name == namedPermissionSet.Name)
				{
					throw new ArgumentException(Locale.GetText("This NamedPermissionSet is the same an existing NamedPermissionSet."));
				}
			}
			this.named_permission_sets.Add(permSet.Copy());
		}

		/// <summary>Заменяет объект <see cref="T:System.Security.NamedPermissionSet" /> в текущем уровне политики с использованием указанного объекта <see cref="T:System.Security.PermissionSet" />.</summary>
		/// <param name="name">Имя заменяемого объекта <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <param name="pSet">Объект <see cref="T:System.Security.PermissionSet" />, который заменяет объект <see cref="T:System.Security.NamedPermissionSet" />, заданный параметром <paramref name="name" />.</param>
		/// <returns>Копия замещенного объекта <see cref="T:System.Security.NamedPermissionSet" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="pSet" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> эквивалентно имени зарезервированного набора разрешений.  
		/// -или- 
		/// Объект <see cref="T:System.Security.PermissionSet" />, заданный параметром <paramref name="pSet" />, не может быть найден.</exception>
		// Token: 0x06002AF6 RID: 10998 RVA: 0x0009B294 File Offset: 0x00099494
		public NamedPermissionSet ChangeNamedPermissionSet(string name, PermissionSet pSet)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (pSet == null)
			{
				throw new ArgumentNullException("pSet");
			}
			if (DefaultPolicies.ReservedNames.IsReserved(name))
			{
				throw new ArgumentException(Locale.GetText("Reserved name"));
			}
			foreach (object obj in this.named_permission_sets)
			{
				NamedPermissionSet namedPermissionSet = (NamedPermissionSet)obj;
				if (name == namedPermissionSet.Name)
				{
					this.named_permission_sets.Remove(namedPermissionSet);
					this.AddNamedPermissionSet(new NamedPermissionSet(name, pSet));
					return namedPermissionSet;
				}
			}
			throw new ArgumentException(Locale.GetText("PermissionSet not found"));
		}

		/// <summary>Создает новый уровень политики, используемый в уровне политики домена приложения.</summary>
		/// <returns>Вновь созданный <see cref="T:System.Security.Policy.PolicyLevel" />.</returns>
		// Token: 0x06002AF7 RID: 10999 RVA: 0x0009B358 File Offset: 0x00099558
		public static PolicyLevel CreateAppDomainLevel()
		{
			UnionCodeGroup unionCodeGroup = new UnionCodeGroup(new AllMembershipCondition(), new PolicyStatement(DefaultPolicies.FullTrust));
			unionCodeGroup.Name = "All_Code";
			PolicyLevel policyLevel = new PolicyLevel("AppDomain", PolicyLevelType.AppDomain);
			policyLevel.RootCodeGroup = unionCodeGroup;
			policyLevel.Reset();
			return policyLevel;
		}

		/// <summary>Восстанавливает объект безопасности с данным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Security.SecurityElement" />, заданный параметром <paramref name="e" />, является недопустимым.</exception>
		// Token: 0x06002AF8 RID: 11000 RVA: 0x0009B3A0 File Offset: 0x000995A0
		public void FromXml(SecurityElement e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			SecurityElement securityElement = e.SearchForChildByTag("SecurityClasses");
			if (securityElement != null && securityElement.Children != null && securityElement.Children.Count > 0)
			{
				this.fullNames = new Hashtable(securityElement.Children.Count);
				foreach (object obj in securityElement.Children)
				{
					SecurityElement securityElement2 = (SecurityElement)obj;
					this.fullNames.Add(securityElement2.Attributes["Name"], securityElement2.Attributes["Description"]);
				}
			}
			SecurityElement securityElement3 = e.SearchForChildByTag("FullTrustAssemblies");
			if (securityElement3 != null && securityElement3.Children != null && securityElement3.Children.Count > 0)
			{
				this.full_trust_assemblies.Clear();
				foreach (object obj2 in securityElement3.Children)
				{
					SecurityElement securityElement4 = (SecurityElement)obj2;
					if (securityElement4.Tag != "IMembershipCondition")
					{
						throw new ArgumentException(Locale.GetText("Invalid XML"));
					}
					if (securityElement4.Attribute("class").IndexOf("StrongNameMembershipCondition") < 0)
					{
						throw new ArgumentException(Locale.GetText("Invalid XML - must be StrongNameMembershipCondition"));
					}
					this.full_trust_assemblies.Add(new StrongNameMembershipCondition(securityElement4));
				}
			}
			SecurityElement securityElement5 = e.SearchForChildByTag("CodeGroup");
			if (securityElement5 != null && securityElement5.Children != null && securityElement5.Children.Count > 0)
			{
				this.root_code_group = CodeGroup.CreateFromXml(securityElement5, this);
				SecurityElement securityElement6 = e.SearchForChildByTag("NamedPermissionSets");
				if (securityElement6 != null && securityElement6.Children != null && securityElement6.Children.Count > 0)
				{
					this.named_permission_sets.Clear();
					foreach (object obj3 in securityElement6.Children)
					{
						SecurityElement et = (SecurityElement)obj3;
						NamedPermissionSet namedPermissionSet = new NamedPermissionSet();
						namedPermissionSet.Resolver = this;
						namedPermissionSet.FromXml(et);
						this.named_permission_sets.Add(namedPermissionSet);
					}
				}
				return;
			}
			throw new ArgumentException(Locale.GetText("Missing Root CodeGroup"));
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.NamedPermissionSet" /> текущего уровня политики с указанным именем.</summary>
		/// <param name="name">Имя объекта <see cref="T:System.Security.NamedPermissionSet" />, который необходимо найти.</param>
		/// <returns>Объект <see cref="T:System.Security.NamedPermissionSet" /> текущего уровня политики с указанным именем, если он найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AF9 RID: 11001 RVA: 0x0009B640 File Offset: 0x00099840
		public NamedPermissionSet GetNamedPermissionSet(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			foreach (object obj in this.named_permission_sets)
			{
				NamedPermissionSet namedPermissionSet = (NamedPermissionSet)obj;
				if (namedPermissionSet.Name == name)
				{
					return (NamedPermissionSet)namedPermissionSet.Copy();
				}
			}
			return null;
		}

		/// <summary>Заменяет файл конфигурации для этого объекта <see cref="T:System.Security.Policy.PolicyLevel" /> с использованием последней резервной копии (отражающей состояние политики до момента последнего сохранения).</summary>
		/// <exception cref="T:System.Security.Policy.PolicyException">Уровень политики не имеет допустимого файла конфигурации.</exception>
		// Token: 0x06002AFA RID: 11002 RVA: 0x0009B6C0 File Offset: 0x000998C0
		public void Recover()
		{
			if (this._location == null)
			{
				throw new PolicyException(Locale.GetText("Only file based policies may be recovered."));
			}
			string text = this._location + ".backup";
			if (!File.Exists(text))
			{
				throw new PolicyException(Locale.GetText("No policy backup exists."));
			}
			try
			{
				File.Copy(text, this._location, true);
			}
			catch (Exception exception)
			{
				throw new PolicyException(Locale.GetText("Couldn't replace the policy file with it's backup."), exception);
			}
		}

		/// <summary>Удаляет сборку с указанным <see cref="T:System.Security.Policy.StrongName" /> из списка сборок, используемых уровнем политики для оценки политики.</summary>
		/// <param name="sn">Объект <see cref="T:System.Security.Policy.StrongName" /> сборки, которую требуется удалить из списка сборок, используемых для оценки политики.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sn" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Сборка с параметром <see cref="T:System.Security.Policy.StrongName" />, задаваемым с помощью параметра <paramref name="sn" />, не считается имеющей полное доверие.</exception>
		// Token: 0x06002AFB RID: 11003 RVA: 0x0009B740 File Offset: 0x00099940
		[Obsolete("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
		public void RemoveFullTrustAssembly(StrongName sn)
		{
			if (sn == null)
			{
				throw new ArgumentNullException("sn");
			}
			StrongNameMembershipCondition snMC = new StrongNameMembershipCondition(sn.PublicKey, sn.Name, sn.Version);
			this.RemoveFullTrustAssembly(snMC);
		}

		/// <summary>Удаляет сборку с указанным <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> из списка сборок, используемых уровнем политики для оценки политики.</summary>
		/// <param name="snMC">Объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" /> сборки, которую требуется удалить из списка сборок, используемых для оценки политики.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="snMC" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Security.Policy.StrongNameMembershipCondition" />, задаваемый с помощью параметра <paramref name="snMC" />, не имеет полного доверия.</exception>
		// Token: 0x06002AFC RID: 11004 RVA: 0x0009B77A File Offset: 0x0009997A
		[Obsolete("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
		public void RemoveFullTrustAssembly(StrongNameMembershipCondition snMC)
		{
			if (snMC == null)
			{
				throw new ArgumentNullException("snMC");
			}
			if (((IList)this.full_trust_assemblies).Contains(snMC))
			{
				((IList)this.full_trust_assemblies).Remove(snMC);
				return;
			}
			throw new ArgumentException(Locale.GetText("sn does not have full trust."));
		}

		/// <summary>Удаляет указанный объект <see cref="T:System.Security.NamedPermissionSet" /> из текущего уровня политики.</summary>
		/// <param name="permSet">Объект <see cref="T:System.Security.NamedPermissionSet" />, который требуется удалить из текущего уровня политики.</param>
		/// <returns>Объект <see cref="T:System.Security.NamedPermissionSet" />, который был удален.</returns>
		/// <exception cref="T:System.ArgumentException">Объект <see cref="T:System.Security.NamedPermissionSet" />, заданный параметром <paramref name="permSet" />, не найден.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="permSet" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AFD RID: 11005 RVA: 0x0009B7B4 File Offset: 0x000999B4
		public NamedPermissionSet RemoveNamedPermissionSet(NamedPermissionSet permSet)
		{
			if (permSet == null)
			{
				throw new ArgumentNullException("permSet");
			}
			return this.RemoveNamedPermissionSet(permSet.Name);
		}

		/// <summary>Удаляет объект <see cref="T:System.Security.NamedPermissionSet" /> с указанным именем из текущего уровня политики.</summary>
		/// <param name="name">Имя удаляемого объекта <see cref="T:System.Security.NamedPermissionSet" />.</param>
		/// <returns>Объект <see cref="T:System.Security.NamedPermissionSet" />, который был удален.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="name" /> эквивалентно имени зарезервированного набора разрешений.  
		/// -или- 
		/// Объект <see cref="T:System.Security.NamedPermissionSet" /> с указанным именем не найден.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002AFE RID: 11006 RVA: 0x0009B7D0 File Offset: 0x000999D0
		public NamedPermissionSet RemoveNamedPermissionSet(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (DefaultPolicies.ReservedNames.IsReserved(name))
			{
				throw new ArgumentException(Locale.GetText("Reserved name"));
			}
			foreach (object obj in this.named_permission_sets)
			{
				NamedPermissionSet namedPermissionSet = (NamedPermissionSet)obj;
				if (name == namedPermissionSet.Name)
				{
					this.named_permission_sets.Remove(namedPermissionSet);
					return namedPermissionSet;
				}
			}
			throw new ArgumentException(string.Format(Locale.GetText("Name '{0}' cannot be found."), name), "name");
		}

		/// <summary>Возвращает текущий уровень политики в состояние, используемое по умолчанию.</summary>
		// Token: 0x06002AFF RID: 11007 RVA: 0x0009B884 File Offset: 0x00099A84
		public void Reset()
		{
			if (this.fullNames != null)
			{
				this.fullNames.Clear();
			}
			if (this._type != PolicyLevelType.AppDomain)
			{
				this.full_trust_assemblies.Clear();
				this.named_permission_sets.Clear();
				if (this._location != null && File.Exists(this._location))
				{
					try
					{
						File.Delete(this._location);
					}
					catch
					{
					}
				}
				this.LoadFromFile(this._location);
				return;
			}
			this.CreateDefaultFullTrustAssemblies();
			this.CreateDefaultNamedPermissionSets();
		}

		/// <summary>Обрабатывает политику, используя свидетельство для уровня политики, и возвращает результирующий объект <see cref="T:System.Security.Policy.PolicyStatement" />.</summary>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" /> используется для обработки <see cref="T:System.Security.Policy.PolicyLevel" />.</param>
		/// <returns>Результирующий объект <see cref="T:System.Security.Policy.PolicyStatement" />.</returns>
		/// <exception cref="T:System.Security.Policy.PolicyException">Уровень политики содержит несколько соответствующих групп кода, которые помечены как взаимоисключающие.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B00 RID: 11008 RVA: 0x0009B914 File Offset: 0x00099B14
		public PolicyStatement Resolve(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new ArgumentNullException("evidence");
			}
			PolicyStatement policyStatement = this.root_code_group.Resolve(evidence);
			if (policyStatement == null)
			{
				return PolicyStatement.Empty();
			}
			return policyStatement;
		}

		/// <summary>Обрабатывает политику на уровне политики и возвращает корень дерева групп кода, соответствующих свидетельству.</summary>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" />, используемый для обработки политики.</param>
		/// <returns>Объект <see cref="T:System.Security.Policy.CodeGroup" />, представляющий корень дерева групп кода, соответствующих указанному свидетельству.</returns>
		/// <exception cref="T:System.Security.Policy.PolicyException">Уровень политики содержит несколько соответствующих групп кода, которые помечены как взаимоисключающие.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002B01 RID: 11009 RVA: 0x0009B948 File Offset: 0x00099B48
		public CodeGroup ResolveMatchingCodeGroups(Evidence evidence)
		{
			if (evidence == null)
			{
				throw new ArgumentNullException("evidence");
			}
			CodeGroup codeGroup = this.root_code_group.ResolveMatchingCodeGroups(evidence);
			if (codeGroup == null)
			{
				return null;
			}
			return codeGroup;
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002B02 RID: 11010 RVA: 0x0009B978 File Offset: 0x00099B78
		public SecurityElement ToXml()
		{
			Hashtable hashtable = new Hashtable();
			if (this.full_trust_assemblies.Count > 0 && !hashtable.Contains("StrongNameMembershipCondition"))
			{
				hashtable.Add("StrongNameMembershipCondition", typeof(StrongNameMembershipCondition).FullName);
			}
			SecurityElement securityElement = new SecurityElement("NamedPermissionSets");
			foreach (object obj in this.named_permission_sets)
			{
				NamedPermissionSet namedPermissionSet = (NamedPermissionSet)obj;
				SecurityElement securityElement2 = namedPermissionSet.ToXml();
				object key = securityElement2.Attributes["class"];
				if (!hashtable.Contains(key))
				{
					hashtable.Add(key, namedPermissionSet.GetType().FullName);
				}
				securityElement.AddChild(securityElement2);
			}
			SecurityElement securityElement3 = new SecurityElement("FullTrustAssemblies");
			foreach (object obj2 in this.full_trust_assemblies)
			{
				StrongNameMembershipCondition strongNameMembershipCondition = (StrongNameMembershipCondition)obj2;
				securityElement3.AddChild(strongNameMembershipCondition.ToXml(this));
			}
			SecurityElement securityElement4 = new SecurityElement("SecurityClasses");
			if (hashtable.Count > 0)
			{
				foreach (object obj3 in hashtable)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj3;
					SecurityElement securityElement5 = new SecurityElement("SecurityClass");
					securityElement5.AddAttribute("Name", (string)dictionaryEntry.Key);
					securityElement5.AddAttribute("Description", (string)dictionaryEntry.Value);
					securityElement4.AddChild(securityElement5);
				}
			}
			SecurityElement securityElement6 = new SecurityElement(typeof(PolicyLevel).Name);
			securityElement6.AddAttribute("version", "1");
			securityElement6.AddChild(securityElement4);
			securityElement6.AddChild(securityElement);
			if (this.root_code_group != null)
			{
				securityElement6.AddChild(this.root_code_group.ToXml(this));
			}
			securityElement6.AddChild(securityElement3);
			return securityElement6;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0009BBB4 File Offset: 0x00099DB4
		internal void Save()
		{
			if (this._type == PolicyLevelType.AppDomain)
			{
				throw new PolicyException(Locale.GetText("Can't save AppDomain PolicyLevel"));
			}
			if (this._location != null)
			{
				try
				{
					if (File.Exists(this._location))
					{
						File.Copy(this._location, this._location + ".backup", true);
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					using (StreamWriter streamWriter = new StreamWriter(this._location))
					{
						streamWriter.Write(this.ToXml().ToString());
						streamWriter.Close();
					}
				}
			}
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0009BC68 File Offset: 0x00099E68
		internal void CreateDefaultLevel(PolicyLevelType type)
		{
			PolicyStatement policy = new PolicyStatement(DefaultPolicies.FullTrust);
			switch (type)
			{
			case PolicyLevelType.User:
			case PolicyLevelType.Enterprise:
			case PolicyLevelType.AppDomain:
				this.root_code_group = new UnionCodeGroup(new AllMembershipCondition(), policy);
				this.root_code_group.Name = "All_Code";
				return;
			case PolicyLevelType.Machine:
			{
				PolicyStatement policy2 = new PolicyStatement(DefaultPolicies.Nothing);
				this.root_code_group = new UnionCodeGroup(new AllMembershipCondition(), policy2);
				this.root_code_group.Name = "All_Code";
				UnionCodeGroup unionCodeGroup = new UnionCodeGroup(new ZoneMembershipCondition(SecurityZone.MyComputer), policy);
				unionCodeGroup.Name = "My_Computer_Zone";
				this.root_code_group.AddChild(unionCodeGroup);
				UnionCodeGroup unionCodeGroup2 = new UnionCodeGroup(new ZoneMembershipCondition(SecurityZone.Intranet), new PolicyStatement(DefaultPolicies.LocalIntranet));
				unionCodeGroup2.Name = "LocalIntranet_Zone";
				this.root_code_group.AddChild(unionCodeGroup2);
				PolicyStatement policy3 = new PolicyStatement(DefaultPolicies.Internet);
				UnionCodeGroup unionCodeGroup3 = new UnionCodeGroup(new ZoneMembershipCondition(SecurityZone.Internet), policy3);
				unionCodeGroup3.Name = "Internet_Zone";
				this.root_code_group.AddChild(unionCodeGroup3);
				UnionCodeGroup unionCodeGroup4 = new UnionCodeGroup(new ZoneMembershipCondition(SecurityZone.Untrusted), policy2);
				unionCodeGroup4.Name = "Restricted_Zone";
				this.root_code_group.AddChild(unionCodeGroup4);
				UnionCodeGroup unionCodeGroup5 = new UnionCodeGroup(new ZoneMembershipCondition(SecurityZone.Trusted), policy3);
				unionCodeGroup5.Name = "Trusted_Zone";
				this.root_code_group.AddChild(unionCodeGroup5);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0009BDBC File Offset: 0x00099FBC
		internal void CreateDefaultFullTrustAssemblies()
		{
			this.full_trust_assemblies.Clear();
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("mscorlib", DefaultPolicies.Key.Ecma));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System", DefaultPolicies.Key.Ecma));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System.Data", DefaultPolicies.Key.Ecma));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System.DirectoryServices", DefaultPolicies.Key.MsFinal));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System.Drawing", DefaultPolicies.Key.MsFinal));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System.Messaging", DefaultPolicies.Key.MsFinal));
			this.full_trust_assemblies.Add(DefaultPolicies.FullTrustMembership("System.ServiceProcess", DefaultPolicies.Key.MsFinal));
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0009BE78 File Offset: 0x0009A078
		internal void CreateDefaultNamedPermissionSets()
		{
			this.named_permission_sets.Clear();
			try
			{
				SecurityManager.ResolvingPolicyLevel = this;
				this.named_permission_sets.Add(DefaultPolicies.LocalIntranet);
				this.named_permission_sets.Add(DefaultPolicies.Internet);
				this.named_permission_sets.Add(DefaultPolicies.SkipVerification);
				this.named_permission_sets.Add(DefaultPolicies.Execution);
				this.named_permission_sets.Add(DefaultPolicies.Nothing);
				this.named_permission_sets.Add(DefaultPolicies.Everything);
				this.named_permission_sets.Add(DefaultPolicies.FullTrust);
			}
			finally
			{
				SecurityManager.ResolvingPolicyLevel = null;
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0009BF28 File Offset: 0x0009A128
		internal string ResolveClassName(string className)
		{
			if (this.fullNames != null)
			{
				object obj = this.fullNames[className];
				if (obj != null)
				{
					return (string)obj;
				}
			}
			return className;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0009BF58 File Offset: 0x0009A158
		internal bool IsFullTrustAssembly(Assembly a)
		{
			AssemblyName name = a.GetName();
			StrongNameMembershipCondition obj = new StrongNameMembershipCondition(new StrongNamePublicKeyBlob(name.GetPublicKey()), name.Name, name.Version);
			using (IEnumerator enumerator = this.full_trust_assemblies.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((StrongNameMembershipCondition)enumerator.Current).Equals(obj))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000173AD File Offset: 0x000155AD
		internal PolicyLevel()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001FA8 RID: 8104
		private string label;

		// Token: 0x04001FA9 RID: 8105
		private CodeGroup root_code_group;

		// Token: 0x04001FAA RID: 8106
		private ArrayList full_trust_assemblies;

		// Token: 0x04001FAB RID: 8107
		private ArrayList named_permission_sets;

		// Token: 0x04001FAC RID: 8108
		private string _location;

		// Token: 0x04001FAD RID: 8109
		private PolicyLevelType _type;

		// Token: 0x04001FAE RID: 8110
		private Hashtable fullNames;

		// Token: 0x04001FAF RID: 8111
		private SecurityElement xml;
	}
}
