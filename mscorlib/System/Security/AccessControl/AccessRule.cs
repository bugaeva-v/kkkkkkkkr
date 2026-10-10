using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя, маски доступа и типа управления доступом ("разрешить" или "запретить"). Кроме того, в объекте <see cref="T:System.Security.AccessControl.AccessRule" /> содержатся сведения о том, как правило наследуется дочерними объектами и как это наследование распространяется.</summary>
	// Token: 0x02000503 RID: 1283
	public abstract class AccessRule : AuthorizationRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AccessRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа. Этот параметр должен быть объектом, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа этого правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило наследуется от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="identity" /> нельзя привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или параметр <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="accessMask" /> равно нулю, либо параметр <paramref name="inheritanceFlags" /> или <paramref name="propagationFlags" /> содержит неопознанные значения флагов.</exception>
		// Token: 0x0600333B RID: 13115 RVA: 0x000BC7F4 File Offset: 0x000BA9F4
		protected AccessRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags)
		{
			if (type < AccessControlType.Allow || type > AccessControlType.Deny)
			{
				throw new ArgumentException("Invalid access control type.", "type");
			}
			this.type = type;
		}

		/// <summary>Получает значение <see cref="T:System.Security.AccessControl.AccessControlType" />, связанное с данным объектом <see cref="T:System.Security.AccessControl.AccessRule" />.</summary>
		/// <returns>Значение <see cref="T:System.Security.AccessControl.AccessControlType" />, связанное с данным объектом <see cref="T:System.Security.AccessControl.AccessRule" />.</returns>
		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600333C RID: 13116 RVA: 0x000BC825 File Offset: 0x000BAA25
		public AccessControlType AccessControlType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x0400240E RID: 9230
		private AccessControlType type;
	}
}
