using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет список управления доступом на уровне пользователей.</summary>
	// Token: 0x02000522 RID: 1314
	public sealed class DiscretionaryAcl : CommonAcl
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> с использованием указанных значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="capacity">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x0600340B RID: 13323 RVA: 0x000BE764 File Offset: 0x000BC964
		public DiscretionaryAcl(bool isContainer, bool isDS, int capacity) : base(isContainer, isDS, capacity)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> с указанными значениями из указанного объекта <see cref="T:System.Security.AccessControl.RawAcl" />.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="rawAcl">Базовый объект <see cref="T:System.Security.AccessControl.RawAcl" />, соответствующий новому объекту <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Чтобы создать пустой список управления доступом, укажите значение <see langword="null" />.</param>
		// Token: 0x0600340C RID: 13324 RVA: 0x000BE76F File Offset: 0x000BC96F
		public DiscretionaryAcl(bool isContainer, bool isDS, RawAcl rawAcl) : base(isContainer, isDS, rawAcl)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> с использованием указанных значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> является объектом каталога списка управления доступом.</param>
		/// <param name="revision">Номер редакции нового объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</param>
		/// <param name="capacity">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x0600340D RID: 13325 RVA: 0x000BE77A File Offset: 0x000BC97A
		public DiscretionaryAcl(bool isContainer, bool isDS, byte revision, int capacity) : base(isContainer, isDS, revision, capacity)
		{
		}

		/// <summary>Добавляет элемент управления доступом с указанными параметрами к текущему объекту <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип добавляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется элемент управления доступом.</param>
		/// <param name="accessMask">Правило доступа для нового элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового элемента управления доступом.</param>
		// Token: 0x0600340E RID: 13326 RVA: 0x000BE787 File Offset: 0x000BC987
		public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.AddAce(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None);
		}

		/// <summary>Добавляет элемент управления доступом с указанными параметрами к текущему объекту <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта для нового элемента управления доступом.</summary>
		/// <param name="accessType">Тип добавляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется элемент управления доступом.</param>
		/// <param name="accessMask">Правило доступа для нового элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового элемента управления доступом.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новый элемент управления доступом.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новый элемент управления доступом.</param>
		// Token: 0x0600340F RID: 13327 RVA: 0x000BE79C File Offset: 0x000BC99C
		public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.AddAce(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Добавляет элемент управления доступом с указанными параметрами к текущему объекту <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип добавляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого добавляется элемент управления доступом.</param>
		/// <param name="rule">
		///   <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> для нового доступа.</param>
		// Token: 0x06003410 RID: 13328 RVA: 0x000BE7C4 File Offset: 0x000BC9C4
		public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, ObjectAccessRule rule)
		{
			this.AddAccess(accessType, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Удаляет указанное правило управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило управления доступом.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно удаляет указанное правило доступа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003411 RID: 13329 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет указанное правило управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило управления доступом.</param>
		/// <param name="accessMask">Маска доступа для удаляемого правила управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого правила управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого правила управления доступом.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется удаляемое правило управления доступом.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать удаляемое правило управления доступом.</param>
		/// <returns>Значение <see langword="true" />, если метод успешно удаляет указанное правило доступа; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003412 RID: 13330 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			throw new NotImplementedException();
		}

		/// <summary>Удаляет указанное правило управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется правило управления доступом.</param>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.ObjectAccessRule" />, для которого удаляется доступ.</param>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.</returns>
		// Token: 0x06003413 RID: 13331 RVA: 0x000BE800 File Offset: 0x000BCA00
		public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, ObjectAccessRule rule)
		{
			return this.RemoveAccess(accessType, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Удаляет указанный элемент управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется элемент управления доступом.</param>
		/// <param name="accessMask">Маска доступа для удаляемого элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого элемента управления доступом.</param>
		// Token: 0x06003414 RID: 13332 RVA: 0x000BE839 File Offset: 0x000BCA39
		public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.RemoveAceSpecific(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None);
		}

		/// <summary>Удаляет указанный элемент управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Используйте этот метод для списков управления доступом объектов каталогов при указании типа объекта или типа наследуемого объекта для удаляемого элемента управления доступом.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется элемент управления доступом.</param>
		/// <param name="accessMask">Маска доступа для удаляемого элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования удаляемого элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования удаляемого элемента управления доступом.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется удаляемый элемент управления доступом.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать удаляемый элемент управления доступом.</param>
		// Token: 0x06003415 RID: 13333 RVA: 0x000BE850 File Offset: 0x000BCA50
		public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.RemoveAceSpecific(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Удаляет указанный элемент управления доступом из текущего объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</summary>
		/// <param name="accessType">Тип удаляемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого удаляется элемент управления доступом.</param>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.ObjectAccessRule" />, для которого удаляется доступ.</param>
		// Token: 0x06003416 RID: 13334 RVA: 0x000BE878 File Offset: 0x000BCA78
		public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, ObjectAccessRule rule)
		{
			this.RemoveAccessSpecific(accessType, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		/// <summary>Задает указанный элемент управления доступом для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="accessType">Тип устанавливаемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого нужно установить элемент управления доступом.</param>
		/// <param name="accessMask">Правило доступа для нового элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового элемента управления доступом.</param>
		// Token: 0x06003417 RID: 13335 RVA: 0x000BE8B1 File Offset: 0x000BCAB1
		public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			base.SetAce(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None);
		}

		/// <summary>Задает указанный элемент управления доступом для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="accessType">Тип устанавливаемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого нужно установить элемент управления доступом.</param>
		/// <param name="accessMask">Правило доступа для нового элемента управления доступом.</param>
		/// <param name="inheritanceFlags">Флаги, определяющие свойства наследования нового элемента управления доступом.</param>
		/// <param name="propagationFlags">Флаги, определяющие свойства распространения наследования нового элемента управления доступом.</param>
		/// <param name="objectFlags">Флаги, определяющие, содержат ли параметры <paramref name="objectType" /> и <paramref name="inheritedObjectType" /> значения, отличные от <see langword="null" />.</param>
		/// <param name="objectType">Идентификатор класса объектов, к которым применяется новый элемент управления доступом.</param>
		/// <param name="inheritedObjectType">Идентификатор класса дочерних объектов, которые могут наследовать новый элемент управления доступом.</param>
		// Token: 0x06003418 RID: 13336 RVA: 0x000BE8C8 File Offset: 0x000BCAC8
		public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			base.SetAce(DiscretionaryAcl.GetAceQualifier(accessType), sid, accessMask, inheritanceFlags, propagationFlags, AuditFlags.None, objectFlags, objectType, inheritedObjectType);
		}

		/// <summary>Задает указанный элемент управления доступом для указанного объекта <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="accessType">Тип устанавливаемого элемента управления доступом ("разрешить" или "запретить").</param>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, для которого нужно установить элемент управления доступом.</param>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.ObjectAccessRule" />, для которого нужно установить доступ.</param>
		// Token: 0x06003419 RID: 13337 RVA: 0x000BE8F0 File Offset: 0x000BCAF0
		public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, ObjectAccessRule rule)
		{
			this.SetAccess(accessType, sid, rule.AccessMask, rule.InheritanceFlags, rule.PropagationFlags, rule.ObjectFlags, rule.ObjectType, rule.InheritedObjectType);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000BE92C File Offset: 0x000BCB2C
		internal override void ApplyCanonicalSortToExplicitAces()
		{
			int canonicalExplicitAceCount = base.GetCanonicalExplicitAceCount();
			int canonicalExplicitDenyAceCount = base.GetCanonicalExplicitDenyAceCount();
			base.ApplyCanonicalSortToExplicitAces(0, canonicalExplicitDenyAceCount);
			base.ApplyCanonicalSortToExplicitAces(canonicalExplicitDenyAceCount, canonicalExplicitAceCount - canonicalExplicitDenyAceCount);
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000BE959 File Offset: 0x000BCB59
		internal override int GetAceInsertPosition(AceQualifier aceQualifier)
		{
			if (aceQualifier == AceQualifier.AccessAllowed)
			{
				return base.GetCanonicalExplicitDenyAceCount();
			}
			return 0;
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000BE966 File Offset: 0x000BCB66
		private static AceQualifier GetAceQualifier(AccessControlType accessType)
		{
			if (accessType == AccessControlType.Allow)
			{
				return AceQualifier.AccessAllowed;
			}
			if (AccessControlType.Deny == accessType)
			{
				return AceQualifier.AccessDenied;
			}
			throw new ArgumentOutOfRangeException("accessType");
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000BE980 File Offset: 0x000BCB80
		internal override bool IsAceMeaningless(GenericAce ace)
		{
			if (base.IsAceMeaningless(ace))
			{
				return true;
			}
			if (ace.AuditFlags != AuditFlags.None)
			{
				return true;
			}
			QualifiedAce qualifiedAce = ace as QualifiedAce;
			return null != qualifiedAce && qualifiedAce.AceQualifier != AceQualifier.AccessAllowed && AceQualifier.AccessDenied != qualifiedAce.AceQualifier;
		}
	}
}
