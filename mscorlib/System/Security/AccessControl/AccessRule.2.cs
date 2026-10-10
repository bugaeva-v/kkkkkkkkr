using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет сочетание идентификатора пользователя, маски доступа и типа управления доступом ("разрешить" или "запретить"). Кроме того, в объекте AccessRule`1 содержатся сведения о том, как правило наследуется дочерними объектами и как это наследование распространяется.</summary>
	/// <typeparam name="T">Тип прав доступа для правила доступа.</typeparam>
	// Token: 0x02000504 RID: 1284
	public class AccessRule<T> : AccessRule where T : struct
	{
		/// <summary>Инициализирует новый экземпляр класса AccessRule’1, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.</param>
		/// <param name="rights">Права правила доступа.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x0600333D RID: 13117 RVA: 0x000BC82D File Offset: 0x000BAA2D
		public AccessRule(string identity, T rights, AccessControlType type) : this(new NTAccount(identity), rights, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса AccessRule’1, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.</param>
		/// <param name="rights">Права правила доступа.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x0600333E RID: 13118 RVA: 0x000BC83D File Offset: 0x000BAA3D
		public AccessRule(IdentityReference identity, T rights, AccessControlType type) : this(identity, rights, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса AccessRule’1, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.</param>
		/// <param name="rights">Права правила доступа.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x0600333F RID: 13119 RVA: 0x000BC84A File Offset: 0x000BAA4A
		public AccessRule(string identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(new NTAccount(identity), rights, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса AccessRule’1, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа.</param>
		/// <param name="rights">Права правила доступа.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <param name="type">Допустимый тип управления доступом.</param>
		// Token: 0x06003340 RID: 13120 RVA: 0x000BC85E File Offset: 0x000BAA5E
		public AccessRule(IdentityReference identity, T rights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(identity, (int)((object)rights), false, inheritanceFlags, propagationFlags, type)
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000BC711 File Offset: 0x000BA911
		internal AccessRule(IdentityReference identity, int rights, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : base(identity, rights, isInherited, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Возвращает права текущего экземпляра.</summary>
		/// <returns>Права, привести к типу &lt;T&gt;, текущего экземпляра.</returns>
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x000BC878 File Offset: 0x000BAA78
		public T Rights
		{
			get
			{
				return (T)((object)base.AccessMask);
			}
		}
	}
}
