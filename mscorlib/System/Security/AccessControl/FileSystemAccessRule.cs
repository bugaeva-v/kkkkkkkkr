using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет абстракцию элемента управления доступом, определяющую правило доступа для файла или каталога. Этот класс не наследуется.</summary>
	// Token: 0x02000528 RID: 1320
	public sealed class FileSystemAccessRule : AccessRule
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, используя ссылку на учетную запись пользователя, значение, определяющее тип операции, связанной с правилом доступа, а также признак разрешения или запрета этой операции.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" />, инкапсулирующий ссылку на учетную запись пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающих тип операции, связанной с правилом доступа.</param>
		/// <param name="type">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlType" />, которое определяет, запрещена или разрешена операция.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не является объектом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="type" />передано неверное перечисление.</exception>
		// Token: 0x06003439 RID: 13369 RVA: 0x000BEA73 File Offset: 0x000BCC73
		public FileSystemAccessRule(IdentityReference identity, FileSystemRights fileSystemRights, AccessControlType type) : this(identity, fileSystemRights, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, используя имя учетной записи пользователя, значение, определяющее тип операции, связанной с правилом доступа, а также признак разрешения или запрета этой операции.</summary>
		/// <param name="identity">Имя учетной записи пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающих тип операции, связанной с правилом доступа.</param>
		/// <param name="type">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlType" />, которое определяет, запрещена или разрешена операция.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="type" />передано неверное перечисление.</exception>
		// Token: 0x0600343A RID: 13370 RVA: 0x000BEA80 File Offset: 0x000BCC80
		public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, AccessControlType type) : this(new NTAccount(identity), fileSystemRights, InheritanceFlags.None, PropagationFlags.None, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, используя ссылку на учетную запись пользователя, значение, определяющее тип связанных с правилом доступа операций, значение, определяющее порядок наследования прав, значение, определяющее порядок распространения прав, а также признак разрешения или запрета этой операции.</summary>
		/// <param name="identity">Объект <see cref="T:System.Security.Principal.IdentityReference" />, инкапсулирующий ссылку на учетную запись пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающих тип операции, связанной с правилом доступа.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="type">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlType" />, которое определяет, запрещена или разрешена операция.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identity" /> не является объектом <see cref="T:System.Security.Principal.IdentityReference" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="type" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="inheritanceFlags" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="propagationFlags" />передано неверное перечисление.</exception>
		// Token: 0x0600343B RID: 13371 RVA: 0x000BEA92 File Offset: 0x000BCC92
		public FileSystemAccessRule(IdentityReference identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(identity, fileSystemRights, false, inheritanceFlags, propagationFlags, type)
		{
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000BC711 File Offset: 0x000BA911
		internal FileSystemAccessRule(IdentityReference identity, FileSystemRights fileSystemRights, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : base(identity, (int)fileSystemRights, isInherited, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, используя имя учетной записи пользователя, значение, определяющее тип связанных с правилом доступа операций, значение, определяющее порядок наследования прав, значение, определяющее порядок распространения прав, а также признак разрешения или запрета этой операции.</summary>
		/// <param name="identity">Имя учетной записи пользователя.</param>
		/// <param name="fileSystemRights">Одно из значений <see cref="T:System.Security.AccessControl.FileSystemRights" />, задающих тип операции, связанной с правилом доступа.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="type">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlType" />, которое определяет, запрещена или разрешена операция.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметру <paramref name="type" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="inheritanceFlags" />передано неверное перечисление.  
		///
		/// или - 
		/// Параметру <paramref name="propagationFlags" />передано неверное перечисление.</exception>
		// Token: 0x0600343D RID: 13373 RVA: 0x000BEAA2 File Offset: 0x000BCCA2
		public FileSystemAccessRule(string identity, FileSystemRights fileSystemRights, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) : this(new NTAccount(identity), fileSystemRights, inheritanceFlags, propagationFlags, type)
		{
		}

		/// <summary>Получает флаги <see cref="T:System.Security.AccessControl.FileSystemRights" />, связанные с текущим объектом <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />.</summary>
		/// <returns>Флаги <see cref="T:System.Security.AccessControl.FileSystemRights" />, связанные с текущим объектом <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />.</returns>
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x000BC722 File Offset: 0x000BA922
		public FileSystemRights FileSystemRights
		{
			get
			{
				return (FileSystemRights)base.AccessMask;
			}
		}
	}
}
