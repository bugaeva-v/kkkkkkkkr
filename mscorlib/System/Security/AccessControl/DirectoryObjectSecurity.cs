using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает возможность управления доступом к объектам каталога без непосредственной работы со списками управления доступом.</summary>
	// Token: 0x02000520 RID: 1312
	public abstract class DirectoryObjectSecurity : ObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		// Token: 0x060033F3 RID: 13299 RVA: 0x000BE141 File Offset: 0x000BC341
		protected DirectoryObjectSecurity() : base(true, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" /> с использованием указанного дескриптора безопасности.</summary>
		/// <param name="securityDescriptor">Дескриптор безопасности, который необходимо связать с новым объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</param>
		// Token: 0x060033F4 RID: 13300 RVA: 0x000BD85C File Offset: 0x000BBA5C
		protected DirectoryObjectSecurity(CommonSecurityDescriptor securityDescriptor) : base(securityDescriptor)
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x0004D851 File Offset: 0x0004BA51
		private Exception GetNotImplementedException()
		{
			return new NotImplementedException();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AccessRule" /> с использованием указанных значений.</summary>
		/// <param name="identityReference">Удостоверение, к которому применяется правило доступа.  Это должен быть объект, который может быть приведен как <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение true, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Указывает допустимый тип управления доступом.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новое правило доступа.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новое правило доступа.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AccessRule" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x060033F6 RID: 13302 RVA: 0x000BE14B File Offset: 0x000BC34B
		public virtual AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type, Guid objectType, Guid inheritedObjectType)
		{
			throw this.GetNotImplementedException();
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000BE154 File Offset: 0x000BC354
		internal override AccessRule InternalAccessRuleFactory(QualifiedAce ace, Type targetType, AccessControlType type)
		{
			ObjectAce objectAce = ace as ObjectAce;
			if (null == objectAce || objectAce.ObjectAceFlags == ObjectAceFlags.None)
			{
				return base.InternalAccessRuleFactory(ace, targetType, type);
			}
			return this.AccessRuleFactory(ace.SecurityIdentifier.Translate(targetType), ace.AccessMask, ace.IsInherited, ace.InheritanceFlags, ace.PropagationFlags, type, objectAce.ObjectAceType, objectAce.InheritedObjectAceType);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" /> с использованием указанных значений.</summary>
		/// <param name="identityReference">Удостоверение, к которому применяется правило аудита.  Это должен быть объект, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил аудита. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="flags">Указывает условия, в которых выполняется аудит правила.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новое правило аудита.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новое правило аудита.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AuditRule" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x060033F8 RID: 13304 RVA: 0x000BE14B File Offset: 0x000BC34B
		public virtual AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags, Guid objectType, Guid inheritedObjectType)
		{
			throw this.GetNotImplementedException();
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000BE1BC File Offset: 0x000BC3BC
		internal override AuditRule InternalAuditRuleFactory(QualifiedAce ace, Type targetType)
		{
			ObjectAce objectAce = ace as ObjectAce;
			if (null == objectAce || objectAce.ObjectAceFlags == ObjectAceFlags.None)
			{
				return base.InternalAuditRuleFactory(ace, targetType);
			}
			return this.AuditRuleFactory(ace.SecurityIdentifier.Translate(targetType), ace.AccessMask, ace.IsInherited, ace.InheritanceFlags, ace.PropagationFlags, ace.AuditFlags, objectAce.ObjectAceType, objectAce.InheritedObjectAceType);
		}

		/// <summary>Получает коллекцию правил доступа, связанных с указанным идентификатором безопасности.</summary>
		/// <param name="includeExplicit">Значение <see langword="true" />, чтобы включить правила доступа, явным образом указанные для данного объекта.</param>
		/// <param name="includeInherited">Значение <see langword="true" />, чтобы включить унаследованные правила доступа.</param>
		/// <param name="targetType">Идентификатор безопасности, для которого извлекаются правила доступа. Это должен быть объект, который можно привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>Коллекция правил доступа, связанных с указанным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x060033FA RID: 13306 RVA: 0x000BD865 File Offset: 0x000BBA65
		public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			return base.InternalGetAccessRules(includeExplicit, includeInherited, targetType);
		}

		/// <summary>Получает коллекцию правил аудита, связанных с указанным идентификатором безопасности.</summary>
		/// <param name="includeExplicit">Значение <see langword="true" />, чтобы включить правила аудита, явным образом указанные для данного объекта.</param>
		/// <param name="includeInherited">Значение <see langword="true" />, чтобы включить унаследованные правила аудита.</param>
		/// <param name="targetType">Идентификатор безопасности, для которого извлекаются правила аудита. Это должен быть объект, который можно привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <returns>Коллекция правил аудита, связанных с указанным объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</returns>
		// Token: 0x060033FB RID: 13307 RVA: 0x000BD870 File Offset: 0x000BBA70
		public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			return base.InternalGetAuditRules(includeExplicit, includeInherited, targetType);
		}

		/// <summary>Добавляет указанное правило доступа в список управления доступом на уровне пользователей, связанный с данным объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Добавляемое правило доступа.</param>
		// Token: 0x060033FC RID: 13308 RVA: 0x000BE228 File Offset: 0x000BC428
		protected void AddAccessRule(ObjectAccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Add, rule, out flag);
		}

		/// <summary>Удаляет правила доступа с тем же идентификатором безопасности и маской доступа, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		/// <returns>Значение <see langword="true" />, если правило доступа успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033FD RID: 13309 RVA: 0x000BE240 File Offset: 0x000BC440
		protected bool RemoveAccessRule(ObjectAccessRule rule)
		{
			bool flag;
			return this.ModifyAccess(AccessControlModification.Remove, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033FE RID: 13310 RVA: 0x000BE258 File Offset: 0x000BC458
		protected void RemoveAccessRuleAll(ObjectAccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.RemoveAll, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа, в точности совпадающие с указанным правилом доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033FF RID: 13311 RVA: 0x000BE270 File Offset: 0x000BC470
		protected void RemoveAccessRuleSpecific(ObjectAccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.RemoveSpecific, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Сбрасываемое правило доступа.</param>
		// Token: 0x06003400 RID: 13312 RVA: 0x000BE288 File Offset: 0x000BC488
		protected void ResetAccessRule(ObjectAccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Reset, rule, out flag);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором и квалификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Устанавливаемое правило доступа.</param>
		// Token: 0x06003401 RID: 13313 RVA: 0x000BE2A0 File Offset: 0x000BC4A0
		protected void SetAccessRule(ObjectAccessRule rule)
		{
			bool flag;
			this.ModifyAccess(AccessControlModification.Set, rule, out flag);
		}

		/// <summary>Применяет указанное изменение к списку управления доступом на уровне пользователей (DACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку DACL.</param>
		/// <param name="rule">Изменяемое правило доступа.</param>
		/// <param name="modified">Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003402 RID: 13314 RVA: 0x000BE2B8 File Offset: 0x000BC4B8
		protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			ObjectAccessRule objectAccessRule = rule as ObjectAccessRule;
			if (objectAccessRule == null)
			{
				throw new ArgumentException("rule");
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
					this.descriptor.DiscretionaryAcl.SetAccess(objectAccessRule.AccessControlType, ObjectSecurity.SidFromIR(objectAccessRule.IdentityReference), objectAccessRule.AccessMask, objectAccessRule.InheritanceFlags, objectAccessRule.PropagationFlags, objectAccessRule.ObjectFlags, objectAccessRule.ObjectType, objectAccessRule.InheritedObjectType);
					goto IL_19D;
				case AccessControlModification.Reset:
					this.PurgeAccessRules(objectAccessRule.IdentityReference);
					break;
				case AccessControlModification.Remove:
					modified = this.descriptor.DiscretionaryAcl.RemoveAccess(objectAccessRule.AccessControlType, ObjectSecurity.SidFromIR(objectAccessRule.IdentityReference), rule.AccessMask, objectAccessRule.InheritanceFlags, objectAccessRule.PropagationFlags, objectAccessRule.ObjectFlags, objectAccessRule.ObjectType, objectAccessRule.InheritedObjectType);
					goto IL_19D;
				case AccessControlModification.RemoveAll:
					this.PurgeAccessRules(objectAccessRule.IdentityReference);
					goto IL_19D;
				case AccessControlModification.RemoveSpecific:
					this.descriptor.DiscretionaryAcl.RemoveAccessSpecific(objectAccessRule.AccessControlType, ObjectSecurity.SidFromIR(objectAccessRule.IdentityReference), objectAccessRule.AccessMask, objectAccessRule.InheritanceFlags, objectAccessRule.PropagationFlags, objectAccessRule.ObjectFlags, objectAccessRule.ObjectType, objectAccessRule.InheritedObjectType);
					goto IL_19D;
				default:
					throw new ArgumentOutOfRangeException("modification");
				}
				this.descriptor.DiscretionaryAcl.AddAccess(objectAccessRule.AccessControlType, ObjectSecurity.SidFromIR(objectAccessRule.IdentityReference), objectAccessRule.AccessMask, objectAccessRule.InheritanceFlags, objectAccessRule.PropagationFlags, objectAccessRule.ObjectFlags, objectAccessRule.ObjectType, objectAccessRule.InheritedObjectType);
				IL_19D:
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

		/// <summary>Добавляет указанное правило аудита в системный список управления доступом, связанный с данным объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Добавляемое правило аудита.</param>
		// Token: 0x06003403 RID: 13315 RVA: 0x000BE494 File Offset: 0x000BC694
		protected void AddAuditRule(ObjectAuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.Add, rule, out flag);
		}

		/// <summary>Удаляет правила аудита с тем же идентификатором безопасности и маской доступа, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если правило аудита успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003404 RID: 13316 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		protected bool RemoveAuditRule(ObjectAuditRule rule)
		{
			bool flag;
			return this.ModifyAudit(AccessControlModification.Remove, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x06003405 RID: 13317 RVA: 0x000BE4C4 File Offset: 0x000BC6C4
		protected void RemoveAuditRuleAll(ObjectAuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.RemoveAll, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита, в точности совпадающие с указанным правилом аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x06003406 RID: 13318 RVA: 0x000BE4DC File Offset: 0x000BC6DC
		protected void RemoveAuditRuleSpecific(ObjectAuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.RemoveSpecific, rule, out flag);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором и квалификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />, а затем добавляет указанное правило аудита.</summary>
		/// <param name="rule">Устанавливаемое правило аудита.</param>
		// Token: 0x06003407 RID: 13319 RVA: 0x000BE4F4 File Offset: 0x000BC6F4
		protected void SetAuditRule(ObjectAuditRule rule)
		{
			bool flag;
			this.ModifyAudit(AccessControlModification.Set, rule, out flag);
		}

		/// <summary>Применяет указанное изменение к системному списку управления доступом (SACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку SACL.</param>
		/// <param name="rule">Правило аудита, которое нужно изменить.</param>
		/// <param name="modified">Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003408 RID: 13320 RVA: 0x000BE50C File Offset: 0x000BC70C
		protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			ObjectAuditRule objectAuditRule = rule as ObjectAuditRule;
			if (objectAuditRule == null)
			{
				throw new ArgumentException("rule");
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
					this.descriptor.SystemAcl.AddAudit(objectAuditRule.AuditFlags, ObjectSecurity.SidFromIR(objectAuditRule.IdentityReference), objectAuditRule.AccessMask, objectAuditRule.InheritanceFlags, objectAuditRule.PropagationFlags, objectAuditRule.ObjectFlags, objectAuditRule.ObjectType, objectAuditRule.InheritedObjectType);
					break;
				case AccessControlModification.Set:
					if (this.descriptor.SystemAcl == null)
					{
						this.descriptor.SystemAcl = new SystemAcl(base.IsContainer, base.IsDS, 1);
					}
					this.descriptor.SystemAcl.SetAudit(objectAuditRule.AuditFlags, ObjectSecurity.SidFromIR(objectAuditRule.IdentityReference), objectAuditRule.AccessMask, objectAuditRule.InheritanceFlags, objectAuditRule.PropagationFlags, objectAuditRule.ObjectFlags, objectAuditRule.ObjectType, objectAuditRule.InheritedObjectType);
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
						modified = this.descriptor.SystemAcl.RemoveAudit(objectAuditRule.AuditFlags, ObjectSecurity.SidFromIR(objectAuditRule.IdentityReference), objectAuditRule.AccessMask, objectAuditRule.InheritanceFlags, objectAuditRule.PropagationFlags, objectAuditRule.ObjectFlags, objectAuditRule.ObjectType, objectAuditRule.InheritedObjectType);
					}
					break;
				case AccessControlModification.RemoveAll:
					this.PurgeAuditRules(objectAuditRule.IdentityReference);
					break;
				case AccessControlModification.RemoveSpecific:
					if (this.descriptor.SystemAcl != null)
					{
						this.descriptor.SystemAcl.RemoveAuditSpecific(objectAuditRule.AuditFlags, ObjectSecurity.SidFromIR(objectAuditRule.IdentityReference), objectAuditRule.AccessMask, objectAuditRule.InheritanceFlags, objectAuditRule.PropagationFlags, objectAuditRule.ObjectFlags, objectAuditRule.ObjectType, objectAuditRule.InheritedObjectType);
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
