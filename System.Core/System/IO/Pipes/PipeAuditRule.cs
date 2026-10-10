using System;
using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
	/// <summary>
	///         Представляет абстракцию записи управления доступом (ACE), определяющей правило аудита для канала.
	///       </summary>
	// Token: 0x02000349 RID: 841
	public sealed class PipeAuditRule : AuditRule
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.PipeAuditRule" /> класса для учетной записи пользователя, указанной в <see cref="T:System.Security.Principal.IdentityReference" /> объекта.
		///       </summary>
		/// <param name="identity">
		///           <see cref="T:System.Security.Principal.IdentityReference" /> Объекта, инкапсулирующего ссылку на учетную запись пользователя.
		///         </param>
		/// <param name="rights">
		///           Один из <see cref="T:System.IO.Pipes.PipeAccessRights" /> значения, которое указывает тип операции, связанной с правилом доступа.
		///         </param>
		/// <param name="flags">
		///           Один из <see cref="T:System.Security.AccessControl.AuditFlags" /> значений, определяющее, когда проведения аудита.
		///         </param>
		// Token: 0x0600197A RID: 6522 RVA: 0x000556C1 File Offset: 0x000538C1
		public PipeAuditRule(IdentityReference identity, PipeAccessRights rights, AuditFlags flags) : this(identity, PipeAuditRule.AccessMaskFromRights(rights), false, flags)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.IO.Pipes.PipeAuditRule" /> класс для учетной записи пользователя с именем.
		///       </summary>
		/// <param name="identity">
		///           Имя учетной записи пользователя.
		///         </param>
		/// <param name="rights">
		///           Один из <see cref="T:System.IO.Pipes.PipeAccessRights" /> значения, которое указывает тип операции, связанной с правилом доступа.
		///         </param>
		/// <param name="flags">
		///           Один из <see cref="T:System.Security.AccessControl.AuditFlags" /> значений, определяющее, когда проведения аудита.
		///         </param>
		// Token: 0x0600197B RID: 6523 RVA: 0x000556D2 File Offset: 0x000538D2
		public PipeAuditRule(string identity, PipeAccessRights rights, AuditFlags flags) : this(new NTAccount(identity), PipeAuditRule.AccessMaskFromRights(rights), false, flags)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000556E8 File Offset: 0x000538E8
		internal PipeAuditRule(IdentityReference identity, int accessMask, bool isInherited, AuditFlags flags) : base(identity, accessMask, isInherited, InheritanceFlags.None, PropagationFlags.None, flags)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000556F7 File Offset: 0x000538F7
		private static int AccessMaskFromRights(PipeAccessRights rights)
		{
			if (rights < (PipeAccessRights)0 || rights > (PipeAccessRights.ReadData | PipeAccessRights.WriteData | PipeAccessRights.ReadAttributes | PipeAccessRights.WriteAttributes | PipeAccessRights.ReadExtendedAttributes | PipeAccessRights.WriteExtendedAttributes | PipeAccessRights.CreateNewInstance | PipeAccessRights.Delete | PipeAccessRights.ReadPermissions | PipeAccessRights.ChangePermissions | PipeAccessRights.TakeOwnership | PipeAccessRights.Synchronize | PipeAccessRights.AccessSystemSecurity))
			{
				throw new ArgumentOutOfRangeException("rights", "Invalid PipeAccessRights value.");
			}
			return (int)rights;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.IO.Pipes.PipeAccessRights" /> флаги, связанные с текущим <see cref="T:System.IO.Pipes.PipeAuditRule" /> объекта.
		///       </summary>
		/// <returns>
		///         Поразрядное сочетание значений <see cref="T:System.IO.Pipes.PipeAccessRights" />.
		///       </returns>
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00055666 File Offset: 0x00053866
		public PipeAccessRights PipeAccessRights
		{
			get
			{
				return PipeAccessRule.RightsFromAccessMask(base.AccessMask);
			}
		}
	}
}
