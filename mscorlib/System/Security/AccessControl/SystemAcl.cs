using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет системный список управления доступом.</summary>
	// Token: 0x0200054B RID: 1355
	public sealed class SystemAcl : CommonAcl
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SystemAcl" /> с использованием указанных значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="capacity">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.SystemAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x06003594 RID: 13716 RVA: 0x000BE764 File Offset: 0x000BC964
		public SystemAcl(bool isContainer, bool isDS, int capacity) : base(isContainer, isDS, capacity)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SystemAcl" /> с указанными значениями из указанного объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="rawAcl">Базовый объект <see cref="T:System.Security.AccessControl.RawAcl" />, соответствующий новому объекту <see cref="T:System.Security.AccessControl.SystemAcl" />. Чтобы создать пустой список управления доступом, укажите значение <see langword="null" />.</param>
		// Token: 0x06003595 RID: 13717 RVA: 0x000BE76F File Offset: 0x000BC96F
		public SystemAcl(bool isContainer, bool isDS, RawAcl rawAcl) : base(isContainer, isDS, rawAcl)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.SystemAcl" /> с использованием указанных значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.SystemAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="revision">Номер редакции нового объекта <see cref="T:System.Security.AccessControl.SystemAcl" />.</param>
		/// <param name="capacity">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.SystemAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x06003596 RID: 13718 RVA: 0x000BE77A File Offset: 0x000BC97A
		public SystemAcl(bool isContainer, bool isDS, byte revision, int capacity) : base(isContainer, isDS, revision, capacity)
		{
		}

		/// <summary>Добавляет правило аудита к текущему объекту <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
		/// <param name="auditFlags">Тип добавляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для нового правила аудита.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового правила аудита.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового правила аудита.</param>
		// Token: 0x06003597 RID: 13719 RVA: 0x000C1D62 File Offset: 0x000BFF62
		public void AddAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.AddAce(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
		}

		/// <summary>Добавляет правило аудита с указанными параметрами к текущему объекту <see cref="T:System.Security.AccessControl.SystemAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта для нового правила аудита.</summary>
		/// <param name="auditFlags">Тип добавляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для нового правила аудита.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового правила аудита.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового правила аудита.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новое правило аудита.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новое правило аудита.</param>
		// Token: 0x06003598 RID: 13720 RVA: 0x000C1D74 File Offset: 0x000BFF74
		public void AddAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.AddAce(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Добавляет правило аудита к текущему объекту <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется правило аудита.</param>
		/// <param name="rule">
		///   <see cref="T:System.Security.AccessControl.ObjectAuditRule" /> для нового правила аудита.</param>
		// Token: 0x06003599 RID: 13721 RVA: 0x000C1D98 File Offset: 0x000BFF98
		public void AddAudit(SecurityIdentifier sid, ObjectAuditRule rule)
		{
			this.AddAudit(rule.AuditFlags, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
		/// <param name="auditFlags">Тип удаляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно удаляет указанное правило аудита; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600359A RID: 13722 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public bool RemoveAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.SystemAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта.</summary>
		/// <param name="auditFlags">Тип удаляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется удаляемое правило аудита.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать удаляемое правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно удаляет указанное правило аудита; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600359B RID: 13723 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public bool RemoveAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.ObjectAuditRule" />, для которого удаляется правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно удаляет указанное правило аудита; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600359C RID: 13724 RVA: 0x000C1DD8 File Offset: 0x000BFFD8
		public bool RemoveAudit(SecurityIdentifier sid, ObjectAuditRule rule)
		{
			return this.RemoveAudit(rule.AuditFlags, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="auditFlags">Тип удаляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила.</param>
		// Token: 0x0600359D RID: 13725 RVA: 0x000C1E16 File Offset: 0x000C0016
		public void RemoveAuditSpecific(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.RemoveAceSpecific(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта.</summary>
		/// <param name="auditFlags">Тип удаляемого правила аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется удаляемое правило аудита.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать удаляемое правило аудита.</param>
		// Token: 0x0600359E RID: 13726 RVA: 0x000C1E28 File Offset: 0x000C0028
		public void RemoveAuditSpecific(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.RemoveAceSpecific(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Удаляет указанное правило аудита из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило аудита.</param>
		/// <param name="rule">
		///   <see cref="T:System.Security.AccessControl.ObjectAuditRule" /> для удаляемого правила.</param>
		// Token: 0x0600359F RID: 13727 RVA: 0x000C1E4C File Offset: 0x000C004C
		public void RemoveAuditSpecific(SecurityIdentifier sid, ObjectAuditRule rule)
		{
			this.RemoveAuditSpecific(rule.AuditFlags, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Устанавливает указанное правило аудита для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="auditFlags">Устанавливаемое условие аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого устанавливается правило аудита.</param>
		/// <param name="accessMask">Маска доступа для нового правила аудита.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового правила аудита.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового правила аудита.</param>
		// Token: 0x060035A0 RID: 13728 RVA: 0x000C1E8A File Offset: 0x000C008A
		public void SetAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.SetAce(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
		}

		/// <summary>Устанавливает указанное правило аудита для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта.</summary>
		/// <param name="auditFlags">Устанавливаемое условие аудита.</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого устанавливается правило аудита.</param>
		/// <param name="accessMask">Маска доступа для нового правила аудита.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового правила аудита.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового правила аудита.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новое правило аудита.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новое правило аудита.</param>
		// Token: 0x060035A1 RID: 13729 RVA: 0x000C1E9C File Offset: 0x000C009C
		public void SetAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.SetAce(AceQualifier.SystemAudit, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Устанавливает указанное правило аудита для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого устанавливается правило аудита.</param>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.ObjectAuditRule" />, для которого устанавливается правило аудита.</param>
		// Token: 0x060035A2 RID: 13730 RVA: 0x000C1EC0 File Offset: 0x000C00C0
		public void SetAudit(SecurityIdentifier sid, ObjectAuditRule rule)
		{
			this.SetAudit(rule.AuditFlags, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x000C1F00 File Offset: 0x000C0100
		internal override void ApplyCanonicalSortToExplicitAces()
		{
			int canonicalExplicitAceCount = base.GetCanonicalExplicitAceCount();
			base.ApplyCanonicalSortToExplicitAces(0, canonicalExplicitAceCount);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		internal override int GetAceInsertPosition(AceQualifier aceQualifier)
		{
			return 0;
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000C1F1C File Offset: 0x000C011C
		internal override bool IsAceMeaningless(GenericAce ace)
		{
			if (base.IsAceMeaningless(ace))
			{
				return true;
			}
			if (!SystemAcl.IsValidAuditFlags(ace.AuditFlags))
			{
				return true;
			}
			QualifiedAce qualifiedAce = ace as QualifiedAce;
			return null != qualifiedAce && AceQualifier.SystemAudit != qualifiedAce.AceQualifier && AceQualifier.SystemAlarm != qualifiedAce.AceQualifier;
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x000C1F68 File Offset: 0x000C0168
		private static bool IsValidAuditFlags(AuditFlags auditFlags)
		{
			return auditFlags != AuditFlags.None && auditFlags == ((AuditFlags.Success | AuditFlags.Failure) & auditFlags);
		}
	}
}
