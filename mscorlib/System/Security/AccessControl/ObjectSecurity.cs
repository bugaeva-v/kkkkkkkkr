using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

namespace System.Security.AccessControl
{
	/// <summary>Предоставляет возможность управления доступом к объектам без непосредственной работы со списками управления доступом (ACL). Этот класс является абстрактным базовым классом для классов <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> и <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" />.</summary>
	// Token: 0x02000541 RID: 1345
	public abstract class ObjectSecurity
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		// Token: 0x06003509 RID: 13577 RVA: 0x0000259F File Offset: 0x0000079F
		protected ObjectSecurity()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="securityDescriptor">Объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> нового экземпляра <see cref="T:System.Security.AccessControl.CommonObjectSecurity" />.</param>
		// Token: 0x0600350A RID: 13578 RVA: 0x000C0590 File Offset: 0x000BE790
		protected ObjectSecurity(CommonSecurityDescriptor securityDescriptor)
		{
			if (securityDescriptor == null)
			{
				throw new ArgumentNullException("securityDescriptor");
			}
			this.descriptor = securityDescriptor;
			this.rw_lock = new ReaderWriterLock();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="isDS">Значение true, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> является объектом каталога.</param>
		// Token: 0x0600350B RID: 13579 RVA: 0x000C05B8 File Offset: 0x000BE7B8
		protected ObjectSecurity(bool isContainer, bool isDS) : this(new CommonSecurityDescriptor(isContainer, isDS, ControlFlags.None, null, null, null, new DiscretionaryAcl(isContainer, isDS, 0)))
		{
		}

		/// <summary>Возвращает <see cref="T:System.Type" /> защищаемого объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Тип защищаемого объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</returns>
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600350C RID: 13580
		public abstract Type AccessRightType { get; }

		/// <summary>Получает <see cref="T:System.Type" /> объекта, связанного с правилами доступа этого объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" />. Объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> должен быть объектом, который может быть приведен как объект <see cref="T:System.Type" />.</summary>
		/// <returns>Тип объекта, связанного с правилами доступа этого <see cref="T:System.Security.AccessControl.ObjectSecurity" /> объекта.</returns>
		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600350D RID: 13581
		public abstract Type AccessRuleType { get; }

		/// <summary>Получает объект <see cref="T:System.Type" />, связанный с правилами аудита этого объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" />. Объект <see cref="T:System.Type" /> должен быть объектом, который может быть приведен как объект <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <returns>Тип объекта, связанного с правилами аудита этого объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</returns>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600350E RID: 13582
		public abstract Type AuditRuleType { get; }

		/// <summary>Возвращает логическое значение, которое указывает, расположены ли правила доступа, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, в каноническом порядке.</summary>
		/// <returns>Значение <see langword="true" />, если правила доступа следуют в каноническом порядке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x000C05E0 File Offset: 0x000BE7E0
		public bool AreAccessRulesCanonical
		{
			get
			{
				this.ReadLock();
				bool isDiscretionaryAclCanonical;
				try
				{
					isDiscretionaryAclCanonical = this.descriptor.IsDiscretionaryAclCanonical;
				}
				finally
				{
					this.ReadUnlock();
				}
				return isDiscretionaryAclCanonical;
			}
		}

		/// <summary>Возвращает логическое значение, указывающее, защищен ли список разграничительного управления доступа (DACL), связанный с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Значение <see langword="true" />, если список DACL защищен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000C061C File Offset: 0x000BE81C
		public bool AreAccessRulesProtected
		{
			get
			{
				this.ReadLock();
				bool result;
				try
				{
					result = ((this.descriptor.ControlFlags & ControlFlags.DiscretionaryAclProtected) > ControlFlags.None);
				}
				finally
				{
					this.ReadUnlock();
				}
				return result;
			}
		}

		/// <summary>Возвращает логическое значение, которое указывает, расположены ли правила аудита, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, в каноническом порядке.</summary>
		/// <returns>Значение <see langword="true" />, если правила аудита следуют в каноническом порядке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000C0660 File Offset: 0x000BE860
		public bool AreAuditRulesCanonical
		{
			get
			{
				this.ReadLock();
				bool isSystemAclCanonical;
				try
				{
					isSystemAclCanonical = this.descriptor.IsSystemAclCanonical;
				}
				finally
				{
					this.ReadUnlock();
				}
				return isSystemAclCanonical;
			}
		}

		/// <summary>Возвращает логическое значение, указывающее, защищен ли системный список управления доступом (SACL), связанный с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Значение <see langword="true" />, если список SACL защищен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x000C069C File Offset: 0x000BE89C
		public bool AreAuditRulesProtected
		{
			get
			{
				this.ReadLock();
				bool result;
				try
				{
					result = ((this.descriptor.ControlFlags & ControlFlags.SystemAclProtected) > ControlFlags.None);
				}
				finally
				{
					this.ReadUnlock();
				}
				return result;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x000C06E0 File Offset: 0x000BE8E0
		// (set) Token: 0x06003514 RID: 13588 RVA: 0x000C06EE File Offset: 0x000BE8EE
		internal AccessControlSections AccessControlSectionsModified
		{
			get
			{
				this.Reading();
				return this.sections_modified;
			}
			set
			{
				this.Writing();
				this.sections_modified = value;
			}
		}

		/// <summary>Получает или задает логическое значение, которое указывает, изменены ли правила доступа, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Значение <see langword="true" />, если правила доступа, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, изменены; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x000C06FD File Offset: 0x000BE8FD
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x000C0706 File Offset: 0x000BE906
		protected bool AccessRulesModified
		{
			get
			{
				return this.AreAccessControlSectionsModified(AccessControlSections.Access);
			}
			set
			{
				this.SetAccessControlSectionsModified(AccessControlSections.Access, value);
			}
		}

		/// <summary>Получает или задает логическое значение, которое указывает, изменены ли правила аудита, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Значение <see langword="true" />, если правила аудита, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, изменены; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x000C0710 File Offset: 0x000BE910
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x000C0719 File Offset: 0x000BE919
		protected bool AuditRulesModified
		{
			get
			{
				return this.AreAccessControlSectionsModified(AccessControlSections.Audit);
			}
			set
			{
				this.SetAccessControlSectionsModified(AccessControlSections.Audit, value);
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, была ли изменена группа, связанная с защищаемым объектом.</summary>
		/// <returns>Значение <see langword="true" />, если группа, связанная с защищаемым объектом, была изменена. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x000C0723 File Offset: 0x000BE923
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x000C072C File Offset: 0x000BE92C
		protected bool GroupModified
		{
			get
			{
				return this.AreAccessControlSectionsModified(AccessControlSections.Group);
			}
			set
			{
				this.SetAccessControlSectionsModified(AccessControlSections.Group, value);
			}
		}

		/// <summary>Получает логическое значение, которое указывает, является ли данный объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> контейнером.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> является контейнером; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x000C0736 File Offset: 0x000BE936
		protected bool IsContainer
		{
			get
			{
				return this.descriptor.IsContainer;
			}
		}

		/// <summary>Получает логическое значение, указывающее, является ли этот объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> объектом каталога.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> является объектом каталога; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x000C0743 File Offset: 0x000BE943
		protected bool IsDS
		{
			get
			{
				return this.descriptor.IsDS;
			}
		}

		/// <summary>Получает или задает логическое значение, указывающее, был ли изменен владелец защищаемого объекта.</summary>
		/// <returns>Значение <see langword="true" />, если владелец защищаемого объекта был изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000C0750 File Offset: 0x000BE950
		// (set) Token: 0x0600351E RID: 13598 RVA: 0x000C0759 File Offset: 0x000BE959
		protected bool OwnerModified
		{
			get
			{
				return this.AreAccessControlSectionsModified(AccessControlSections.Owner);
			}
			set
			{
				this.SetAccessControlSectionsModified(AccessControlSections.Owner, value);
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
		// Token: 0x0600351F RID: 13599
		public abstract AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" /> с использованием указанных значений.</summary>
		/// <param name="identityReference">Удостоверение, к которому применяется правило аудита.  Это должен быть объект, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил аудита. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="flags">Указывает условия, в которых выполняется аудит правила.</param>
		/// <returns>Объект <see cref="T:System.Security.AccessControl.AuditRule" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x06003520 RID: 13600
		public abstract AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);

		/// <summary>Получает основную группу, связанную с указанным владельцем.</summary>
		/// <param name="targetType">Владелец, для которого требуется получить основную группу.</param>
		/// <returns>Основная группа, связанная с указанным владельцем.</returns>
		// Token: 0x06003521 RID: 13601 RVA: 0x000C0764 File Offset: 0x000BE964
		public IdentityReference GetGroup(Type targetType)
		{
			this.ReadLock();
			IdentityReference result;
			try
			{
				if (this.descriptor.Group == null)
				{
					result = null;
				}
				else
				{
					result = this.descriptor.Group.Translate(targetType);
				}
			}
			finally
			{
				this.ReadUnlock();
			}
			return result;
		}

		/// <summary>Возвращает владельца, связанного с указанной основной группой.</summary>
		/// <param name="targetType">Основная группа, для которой требуется получить владельца.</param>
		/// <returns>Владелец, связанный с указанной группой.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="targetType" /> не является типом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.Security.Principal.IdentityNotMappedException">Некоторые или ссылки на свойства нельзя преобразовать.</exception>
		/// <exception cref="T:System.SystemException">Возвращен код ошибки Win32.</exception>
		// Token: 0x06003522 RID: 13602 RVA: 0x000C07BC File Offset: 0x000BE9BC
		public IdentityReference GetOwner(Type targetType)
		{
			this.ReadLock();
			IdentityReference result;
			try
			{
				if (this.descriptor.Owner == null)
				{
					result = null;
				}
				else
				{
					result = this.descriptor.Owner.Translate(targetType);
				}
			}
			finally
			{
				this.ReadUnlock();
			}
			return result;
		}

		/// <summary>Возвращает массив значений байтов, представляющих данные дескриптора безопасности для этого объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <returns>Массив значений байтов, представляющих дескриптор безопасности для этого объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" />. Этот метод возвращает <see langword="null" />, если отсутствуют сведения о безопасности в этом объекте <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</returns>
		// Token: 0x06003523 RID: 13603 RVA: 0x000C0814 File Offset: 0x000BEA14
		public byte[] GetSecurityDescriptorBinaryForm()
		{
			this.ReadLock();
			byte[] result;
			try
			{
				byte[] array = new byte[this.descriptor.BinaryLength];
				this.descriptor.GetBinaryForm(array, 0);
				result = array;
			}
			finally
			{
				this.ReadUnlock();
			}
			return result;
		}

		/// <summary>Возвращает представление на языке определения дескриптора безопасности (SDDL) указанных разделов дескриптора безопасности, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="includeSections">Указывает, какие следует получить разделы дескриптора безопасности (правила доступа, правила аудита, основная группа, владелец).</param>
		/// <returns>Представление на языке SDDL указанных разделов дескриптора безопасности, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</returns>
		// Token: 0x06003524 RID: 13604 RVA: 0x000C0864 File Offset: 0x000BEA64
		public string GetSecurityDescriptorSddlForm(AccessControlSections includeSections)
		{
			this.ReadLock();
			string sddlForm;
			try
			{
				sddlForm = this.descriptor.GetSddlForm(includeSections);
			}
			finally
			{
				this.ReadUnlock();
			}
			return sddlForm;
		}

		/// <summary>Возвращает логическое значение, указывающее, может ли дескриптор безопасности, связанный с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, быть преобразован в формат языка определения дескрипторов безопасности (SDDL).</summary>
		/// <returns>Значение <see langword="true" />, если дескриптор безопасности, связанный с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, может быть преобразован в формат языка определения дескрипторов безопасности (SDDL). В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003525 RID: 13605 RVA: 0x000C08A0 File Offset: 0x000BEAA0
		public static bool IsSddlConversionSupported()
		{
			return GenericSecurityDescriptor.IsSddlConversionSupported();
		}

		/// <summary>Применяет указанное изменение к списку управления доступом на уровне пользователей (DACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку DACL.</param>
		/// <param name="rule">Изменяемое правило доступа.</param>
		/// <param name="modified">Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003526 RID: 13606 RVA: 0x000C08A7 File Offset: 0x000BEAA7
		public virtual bool ModifyAccessRule(AccessControlModification modification, AccessRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			if (!this.AccessRuleType.IsAssignableFrom(rule.GetType()))
			{
				throw new ArgumentException("rule");
			}
			return this.ModifyAccess(modification, rule, out modified);
		}

		/// <summary>Применяет указанное изменение к системному списку управления доступом (SACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку SACL.</param>
		/// <param name="rule">Правило аудита, которое нужно изменить.</param>
		/// <param name="modified">Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003527 RID: 13607 RVA: 0x000C08DE File Offset: 0x000BEADE
		public virtual bool ModifyAuditRule(AccessControlModification modification, AuditRule rule, out bool modified)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			if (!this.AuditRuleType.IsAssignableFrom(rule.GetType()))
			{
				throw new ArgumentException("rule");
			}
			return this.ModifyAudit(modification, rule, out modified);
		}

		/// <summary>Удаляет все правила доступа, связанные с указанным объектом <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" />, для которого требуется удалить все правила доступа.</param>
		/// <exception cref="T:System.InvalidOperationException">Все правила доступа указаны не в каноническом порядке.</exception>
		// Token: 0x06003528 RID: 13608 RVA: 0x000C0918 File Offset: 0x000BEB18
		public virtual void PurgeAccessRules(IdentityReference identity)
		{
			if (null == identity)
			{
				throw new ArgumentNullException("identity");
			}
			this.WriteLock();
			try
			{
				this.descriptor.PurgeAccessControl(ObjectSecurity.SidFromIR(identity));
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Удаляет все правила, связанные с заданным <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="identity">
		///   <see cref="T:System.Security.Principal.IdentityReference" />, для которого необходимо удалить все правила аудита.</param>
		/// <exception cref="T:System.InvalidOperationException">Все правила аудита указаны не в каноническом порядке.</exception>
		// Token: 0x06003529 RID: 13609 RVA: 0x000C096C File Offset: 0x000BEB6C
		public virtual void PurgeAuditRules(IdentityReference identity)
		{
			if (null == identity)
			{
				throw new ArgumentNullException("identity");
			}
			this.WriteLock();
			try
			{
				this.descriptor.PurgeAudit(ObjectSecurity.SidFromIR(identity));
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Задает или удаляет защиту правил доступа, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />. Защищенные правила доступа не могут изменяться родительскими объектами через наследование.</summary>
		/// <param name="isProtected">
		///   <see langword="true" /> — для защиты правил доступа, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, от наследования; <see langword="false" /> — для разрешения наследования.</param>
		/// <param name="preserveInheritance">
		///   <see langword="true" /> — для сохранения наследуемых правил доступа; <see langword="false" /> — для удаления наследуемых правил доступа. Этот параметр не учитывается, если <paramref name="isProtected" /> является <see langword="false" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Этот метод пытается удалить наследуемые правила из неканонического списка управления доступом на уровне пользователей (DACL).</exception>
		// Token: 0x0600352A RID: 13610 RVA: 0x000C09C0 File Offset: 0x000BEBC0
		public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance)
		{
			this.WriteLock();
			try
			{
				this.descriptor.SetDiscretionaryAclProtection(isProtected, preserveInheritance);
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Задает или удаляет защиту правил аудита, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />. Защищенные правила аудита не могут изменяться родительскими объектами через наследование.</summary>
		/// <param name="isProtected">
		///   <see langword="true" /> — для защиты правил аудита, связанных с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, от наследования; <see langword="false" /> — для разрешения наследования.</param>
		/// <param name="preserveInheritance">
		///   <see langword="true" /> — для сохранения наследуемых правил аудита; <see langword="false" /> — для удаления наследуемых правил аудита. Этот параметр не учитывается, если <paramref name="isProtected" /> является <see langword="false" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Этот метод пытается удалить наследуемые правила из неканонического системного списка управления доступом (SACL).</exception>
		// Token: 0x0600352B RID: 13611 RVA: 0x000C09FC File Offset: 0x000BEBFC
		public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance)
		{
			this.WriteLock();
			try
			{
				this.descriptor.SetSystemAclProtection(isProtected, preserveInheritance);
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Задает основную группу для дескриптора безопасности, связанного с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="identity">Основная группа, которую необходимо задать.</param>
		// Token: 0x0600352C RID: 13612 RVA: 0x000C0A38 File Offset: 0x000BEC38
		public void SetGroup(IdentityReference identity)
		{
			this.WriteLock();
			try
			{
				this.descriptor.Group = ObjectSecurity.SidFromIR(identity);
				this.GroupModified = true;
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Задает владельца для дескриптора безопасности, связанного с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="identity">Задаваемый владелец.</param>
		// Token: 0x0600352D RID: 13613 RVA: 0x000C0A7C File Offset: 0x000BEC7C
		public void SetOwner(IdentityReference identity)
		{
			this.WriteLock();
			try
			{
				this.descriptor.Owner = ObjectSecurity.SidFromIR(identity);
				this.OwnerModified = true;
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Задает дескриптор безопасности для данного объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" /> из указанного массива байтовых значений.</summary>
		/// <param name="binaryForm">Массив байтов, из которого задается дескриптор безопасности.</param>
		// Token: 0x0600352E RID: 13614 RVA: 0x000C0AC0 File Offset: 0x000BECC0
		public void SetSecurityDescriptorBinaryForm(byte[] binaryForm)
		{
			this.SetSecurityDescriptorBinaryForm(binaryForm, AccessControlSections.All);
		}

		/// <summary>Задает указанные разделы дескриптора безопасности для данного объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" /> из указанного массива байтовых значений.</summary>
		/// <param name="binaryForm">Массив байтов, из которого задается дескриптор безопасности.</param>
		/// <param name="includeSections">Задаваемые разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа).</param>
		// Token: 0x0600352F RID: 13615 RVA: 0x000C0ACB File Offset: 0x000BECCB
		public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections)
		{
			this.CopySddlForm(new CommonSecurityDescriptor(this.IsContainer, this.IsDS, binaryForm, 0), includeSections);
		}

		/// <summary>Задает дескриптор безопасности для данного объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" /> из указанной строки языка определения дескрипторов безопасности (SDDL).</summary>
		/// <param name="sddlForm">Строка SDDL, из которой задается дескриптор безопасности.</param>
		// Token: 0x06003530 RID: 13616 RVA: 0x000C0AE7 File Offset: 0x000BECE7
		public void SetSecurityDescriptorSddlForm(string sddlForm)
		{
			this.SetSecurityDescriptorSddlForm(sddlForm, AccessControlSections.All);
		}

		/// <summary>Задает указанные разделы дескриптора безопасности для данного объекта <see cref="T:System.Security.AccessControl.ObjectSecurity" /> из указанной строки языка определения дескрипторов безопасности (SDDL).</summary>
		/// <param name="sddlForm">Строка SDDL, из которой задается дескриптор безопасности.</param>
		/// <param name="includeSections">Задаваемые разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа).</param>
		// Token: 0x06003531 RID: 13617 RVA: 0x000C0AF2 File Offset: 0x000BECF2
		public void SetSecurityDescriptorSddlForm(string sddlForm, AccessControlSections includeSections)
		{
			this.CopySddlForm(new CommonSecurityDescriptor(this.IsContainer, this.IsDS, sddlForm), includeSections);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000C0B10 File Offset: 0x000BED10
		private void CopySddlForm(CommonSecurityDescriptor sourceDescriptor, AccessControlSections includeSections)
		{
			this.WriteLock();
			try
			{
				this.AccessControlSectionsModified |= includeSections;
				if ((includeSections & AccessControlSections.Audit) != AccessControlSections.None)
				{
					this.descriptor.SystemAcl = sourceDescriptor.SystemAcl;
				}
				if ((includeSections & AccessControlSections.Access) != AccessControlSections.None)
				{
					this.descriptor.DiscretionaryAcl = sourceDescriptor.DiscretionaryAcl;
				}
				if ((includeSections & AccessControlSections.Owner) != AccessControlSections.None)
				{
					this.descriptor.Owner = sourceDescriptor.Owner;
				}
				if ((includeSections & AccessControlSections.Group) != AccessControlSections.None)
				{
					this.descriptor.Group = sourceDescriptor.Group;
				}
			}
			finally
			{
				this.WriteUnlock();
			}
		}

		/// <summary>Применяет указанное изменение к списку управления доступом на уровне пользователей (DACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку DACL.</param>
		/// <param name="rule">Изменяемое правило доступа.</param>
		/// <param name="modified">Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список DACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003533 RID: 13619
		protected abstract bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);

		/// <summary>Применяет указанное изменение к системному списку управления доступом (SACL), связанному с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />.</summary>
		/// <param name="modification">Изменение, применяемое к списку SACL.</param>
		/// <param name="rule">Правило аудита, которое нужно изменить.</param>
		/// <param name="modified">Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если список SACL успешно изменен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003534 RID: 13620
		protected abstract bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified);

		// Token: 0x06003535 RID: 13621 RVA: 0x0004D851 File Offset: 0x0004BA51
		private Exception GetNotImplementedException()
		{
			return new NotImplementedException();
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="handle">Дескриптор, используемый для получения хранимой информации.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		// Token: 0x06003536 RID: 13622 RVA: 0x000C0BA4 File Offset: 0x000BEDA4
		protected virtual void Persist(SafeHandle handle, AccessControlSections includeSections)
		{
			throw this.GetNotImplementedException();
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="name">Имя, используемое для получения хранимой информации.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		// Token: 0x06003537 RID: 13623 RVA: 0x000C0BA4 File Offset: 0x000BEDA4
		protected virtual void Persist(string name, AccessControlSections includeSections)
		{
			throw this.GetNotImplementedException();
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.ObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="enableOwnershipPrivilege">Значение <see langword="true" />, чтобы включить привилегию, позволяющую вызывающему объекту стать владельцем объекта.</param>
		/// <param name="name">Имя, используемое для получения хранимой информации.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		// Token: 0x06003538 RID: 13624 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		[HandleProcessCorruptedStateExceptions]
		protected virtual void Persist(bool enableOwnershipPrivilege, string name, AccessControlSections includeSections)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x000C0BAC File Offset: 0x000BEDAC
		private void Reading()
		{
			if (!this.rw_lock.IsReaderLockHeld && !this.rw_lock.IsWriterLockHeld)
			{
				throw new InvalidOperationException("Either a read or a write lock must be held.");
			}
		}

		/// <summary>Блокирует этот объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> для доступа для чтения.</summary>
		// Token: 0x0600353A RID: 13626 RVA: 0x000C0BD3 File Offset: 0x000BEDD3
		protected void ReadLock()
		{
			this.rw_lock.AcquireReaderLock(-1);
		}

		/// <summary>Разблокирует этот объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> для доступа для чтения.</summary>
		// Token: 0x0600353B RID: 13627 RVA: 0x000C0BE1 File Offset: 0x000BEDE1
		protected void ReadUnlock()
		{
			this.rw_lock.ReleaseReaderLock();
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000C0BEE File Offset: 0x000BEDEE
		private void Writing()
		{
			if (!this.rw_lock.IsWriterLockHeld)
			{
				throw new InvalidOperationException("Write lock must be held.");
			}
		}

		/// <summary>Блокирует доступ к этому объекту <see cref="T:System.Security.AccessControl.ObjectSecurity" /> для записи.</summary>
		// Token: 0x0600353D RID: 13629 RVA: 0x000C0C08 File Offset: 0x000BEE08
		protected void WriteLock()
		{
			this.rw_lock.AcquireWriterLock(-1);
		}

		/// <summary>Разблокирует этот объект <see cref="T:System.Security.AccessControl.ObjectSecurity" /> для доступа для записи.</summary>
		// Token: 0x0600353E RID: 13630 RVA: 0x000C0C16 File Offset: 0x000BEE16
		protected void WriteUnlock()
		{
			this.rw_lock.ReleaseWriterLock();
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000C0C24 File Offset: 0x000BEE24
		internal AuthorizationRuleCollection InternalGetAccessRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			List<AuthorizationRule> list = new List<AuthorizationRule>();
			this.ReadLock();
			try
			{
				foreach (GenericAce genericAce in this.descriptor.DiscretionaryAcl)
				{
					QualifiedAce qualifiedAce = genericAce as QualifiedAce;
					if (!(null == qualifiedAce) && (!qualifiedAce.IsInherited || includeInherited) && (qualifiedAce.IsInherited || includeExplicit))
					{
						AccessControlType type;
						if (qualifiedAce.AceQualifier == AceQualifier.AccessAllowed)
						{
							type = AccessControlType.Allow;
						}
						else
						{
							if (AceQualifier.AccessDenied != qualifiedAce.AceQualifier)
							{
								continue;
							}
							type = AccessControlType.Deny;
						}
						AccessRule item = this.InternalAccessRuleFactory(qualifiedAce, targetType, type);
						list.Add(item);
					}
				}
			}
			finally
			{
				this.ReadUnlock();
			}
			return new AuthorizationRuleCollection(list.ToArray());
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000C0CD4 File Offset: 0x000BEED4
		internal virtual AccessRule InternalAccessRuleFactory(QualifiedAce ace, Type targetType, AccessControlType type)
		{
			return this.AccessRuleFactory(ace.SecurityIdentifier.Translate(targetType), ace.AccessMask, ace.IsInherited, ace.InheritanceFlags, ace.PropagationFlags, type);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000C0D04 File Offset: 0x000BEF04
		internal AuthorizationRuleCollection InternalGetAuditRules(bool includeExplicit, bool includeInherited, Type targetType)
		{
			List<AuthorizationRule> list = new List<AuthorizationRule>();
			this.ReadLock();
			try
			{
				if (this.descriptor.SystemAcl != null)
				{
					foreach (GenericAce genericAce in this.descriptor.SystemAcl)
					{
						QualifiedAce qualifiedAce = genericAce as QualifiedAce;
						if (!(null == qualifiedAce) && (!qualifiedAce.IsInherited || includeInherited) && (qualifiedAce.IsInherited || includeExplicit) && AceQualifier.SystemAudit == qualifiedAce.AceQualifier)
						{
							AuditRule item = this.InternalAuditRuleFactory(qualifiedAce, targetType);
							list.Add(item);
						}
					}
				}
			}
			finally
			{
				this.ReadUnlock();
			}
			return new AuthorizationRuleCollection(list.ToArray());
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x000C0DB0 File Offset: 0x000BEFB0
		internal virtual AuditRule InternalAuditRuleFactory(QualifiedAce ace, Type targetType)
		{
			return this.AuditRuleFactory(ace.SecurityIdentifier.Translate(targetType), ace.AccessMask, ace.IsInherited, ace.InheritanceFlags, ace.PropagationFlags, ace.AuditFlags);
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x000C0DE2 File Offset: 0x000BEFE2
		internal static SecurityIdentifier SidFromIR(IdentityReference identity)
		{
			if (null == identity)
			{
				throw new ArgumentNullException("identity");
			}
			return (SecurityIdentifier)identity.Translate(typeof(SecurityIdentifier));
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x000C0E0D File Offset: 0x000BF00D
		private bool AreAccessControlSectionsModified(AccessControlSections mask)
		{
			return (this.AccessControlSectionsModified & mask) > AccessControlSections.None;
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x000C0E1A File Offset: 0x000BF01A
		private void SetAccessControlSectionsModified(AccessControlSections mask, bool modified)
		{
			if (modified)
			{
				this.AccessControlSectionsModified |= mask;
				return;
			}
			this.AccessControlSectionsModified &= ~mask;
		}

		// Token: 0x040024CD RID: 9421
		internal CommonSecurityDescriptor descriptor;

		// Token: 0x040024CE RID: 9422
		private AccessControlSections sections_modified;

		// Token: 0x040024CF RID: 9423
		private ReaderWriterLock rw_lock;
	}
}
