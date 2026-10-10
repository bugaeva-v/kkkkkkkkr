using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя и маски доступа. Кроме того, в объекте <see cref="T:System.Security.AccessControl.AuditRule" /> содержатся сведения о том, как правило наследуется дочерними объектами, как это наследование распространяется, а также об условиях, при которых выполняется аудит.</summary>
	// Token: 0x0200050A RID: 1290
	public abstract class AuditRule : AuthorizationRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита. Это должен быть объект, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа данного правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило должно наследоваться от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил аудита. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="auditFlags">Условия, в которых применяется правило аудита.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="identity" /> нельзя привести к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или параметр <paramref name="auditFlags" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="accessMask" /> равно нулю, либо параметр <paramref name="inheritanceFlags" /> или <paramref name="propagationFlags" /> содержит неопознанные значения флагов.</exception>
		// Token: 0x06003349 RID: 13129 RVA: 0x000BC8F7 File Offset: 0x000BAAF7
		protected AuditRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) : base(identity, accessMask, isInherited, inheritanceFlags, propagationFlags)
		{
			if (auditFlags != ((AuditFlags.Success | AuditFlags.Failure) & auditFlags))
			{
				throw new ArgumentException("Invalid audit flags.", "auditFlags");
			}
			this.auditFlags = auditFlags;
		}

		/// <summary>Получает флаги аудита для данного правила аудита.</summary>
		/// <returns>Побитовое сочетание значений перечисления. Это сочетание определяет условия аудита для данного правила аудита.</returns>
		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x000BC926 File Offset: 0x000BAB26
		public AuditFlags AuditFlags
		{
			get
			{
				return this.auditFlags;
			}
		}

		// Token: 0x04002438 RID: 9272
		private AuditFlags auditFlags;
	}
}
