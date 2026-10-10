using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя, маски доступа и типа управления доступом ("разрешить" или "запретить"). Кроме того, в объекте <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> содержатся сведения о типе объекта, к которому относится правило, типе дочернего объекта, который может наследовать правило, способе наследования правила дочерними объектами, а также способе распространения этого наследования.</summary>
	// Token: 0x0200053D RID: 1341
	public abstract class ObjectAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> с использованием указанных значений.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.  Это должен быть объект, который может быть приведен как <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Указывает свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Указывает, выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="objectType">Тип объекта, к которому применяется правило доступа.</param>
		/// <param name="inheritedObjectType">Тип дочернего объекта, который может наследовать данное правило.</param>
		/// <param name="type">Определяет тип правила ("разрешить" или "запретить").</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="identity" /> нельзя привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="accessMask" /> равно 0 или параметр <paramref name="inheritanceFlags" /> или <paramref name="propagationFlags" /> содержит неизвестное значение флага.</exception>
		// Token: 0x060034EF RID: 13551 RVA: 0x000C0061 File Offset: 0x000BE261
		protected ObjectAccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, Guid objectType, Guid inheritedObjectType, AccessControlType type) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags, type)
		{
			this.object_type = objectType;
			this.inherited_object_type = inheritedObjectType;
		}

		/// <summary>Получает тип дочернего объекта, который может наследовать от объекта <see cref="T:System.Security.AccessControl.ObjectAccessRule" />.</summary>
		/// <returns>Тип дочернего объекта, который может наследовать от объекта <see cref="T:System.Security.AccessControl.ObjectAccessRule" />.</returns>
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x000C0082 File Offset: 0x000BE282
		public Guid InheritedObjectType
		{
			get
			{
				return this.inherited_object_type;
			}
		}

		/// <summary>Получает флаги, указывающие, содержат ли свойства <see cref="P:System.Security.AccessControl.ObjectAccessRule.ObjectType" /> и <see cref="P:System.Security.AccessControl.ObjectAccessRule.InheritedObjectType" /> объекта <see cref="T:System.Security.AccessControl.ObjectAccessRule" /> допустимые значения.</summary>
		/// <returns>
		///   <see cref="F:System.Security.AccessControl.ObjectAceFlags.ObjectAceTypePresent" /> указывает, что свойство <see cref="P:System.Security.AccessControl.ObjectAccessRule.ObjectType" /> содержит допустимое значение. <see cref="F:System.Security.AccessControl.ObjectAceFlags.InheritedObjectAceTypePresent" /> указывает, что свойство <see cref="P:System.Security.AccessControl.ObjectAccessRule.InheritedObjectType" /> содержит допустимое значение. Эти значения могут объединяться с помощью логического ИЛИ.</returns>
		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060034F1 RID: 13553 RVA: 0x000C008C File Offset: 0x000BE28C
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

		/// <summary>Получает тип объекта, к которому применяется <see cref="T:System.Security.AccessControl.ObjectAccessRule" />.</summary>
		/// <returns>Тип объекта, к которому применяется <see cref="T:System.Security.AccessControl.ObjectAccessRule" />.</returns>
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x000C00C8 File Offset: 0x000BE2C8
		public Guid ObjectType
		{
			get
			{
				return this.object_type;
			}
		}

		// Token: 0x040024C2 RID: 9410
		private Guid object_type;

		// Token: 0x040024C3 RID: 9411
		private Guid inherited_object_type;
	}
}
