using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает возможность управлять доступом к объекту криптографического ключа без непосредственной работы со списками управления доступом (ACL).</summary>
	// Token: 0x0200051E RID: 1310
	public sealed class CryptoKeySecurity : NativeObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		// Token: 0x060033DA RID: 13274 RVA: 0x000BE0A8 File Offset: 0x000BC2A8
		public CryptoKeySecurity() : base(false, ResourceType.Unknown)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> с использованием указанного дескриптора безопасности.</summary>
		/// <param name="securityDescriptor">Дескриптор безопасности, на основании которого создается новый объект <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</param>
		// Token: 0x060033DB RID: 13275 RVA: 0x000BE0B2 File Offset: 0x000BC2B2
		public CryptoKeySecurity(CommonSecurityDescriptor securityDescriptor) : base(securityDescriptor, ResourceType.Unknown)
		{
		}

		/// <summary>Возвращает <see cref="T:System.Type" /> защищаемого объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <returns>Тип защищаемого объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</returns>
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060033DC RID: 13276 RVA: 0x000BE0BC File Offset: 0x000BC2BC
		public override Type AccessRightType
		{
			get
			{
				return typeof(CryptoKeyRights);
			}
		}

		/// <summary>Получает <see cref="T:System.Type" /> объекта, связанного с правилами доступа этого объекта <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />. Объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> должен быть объектом, который может быть приведен как объект <see cref="T:System.Type" />.</summary>
		/// <returns>Тип объекта, связанного с правилами доступа этого <see cref="T:System.Security.AccessControl.CryptoKeySecurity" /> объекта.</returns>
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x000BE0C8 File Offset: 0x000BC2C8
		public override Type AccessRuleType
		{
			get
			{
				return typeof(CryptoKeyAccessRule);
			}
		}

		/// <summary>Получает объект <see cref="T:System.Type" />, связанный с правилами аудита этого объекта <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />. Объект <see cref="T:System.Type" /> должен быть объектом, который может быть приведен как объект <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <returns>Тип объекта, связанного с правилами аудита этого объекта <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</returns>
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x000BE0D4 File Offset: 0x000BC2D4
		public override Type AuditRuleType
		{
			get
			{
				return typeof(CryptoKeyAuditRule);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AccessRule" /> с использованием указанных значений.</summary>
		/// <param name="identityReference">Удостоверение, к которому применяется правило доступа.  Это должен быть объект, который может быть приведен как <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение true, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Указывает допустимый тип управления доступом.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AccessRule" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x060033DF RID: 13279 RVA: 0x000BE0E0 File Offset: 0x000BC2E0
		public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new CryptoKeyAccessRule(identityReference, (CryptoKeyRights)accessMask, type);
		}

		/// <summary>Добавляет указанное правило доступа в список управления доступом на уровне пользователей, связанный с данным объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Добавляемое правило доступа.</param>
		// Token: 0x060033E0 RID: 13280 RVA: 0x000BC644 File Offset: 0x000BA844
		public void AddAccessRule(CryptoKeyAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Удаляет правила доступа с тем же идентификатором безопасности и маской доступа, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		/// <returns>Значение <see langword="true" />, если правило доступа успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033E1 RID: 13281 RVA: 0x000BC65F File Offset: 0x000BA85F
		public bool RemoveAccessRule(CryptoKeyAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033E2 RID: 13282 RVA: 0x000BC668 File Offset: 0x000BA868
		public void RemoveAccessRuleAll(CryptoKeyAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Удаляет все правила доступа, в точности совпадающие с указанным правилом доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x060033E3 RID: 13283 RVA: 0x000BC671 File Offset: 0x000BA871
		public void RemoveAccessRuleSpecific(CryptoKeyAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Сбрасываемое правило доступа.</param>
		// Token: 0x060033E4 RID: 13284 RVA: 0x000BC656 File Offset: 0x000BA856
		public void ResetAccessRule(CryptoKeyAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором и квалификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Устанавливаемое правило доступа.</param>
		// Token: 0x060033E5 RID: 13285 RVA: 0x000BC64D File Offset: 0x000BA84D
		public void SetAccessRule(CryptoKeyAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" /> с использованием указанных значений.</summary>
		/// <param name="identityReference">Удостоверение, к которому применяется правило аудита.  Это должен быть объект, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил аудита. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="flags">Указывает условия, в которых выполняется аудит правила.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AuditRule" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x060033E6 RID: 13286 RVA: 0x000BE0EB File Offset: 0x000BC2EB
		public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new CryptoKeyAuditRule(identityReference, (CryptoKeyRights)accessMask, flags);
		}

		/// <summary>Добавляет указанное правило аудита в системный список управления доступом, связанный с данным объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Добавляемое правило аудита.</param>
		// Token: 0x060033E7 RID: 13287 RVA: 0x000BC67A File Offset: 0x000BA87A
		public void AddAuditRule(CryptoKeyAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Удаляет правила аудита с тем же идентификатором безопасности и маской доступа, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если правило аудита успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060033E8 RID: 13288 RVA: 0x000BC68C File Offset: 0x000BA88C
		public bool RemoveAuditRule(CryptoKeyAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x060033E9 RID: 13289 RVA: 0x000BC695 File Offset: 0x000BA895
		public void RemoveAuditRuleAll(CryptoKeyAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Удаляет все правила аудита, в точности совпадающие с указанным правилом аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x060033EA RID: 13290 RVA: 0x000BC69E File Offset: 0x000BA89E
		public void RemoveAuditRuleSpecific(CryptoKeyAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором и квалификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CryptoKeySecurity" />, а затем добавляет указанное правило аудита.</summary>
		/// <param name="rule">Устанавливаемое правило аудита.</param>
		// Token: 0x060033EB RID: 13291 RVA: 0x000BC683 File Offset: 0x000BA883
		public void SetAuditRule(CryptoKeyAuditRule rule)
		{
			base.SetAuditRule(rule);
		}
	}
}
