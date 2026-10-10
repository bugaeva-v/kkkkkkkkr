using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя и маски доступа.</summary>
	/// <typeparam name="T">Тип правила аудита.</typeparam>
	// Token: 0x0200050B RID: 1291
	public class AuditRule<T> : AuditRule where T : struct
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule`1" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита.</param>
		/// <param name="rights">Права правила аудита.</param>
		/// <param name="flags">Свойства правила аудита.</param>
		// Token: 0x0600334B RID: 13131 RVA: 0x000BC92E File Offset: 0x000BAB2E
		public AuditRule(string identity, T rights, AuditFlags flags) : this(new NTAccount(identity), rights, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule`1" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется данное правило аудита.</param>
		/// <param name="rights">Права правила аудита.</param>
		/// <param name="flags">Условия, в которых применяется правило аудита.</param>
		// Token: 0x0600334C RID: 13132 RVA: 0x000BC93E File Offset: 0x000BAB3E
		public AuditRule(IdentityReference identity, T rights, AuditFlags flags) : this(identity, rights, InheritanceFlags.None, PropagationFlags.None, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule`1" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита.</param>
		/// <param name="rights">Права правила аудита.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил аудита.</param>
		/// <param name="flags">Условия, в которых применяется правило аудита.</param>
		// Token: 0x0600334D RID: 13133 RVA: 0x000BC94B File Offset: 0x000BAB4B
		public AuditRule(string identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(new NTAccount(identity), rights, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AuditRule`1" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило аудита.</param>
		/// <param name="rights">Права правила аудита.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила аудита.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил аудита.</param>
		/// <param name="flags">Условия, в которых применяется правило аудита.</param>
		// Token: 0x0600334E RID: 13134 RVA: 0x000BC95F File Offset: 0x000BAB5F
		public AuditRule(IdentityReference identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(identity, (int)((object)rights), false, inheritanceFlags, propagationFlags, flags)
		{
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000BC74F File Offset: 0x000BA94F
		internal AuditRule(IdentityReference identity, int rights, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : base(identity, rights, isInherited, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Получает права правила аудита.</summary>
		/// <returns>Права правила аудита.</returns>
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x000BC878 File Offset: 0x000BAA78
		public T Rights
		{
			get
			{
				return (T)((object)base.AccessMask);
			}
		}
	}
}
