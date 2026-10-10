using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Предоставляет возможность управления доступом к собственным объектам без непосредственной работы со списками управления доступом (ACL). Типы собственных объектов определяются перечислением <see cref="T:System.Security.AccessControl.ResourceType" />.</summary>
	// Token: 0x02000535 RID: 1333
	public abstract class NativeObjectSecurity : CommonObjectSecurity
	{
		// Token: 0x060034BC RID: 13500 RVA: 0x000BF9E3 File Offset: 0x000BDBE3
		internal NativeObjectSecurity(CommonSecurityDescriptor securityDescriptor, ResourceType resourceType) : base(securityDescriptor)
		{
			this.resource_type = resourceType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> с использованием указанных значений.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		// Token: 0x060034BD RID: 13501 RVA: 0x000BF9F3 File Offset: 0x000BDBF3
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType) : this(isContainer, resourceType, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, используя указанные значения.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="exceptionFromErrorCode">Делегат, реализованный интеграторами, предоставляющий пользовательские исключения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x060034BE RID: 13502 RVA: 0x000BF9FF File Offset: 0x000BDBFF
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base(isContainer)
		{
			this.exception_from_error_code = exceptionFromErrorCode;
			this.resource_type = resourceType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> с использованием указанных значений. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для включения в этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		// Token: 0x060034BF RID: 13503 RVA: 0x000BFA16 File Offset: 0x000BDC16
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections) : this(isContainer, resourceType, handle, includeSections, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> с использованием указанных значений. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="name">Имя защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для включения в этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		// Token: 0x060034C0 RID: 13504 RVA: 0x000BFA25 File Offset: 0x000BDC25
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections) : this(isContainer, resourceType, name, includeSections, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> с использованием указанных значений. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для включения в этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="exceptionFromErrorCode">Делегат, реализованный интеграторами, предоставляющий пользовательские исключения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x060034C1 RID: 13505 RVA: 0x000BFA34 File Offset: 0x000BDC34
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : this(isContainer, resourceType, exceptionFromErrorCode, exceptionContext)
		{
			this.RaiseExceptionOnFailure(this.InternalGet(handle, includeSections), null, handle, exceptionContext);
			this.ClearAccessControlSectionsModified();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> с использованием указанных значений. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="isContainer">Значение <see langword="true" />, если новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> является объектом контейнера.</param>
		/// <param name="resourceType">Тип защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="name">Имя защищаемого объекта, с которым связан новый объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для включения в этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="exceptionFromErrorCode">Делегат, реализованный интеграторами, предоставляющий пользовательские исключения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		// Token: 0x060034C2 RID: 13506 RVA: 0x000BFA5B File Offset: 0x000BDC5B
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : this(isContainer, resourceType, exceptionFromErrorCode, exceptionContext)
		{
			this.RaiseExceptionOnFailure(this.InternalGet(name, includeSections), name, null, exceptionContext);
			this.ClearAccessControlSectionsModified();
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000BFA84 File Offset: 0x000BDC84
		private void ClearAccessControlSectionsModified()
		{
			base.WriteLock();
			try
			{
				base.AccessControlSectionsModified = AccessControlSections.None;
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор и методы сохранения, были идентичными.</summary>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Защищаемый объект, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, является каталогом или файлом, и ни один из них не найден.</exception>
		// Token: 0x060034C4 RID: 13508 RVA: 0x000BFAB8 File Offset: 0x000BDCB8
		protected sealed override void Persist(SafeHandle handle, AccessControlSections includeSections)
		{
			this.Persist(handle, includeSections, null);
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="name">Имя защищаемого объекта, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Защищаемый объект, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, является каталогом или файлом, и ни один из них не найден.</exception>
		// Token: 0x060034C5 RID: 13509 RVA: 0x000BFAC3 File Offset: 0x000BDCC3
		protected sealed override void Persist(string name, AccessControlSections includeSections)
		{
			this.Persist(name, includeSections, null);
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x000BFAD0 File Offset: 0x000BDCD0
		internal void PersistModifications(SafeHandle handle)
		{
			base.WriteLock();
			try
			{
				this.Persist(handle, base.AccessControlSectionsModified, null);
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Защищаемый объект, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, является каталогом или файлом, и ни один из них не найден.</exception>
		// Token: 0x060034C7 RID: 13511 RVA: 0x000BFB0C File Offset: 0x000BDD0C
		protected void Persist(SafeHandle handle, AccessControlSections includeSections, object exceptionContext)
		{
			base.WriteLock();
			try
			{
				this.RaiseExceptionOnFailure(this.InternalSet(handle, includeSections), null, handle, exceptionContext);
				base.AccessControlSectionsModified &= ~includeSections;
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000BFB58 File Offset: 0x000BDD58
		internal void PersistModifications(string name)
		{
			base.WriteLock();
			try
			{
				this.Persist(name, base.AccessControlSectionsModified, null);
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		/// <summary>Сохраняет указанные разделы дескриптора безопасности, связанные с этим объектом <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, в постоянном хранилище. Рекомендуется, чтобы значения параметров <paramref name="includeSections" />, переданные в конструктор, и методы сохранения были идентичными.</summary>
		/// <param name="name">Имя защищаемого объекта, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="includeSections">Одно из значений перечисления <see cref="T:System.Security.AccessControl.AccessControlSections" />, указывающее разделы дескриптора безопасности (правила доступа, правила аудита, владелец, основная группа) защищаемого объекта для сохранения.</param>
		/// <param name="exceptionContext">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		/// <exception cref="T:System.IO.FileNotFoundException">Защищаемый объект, с которым связан этот объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />, является каталогом или файлом, и ни один из них не найден.</exception>
		// Token: 0x060034C9 RID: 13513 RVA: 0x000BFB94 File Offset: 0x000BDD94
		protected void Persist(string name, AccessControlSections includeSections, object exceptionContext)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			base.WriteLock();
			try
			{
				this.RaiseExceptionOnFailure(this.InternalSet(name, includeSections), name, null, exceptionContext);
				base.AccessControlSectionsModified &= ~includeSections;
			}
			finally
			{
				base.WriteUnlock();
			}
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000BFBF0 File Offset: 0x000BDDF0
		internal static Exception DefaultExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context)
		{
			switch (errorCode)
			{
			case 2:
				return new FileNotFoundException();
			case 3:
				return new DirectoryNotFoundException();
			case 4:
				break;
			case 5:
				return new UnauthorizedAccessException();
			default:
				if (errorCode == 1314)
				{
					return new PrivilegeNotHeldException();
				}
				break;
			}
			return new InvalidOperationException("OS error code " + errorCode.ToString());
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000BFC4D File Offset: 0x000BDE4D
		private void RaiseExceptionOnFailure(int errorCode, string name, SafeHandle handle, object context)
		{
			if (errorCode == 0)
			{
				return;
			}
			throw (this.exception_from_error_code ?? new NativeObjectSecurity.ExceptionFromErrorCode(NativeObjectSecurity.DefaultExceptionFromErrorCode))(errorCode, name, handle, context);
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000BFC74 File Offset: 0x000BDE74
		internal virtual int InternalGet(SafeHandle handle, AccessControlSections includeSections)
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				throw new PlatformNotSupportedException();
			}
			return this.Win32GetHelper(delegate(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor)
			{
				return NativeObjectSecurity.GetSecurityInfo(handle, this.ResourceType, securityInfos, out owner, out group, out dacl, out sacl, out descriptor);
			}, includeSections);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000BFCBC File Offset: 0x000BDEBC
		internal virtual int InternalGet(string name, AccessControlSections includeSections)
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				throw new PlatformNotSupportedException();
			}
			return this.Win32GetHelper(delegate(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor)
			{
				return NativeObjectSecurity.GetNamedSecurityInfo(this.Win32FixName(name), this.ResourceType, securityInfos, out owner, out group, out dacl, out sacl, out descriptor);
			}, includeSections);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000BFD04 File Offset: 0x000BDF04
		internal virtual int InternalSet(SafeHandle handle, AccessControlSections includeSections)
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				throw new PlatformNotSupportedException();
			}
			return this.Win32SetHelper((SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl) => NativeObjectSecurity.SetSecurityInfo(handle, this.ResourceType, securityInfos, owner, group, dacl, sacl), includeSections);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000BFD4C File Offset: 0x000BDF4C
		internal virtual int InternalSet(string name, AccessControlSections includeSections)
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				throw new PlatformNotSupportedException();
			}
			return this.Win32SetHelper((SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl) => NativeObjectSecurity.SetNamedSecurityInfo(this.Win32FixName(name), this.ResourceType, securityInfos, owner, group, dacl, sacl), includeSections);
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x000BFD93 File Offset: 0x000BDF93
		internal ResourceType ResourceType
		{
			get
			{
				return this.resource_type;
			}
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000BFD9C File Offset: 0x000BDF9C
		private int Win32GetHelper(NativeObjectSecurity.GetSecurityInfoNativeCall nativeCall, AccessControlSections includeSections)
		{
			bool flag = (includeSections & AccessControlSections.Owner) > AccessControlSections.None;
			bool flag2 = (includeSections & AccessControlSections.Group) > AccessControlSections.None;
			bool flag3 = (includeSections & AccessControlSections.Access) > AccessControlSections.None;
			bool flag4 = (includeSections & AccessControlSections.Audit) > AccessControlSections.None;
			SecurityInfos securityInfos = (SecurityInfos)0;
			if (flag)
			{
				securityInfos |= SecurityInfos.Owner;
			}
			if (flag2)
			{
				securityInfos |= SecurityInfos.Group;
			}
			if (flag3)
			{
				securityInfos |= SecurityInfos.DiscretionaryAcl;
			}
			if (flag4)
			{
				securityInfos |= SecurityInfos.SystemAcl;
			}
			IntPtr intPtr;
			IntPtr intPtr2;
			IntPtr intPtr3;
			IntPtr intPtr4;
			IntPtr intPtr5;
			int num = nativeCall(securityInfos, out intPtr, out intPtr2, out intPtr3, out intPtr4, out intPtr5);
			if (num != 0)
			{
				return num;
			}
			try
			{
				int num2 = 0;
				if (NativeObjectSecurity.IsValidSecurityDescriptor(intPtr5))
				{
					num2 = NativeObjectSecurity.GetSecurityDescriptorLength(intPtr5);
				}
				byte[] array = new byte[num2];
				Marshal.Copy(intPtr5, array, 0, num2);
				base.SetSecurityDescriptorBinaryForm(array, includeSections);
			}
			finally
			{
				NativeObjectSecurity.LocalFree(intPtr5);
			}
			return 0;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000BFE4C File Offset: 0x000BE04C
		private int Win32SetHelper(NativeObjectSecurity.SetSecurityInfoNativeCall nativeCall, AccessControlSections includeSections)
		{
			if (includeSections == AccessControlSections.None)
			{
				return 0;
			}
			SecurityInfos securityInfos = (SecurityInfos)0;
			byte[] array = null;
			byte[] array2 = null;
			byte[] array3 = null;
			byte[] array4 = null;
			if ((includeSections & AccessControlSections.Owner) != AccessControlSections.None)
			{
				securityInfos |= SecurityInfos.Owner;
				SecurityIdentifier securityIdentifier = (SecurityIdentifier)base.GetOwner(typeof(SecurityIdentifier));
				if (null != securityIdentifier)
				{
					array = new byte[securityIdentifier.BinaryLength];
					securityIdentifier.GetBinaryForm(array, 0);
				}
			}
			if ((includeSections & AccessControlSections.Group) != AccessControlSections.None)
			{
				securityInfos |= SecurityInfos.Group;
				SecurityIdentifier securityIdentifier2 = (SecurityIdentifier)base.GetGroup(typeof(SecurityIdentifier));
				if (null != securityIdentifier2)
				{
					array2 = new byte[securityIdentifier2.BinaryLength];
					securityIdentifier2.GetBinaryForm(array2, 0);
				}
			}
			if ((includeSections & AccessControlSections.Access) != AccessControlSections.None)
			{
				securityInfos |= SecurityInfos.DiscretionaryAcl;
				if (base.AreAccessRulesProtected)
				{
					securityInfos |= (SecurityInfos)(-2147483648);
				}
				else
				{
					securityInfos |= (SecurityInfos)536870912;
				}
				array3 = new byte[this.descriptor.DiscretionaryAcl.BinaryLength];
				this.descriptor.DiscretionaryAcl.GetBinaryForm(array3, 0);
			}
			if ((includeSections & AccessControlSections.Audit) != AccessControlSections.None && this.descriptor.SystemAcl != null)
			{
				securityInfos |= SecurityInfos.SystemAcl;
				if (base.AreAuditRulesProtected)
				{
					securityInfos |= (SecurityInfos)1073741824;
				}
				else
				{
					securityInfos |= (SecurityInfos)268435456;
				}
				array4 = new byte[this.descriptor.SystemAcl.BinaryLength];
				this.descriptor.SystemAcl.GetBinaryForm(array4, 0);
			}
			return nativeCall(securityInfos, array, array2, array3, array4);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000BFF9A File Offset: 0x000BE19A
		private string Win32FixName(string name)
		{
			if (this.ResourceType == ResourceType.RegistryKey)
			{
				if (!name.StartsWith("HKEY_"))
				{
					throw new InvalidOperationException();
				}
				name = name.Substring("HKEY_".Length);
			}
			return name;
		}

		// Token: 0x060034D4 RID: 13524
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetSecurityInfo(SafeHandle handle, ResourceType resourceType, SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor);

		// Token: 0x060034D5 RID: 13525
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetNamedSecurityInfo(string name, ResourceType resourceType, SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor);

		// Token: 0x060034D6 RID: 13526
		[DllImport("kernel32.dll")]
		private static extern IntPtr LocalFree(IntPtr handle);

		// Token: 0x060034D7 RID: 13527
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int SetSecurityInfo(SafeHandle handle, ResourceType resourceType, SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl);

		// Token: 0x060034D8 RID: 13528
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int SetNamedSecurityInfo(string name, ResourceType resourceType, SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl);

		// Token: 0x060034D9 RID: 13529
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetSecurityDescriptorLength(IntPtr descriptor);

		// Token: 0x060034DA RID: 13530
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsValidSecurityDescriptor(IntPtr descriptor);

		// Token: 0x040024B8 RID: 9400
		private NativeObjectSecurity.ExceptionFromErrorCode exception_from_error_code;

		// Token: 0x040024B9 RID: 9401
		private ResourceType resource_type;

		/// <summary>Обеспечивает для интеграторов способ сопоставления числовых кодов ошибок с конкретными создаваемыми ими исключениями.</summary>
		/// <param name="errorCode">Числовой код ошибки.</param>
		/// <param name="name">Имя защищаемого объекта, с которым связан объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="handle">Дескриптор защищаемого объекта, с которым связан объект <see cref="T:System.Security.AccessControl.NativeObjectSecurity" />.</param>
		/// <param name="context">Объект, содержащий контекстные сведения об источнике или назначении исключения.</param>
		/// <returns>Исключение <see cref="T:System.Exception" />, создаваемое этим делегатом.</returns>
		// Token: 0x02000536 RID: 1334
		// (Invoke) Token: 0x060034DC RID: 13532
		protected internal delegate Exception ExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context);

		// Token: 0x02000537 RID: 1335
		// (Invoke) Token: 0x060034E0 RID: 13536
		private delegate int GetSecurityInfoNativeCall(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor);

		// Token: 0x02000538 RID: 1336
		// (Invoke) Token: 0x060034E4 RID: 13540
		private delegate int SetSecurityInfoNativeCall(SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl);
	}
}
