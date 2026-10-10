using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет дескриптор безопасности. Дескриптор безопасности включает владельца, основную группу, список управления доступом на уровне пользователей (DACL) и системный список управления доступом управления (SACL).</summary>
	// Token: 0x02000517 RID: 1303
	public sealed class CommonSecurityDescriptor : GenericSecurityDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> на основании указанного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом-контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом каталога.</param>
		/// <param name="rawSecurityDescriptor">Объект <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />, из которого создается новый объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		// Token: 0x060033B1 RID: 13233 RVA: 0x000BDCE4 File Offset: 0x000BBEE4
		public CommonSecurityDescriptor(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor)
		{
			this.Init(isContainer, isDS, rawSecurityDescriptor);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> на основании указанной строки SDDL (Security Descriptor Definition Language).</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом-контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом каталога.</param>
		/// <param name="sddlForm">Строка SDDL, на основании которой создается новый объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		// Token: 0x060033B2 RID: 13234 RVA: 0x000BDCF5 File Offset: 0x000BBEF5
		public CommonSecurityDescriptor(bool isContainer, bool isDS, string sddlForm)
		{
			this.Init(isContainer, isDS, new RawSecurityDescriptor(sddlForm));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> на основании указанного массива байтовых значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом-контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом каталога.</param>
		/// <param name="binaryForm">Массив байтовых значений, на основании которого необходимо создать новый объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		/// <param name="offset">Позиция в массиве <paramref name="binaryForm" />, с которой начинается копирование.</param>
		// Token: 0x060033B3 RID: 13235 RVA: 0x000BDD0B File Offset: 0x000BBF0B
		public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset)
		{
			this.Init(isContainer, isDS, new RawSecurityDescriptor(binaryForm, offset));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> на основании указанных сведений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом-контейнером.</param>
		/// <param name="isDS">Значение <see langword="true" />, если новый дескриптор безопасности связан с объектом каталога.</param>
		/// <param name="flags">Флаги, определяющие поведение нового объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		/// <param name="owner">Владелец нового объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		/// <param name="group">Основная группа для нового объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		/// <param name="systemAcl">Системный список управления доступом нового объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		/// <param name="discretionaryAcl">Список управления доступом на уровне пользователей нового объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</param>
		// Token: 0x060033B4 RID: 13236 RVA: 0x000BDD23 File Offset: 0x000BBF23
		public CommonSecurityDescriptor(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl)
		{
			this.Init(isContainer, isDS, flags, owner, group, systemAcl, discretionaryAcl);
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000BDD3C File Offset: 0x000BBF3C
		private void Init(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor)
		{
			if (rawSecurityDescriptor == null)
			{
				throw new ArgumentNullException("rawSecurityDescriptor");
			}
			SystemAcl systemAcl = null;
			if (rawSecurityDescriptor.SystemAcl != null)
			{
				systemAcl = new SystemAcl(isContainer, isDS, rawSecurityDescriptor.SystemAcl);
			}
			DiscretionaryAcl discretionaryAcl = null;
			if (rawSecurityDescriptor.DiscretionaryAcl != null)
			{
				discretionaryAcl = new DiscretionaryAcl(isContainer, isDS, rawSecurityDescriptor.DiscretionaryAcl);
			}
			this.Init(isContainer, isDS, rawSecurityDescriptor.ControlFlags, rawSecurityDescriptor.Owner, rawSecurityDescriptor.Group, systemAcl, discretionaryAcl);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x000BDDA3 File Offset: 0x000BBFA3
		private void Init(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl)
		{
			this.flags = (flags & ~ControlFlags.SystemAclPresent);
			this.is_container = isContainer;
			this.is_ds = isDS;
			this.Owner = owner;
			this.Group = group;
			this.SystemAcl = systemAcl;
			this.DiscretionaryAcl = discretionaryAcl;
		}

		/// <summary>Возвращает значения, которые определяют поведение <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> объекта.</summary>
		/// <returns>Одно или несколько значений перечисления <see cref="T:System.Security.AccessControl.ControlFlags" />, объединенных с помощью логической операции ИЛИ.</returns>
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000BDDE0 File Offset: 0x000BBFE0
		public override ControlFlags ControlFlags
		{
			get
			{
				ControlFlags controlFlags = this.flags;
				controlFlags |= ControlFlags.DiscretionaryAclPresent;
				controlFlags |= ControlFlags.SelfRelative;
				if (this.SystemAcl != null)
				{
					controlFlags |= ControlFlags.SystemAclPresent;
				}
				return controlFlags;
			}
		}

		/// <summary>Получает или задает список управления доступом на уровне пользователей для данного объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />. Список управления доступом на уровне пользователей содержит правила доступа.</summary>
		/// <returns>Список управления доступом на уровне пользователей для данного объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</returns>
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x000BDE0E File Offset: 0x000BC00E
		// (set) Token: 0x060033B9 RID: 13241 RVA: 0x000BDE18 File Offset: 0x000BC018
		public DiscretionaryAcl DiscretionaryAcl
		{
			get
			{
				return this.discretionary_acl;
			}
			set
			{
				if (value == null)
				{
					value = new DiscretionaryAcl(this.IsContainer, this.IsDS, 1);
					value.AddAccess(AccessControlType.Allow, new SecurityIdentifier("WD"), -1, this.IsContainer ? (InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit) : InheritanceFlags.None, PropagationFlags.None);
					value.IsAefa = true;
				}
				this.CheckAclConsistency(value);
				this.discretionary_acl = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x000BDE70 File Offset: 0x000BC070
		internal override GenericAcl InternalDacl
		{
			get
			{
				return this.DiscretionaryAcl;
			}
		}

		/// <summary>Возвращает или задает основную группу для этого объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</summary>
		/// <returns>Основная группа для этого объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</returns>
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x000BDE78 File Offset: 0x000BC078
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x000BDE80 File Offset: 0x000BC080
		public override SecurityIdentifier Group
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		/// <summary>Получает логическое значение, которое указывает, связан ли данный объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> с объектом-контейнером.</summary>
		/// <returns>Значение <see langword="true" />, если объект связан с объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />, являющимся контейнером; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x000BDE89 File Offset: 0x000BC089
		public bool IsContainer
		{
			get
			{
				return this.is_container;
			}
		}

		/// <summary>Получает логическое значение, указывающее, размещены ли элементы связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> списка управления доступом на уровне пользователей в каноническом порядке.</summary>
		/// <returns>Значение <see langword="true" />, если элементы связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> списка управления доступом на уровне пользователей размещены в каноническом порядке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x000BDE91 File Offset: 0x000BC091
		public bool IsDiscretionaryAclCanonical
		{
			get
			{
				return this.DiscretionaryAcl.IsCanonical;
			}
		}

		/// <summary>Получает логическое значение, которое указывает, связан ли данный объект <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> с объектом каталога.</summary>
		/// <returns>Значение <see langword="true" />, если объект, связанный с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />, является объектом каталога; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000BDE9E File Offset: 0x000BC09E
		public bool IsDS
		{
			get
			{
				return this.is_ds;
			}
		}

		/// <summary>Получает логическое значение, указывающее, размещены ли элементы связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> системного списка управления доступом в каноническом порядке.</summary>
		/// <returns>Значение <see langword="true" />, если элементы связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> системного списка управления доступом размещены в каноническом порядке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x000BDEA6 File Offset: 0x000BC0A6
		public bool IsSystemAclCanonical
		{
			get
			{
				return this.SystemAcl == null || this.SystemAcl.IsCanonical;
			}
		}

		/// <summary>Возвращает или задает владельца объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</summary>
		/// <returns>Владелец объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</returns>
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000BDEBD File Offset: 0x000BC0BD
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x000BDEC5 File Offset: 0x000BC0C5
		public override SecurityIdentifier Owner
		{
			get
			{
				return this.owner;
			}
			set
			{
				this.owner = value;
			}
		}

		/// <summary>Получает или задает системный список управления доступом для данного объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />. Системный список управления доступом содержит правила аудита.</summary>
		/// <returns>Системный список управления доступом для данного объекта <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</returns>
		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000BDECE File Offset: 0x000BC0CE
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x000BDED6 File Offset: 0x000BC0D6
		public SystemAcl SystemAcl
		{
			get
			{
				return this.system_acl;
			}
			set
			{
				if (value != null)
				{
					this.CheckAclConsistency(value);
				}
				this.system_acl = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000BDEE9 File Offset: 0x000BC0E9
		internal override GenericAcl InternalSacl
		{
			get
			{
				return this.SystemAcl;
			}
		}

		/// <summary>Удаляет все правила доступа для указанного идентификатора безопасности из списка управления доступом на уровне пользователей, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</summary>
		/// <param name="sid">Идентификатор безопасности, для которого удаляются правила доступа.</param>
		// Token: 0x060033C6 RID: 13254 RVA: 0x000BDEF1 File Offset: 0x000BC0F1
		public void PurgeAccessControl(SecurityIdentifier sid)
		{
			this.DiscretionaryAcl.Purge(sid);
		}

		/// <summary>Удаляет все правила аудита для указанного идентификатора безопасности из системного списка управления доступом, связанного с текущим объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />.</summary>
		/// <param name="sid">Идентификатор безопасности, для которого удаляются правила аудита.</param>
		// Token: 0x060033C7 RID: 13255 RVA: 0x000BDEFF File Offset: 0x000BC0FF
		public void PurgeAudit(SecurityIdentifier sid)
		{
			if (this.SystemAcl != null)
			{
				this.SystemAcl.Purge(sid);
			}
		}

		/// <summary>Задает защиту от наследования для списка управления доступом на уровне пользователей, связанного с данным объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />. Защищенные списки управления доступом на уровне пользователей не наследуют правила доступа у родительских контейнеров.</summary>
		/// <param name="isProtected">Значение <see langword="true" />, если список управления доступом на уровне пользователей защищается от наследования.</param>
		/// <param name="preserveInheritance">Значение <see langword="true" /> для сохранения наследуемых правил доступа в списке управления доступом на уровне пользователей; значение <see langword="false" /> для удаления наследуемых правил доступа из списка управления доступом на уровне пользователей.</param>
		// Token: 0x060033C8 RID: 13256 RVA: 0x000BDF18 File Offset: 0x000BC118
		public void SetDiscretionaryAclProtection(bool isProtected, bool preserveInheritance)
		{
			this.DiscretionaryAcl.IsAefa = false;
			if (!isProtected)
			{
				this.flags &= ~ControlFlags.DiscretionaryAclProtected;
				return;
			}
			this.flags |= ControlFlags.DiscretionaryAclProtected;
			if (!preserveInheritance)
			{
				this.DiscretionaryAcl.RemoveInheritedAces();
			}
		}

		/// <summary>Задает защиту от наследования для системного списка управления доступом, связанного с данным объектом <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" />. Защищенные системные списки управления доступом не наследуют правила аудита у родительских контейнеров.</summary>
		/// <param name="isProtected">Значение <see langword="true" />, если системный список управления доступом защищается от наследования.</param>
		/// <param name="preserveInheritance">Значение <see langword="true" /> для сохранения наследуемых правил аудита в системном списке управления доступом; значение <see langword="false" /> для удаления наследуемых правил аудита из системного списка управления доступом.</param>
		// Token: 0x060033C9 RID: 13257 RVA: 0x000BDF67 File Offset: 0x000BC167
		public void SetSystemAclProtection(bool isProtected, bool preserveInheritance)
		{
			if (!isProtected)
			{
				this.flags &= ~ControlFlags.SystemAclProtected;
				return;
			}
			this.flags |= ControlFlags.SystemAclProtected;
			if (!preserveInheritance && this.SystemAcl != null)
			{
				this.SystemAcl.RemoveInheritedAces();
			}
		}

		/// <summary>Задает свойство <see cref="P:System.Security.AccessControl.CommonSecurityDescriptor.DiscretionaryAcl" /> для этого экземпляра <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> и задает флаг <see cref="F:System.Security.AccessControl.ControlFlags.DiscretionaryAclPresent" />.</summary>
		/// <param name="revision">Номер редакции нового объекта <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />.</param>
		/// <param name="trusted">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.DiscretionaryAcl" />. Это число будет использоваться только для справки.</param>
		// Token: 0x060033CA RID: 13258 RVA: 0x000BDFA7 File Offset: 0x000BC1A7
		public void AddDiscretionaryAcl(byte revision, int trusted)
		{
			this.DiscretionaryAcl = new DiscretionaryAcl(this.IsContainer, this.IsDS, revision, trusted);
			this.flags |= ControlFlags.DiscretionaryAclPresent;
		}

		/// <summary>Задает свойство <see cref="P:System.Security.AccessControl.CommonSecurityDescriptor.SystemAcl" /> для этого экземпляра <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> и задает флаг <see cref="F:System.Security.AccessControl.ControlFlags.SystemAclPresent" />.</summary>
		/// <param name="revision">Номер редакции нового объекта <see cref="T:System.Security.AccessControl.SystemAcl" />.</param>
		/// <param name="trusted">Количество элементов управления доступом, которые могут содержаться в данном объекте <see cref="T:System.Security.AccessControl.SystemAcl" />. Это число должно использоваться только как указание.</param>
		// Token: 0x060033CB RID: 13259 RVA: 0x000BDFD0 File Offset: 0x000BC1D0
		public void AddSystemAcl(byte revision, int trusted)
		{
			this.SystemAcl = new SystemAcl(this.IsContainer, this.IsDS, revision, trusted);
			this.flags |= ControlFlags.SystemAclPresent;
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x000BDFFA File Offset: 0x000BC1FA
		private void CheckAclConsistency(CommonAcl acl)
		{
			if (this.IsContainer != acl.IsContainer)
			{
				throw new ArgumentException("IsContainer must match between descriptor and ACL.");
			}
			if (this.IsDS != acl.IsDS)
			{
				throw new ArgumentException("IsDS must match between descriptor and ACL.");
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000BE02E File Offset: 0x000BC22E
		internal override bool DaclIsUnmodifiedAefa
		{
			get
			{
				return this.DiscretionaryAcl.IsAefa;
			}
		}

		// Token: 0x04002456 RID: 9302
		private bool is_container;

		// Token: 0x04002457 RID: 9303
		private bool is_ds;

		// Token: 0x04002458 RID: 9304
		private ControlFlags flags;

		// Token: 0x04002459 RID: 9305
		private SecurityIdentifier owner;

		// Token: 0x0400245A RID: 9306
		private SecurityIdentifier group;

		// Token: 0x0400245B RID: 9307
		private SystemAcl system_acl;

		// Token: 0x0400245C RID: 9308
		private DiscretionaryAcl discretionary_acl;
	}
}
