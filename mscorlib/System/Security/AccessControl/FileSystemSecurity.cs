using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Unity;

namespace System.Security.AccessControl
{
	/// <summary>Представляет возможности управления доступом и аудита безопасности для файла или каталога.</summary>
	// Token: 0x0200052B RID: 1323
	public abstract class FileSystemSecurity : NativeObjectSecurity
	{
		// Token: 0x06003445 RID: 13381 RVA: 0x000BEAF7 File Offset: 0x000BCCF7
		internal FileSystemSecurity(bool isContainer) : base(isContainer, ResourceType.FileObject)
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x000BEB01 File Offset: 0x000BCD01
		internal FileSystemSecurity(bool isContainer, string name, AccessControlSections includeSections) : base(isContainer, ResourceType.FileObject, name, includeSections)
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000BEB0D File Offset: 0x000BCD0D
		internal FileSystemSecurity(bool isContainer, SafeHandle handle, AccessControlSections includeSections) : base(isContainer, ResourceType.FileObject, handle, includeSections)
		{
		}

		/// <summary>Получает значение перечисления, используемое классом <see cref="T:System.Security.AccessControl.FileSystemSecurity" /> для обозначения прав доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий перечисление <see cref="T:System.Security.AccessControl.FileSystemRights" />.</returns>
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x000BEB19 File Offset: 0x000BCD19
		public override Type AccessRightType
		{
			get
			{
				return typeof(FileSystemRights);
			}
		}

		/// <summary>Получает перечисление, используемое классом <see cref="T:System.Security.AccessControl.FileSystemSecurity" /> для обозначения правил доступа.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />.</returns>
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x000BEB25 File Offset: 0x000BCD25
		public override Type AccessRuleType
		{
			get
			{
				return typeof(FileSystemAccessRule);
			}
		}

		/// <summary>Получает тип, используемый классом <see cref="T:System.Security.AccessControl.FileSystemSecurity" /> для обозначения правил аудита.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />.</returns>
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000BEB31 File Offset: 0x000BCD31
		public override Type AuditRuleType
		{
			get
			{
				return typeof(FileSystemAuditRule);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий новое правило управления доступом для указанного пользователя с указанными правами доступа, типом доступа и флагами.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, представляющий учетную запись пользователя.</param>
		/// <param name="accessMask">Целочисленное значение, задающее тип доступа.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило доступа наследуется; в противном случае — значение <see langword="false" />.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Security.AccessControl.AccessControlType" />, определяющее тип правила ("разрешить" или "запретить").</param>
		/// <returns>Новый объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий новое правило управления доступом для указанного пользователя с указанными правами доступа, типом доступа и флагами.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="type" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identityReference" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="accessMask" /> равно нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="identityReference" /> не принадлежит к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или к типу (такому, как <see cref="T:System.Security.Principal.NTAccount" />), допускающему преобразование в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x0600344B RID: 13387 RVA: 0x000BEB3D File Offset: 0x000BCD3D
		public sealed override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
		{
			return new FileSystemAccessRule(identityReference, (FileSystemRights)accessMask, isInherited, inheritanceFlags, propagationFlags, type);
		}

		/// <summary>Добавляет указанное разрешение списка управления доступом к текущему файлу или каталогу.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий разрешение списка управления доступом, которое необходимо добавить к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600344C RID: 13388 RVA: 0x000BC644 File Offset: 0x000BA844
		public void AddAccessRule(FileSystemAccessRule rule)
		{
			base.AddAccessRule(rule);
		}

		/// <summary>Удаляет все подходящие разрешения и запреты списка управления доступом из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий разрешение списка управления доступом, которое необходимо удалить из файла или каталога.</param>
		/// <returns>Значение <see langword="true" />, если правило доступа удалено; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600344D RID: 13389 RVA: 0x000BC65F File Offset: 0x000BA85F
		public bool RemoveAccessRule(FileSystemAccessRule rule)
		{
			return base.RemoveAccessRule(rule);
		}

		/// <summary>Удаляет все разрешения списка управления доступом для указанного пользователя из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, задающий пользователя, разрешения списка управления доступом которого необходимо удалить из файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600344E RID: 13390 RVA: 0x000BC668 File Offset: 0x000BA868
		public void RemoveAccessRuleAll(FileSystemAccessRule rule)
		{
			base.RemoveAccessRuleAll(rule);
		}

		/// <summary>Удаляет одно подходящее разрешение или один запрет списка управления доступом из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, задающий пользователя, разрешения списка управления доступом которого необходимо удалить из файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600344F RID: 13391 RVA: 0x000BC671 File Offset: 0x000BA871
		public void RemoveAccessRuleSpecific(FileSystemAccessRule rule)
		{
			base.RemoveAccessRuleSpecific(rule);
		}

		/// <summary>Добавляет указанное разрешение списка управления доступом к текущему файлу или каталогу и удаляет все совпадающие разрешения списка управления доступом.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий разрешение списка управления доступом, которое необходимо добавить к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003450 RID: 13392 RVA: 0x000BC656 File Offset: 0x000BA856
		public void ResetAccessRule(FileSystemAccessRule rule)
		{
			base.ResetAccessRule(rule);
		}

		/// <summary>Устанавливает указанное разрешение списка управления доступом для текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAccessRule" />, представляющий разрешение списка управления доступом, которое необходимо установить для файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003451 RID: 13393 RVA: 0x000BC64D File Offset: 0x000BA84D
		public void SetAccessRule(FileSystemAccessRule rule)
		{
			base.SetAccessRule(rule);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, который представляет указанное правило аудита для указанного пользователя.</summary>
		/// <param name="identityReference">Объект <see cref="T:System.Security.Principal.IdentityReference" />, представляющий учетную запись пользователя.</param>
		/// <param name="accessMask">Целочисленное значение, задающее тип доступа.</param>
		/// <param name="isInherited">Значение <see langword="true" />, если правило доступа наследуется; в противном случае — значение <see langword="false" />.</param>
		/// <param name="inheritanceFlags">Одно из значений <see cref="T:System.Security.AccessControl.InheritanceFlags" />, определяющее порядок распространения масок доступа на дочерние объекты.</param>
		/// <param name="propagationFlags">Одно из значений <see cref="T:System.Security.AccessControl.PropagationFlags" />, определяющее порядок распространения элементов управления доступом на дочерние объекты.</param>
		/// <param name="flags">Одно из значений <see cref="T:System.Security.AccessControl.AuditFlags" />, определяющее тип проводимого аудита.</param>
		/// <returns>Новый объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, представляющий указанное правило аудита для указанного пользователя.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Свойство <paramref name="accessMask" />, <paramref name="inheritanceFlags" />, <paramref name="propagationFlags" /> или <paramref name="flags" /> задает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <paramref name="identityReference" /> — <see langword="null" />.  
		///
		/// или - 
		/// Значение свойства <paramref name="accessMask" /> равно нулю.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="identityReference" /> не принадлежит к типу <see cref="T:System.Security.Principal.SecurityIdentifier" /> или к типу (такому, как <see cref="T:System.Security.Principal.NTAccount" />), допускающему преобразование в тип <see cref="T:System.Security.Principal.SecurityIdentifier" />.</exception>
		// Token: 0x06003452 RID: 13394 RVA: 0x000BEB4D File Offset: 0x000BCD4D
		public sealed override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
		{
			return new FileSystemAuditRule(identityReference, (FileSystemRights)accessMask, isInherited, inheritanceFlags, propagationFlags, flags);
		}

		/// <summary>Добавляет указанное правило аудита к текущему файлу или каталогу.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, представляющий правило аудита, которое необходимо добавить к файлу или каталогу.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003453 RID: 13395 RVA: 0x000BC67A File Offset: 0x000BA87A
		public void AddAuditRule(FileSystemAuditRule rule)
		{
			base.AddAuditRule(rule);
		}

		/// <summary>Удаляет все подходящие разрешающие или запрещающие правила аудита из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, представляющий правило аудита, которое необходимо удалить из файла или каталога.</param>
		/// <returns>Значение <see langword="true" />, если правило аудита удалено, в противном случае — значение <see langword="false" /></returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003454 RID: 13396 RVA: 0x000BC68C File Offset: 0x000BA88C
		public bool RemoveAuditRule(FileSystemAuditRule rule)
		{
			return base.RemoveAuditRule(rule);
		}

		/// <summary>Удаляет все правила аудита для указанного пользователя из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, задающий пользователя, правила аудита которого необходимо удалить из файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003455 RID: 13397 RVA: 0x000BC695 File Offset: 0x000BA895
		public void RemoveAuditRuleAll(FileSystemAuditRule rule)
		{
			base.RemoveAuditRuleAll(rule);
		}

		/// <summary>Удаляет одно подходящее разрешающее или запрещающее правило аудита из текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, представляющий правило аудита, которое необходимо удалить из файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003456 RID: 13398 RVA: 0x000BC69E File Offset: 0x000BA89E
		public void RemoveAuditRuleSpecific(FileSystemAuditRule rule)
		{
			base.RemoveAuditRuleSpecific(rule);
		}

		/// <summary>Устанавливает указанное правило аудита для текущего файла или каталога.</summary>
		/// <param name="rule">Объект <see cref="T:System.Security.AccessControl.FileSystemAuditRule" />, представляющий правило аудита, которое необходимо установить для файла или каталога.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rule" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003457 RID: 13399 RVA: 0x000BC683 File Offset: 0x000BA883
		public void SetAuditRule(FileSystemAuditRule rule)
		{
			base.SetAuditRule(rule);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x000173AD File Offset: 0x000155AD
		internal FileSystemSecurity()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
