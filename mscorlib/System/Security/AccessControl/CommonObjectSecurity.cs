using System;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает возможность управления доступом к объектам без непосредственной работы со списками управления доступом. Этот класс является абстрактным базовым классом для класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</summary>
	// Token: 0x02000516 RID: 1302
	public abstract class CommonObjectSecurity : ObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект является контейнером.</param>
		// Token: 0x060033A0 RID: 13216 RVA: 0x000BD852 File Offset: 0x000BBA52
		protected CommonObjectSecurity(bool isContainer) : base(isContainer, false)
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000BD85C File Offset: 0x000BBA5C
		internal CommonObjectSecurity(CommonSecurityDescriptor securityDescriptor) : base(securityDescriptor)
		{
		}

		/// <summary>Получает коллекцию правил доступа, связанных с указанным идентификатором безопасности.</summary>
		/// <param name="includeExplicit">Значение <see langword="true" />, чтобы включить правила доступа, явным образом указанные для данного объекта.</param>
		/// <param name="includeInherited">Значение <see langword="true" />, чтобы включить унаследованные правила доступа.</param>
		/// <param name="targetType">Определяет, относится ли идентификатор безопасности, для которого извлекаются правила доступа, к типу T:System.Security.Principal.SecurityIdentifier или к типу T:System.Security.Principal.NTAccount. Значение этого параметра должно иметь тип, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>Коллекция правил доступа, связанных с указанным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x060033A2 RID: 13218 RVA: 0x000BD865 File Offset: 0x000BBA65
		public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			return base.InternalGetAccessRules(includeExplicit, includeInherited, targetType);
		}

		/// <summary>Получает коллекцию правил аудита, связанных с указанным идентификатором безопасности.</summary>
		/// <param name="includeExplicit">Значение <see langword="true" />, чтобы включить правила аудита, явным образом указанные для данного объекта.</param>
		/// <param name="includeInherited">Значение <see langword="true" />, чтобы включить унаследованные правила аудита.</param>
		/// <param name="targetType">Идентификатор безопасности, для которого извлекаются правила аудита. Это должен быть объект, который можно привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>Коллекция правил аудита, связанных с указанным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x060033A3 RID: 13219 RVA: 0x000BD870 File Offset: 0x000BBA70
		public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			return base.InternalGetAuditRules(includeExplicit, includeInherited, targetType);
		}

		/// <summary>Добавляет указанное правило доступа в список управления доступом на уровне пользователей, связанный с данным объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Добавляемое правило доступа.</param>
		// Token: 0x060033A4 RID: 13220 RVA: 0x000BD87C File Offset: 0x000BBA7C
		protected void AddAccessRule(AccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Add, rule, out flag);
		}

		/// <summary>Удаляет правила доступа с тем же идентификатором безопасности и маской доступа, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		/// <returns>Значение <see langword="true" />, если правило доступа успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033A5 RID: 13221 RVA: 0x000BD894 File Offset: 0x000BBA94
		protected bool RemoveAccessRule(AccessRule rule)
		{
			bool flag;
			return this.ModifyAccess(AccessControlModification.Remove, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033A6 RID: 13222 RVA: 0x000BD8AC File Offset: 0x000BBAAC
		protected void RemoveAccessRuleAll(AccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.RemoveAll, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа, в точности совпадающие с указанным правилом доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033A7 RID: 13223 RVA: 0x000BD8C4 File Offset: 0x000BBAC4
		protected void RemoveAccessRuleSpecific(AccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.RemoveSpecific, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Сбрасываемое правило доступа.</param>
		// Token: 0x060033A8 RID: 13224 RVA: 0x000BD8DC File Offset: 0x000BBADC
		protected void ResetAccessRule(AccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Reset, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором и квалификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Устанавливаемое правило доступа.</param>
		// Token: 0x060033A9 RID: 13225 RVA: 0x000BD8F4 File Offset: 0x000BBAF4
		protected void SetAccessRule(AccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Set, rule, out flag);
		}

		/// <summary>Применяет указанное изменение к списку управления доступом на уровне пользователей (DACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку DACL.</param>
		/// <param name="rule">Изменяемое правило доступа.</param>
		/// <param name="modified">Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033AA RID: 13226 RVA: 0x000BD90C File Offset: 0x000BBB0C
		protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			modified = true;
			base.WriteLock();
			try
			{
				switch (modification)
				{
				case AccessControlModification.Add:
					break;
				case AccessControlModification.Set:
					this.descriptor.DiscretionaryAcl.SetAccess(rule.AccessControlType, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					goto IL_13D;
				case AccessControlModification.Reset:
					this.PurgeAccessRules(rule.IdentityReference);
					break;
				case AccessControlModification.Remove:
					modified = this.descriptor.DiscretionaryAcl.RemoveAccess(rule.AccessControlType, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					goto IL_13D;
				case AccessControlModification.RemoveAll:
					this.PurgeAccessRules(rule.IdentityReference);
					goto IL_13D;
				case AccessControlModification.RemoveSpecific:
					this.descriptor.DiscretionaryAcl.RemoveAccessSpecific(rule.AccessControlType, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					goto IL_13D;
				default:
					throw new ArgumentOutOfRangeException("modification");
				}
				this.descriptor.DiscretionaryAcl.AddAccess(rule.AccessControlType, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
				IL_13D:
				if (modified)
				{
					base.AccessRulesModified = true;
				}
			}
			finally
			{
				base.WriteUnlock();
			}
			return modified;
		}

		/// <summary>Добавляет указанное правило аудита в системный список управления доступом, связанный с данным объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Добавляемое правило аудита.</param>
		// Token: 0x060033AB RID: 13227 RVA: 0x000BDA88 File Offset: 0x000BBC88
		protected void AddAuditRule(AuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.Add, rule, out flag);
		}

		/// <summary>Удаляет правила аудита с тем же идентификатором безопасности и маской доступа, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если правило аудита успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033AC RID: 13228 RVA: 0x000BDAA0 File Offset: 0x000BBCA0
		protected bool RemoveAuditRule(AuditRule rule)
		{
			bool flag;
			return this.ModifyAudit(AccessControlModification.Remove, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x060033AD RID: 13229 RVA: 0x000BDAB8 File Offset: 0x000BBCB8
		protected void RemoveAuditRuleAll(AuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.RemoveAll, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита, в точности совпадающие с указанным правилом аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x060033AE RID: 13230 RVA: 0x000BDAD0 File Offset: 0x000BBCD0
		protected void RemoveAuditRuleSpecific(AuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.RemoveSpecific, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором и квалификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />, а затем добавляет указанное правило аудита.</summary>
		/// <param name="rule">Устанавливаемое правило аудита.</param>
		// Token: 0x060033AF RID: 13231 RVA: 0x000BDAE8 File Offset: 0x000BBCE8
		protected void SetAuditRule(AuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.Set, rule, out flag);
		}

		/// <summary>Применяет указанное изменение к системному списку управления доступом (SACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку SACL.</param>
		/// <param name="rule">Правило аудита, которое нужно изменить.</param>
		/// <param name="modified">Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033B0 RID: 13232 RVA: 0x000BDB00 File Offset: 0x000BBD00
		protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			modified = true;
			base.WriteLock();
			try
			{
				switch (modification)
				{
				case AccessControlModification.Add:
					if (this.descriptor.SystemAcl == null)
					{
						this.descriptor.SystemAcl = new SystemAcl(base.IsContainer, base.IsDS, 1);
					}
					this.descriptor.SystemAcl.AddAudit(rule.AuditFlags, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					break;
				case AccessControlModification.Set:
					if (this.descriptor.SystemAcl == null)
					{
						this.descriptor.SystemAcl = new SystemAcl(base.IsContainer, base.IsDS, 1);
					}
					this.descriptor.SystemAcl.SetAudit(rule.AuditFlags, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					break;
				case AccessControlModification.Reset:
					break;
				case AccessControlModification.Remove:
					if (this.descriptor.SystemAcl == null)
					{
						modified = false;
					}
					else
					{
						modified = this.descriptor.SystemAcl.RemoveAudit(rule.AuditFlags, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					}
					break;
				case AccessControlModification.RemoveAll:
					this.PurgeAuditRules(rule.IdentityReference);
					break;
				case AccessControlModification.RemoveSpecific:
					if (this.descriptor.SystemAcl != null)
					{
						this.descriptor.SystemAcl.RemoveAuditSpecific(rule.AuditFlags, ObjectSecurity.SidFromIR(rule.IdentityReference), rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags);
					}
					break;
				default:
					throw new ArgumentOutOfRangeException("modification");
				}
				if (modified)
				{
					base.AuditRulesModified = true;
				}
			}
			finally
			{
				base.WriteUnlock();
			}
			return modified;
		}
	}
}
