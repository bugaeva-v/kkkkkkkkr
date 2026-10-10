using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает безопасность управления доступом Windows для раздела реестра. Этот класс не наследуется.</summary>
	// Token: 0x020004FB RID: 1275
	public sealed class RegistrySecurity : NativeObjectSecurity
	{
		// Token: 0x06003315 RID: 13077 RVA: 0x000BC4F8 File Offset: 0x000BA6F8
		private static Exception _HandleErrorCodeCore(int errorCode, string name, SafeHandle handle, object context)
		{
			Exception result = null;
			if (errorCode != 2)
			{
				if (errorCode != 6)
				{
					if (errorCode == 123)
					{
						result = new ArgumentException(SR.Format("Registry key name must start with a valid base key name.", "name"));
					}
				}
				else
				{
					result = new ArgumentException("The supplied handle is invalid. This can happen when trying to set an ACL on an anonymous kernel object.");
				}
			}
			else
			{
				result = new IOException(SR.Format("The specified registry key does not exist.", errorCode));
			}
			return result;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RegistrySecurity" /> со значениями по умолчанию.</summary>
		// Token: 0x06003316 RID: 13078 RVA: 0x000BC551 File Offset: 0x000BA751
		public RegistrySecurity() : base(true, ResourceType.RegistryKey)
		{
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000BC55B File Offset: 0x000BA75B
		internal RegistrySecurity(SafeRegistryHandle hKey, string name, AccessControlSections includeSections) : base(true, ResourceType.RegistryKey, hKey, includeSections, new NativeObjectSecurity.ExceptionFromErrorCode(RegistrySecurity._HandleErrorCode), null)
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000BC574 File Offset: 0x000BA774
		private static Exception _HandleErrorCode(int errorCode, string name, SafeHandle handle, object context)
		{
			return RegistrySecurity._HandleErrorCodeCore(errorCode, name, handle, context);
		}

		/// <summary>Создает новое правило управления доступом для указанного пользователя с указанными правами, типом управления доступом и флагами.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее разрешаемые или запрещаемые права доступа, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Логическое значение, которое определяет, наследуется ли правило.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок наследования правила подразделами.</param>
		/// <param name="propagationFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, изменяющее порядок наследования правила подразделами. Не имеет смысла, если свойство <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, представляющий указанные права для указанного пользователя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="type" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x06003319 RID: 13081 RVA: 0x000BC57F File Offset: 0x000BA77F
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new RegistryAccessRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type);
		}

		/// <summary>Создает новое правило аудита, в котором указывается пользователь, к которому относится правило, права доступа для аудита, параметры наследования и распространения правила, а также событие, вызывающее срабатывание правила.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, идентифицирующий пользователя или группу, к которым относится данное правило.</param>
		/// <param name="accessMask">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.RegistryRights" />, определяющее права доступа для аудита, приведенное к целочисленному типу.</param>
		/// <param name="isInherited">Логическое значение, которое определяет, наследуется ли правило.</param>
		/// <param name="inheritanceFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок наследования правила подразделами.</param>
		/// <param name="propagationFlags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, изменяющее порядок наследования правила подразделами. Не имеет смысла, если свойство <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="flags">Побитовое сочетание значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее предмет аудита — успешные попытки доступа, неудачные попытки доступа или все попытки доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.RegistryAuditRule" />, представляющий указанное правило аудита для заданного пользователя с заданными флагами. Метод возвращает объект базового класса (<see cref="T:System.Security.AccessControl.AuditRule" />), но возвращаемое значение можно безопасно привести к производному классу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="flags" /> имеет недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="accessMask" /> равен нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не относится к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> и к такому типу, как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600331A RID: 13082 RVA: 0x000BC58F File Offset: 0x000BA78F
		public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new RegistryAuditRule(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000BC5A0 File Offset: 0x000BA7A0
		internal AccessControlSections GetAccessControlSectionsFromChanges()
		{
			AccessControlSections accessControlSections = AccessControlSections.None;
			if (base.AccessRulesModified)
			{
				accessControlSections = AccessControlSections.Access;
			}
			if (base.AuditRulesModified)
			{
				accessControlSections |= AccessControlSections.Audit;
			}
			if (base.OwnerModified)
			{
				accessControlSections |= AccessControlSections.Owner;
			}
			if (base.GroupModified)
			{
				accessControlSections |= AccessControlSections.Group;
			}
			return accessControlSections;
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000BC5E0 File Offset: 0x000BA7E0
		internal void Persist(SafeRegistryHandle hKey, string keyName)
		{
			base.WriteLock();
			try
			{
				AccessControlSections accessControlSectionsFromChanges = this.GetAccessControlSectionsFromChanges();
				if (accessControlSectionsFromChanges != AccessControlSections.None)
				{
					this.Persist(hKey, accessControlSectionsFromChanges);
					base.OwnerModified = (base.GroupModified = (base.AuditRulesModified = (base.AccessRulesModified = false)));
				}
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>Выполняет поиск подходящего элемента управления доступом, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило управления доступом.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600331D RID: 13085 RVA: 0x000BC644 File Offset: 0x000BA844
		public void AddAccessRule(RegistryAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" />. Имя пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> определяют правила, которые необходимо удалить перед добавлением этого правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600331E RID: 13086 RVA: 0x000BC64D File Offset: 0x000BA84D
		public void SetAccessRule(RegistryAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Удаляет все правила управления доступом с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AccessControlType" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		// Token: 0x0600331F RID: 13087 RVA: 0x000BC656 File Offset: 0x000BA856
		public void ResetAccessRule(RegistryAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом с тем же именем пользователя и значением <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если правило найдено, содержащиеся в указанном правиле доступа права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий пользователя и тип <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003320 RID: 13088 RVA: 0x000BC65F File Offset: 0x000BA85F
		public bool RemoveAccessRule(RegistryAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Осуществляет поиск всех правил управления доступом с тем же именем пользователя и значением свойства <see cref="T:System.Security.AccessControl.AccessControlType" /> ("разрешить" или "запретить"), что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" />, определяющий пользователя и значение <see cref="T:System.Security.AccessControl.AccessControlType" /> для поиска. Никакие указанные в этом правиле права, флаги наследования и распространения не учитываются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003321 RID: 13089 RVA: 0x000BC668 File Offset: 0x000BA868
		public void RemoveAccessRuleAll(RegistryAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила управления доступом, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.RegistryAccessRule" /> для удаления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003322 RID: 13090 RVA: 0x000BC671 File Offset: 0x000BA871
		public void RemoveAccessRuleSpecific(RegistryAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Осуществляет поиск правила аудита, с которым можно объединить новое правило. Если поиск не дал результатов, добавляется новое правило.</summary>
		/// <param name="rule">Добавляемое правило аудита. Поиск ведется по имени пользователя, указанному в этом правиле.</param>
		// Token: 0x06003323 RID: 13091 RVA: 0x000BC67A File Offset: 0x000BA87A
		public void AddAuditRule(RegistryAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же именем пользователя, что и у указанного правила, вне зависимости от значения свойства <see cref="T:System.Security.AccessControl.AuditFlags" />, после чего добавляет указанное правило.</summary>
		/// <param name="rule">Добавляемый объект <see cref="T:System.Security.AccessControl.RegistryAuditRule" />. Имя пользователя, заданное в этом правиле, определяет правила, которые необходимо удалить перед добавлением данного правила.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003324 RID: 13092 RVA: 0x000BC683 File Offset: 0x000BA883
		public void SetAuditRule(RegistryAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		/// <summary>Осуществляет поиск правила управления аудитом с тем же именем пользователя, что и указанного правила доступа, а также с совместимыми флагами наследования и распространения; если совместимое правило найдено, содержащиеся в указанном правиле права удаляются.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.RegistryAuditRule" />, определяющий пользователя для поиска, а также набор флагов наследования и распространения, с которыми должно быть совместимо найденное правило. Задает права, которые требуется удалить из совместимого правила, если оно будет найдено.</param>
		/// <returns>Значение <see langword="true" />, если совместимое правило найдено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003325 RID: 13093 RVA: 0x000BC68C File Offset: 0x000BA88C
		public bool RemoveAuditRule(RegistryAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Производит поиск всех правил аудита с тем же пользователем, что и у указанного правила, и удаляет найденные правила.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.RegistryAuditRule" />, определяющий пользователя для поиска. Никакие указанные в этом правиле права, флаги наследования и распространения не учитываются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003326 RID: 13094 RVA: 0x000BC695 File Offset: 0x000BA895
		public void RemoveAuditRuleAll(RegistryAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Осуществляет поиск правила аудита, в точности соответствующего указанному правилу, и удаляет найденное правило.</summary>
		/// <param name="rule">Удаляемый объект <see cref="T:System.Security.AccessControl.RegistryAuditRule" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003327 RID: 13095 RVA: 0x000BC69E File Offset: 0x000BA89E
		public void RemoveAuditRuleSpecific(RegistryAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Получает значение перечисления, используемое классом <see cref="T:System.Security.AccessControl.RegistrySecurity" /> для обозначения прав доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий перечисление <see cref="T:System.Security.AccessControl.RegistryRights" />.</returns>
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x000BC6A7 File Offset: 0x000BA8A7
		public override Type AccessRightType
		{
			get
			{
				return typeof(RegistryRights);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.RegistrySecurity" /> для обозначения правил доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.RegistryAccessRule" />.</returns>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000BC6B3 File Offset: 0x000BA8B3
		public override Type AccessRuleType
		{
			get
			{
				return typeof(RegistryAccessRule);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.RegistrySecurity" /> для обозначения правил аудита.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.RegistryAuditRule" />.</returns>
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x000BC6BF File Offset: 0x000BA8BF
		public override Type AuditRuleType
		{
			get
			{
				return typeof(RegistryAuditRule);
			}
		}
	}
}
