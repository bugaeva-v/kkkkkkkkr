using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Определяет доступ к защищаемым объектам. Производные классы <see cref="T:System.Security.AccessControl.AccessRule" /> и <see cref="T:System.Security.AccessControl.AuditRule" /> предоставляют специализации для функций доступа и аудита.</summary>
	// Token: 0x0200050C RID: 1292
	public abstract class AuthorizationRule
	{
		// Token: 0x06003351 RID: 13137 RVA: 0x0000259F File Offset: 0x0000079F
		internal AuthorizationRule()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.AccessRule" />, используя указанные значения.</summary>
		/// <param name="identity">Удостоверение, к которому применяется правило доступа. Этот параметр должен быть объектом, который может быть приведен к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</param>
		/// <param name="accessMask">Маска доступа этого правила. Маска доступа является 32-разрядной коллекцией анонимных битов, значение которой определяется отдельными интеграторами.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило должно наследоваться от родительского контейнера.</param>
		/// <param name="inheritanceFlags">Свойства наследования правила доступа.</param>
		/// <param name="propagationFlags">Выполняется ли автоматическое распространение наследуемых правил доступа. Флаги распространения не учитываются, если <paramref name="inheritanceFlags" /> имеет значение <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="identity" /> не может быть приведено к <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="accessMask" /> равно нулю, либо параметр <paramref name="inheritanceFlags" /> или <paramref name="propagationFlags" /> содержит неопознанные значения флагов.</exception>
		// Token: 0x06003352 RID: 13138 RVA: 0x000BC97C File Offset: 0x000BAB7C
		protected internal AuthorizationRule(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags)
		{
			if (null == identity)
			{
				throw new ArgumentNullException("identity");
			}
			if (!(identity is SecurityIdentifier) && !(identity is NTAccount))
			{
				throw new ArgumentException("identity");
			}
			if (accessMask == 0)
			{
				throw new ArgumentException("accessMask");
			}
			if ((inheritanceFlags & ~(InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit)) != InheritanceFlags.None)
			{
				throw new ArgumentOutOfRangeException();
			}
			if ((propagationFlags & ~(PropagationFlags.NoPropagateInherit | PropagationFlags.InheritOnly)) != PropagationFlags.None)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.identity = identity;
			this.accessMask = accessMask;
			this.isInherited = isInherited;
			this.inheritanceFlags = inheritanceFlags;
			this.propagationFlags = propagationFlags;
		}

		/// <summary>Возвращает <see cref="T:System.Security.Principal.IdentityReference" />, к которому применяется это правило.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Principal.IdentityReference" />, к которому применяется это правило.</returns>
		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003353 RID: 13139 RVA: 0x000BCA0B File Offset: 0x000BAC0B
		public IdentityReference IdentityReference
		{
			get
			{
				return this.identity;
			}
		}

		/// <summary>Возвращает значение флагов, определяющих способ наследования этого правила дочерними объектами.</summary>
		/// <returns>Побитовое сочетание значений перечисления.</returns>
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x000BCA13 File Offset: 0x000BAC13
		public InheritanceFlags InheritanceFlags
		{
			get
			{
				return this.inheritanceFlags;
			}
		}

		/// <summary>Получает значение, указывающее, задано ли это правило явно или унаследовано от родительского объекта контейнера.</summary>
		/// <returns>Значение <see langword="true" />, если это правило не задано явно, но наследуется от родительского контейнера.</returns>
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x000BCA1B File Offset: 0x000BAC1B
		public bool IsInherited
		{
			get
			{
				return this.isInherited;
			}
		}

		/// <summary>Получает значение флагов распространения, которые определяют, как наследование этого правила распространяется на дочерние объекты. Это свойство является значимым, только когда значением перечисления <see cref="T:System.Security.AccessControl.InheritanceFlags" /> не является <see cref="F:System.Security.AccessControl.InheritanceFlags.None" />.</summary>
		/// <returns>Побитовое сочетание значений перечисления.</returns>
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x000BCA23 File Offset: 0x000BAC23
		public PropagationFlags PropagationFlags
		{
			get
			{
				return this.propagationFlags;
			}
		}

		/// <summary>Возвращает маску доступа для этого правила.</summary>
		/// <returns>Маска доступа для этого правила.</returns>
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x000BCA2B File Offset: 0x000BAC2B
		protected internal int AccessMask
		{
			get
			{
				return this.accessMask;
			}
		}

		// Token: 0x04002439 RID: 9273
		private IdentityReference identity;

		// Token: 0x0400243A RID: 9274
		private int accessMask;

		// Token: 0x0400243B RID: 9275
		private bool isInherited;

		// Token: 0x0400243C RID: 9276
		private InheritanceFlags inheritanceFlags;

		// Token: 0x0400243D RID: 9277
		private PropagationFlags propagationFlags;
	}
}
