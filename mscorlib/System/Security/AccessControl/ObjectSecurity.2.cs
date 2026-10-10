using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Обеспечивает возможность управления доступом к объектам каталога без непосредственной работы со списками управления доступом; также дает возможность приводить тип для прав доступа.</summary>
	/// <typeparam name="T">Права доступа для объекта.</typeparam>
	// Token: 0x02000542 RID: 1346
	public abstract class ObjectSecurity<T> : NativeObjectSecurity where T : struct
	{
		/// <summary>Инициализирует новый экземпляр класса ObjectSecurity`1.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип ресурса.</param>
		// Token: 0x06003546 RID: 13638 RVA: 0x000C0E3D File Offset: 0x000BF03D
		protected ObjectSecurity(bool isContainer, ResourceType resourceType) : base(isContainer, resourceType)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса ObjectSecurity`1.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип ресурса.</param>
		/// <param name="safeHandle">Дескриптор.</param>
		/// <param name="includeSections">Разделы, которые необходимо включить.</param>
		// Token: 0x06003547 RID: 13639 RVA: 0x000C0E47 File Offset: 0x000BF047
		protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections) : base(isContainer, resourceType, safeHandle, includeSections)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса ObjectSecurity`1.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип ресурса.</param>
		/// <param name="name">Имя защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" />.</param>
		/// <param name="includeSections">Разделы, которые необходимо включить.</param>
		// Token: 0x06003548 RID: 13640 RVA: 0x000C0E54 File Offset: 0x000BF054
		protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections) : base(isContainer, resourceType, name, includeSections)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса ObjectSecurity`1.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип ресурса.</param>
		/// <param name="safeHandle">Дескриптор.</param>
		/// <param name="includeSections">Разделы, которые необходимо включить.</param>
		/// <param name="exceptionFromErrorCode">Делегат, реализованный интеграторами, предоставляющий пользовательские исключения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x06003549 RID: 13641 RVA: 0x000C0E61 File Offset: 0x000BF061
		protected ObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle safeHandle, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base(isContainer, resourceType, safeHandle, includeSections, exceptionFromErrorCode, exceptionContext)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса ObjectSecurity`1.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип ресурса.</param>
		/// <param name="name">Имя защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.ObjectSecurity`1" />.</param>
		/// <param name="includeSections">Разделы, которые необходимо включить.</param>
		/// <param name="exceptionFromErrorCode">Делегат, реализованный интеграторами, предоставляющий пользовательские исключения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x0600354A RID: 13642 RVA: 0x000C0E72 File Offset: 0x000BF072
		protected ObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base(isContainer, resourceType, name, includeSections, exceptionFromErrorCode, exceptionContext)
		{
		}

		/// <summary>Получает тип защищаемого объекта, связанного с правилами аудита данного объекта ObjectSecurity`1.</summary>
		/// <returns>Тип защищаемого объекта, связанный с текущим экземпляром.</returns>
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x000C0E83 File Offset: 0x000BF083
		public override Type AccessRightType
		{
			get
			{
				return typeof(T);
			}
		}

		/// <summary>Получает тип объекта, связанного с правилами доступа данного объекта ObjectSecurity`1.</summary>
		/// <returns>Тип объекта, связанного с правилами доступа для текущего экземпляра.</returns>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x000C0E8F File Offset: 0x000BF08F
		public override Type AccessRuleType
		{
			get
			{
				return typeof(AccessRule<T>);
			}
		}

		/// <summary>Получает объект Type, связанный с правилами аудита данного объекта ObjectSecurity`1.</summary>
		/// <returns>объект Type, связанный с правилами аудита для текущего экземпляра.</returns>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x000C0E9B File Offset: 0x000BF09B
		public override Type AuditRuleType
		{
			get
			{
				return typeof(AuditRule<T>);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса ObjectAccessRule, представляющий новое правило управления доступом для связанного объекта безопасности.</summary>
		/// <param name="identityReference">Представляет учетную запись пользователя.</param>
		/// <param name="accessMask">Тип доступа.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило доступа наследуется; в противном случае — значение <see langword="false" />.</param>
		/// <param name="inheritanceFlags">Определяет, как выполнять распространение масок доступа на дочерние объектам.</param>
		/// <param name="propagationFlags">Определяет порядок распространения действия элементов управления доступом на дочерние объекты.</param>
		/// <param name="type">Определяет, разрешен или запрещен доступ.</param>
		/// <returns>Представляет новое правило управления доступом для указанного пользователя с указанными правами, типом управления доступом и флагами.</returns>
		// Token: 0x0600354E RID: 13646 RVA: 0x000C0EA7 File Offset: 0x000BF0A7
		public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new AccessRule<T>(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type);
		}

		/// <summary>Добавляет указанное правило доступа в список управления доступом на уровне пользователей, связанный с данным объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Добавляемое правило.</param>
		// Token: 0x0600354F RID: 13647 RVA: 0x000BC644 File Offset: 0x000BA844
		public virtual void AddAccessRule(AccessRule<T> rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Удаляет правила доступа с тем же идентификатором безопасности и маской доступа, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемая правило.</param>
		/// <returns>Значение <see langword="true" />, если правило доступа успешно удалено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003550 RID: 13648 RVA: 0x000BC65F File Offset: 0x000BA85F
		public virtual bool RemoveAccessRule(AccessRule<T> rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x06003551 RID: 13649 RVA: 0x000BC668 File Offset: 0x000BA868
		public virtual void RemoveAccessRuleAll(AccessRule<T> rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Удаляет все правила доступа, в точности совпадающие с указанным правилом доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемое правило доступа.</param>
		// Token: 0x06003552 RID: 13650 RVA: 0x000BC671 File Offset: 0x000BA871
		public virtual void RemoveAccessRuleSpecific(AccessRule<T> rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила доступа из списка управления доступом на уровне пользователей (DACL), связанного с текущим объектом ObjectSecurity`1, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Сбрасываемое правило доступа.</param>
		// Token: 0x06003553 RID: 13651 RVA: 0x000BC656 File Offset: 0x000BA856
		public virtual void ResetAccessRule(AccessRule<T> rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Удаляет все правила доступа с тем же идентификатором и квалификатором безопасности, что и у указанного правила доступа, из списка управления доступом на уровне пользователей, связанного с текущим объектом ObjectSecurity`1, а затем добавляет указанное правило доступа.</summary>
		/// <param name="rule">Устанавливаемое правило доступа.</param>
		// Token: 0x06003554 RID: 13652 RVA: 0x000BC64D File Offset: 0x000BA84D
		public virtual void SetAccessRule(AccessRule<T> rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" />, который представляет указанное правило аудита для указанного пользователя.</summary>
		/// <param name="identityReference">Представляет учетную запись пользователя.</param>
		/// <param name="accessMask">Целочисленное значение, задающее тип доступа.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило доступа наследуется; в противном случае — значение <see langword="false" />.</param>
		/// <param name="inheritanceFlags">Определяет, как выполнять распространение масок доступа на дочерние объектам.</param>
		/// <param name="propagationFlags">Определяет порядок распространения действия элементов управления доступом на дочерние объекты.</param>
		/// <param name="flags">Описывает тип аудита для выполнения.</param>
		/// <returns>Заданное правило аудита для указанного пользователя.</returns>
		// Token: 0x06003555 RID: 13653 RVA: 0x000C0EB7 File Offset: 0x000BF0B7
		public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new AuditRule<T>(identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
		}

		/// <summary>Добавляет указанное правило аудита в системный список управления доступом, связанный с данным объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Добавляемое правило аудита.</param>
		// Token: 0x06003556 RID: 13654 RVA: 0x000BC67A File Offset: 0x000BA87A
		public virtual void AddAuditRule(AuditRule<T> rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Удаляет правила аудита с тем же идентификатором безопасности и маской доступа, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		/// <returns>Значение <see langword="true" />, если объект был удален; иначе — значение <see langword="false" />.</returns>
		// Token: 0x06003557 RID: 13655 RVA: 0x000BC68C File Offset: 0x000BA88C
		public virtual bool RemoveAuditRule(AuditRule<T> rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x06003558 RID: 13656 RVA: 0x000BC695 File Offset: 0x000BA895
		public virtual void RemoveAuditRuleAll(AuditRule<T> rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Удаляет все правила аудита, в точности совпадающие с указанным правилом аудита, из системного списка управления доступом, связанного с текущим объектом ObjectSecurity`1.</summary>
		/// <param name="rule">Удаляемое правило аудита.</param>
		// Token: 0x06003559 RID: 13657 RVA: 0x000BC69E File Offset: 0x000BA89E
		public virtual void RemoveAuditRuleSpecific(AuditRule<T> rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Удаляет все правила аудита с тем же идентификатором и квалификатором безопасности, что и у указанного правила аудита, из системного списка управления доступом, связанного с текущим объектом ObjectSecurity`1, а затем добавляет указанное правило аудита.</summary>
		/// <param name="rule">Устанавливаемое правило аудита.</param>
		// Token: 0x0600355A RID: 13658 RVA: 0x000BC683 File Offset: 0x000BA883
		public virtual void SetAuditRule(AuditRule<T> rule)
		{
			base.SetAuditRule(rule);
		}

		/// <summary>Сохраняет дескриптора безопасности, связанного с данным объектом ObjectSecurity`1, в постоянном хранилище, используя указанный дескриптор.</summary>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан данный объект ObjectSecurity`1.</param>
		// Token: 0x0600355B RID: 13659 RVA: 0x000C0EC8 File Offset: 0x000BF0C8
		protected void Persist(SafeHandle handle)
		{
			base.WriteLock();
			try
			{
				this.Persist(handle, base.AccessControlSectionsModified);
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>Сохраняет дескриптора безопасности, связанного с данным объектом ObjectSecurity`1, в постоянном хранилище, используя указанное имя.</summary>
		/// <param name="name">Имя защищаемого объекта, с которым связан данный объект ObjectSecurity`1.</param>
		// Token: 0x0600355C RID: 13660 RVA: 0x000C0F04 File Offset: 0x000BF104
		protected void Persist(string name)
		{
			base.WriteLock();
			try
			{
				this.Persist(name, base.AccessControlSectionsModified);
			}
			finally
			{
				base.WriteUnlock();
			}
		}
	}
}
