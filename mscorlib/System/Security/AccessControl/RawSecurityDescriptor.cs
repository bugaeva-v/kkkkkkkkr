using System;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Представляет дескриптор безопасности. Дескриптор безопасности включает владельца, основную группу, список управления доступом на уровне пользователей (DACL) и системный список управления доступом управления (SACL).</summary>
	// Token: 0x02000546 RID: 1350
	public sealed class RawSecurityDescriptor : GenericSecurityDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> на основании указанной строки SDDL (Security Descriptor Definition Language).</summary>
		/// <param name="sddlForm">Строка SDDL, на основании которой создается новый объект <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		// Token: 0x06003575 RID: 13685 RVA: 0x000C1585 File Offset: 0x000BF785
		public RawSecurityDescriptor(string sddlForm)
		{
			if (sddlForm == null)
			{
				throw new ArgumentNullException("sddlForm");
			}
			this.ParseSddl(sddlForm.Replace(" ", ""));
			this.control_flags |= ControlFlags.SelfRelative;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> на основании указанного массива байтовых значений.</summary>
		/// <param name="binaryForm">Массив байтовых значений, на основании которого необходимо создать новый объект <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		/// <param name="offset">Позиция в массиве <paramref name="binaryForm" />, с которой начинается копирование.</param>
		// Token: 0x06003576 RID: 13686 RVA: 0x000C15C4 File Offset: 0x000BF7C4
		public RawSecurityDescriptor(byte[] binaryForm, int offset)
		{
			if (binaryForm == null)
			{
				throw new ArgumentNullException("binaryForm");
			}
			if (offset < 0 || offset > binaryForm.Length - 20)
			{
				throw new ArgumentOutOfRangeException("offset", offset, "Offset out of range");
			}
			if (binaryForm[offset] != 1)
			{
				throw new ArgumentException("Unrecognized Security Descriptor revision.", "binaryForm");
			}
			this.resourcemgr_control = binaryForm[offset + 1];
			this.control_flags = (ControlFlags)this.ReadUShort(binaryForm, offset + 2);
			int num = this.ReadInt(binaryForm, offset + 4);
			int num2 = this.ReadInt(binaryForm, offset + 8);
			int num3 = this.ReadInt(binaryForm, offset + 12);
			int num4 = this.ReadInt(binaryForm, offset + 16);
			if (num != 0)
			{
				this.owner_sid = new SecurityIdentifier(binaryForm, num);
			}
			if (num2 != 0)
			{
				this.group_sid = new SecurityIdentifier(binaryForm, num2);
			}
			if (num3 != 0)
			{
				this.system_acl = new RawAcl(binaryForm, num3);
			}
			if (num4 != 0)
			{
				this.discretionary_acl = new RawAcl(binaryForm, num4);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> с использованием указанных значений.</summary>
		/// <param name="flags">Флаги, определяющие поведение нового объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		/// <param name="owner">Владелец нового объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		/// <param name="group">Основная группа для нового объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		/// <param name="systemAcl">Системный список управления доступом нового объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		/// <param name="discretionaryAcl">Список управления доступом на уровне пользователей нового объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</param>
		// Token: 0x06003577 RID: 13687 RVA: 0x000C16A7 File Offset: 0x000BF8A7
		public RawSecurityDescriptor(ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, RawAcl systemAcl, RawAcl discretionaryAcl)
		{
			this.control_flags = flags;
			this.owner_sid = owner;
			this.group_sid = group;
			this.system_acl = systemAcl;
			this.discretionary_acl = discretionaryAcl;
		}

		/// <summary>Возвращает значения, которые определяют поведение <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> объекта.</summary>
		/// <returns>Одно или несколько значений перечисления <see cref="T:System.Security.AccessControl.ControlFlags" />, объединенных с помощью логической операции ИЛИ.</returns>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000C16D4 File Offset: 0x000BF8D4
		public override ControlFlags ControlFlags
		{
			get
			{
				return this.control_flags;
			}
		}

		/// <summary>Получает или задает список управления доступом на уровне пользователей для данного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />. Список управления доступом на уровне пользователей содержит правила доступа.</summary>
		/// <returns>Список управления доступом на уровне пользователей для данного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</returns>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x000C16DC File Offset: 0x000BF8DC
		// (set) Token: 0x0600357A RID: 13690 RVA: 0x000C16E4 File Offset: 0x000BF8E4
		public RawAcl DiscretionaryAcl
		{
			get
			{
				return this.discretionary_acl;
			}
			set
			{
				this.discretionary_acl = value;
			}
		}

		/// <summary>Возвращает или задает основную группу для этого объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</summary>
		/// <returns>Основная группа для этого объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</returns>
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x000C16ED File Offset: 0x000BF8ED
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x000C16F5 File Offset: 0x000BF8F5
		public override SecurityIdentifier Group
		{
			get
			{
				return this.group_sid;
			}
			set
			{
				this.group_sid = value;
			}
		}

		/// <summary>Возвращает или задает владельца объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</summary>
		/// <returns>Владелец объекта, связанного с этим объектом <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</returns>
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000C16FE File Offset: 0x000BF8FE
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x000C1706 File Offset: 0x000BF906
		public override SecurityIdentifier Owner
		{
			get
			{
				return this.owner_sid;
			}
			set
			{
				this.owner_sid = value;
			}
		}

		/// <summary>Получает или задает байтовое значение, которое представляет управляющие биты диспетчера ресурсов, связанные с данным объектом <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</summary>
		/// <returns>Байтовое значение, которое представляет управляющие биты диспетчера ресурсов, связанные с данным объектом <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</returns>
		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x000C170F File Offset: 0x000BF90F
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x000C1717 File Offset: 0x000BF917
		public byte ResourceManagerControl
		{
			get
			{
				return this.resourcemgr_control;
			}
			set
			{
				this.resourcemgr_control = value;
			}
		}

		/// <summary>Получает или задает системный список управления доступом для данного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />. Системный список управления доступом содержит правила аудита.</summary>
		/// <returns>Системный список управления доступом для данного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</returns>
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x000C1720 File Offset: 0x000BF920
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x000C1728 File Offset: 0x000BF928
		public RawAcl SystemAcl
		{
			get
			{
				return this.system_acl;
			}
			set
			{
				this.system_acl = value;
			}
		}

		/// <summary>Устанавливает указанное значение для свойства <see cref="P:System.Security.AccessControl.RawSecurityDescriptor.ControlFlags" /> данного объекта <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" />.</summary>
		/// <param name="flags">Одно или несколько значений перечисления <see cref="T:System.Security.AccessControl.ControlFlags" />, объединенных с помощью логической операции ИЛИ.</param>
		// Token: 0x06003583 RID: 13699 RVA: 0x000C1731 File Offset: 0x000BF931
		public void SetFlags(ControlFlags flags)
		{
			this.control_flags = (flags | ControlFlags.SelfRelative);
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x000C1740 File Offset: 0x000BF940
		internal override GenericAcl InternalDacl
		{
			get
			{
				return this.DiscretionaryAcl;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x000C1748 File Offset: 0x000BF948
		internal override GenericAcl InternalSacl
		{
			get
			{
				return this.SystemAcl;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x000C1750 File Offset: 0x000BF950
		internal override byte InternalReservedField
		{
			get
			{
				return this.ResourceManagerControl;
			}
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000C1758 File Offset: 0x000BF958
		private void ParseSddl(string sddlForm)
		{
			ControlFlags controlFlags = ControlFlags.None;
			int i = 0;
			while (i < sddlForm.Length - 2)
			{
				string a = sddlForm.Substring(i, 2);
				if (!(a == "O:"))
				{
					if (!(a == "G:"))
					{
						if (!(a == "D:"))
						{
							if (!(a == "S:"))
							{
								throw new ArgumentException("Invalid SDDL.", "sddlForm");
							}
							i += 2;
							this.SystemAcl = RawAcl.ParseSddlForm(sddlForm, false, ref controlFlags, ref i);
							controlFlags |= ControlFlags.SystemAclPresent;
						}
						else
						{
							i += 2;
							this.DiscretionaryAcl = RawAcl.ParseSddlForm(sddlForm, true, ref controlFlags, ref i);
							controlFlags |= ControlFlags.DiscretionaryAclPresent;
						}
					}
					else
					{
						i += 2;
						this.Group = SecurityIdentifier.ParseSddlForm(sddlForm, ref i);
					}
				}
				else
				{
					i += 2;
					this.Owner = SecurityIdentifier.ParseSddlForm(sddlForm, ref i);
				}
			}
			if (i != sddlForm.Length)
			{
				throw new ArgumentException("Invalid SDDL.", "sddlForm");
			}
			this.SetFlags(controlFlags);
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000C1577 File Offset: 0x000BF777
		private ushort ReadUShort(byte[] buffer, int offset)
		{
			return (ushort)((int)buffer[offset] | (int)buffer[offset + 1] << 8);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000C184A File Offset: 0x000BFA4A
		private int ReadInt(byte[] buffer, int offset)
		{
			return (int)buffer[offset] | (int)buffer[offset + 1] << 8 | (int)buffer[offset + 2] << 16 | (int)buffer[offset + 3] << 24;
		}

		// Token: 0x040024D7 RID: 9431
		private ControlFlags control_flags;

		// Token: 0x040024D8 RID: 9432
		private SecurityIdentifier owner_sid;

		// Token: 0x040024D9 RID: 9433
		private SecurityIdentifier group_sid;

		// Token: 0x040024DA RID: 9434
		private RawAcl system_acl;

		// Token: 0x040024DB RID: 9435
		private RawAcl discretionary_acl;

		// Token: 0x040024DC RID: 9436
		private byte resourcemgr_control;
	}
}
