using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя, маски доступа и условий аудита. Кроме того, в объекте <see cref="T:System.Security.AccessControl.ObjectAuditRule" /> содержатся сведения о типе объекта, к которому относится правило, типе дочернего объекта, который может наследовать правило, способе наследования правила дочерними объектами, а также способе распространения этого наследования.</summary>
	// Token: 0x02000540 RID: 1344
	public abstract class ObjectAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectAuditRule" />.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.  Это должен быть объект, который может быть приведен как <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="objectType">Тип объекта, к которому применяется правило доступа.</param>
		/// <param name="inheritedObjectType">Тип дочернего объекта, который может наследовать данное правило.</param>
		/// <param name="auditFlags">Условия аудита.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="identity" /> нельзя привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="accessMask" /> равно 0 или параметр <paramref name="inheritanceFlags" /> или <paramref name="propagationFlags" /> содержит неизвестное значение флага.</exception>
		// Token: 0x06003505 RID: 13573 RVA: 0x000C0522 File Offset: 0x000BE722
		protected ObjectAuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, Guid objectType, Guid inheritedObjectType, AuditFlags auditFlags) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, auditFlags)
		{
			this.object_type = objectType;
			this.inherited_object_type = inheritedObjectType;
		}

		/// <summary>Получает тип дочернего объекта, который может наследовать от объекта <see cref="T:System.Security.AccessControl.ObjectAuditRule" />.</summary>
		/// <returns>Тип дочернего объекта, который может наследовать от объекта <see cref="T:System.Security.AccessControl.ObjectAuditRule" />.</returns>
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000C0543 File Offset: 0x000BE743
		public Guid InheritedObjectType
		{
			get
			{
				return this.inherited_object_type;
			}
		}

		/// <summary>Свойства <see cref="P:System.Security.AccessControl.ObjectAuditRule.ObjectType" /> и <see cref="P:System.Security.AccessControl.ObjectAuditRule.InheritedObjectType" /> объекта <see cref="T:System.Security.AccessControl.ObjectAuditRule" /> содержат допустимые значения.</summary>
		/// <returns>
		///   <see cref="F:System.Security.AccessControl.ObjectAceFlags.ObjectAceTypePresent" /> указывает, что свойство <see cref="P:System.Security.AccessControl.ObjectAuditRule.ObjectType" /> содержит допустимое значение. <see cref="F:System.Security.AccessControl.ObjectAceFlags.InheritedObjectAceTypePresent" /> указывает, что свойство <see cref="P:System.Security.AccessControl.ObjectAuditRule.InheritedObjectType" /> содержит допустимое значение. Эти значения могут объединяться с помощью логического ИЛИ.</returns>
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000C054C File Offset: 0x000BE74C
		public ObjectAceFlags ObjectFlags
		{
			get
			{
				ObjectAceFlags objectAceFlags = ObjectAceFlags.None;
				if (this.object_type != Guid.Empty)
				{
					objectAceFlags |= ObjectAceFlags.ObjectAceTypePresent;
				}
				if (this.inherited_object_type != Guid.Empty)
				{
					objectAceFlags |= ObjectAceFlags.InheritedObjectAceTypePresent;
				}
				return objectAceFlags;
			}
		}

		/// <summary>Получает тип объекта, к которому применяется <see cref="T:System.Security.AccessControl.ObjectAuditRule" />.</summary>
		/// <returns>Тип объекта, к которому применяется <see cref="T:System.Security.AccessControl.ObjectAuditRule" />.</returns>
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000C0588 File Offset: 0x000BE788
		public Guid ObjectType
		{
			get
			{
				return this.object_type;
			}
		}

		// Token: 0x040024CB RID: 9419
		private Guid inherited_object_type;

		// Token: 0x040024CC RID: 9420
		private Guid object_type;
	}
}
