using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.SecurityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000458 RID: 1112
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.SecurityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002D21 RID: 11553 RVA: 0x000A1DA7 File Offset: 0x0009FFA7
		public SecurityPermissionAttribute(SecurityAction action) : base(action)
		{
			this.m_Flags = SecurityPermissionFlag.NoFlags;
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на подтверждение того, что все вызывающие объекты этого кода имеют необходимое разрешение на выполнение операции.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на подтверждение объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x000A1DB7 File Offset: 0x0009FFB7
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x000A1DC4 File Offset: 0x0009FFC4
		public bool Assertion
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.Assertion) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.Assertion;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.Assertion;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, имеет ли код разрешение на выполнение переадресации привязки в файле конфигурации приложения.</summary>
		/// <returns>Значение <see langword="true" />, если код может выполнять переадресации привязки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000A1DE7 File Offset: 0x0009FFE7
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x000A1DF8 File Offset: 0x0009FFF8
		public bool BindingRedirects
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.BindingRedirects) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.BindingRedirects;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.BindingRedirects;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на управление <see cref="T:System.AppDomain" />.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на управление <see cref="T:System.AppDomain" /> объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000A1E22 File Offset: 0x000A0022
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x000A1E33 File Offset: 0x000A0033
		public bool ControlAppDomain
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlAppDomain) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlAppDomain;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlAppDomain;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на изменение или управление политикой безопасности домена.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на изменение или управление политикой безопасности в домене приложения объявлено. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x000A1E5D File Offset: 0x000A005D
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x000A1E6E File Offset: 0x000A006E
		public bool ControlDomainPolicy
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlDomainPolicy) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlDomainPolicy;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlDomainPolicy;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на изменение или управление свидетельством.</summary>
		/// <returns>
		///   <see langword="true" />, если возможность изменения или управления свидетельством объявлена. В противном случае — <see langword="false" />.</returns>
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000A1E98 File Offset: 0x000A0098
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x000A1EA6 File Offset: 0x000A00A6
		public bool ControlEvidence
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlEvidence) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlEvidence;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlEvidence;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на просмотр и управление политикой безопасности.</summary>
		/// <returns>
		///   <see langword="true" />, если разрешение на управление политикой безопасности объявлено; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000A1ECA File Offset: 0x000A00CA
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x000A1ED8 File Offset: 0x000A00D8
		public bool ControlPolicy
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlPolicy) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlPolicy;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlPolicy;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на управление текущим участником.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на управление текущим участником объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000A1EFC File Offset: 0x000A00FC
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x000A1F0D File Offset: 0x000A010D
		public bool ControlPrincipal
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlPrincipal) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlPrincipal;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlPrincipal;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на обход управления потоками.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на управление потоками объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000A1F37 File Offset: 0x000A0137
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x000A1F45 File Offset: 0x000A0145
		public bool ControlThread
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.ControlThread) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.ControlThread;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.ControlThread;
			}
		}

		/// <summary>Получает или задает значение, указывающее, объявлено ли разрешение на выполнение кода.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на выполнение кода объявлено. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000A1F69 File Offset: 0x000A0169
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x000A1F76 File Offset: 0x000A0176
		public bool Execution
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.Execution) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.Execution;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.Execution;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, может ли код подключиться к инфраструктуре среды CLR (например, добавление Remoting Context Sinks, Envoy Sinks и Dynamic Sinks).</summary>
		/// <returns>
		///   <see langword="true" />, если код может подключиться к инфраструктуре среды CLR; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000A1F99 File Offset: 0x000A0199
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x000A1FAA File Offset: 0x000A01AA
		[ComVisible(true)]
		public bool Infrastructure
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.Infrastructure) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.Infrastructure;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.Infrastructure;
			}
		}

		/// <summary>Получает или задает значение, указывающее, может ли код настраивать каналы и типы удаленного взаимодействия.</summary>
		/// <returns>Значение <see langword="true" />, если код может настраивать каналы и типы удаленного взаимодействия; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000A1FD4 File Offset: 0x000A01D4
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x000A1FE5 File Offset: 0x000A01E5
		public bool RemotingConfiguration
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.RemotingConfiguration) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.RemotingConfiguration;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.RemotingConfiguration;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, может ли код использовать модуль форматирования сериализации для сериализации или десериализации объекта.</summary>
		/// <returns>Значение <see langword="true" />, если код может использовать модуль форматирования сериализации для сериализации или десериализации объекта; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000A200F File Offset: 0x000A020F
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x000A2020 File Offset: 0x000A0220
		public bool SerializationFormatter
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.SerializationFormatter) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.SerializationFormatter;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.SerializationFormatter;
			}
		}

		/// <summary>Получает или задает значение, указывающее, объявлено ли разрешение на обход проверки кода.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на обход проверки кода объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000A204A File Offset: 0x000A024A
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x000A2057 File Offset: 0x000A0257
		public bool SkipVerification
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.SkipVerification) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.SkipVerification;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.SkipVerification;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, объявлено ли разрешение на вызов неуправляемого кода.</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на вызов неуправляемого кода объявлено. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000A207A File Offset: 0x000A027A
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x000A2087 File Offset: 0x000A0287
		public bool UnmanagedCode
		{
			get
			{
				return (this.m_Flags & SecurityPermissionFlag.UnmanagedCode) > SecurityPermissionFlag.NoFlags;
			}
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.UnmanagedCode;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.UnmanagedCode;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.SecurityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.SecurityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002D3E RID: 11582 RVA: 0x000A20AC File Offset: 0x000A02AC
		public override IPermission CreatePermission()
		{
			SecurityPermission result;
			if (base.Unrestricted)
			{
				result = new SecurityPermission(PermissionState.Unrestricted);
			}
			else
			{
				result = new SecurityPermission(this.m_Flags);
			}
			return result;
		}

		/// <summary>Возвращает или задает все флаги разрешения, составляющие разрешения <see cref="T:System.Security.Permissions.SecurityPermission" />.</summary>
		/// <returns>Одно или несколько значений <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />, объединенных с помощью битового оператора ИЛИ.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка задать этому свойству недопустимое значение. Допустимые значения см. в разделе <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />.</exception>
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000A20D9 File Offset: 0x000A02D9
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x000A20E1 File Offset: 0x000A02E1
		public SecurityPermissionFlag Flags
		{
			get
			{
				return this.m_Flags;
			}
			set
			{
				this.m_Flags = value;
			}
		}

		// Token: 0x04002097 RID: 8343
		private SecurityPermissionFlag m_Flags;
	}
}
