using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>
	///         Представляет элемент управления доступом и аудита безопасности для канала.
	///       </summary>
	// Token: 0x0200034E RID: 846
	public class PipeSecurity : NativeObjectSecurity
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.IO.Pipes.PipeSecurity" />.
		///       </summary>
		// Token: 0x0600198D RID: 6541 RVA: 0x0005595E File Offset: 0x00053B5E
		public PipeSecurity() : base(false, ResourceType.KernelObject)
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00055968 File Offset: 0x00053B68
		internal PipeSecurity(SafePipeHandle safeHandle, AccessControlSections includeSections) : base(false, ResourceType.KernelObject, safeHandle, includeSections)
		{
		}

		/// <summary>
		///         Добавляет правило доступа в список управления доступом на уровне пользователей (DACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Чтобы добавить правило доступа.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600198F RID: 6543 RVA: 0x00055974 File Offset: 0x00053B74
		public void AddAccessRule(PipeAccessRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			base.AddAccessRule(rule);
		}

		/// <summary>
		///         Устанавливает правила доступа в списке управления доступом на уровне пользователей (DACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Правило для установки.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001990 RID: 6544 RVA: 0x0005598B File Offset: 0x00053B8B
		public void SetAccessRule(PipeAccessRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			base.SetAccessRule(rule);
		}

		/// <summary>
		///         Удаляет все правила доступа в списке управления доступом на уровне пользователей (DACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта, а затем добавляет указанное правило доступа.
		///       </summary>
		/// <param name="rule">
		///           Чтобы добавить правило доступа.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001991 RID: 6545 RVA: 0x000559A2 File Offset: 0x00053BA2
		public void ResetAccessRule(PipeAccessRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			base.ResetAccessRule(rule);
		}

		/// <summary>
		///         Удаляет правило доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Удаляемое правило доступа.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001992 RID: 6546 RVA: 0x000559BC File Offset: 0x00053BBC
		public bool RemoveAccessRule(PipeAccessRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			AuthorizationRuleCollection accessRules = base.GetAccessRules(true, true, rule.IdentityReference.GetType());
			for (int i = 0; i < accessRules.Count; i++)
			{
				PipeAccessRule pipeAccessRule = accessRules[i] as PipeAccessRule;
				if (pipeAccessRule != null && pipeAccessRule.PipeAccessRights == rule.PipeAccessRights && pipeAccessRule.IdentityReference == rule.IdentityReference && pipeAccessRule.AccessControlType == rule.AccessControlType)
				{
					return base.RemoveAccessRule(rule);
				}
			}
			if (rule.PipeAccessRights != PipeAccessRights.FullControl)
			{
				return base.RemoveAccessRule(new PipeAccessRule(rule.IdentityReference, PipeAccessRule.AccessMaskFromRights(rule.PipeAccessRights, AccessControlType.Deny), false, rule.AccessControlType));
			}
			return base.RemoveAccessRule(rule);
		}

		/// <summary>
		///         Удаляет указанное правило доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Удаляемое правило доступа.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001993 RID: 6547 RVA: 0x00055A7C File Offset: 0x00053C7C
		public void RemoveAccessRuleSpecific(PipeAccessRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			AuthorizationRuleCollection accessRules = base.GetAccessRules(true, true, rule.IdentityReference.GetType());
			for (int i = 0; i < accessRules.Count; i++)
			{
				PipeAccessRule pipeAccessRule = accessRules[i] as PipeAccessRule;
				if (pipeAccessRule != null && pipeAccessRule.PipeAccessRights == rule.PipeAccessRights && pipeAccessRule.IdentityReference == rule.IdentityReference && pipeAccessRule.AccessControlType == rule.AccessControlType)
				{
					base.RemoveAccessRuleSpecific(rule);
					return;
				}
			}
			if (rule.PipeAccessRights != PipeAccessRights.FullControl)
			{
				base.RemoveAccessRuleSpecific(new PipeAccessRule(rule.IdentityReference, PipeAccessRule.AccessMaskFromRights(rule.PipeAccessRights, AccessControlType.Deny), false, rule.AccessControlType));
				return;
			}
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>
		///         Добавляет правило аудита для системы управления доступом список (SACL), связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Чтобы добавить правило аудита.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001994 RID: 6548 RVA: 0x00055B3C File Offset: 0x00053D3C
		public void AddAuditRule(PipeAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>
		///         Задает правила аудита в системе управления списка управления ДОСТУПОМ, связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Правило для установки.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001995 RID: 6549 RVA: 0x00055B45 File Offset: 0x00053D45
		public void SetAuditRule(PipeAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		/// <summary>
		///         Удаляет правила аудита из системного списка (Управления доступом), связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Удаляемое правило аудита.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если правило аудита удалено; в противном случае — <see langword="false" />
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001996 RID: 6550 RVA: 0x00055B4E File Offset: 0x00053D4E
		public bool RemoveAuditRule(PipeAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>
		///         Удаляет все правила аудита с тем же идентификатором безопасности, что указанного правила аудита из системного списка (Управления доступом), связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Удаляемое правило аудита.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001997 RID: 6551 RVA: 0x00055B57 File Offset: 0x00053D57
		public void RemoveAuditRuleAll(PipeAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>
		///         Удаляет указанное правило аудита из системного списка (Управления доступом), связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <param name="rule">
		///           Удаляемое правило аудита.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="rule" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06001998 RID: 6552 RVA: 0x00055B60 File Offset: 0x00053D60
		public void RemoveAuditRuleSpecific(PipeAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AccessRule" /> с использованием указанных значений.
		///       </summary>
		/// <param name="identityReference">
		///           Удостоверение, к которому применяется правило доступа.
		///            Это должен быть объект, который может быть приведено к <see cref="T:System.Security.Principal.SecurityIdentifier" /> объекта.
		///         </param>
		/// <param name="accessMask">
		///           Маска доступа этого правила.
		///            Маска доступа является коллекцией 32-разрядных битов, значение каждого из которых определяется отдельными интеграторами
		///         </param>
		/// <param name="isInherited">
		///           <see langword="true" /> Если это правило наследуется от родительского контейнера; в противном случае — значение false.
		///         </param>
		/// <param name="inheritanceFlags">
		///           Один из <see cref="T:System.Security.AccessControl.InheritanceFlags" /> значения, которые определяет свойства наследования правила доступа.
		///         </param>
		/// <param name="propagationFlags">
		///           Один из <see cref="T:System.Security.AccessControl.PropagationFlags" /> значений, определяющих возможность автоматического распространения наследуемых правил доступа.
		///            Флаги распространения не учитываются, если для <paramref name="inheritanceFlags" /> задано значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.
		///         </param>
		/// <param name="type">
		///           Указывает допустимый тип управления доступом.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Security.AccessControl.AccessRule" />, создаваемый с помощью данного метода.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, или <paramref name="type" /> задает недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="identityReference" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             <paramref name="accessMask" /> равно нулю.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="identityReference" /> не является ни тип <see cref="T:System.Security.Principal.SecurityIdentifier" /> ни типа, таких как <see cref="T:System.Security.Principal.NTAccount" />, который можно преобразовать в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.
		///           </exception>
		// Token: 0x06001999 RID: 6553 RVA: 0x00055B69 File Offset: 0x00053D69
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			if (inheritanceFlags != InheritanceFlags.None)
			{
				throw new ArgumentException("This flag may not be set on a pipe.", "inheritanceFlags");
			}
			if (propagationFlags != PropagationFlags.None)
			{
				throw new ArgumentException("This flag may not be set on a pipe.", "propagationFlags");
			}
			return new PipeAccessRule(identityReference, accessMask, isInherited, type);
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" /> с использованием указанных значений.
		///       </summary>
		/// <param name="identityReference">
		///           Удостоверение, к которому применяется правило доступа.
		///            Это должен быть объект, который может быть приведено к <see cref="T:System.Security.Principal.SecurityIdentifier" /> объекта.
		///         </param>
		/// <param name="accessMask">
		///           Маска доступа этого правила.
		///            Маска доступа является коллекцией 32-разрядных битов, значение каждого из которых определяется отдельными интеграторами
		///         </param>
		/// <param name="isInherited">
		///           <see langword="true" /> Если это правило наследуется от родительского контейнера; в противном случае — значение false.
		///         </param>
		/// <param name="inheritanceFlags">
		///           Один из <see cref="T:System.Security.AccessControl.InheritanceFlags" /> значения, которые определяет свойства наследования правила доступа.
		///         </param>
		/// <param name="propagationFlags">
		///           Один из <see cref="T:System.Security.AccessControl.PropagationFlags" /> значений, определяющих возможность автоматического распространения наследуемых правил доступа.
		///            Флаги распространения не учитываются, если для <paramref name="inheritanceFlags" /> задано значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.
		///         </param>
		/// <param name="flags">
		///           Один из <see cref="T:System.Security.AccessControl.AuditFlags" /> типа элемента управления значения, которые определяет допустимые права доступа.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Security.AccessControl.AuditRule" />, создаваемый с помощью данного метода.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" />, Или <paramref name="flags" /> свойств указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение свойства <paramref name="identityReference" /> — <see langword="null" />.
		///
		///             -или-
		///
		///             <paramref name="accessMask" /> Равно нулю.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="identityReference" /> Свойство не является ни типа <see cref="T:System.Security.Principal.SecurityIdentifier" /> ни типа, таких как <see cref="T:System.Security.Principal.NTAccount" />, может привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" />.
		///           </exception>
		// Token: 0x0600199A RID: 6554 RVA: 0x00055B9D File Offset: 0x00053D9D
		public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			if (inheritanceFlags != InheritanceFlags.None)
			{
				throw new ArgumentException("This flag may not be set on a pipe.", "inheritanceFlags");
			}
			if (propagationFlags != PropagationFlags.None)
			{
				throw new ArgumentException("This flag may not be set on a pipe.", "propagationFlags");
			}
			return new PipeAuditRule(identityReference, accessMask, isInherited, flags);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00055BD4 File Offset: 0x00053DD4
		private AccessControlSections GetAccessControlSectionsFromChanges()
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

		/// <summary>
		///         Сохраняет указанные разделы дескриптора безопасности, связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объект в постоянное хранилище.
		///       </summary>
		/// <param name="handle">
		///           Дескриптор защищаемого объекта, объекта, текущий <see cref="T:System.IO.Pipes.PipeSecurity" /> объект, связанный с.
		///         </param>
		// Token: 0x0600199C RID: 6556 RVA: 0x00055C14 File Offset: 0x00053E14
		protected internal void Persist(SafeHandle handle)
		{
			base.WriteLock();
			try
			{
				AccessControlSections accessControlSectionsFromChanges = this.GetAccessControlSectionsFromChanges();
				base.Persist(handle, accessControlSectionsFromChanges);
				base.OwnerModified = (base.GroupModified = (base.AuditRulesModified = (base.AccessRulesModified = false)));
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>
		///         Сохраняет указанные разделы дескриптора безопасности, связанный с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объект в постоянное хранилище.
		///       </summary>
		/// <param name="name">
		///           Имя защищаемого объекта, текущий <see cref="T:System.IO.Pipes.PipeSecurity" /> объект, связанный с.
		///         </param>
		// Token: 0x0600199D RID: 6557 RVA: 0x00055C74 File Offset: 0x00053E74
		protected internal void Persist(string name)
		{
			base.WriteLock();
			try
			{
				AccessControlSections accessControlSectionsFromChanges = this.GetAccessControlSectionsFromChanges();
				base.Persist(name, accessControlSectionsFromChanges);
				base.OwnerModified = (base.GroupModified = (base.AuditRulesModified = (base.AccessRulesModified = false)));
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Type" /> защищаемого объекта, связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <returns>
		///         Тип защищаемого объекта, связанного с текущим <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </returns>
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00055CD4 File Offset: 0x00053ED4
		public override Type AccessRightType
		{
			get
			{
				return typeof(PipeAccessRights);
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Type" /> объекта, связанного с правилами доступа текущего <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <returns>
		///         Тип объекта, связанного с правилами доступа текущего <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </returns>
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x00055CE0 File Offset: 0x00053EE0
		public override Type AccessRuleType
		{
			get
			{
				return typeof(PipeAccessRule);
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Type" /> объекта, связанного с правилами аудита текущего <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </summary>
		/// <returns>
		///         Тип объекта, связанного с правилами аудита текущего <see cref="T:System.IO.Pipes.PipeSecurity" /> объекта.
		///       </returns>
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00055CEC File Offset: 0x00053EEC
		public override Type AuditRuleType
		{
			get
			{
				return typeof(PipeAuditRule);
			}
		}
	}
}
