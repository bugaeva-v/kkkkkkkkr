using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет абстракцию элемента управления доступом, определяющую правило аудита для файла или каталога. Этот класс не наследуется.</summary>
	// Token: 0x02000529 RID: 1321
	public sealed class FileSystemAuditRule : AuditRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, используя ссылку на учетную запись пользователя, значение, определяющее тип операции, связанной с правилом аудита, а также значение, определяющее условия проведения аудита.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" />, инкапсулирующий ссылку на учетную запись пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающее тип операции, связанной с правилом аудита.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Security.AccessControl.AuditFlags" />, задающее условия проведения аудита.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не является объектом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="flags" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="flags" /> передано значение <see cref="F:System.Security.AccessControl.AuditFlags.None" />.</exception>
		// Token: 0x0600343F RID: 13375 RVA: 0x000BEAB6 File Offset: 0x000BCCB6
		public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, AuditFlags flags) : this(identity, fileSystemRights, InheritanceFlags.None, PropagationFlags.None, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, используя имя учетной записи пользователя, значение, определяющее тип операции, связанной с правилом аудита, а также значение, определяющее условия проведения аудита.</summary>
		/// <param name="identity">Имя учетной записи пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающее тип операции, связанной с правилом аудита.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Security.AccessControl.AuditFlags" />, задающее условия проведения аудита.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="flags" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="flags" /> передано значение <see cref="F:System.Security.AccessControl.AuditFlags.None" />.</exception>
		// Token: 0x06003440 RID: 13376 RVA: 0x000BEAC3 File Offset: 0x000BCCC3
		public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, AuditFlags flags) : this(new NTAccount(identity), fileSystemRights, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, используя имя ссылки на учетную запись пользователя, значение, определяющее тип связанных с правилом аудита операций, значение, определяющее порядок наследования прав, значение, определяющее порядок распространения прав, а также значение, обозначающее условия проведения аудита.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" />, инкапсулирующий ссылку на учетную запись пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающее тип операции, связанной с правилом аудита.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Security.AccessControl.AuditFlags" />, задающее условия проведения аудита.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не является объектом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="flags" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="flags" /> передано значение <see cref="F:System.Security.AccessControl.AuditFlags.None" />.</exception>
		// Token: 0x06003441 RID: 13377 RVA: 0x000BEAD3 File Offset: 0x000BCCD3
		public FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(identity, fileSystemRights, false, inheritanceFlags, propagationFlags, flags)
		{
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000BC74F File Offset: 0x000BA94F
		internal FileSystemAuditRule(IdentityReference identity, FileSystemRights fileSystemRights, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : base(identity, (int)fileSystemRights, isInherited, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, используя имя учетной записи пользователя, значение, определяющее тип связанных с правилом аудита операций, значение, определяющее порядок наследования прав, значение, определяющее порядок распространения прав, а также значение, обозначающее условия проведения аудита.</summary>
		/// <param name="identity">Имя учетной записи пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающее тип операции, связанной с правилом аудита.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Security.AccessControl.AuditFlags" />, задающее условия проведения аудита.</param>
		// Token: 0x06003443 RID: 13379 RVA: 0x000BEAE3 File Offset: 0x000BCCE3
		public FileSystemAuditRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) : this(new NTAccount(identity), fileSystemRights, inheritanceFlags, propagationFlags, flags)
		{
		}

		/// <summary>Получает флаги <see cref="T:System.Security.AccessControl.FileSystemRights" />, связанные с текущим объектом <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />.</summary>
		/// <returns>Флаги <see cref="T:System.Security.AccessControl.FileSystemRights" />, связанные с текущим объектом <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />.</returns>
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x000BC722 File Offset: 0x000BA922
		public FileSystemRights FileSystemRights
		{
			get
			{
				return (FileSystemRights)base.AccessMask;
			}
		}
	}
}
