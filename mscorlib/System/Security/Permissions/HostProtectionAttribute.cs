using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Позволяет применять декларативные действия по безопасности для определения требований защиты узла. Этот класс не наследуется.</summary>
	// Token: 0x0200043D RID: 1085
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class HostProtectionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.HostProtectionAttribute" /> со значениями по умолчанию.</summary>
		// Token: 0x06002C0D RID: 11277 RVA: 0x0009ECC4 File Offset: 0x0009CEC4
		public HostProtectionAttribute() : base(SecurityAction.LinkDemand)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.HostProtectionAttribute" /> заданным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> не является <see cref="F:System.Security.Permissions.SecurityAction.LinkDemand" />.</exception>
		// Token: 0x06002C0E RID: 11278 RVA: 0x0009ECCD File Offset: 0x0009CECD
		public HostProtectionAttribute(SecurityAction action) : base(action)
		{
			if (action != SecurityAction.LinkDemand)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Only {0} is accepted."), SecurityAction.LinkDemand), "action");
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли возможность управлять внешними процессами.</summary>
		/// <returns>Значение <see langword="true" />, если возможность управлять внешними процессам предоставляется, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x0009ECFA File Offset: 0x0009CEFA
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x0009ED07 File Offset: 0x0009CF07
		public bool ExternalProcessMgmt
		{
			get
			{
				return (this._resources & HostProtectionResource.ExternalProcessMgmt) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.ExternalProcessMgmt;
					return;
				}
				this._resources &= ~HostProtectionResource.ExternalProcessMgmt;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли возможность управлять внешними потоками.</summary>
		/// <returns>Значение <see langword="true" />, если внешний поток предоставлен, иначе — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x0009ED2A File Offset: 0x0009CF2A
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0009ED38 File Offset: 0x0009CF38
		public bool ExternalThreading
		{
			get
			{
				return (this._resources & HostProtectionResource.ExternalThreading) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.ExternalThreading;
					return;
				}
				this._resources &= ~HostProtectionResource.ExternalThreading;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее, могут ли ресурсы допускать утечку памяти при прерывании операции.</summary>
		/// <returns>Значение <see langword="true" />, если ресурсы могут допускать утечку памяти при прерывании операции, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x0009ED5C File Offset: 0x0009CF5C
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x0009ED6D File Offset: 0x0009CF6D
		public bool MayLeakOnAbort
		{
			get
			{
				return (this._resources & HostProtectionResource.MayLeakOnAbort) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.MayLeakOnAbort;
					return;
				}
				this._resources &= ~HostProtectionResource.MayLeakOnAbort;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли инфраструктура безопасности.</summary>
		/// <returns>Значение <see langword="true" />, если инфраструктура безопасности предоставляется; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x0009ED97 File Offset: 0x0009CF97
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x0009EDA5 File Offset: 0x0009CFA5
		[ComVisible(true)]
		public bool SecurityInfrastructure
		{
			get
			{
				return (this._resources & HostProtectionResource.SecurityInfrastructure) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.SecurityInfrastructure;
					return;
				}
				this._resources &= ~HostProtectionResource.SecurityInfrastructure;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли процессам возможность влиять на свое выполнение.</summary>
		/// <returns>Значение <see langword="true" />, если управление влияющего на себя процесса предоставлено, иначе — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x0009EDC9 File Offset: 0x0009CFC9
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x0009EDD6 File Offset: 0x0009CFD6
		public bool SelfAffectingProcessMgmt
		{
			get
			{
				return (this._resources & HostProtectionResource.SelfAffectingProcessMgmt) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.SelfAffectingProcessMgmt;
					return;
				}
				this._resources &= ~HostProtectionResource.SelfAffectingProcessMgmt;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли потокам возможность влиять на свое выполнение.</summary>
		/// <returns>Значение <see langword="true" />, если влияющий на себя поток предоставлен, иначе — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0009EDF9 File Offset: 0x0009CFF9
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x0009EE07 File Offset: 0x0009D007
		public bool SelfAffectingThreading
		{
			get
			{
				return (this._resources & HostProtectionResource.SelfAffectingThreading) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.SelfAffectingThreading;
					return;
				}
				this._resources &= ~HostProtectionResource.SelfAffectingThreading;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли потокам возможность использовать общее состояние.</summary>
		/// <returns>Значение <see langword="true" />, если совместный доступ предоставлен, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0009EE2B File Offset: 0x0009D02B
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x0009EE38 File Offset: 0x0009D038
		public bool SharedState
		{
			get
			{
				return (this._resources & HostProtectionResource.SharedState) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.SharedState;
					return;
				}
				this._resources &= ~HostProtectionResource.SharedState;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли возможность синхронизации.</summary>
		/// <returns>Значение <see langword="true" />, если возможность синхронизации предоставляется; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x0009EE5B File Offset: 0x0009D05B
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x0009EE68 File Offset: 0x0009D068
		public bool Synchronization
		{
			get
			{
				return (this._resources & HostProtectionResource.Synchronization) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.Synchronization;
					return;
				}
				this._resources &= ~HostProtectionResource.Synchronization;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, предоставляется ли пользовательский интерфейс.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс предоставлен, если нет — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x0009EE8B File Offset: 0x0009D08B
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x0009EE9C File Offset: 0x0009D09C
		public bool UI
		{
			get
			{
				return (this._resources & HostProtectionResource.UI) > HostProtectionResource.None;
			}
			set
			{
				if (value)
				{
					this._resources |= HostProtectionResource.UI;
					return;
				}
				this._resources &= ~HostProtectionResource.UI;
			}
		}

		/// <summary>Возвращает или задает флаги, определяющие категории функциональных возможностей, которые могут быть потенциально опасны для узла.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.HostProtectionResource" />. Значение по умолчанию — <see cref="F:System.Security.Permissions.HostProtectionResource.None" />.</returns>
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x0009EEC6 File Offset: 0x0009D0C6
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x0009EECE File Offset: 0x0009D0CE
		public HostProtectionResource Resources
		{
			get
			{
				return this._resources;
			}
			set
			{
				this._resources = value;
			}
		}

		/// <summary>Создает и возвращает новое разрешение защиты узла.</summary>
		/// <returns>Значение <see cref="T:System.Security.IPermission" />, соответствующее текущему атрибуту.</returns>
		// Token: 0x06002C23 RID: 11299 RVA: 0x0009EED7 File Offset: 0x0009D0D7
		public override IPermission CreatePermission()
		{
			return new HostProtectionPermission(this._resources);
		}

		// Token: 0x0400202D RID: 8237
		private HostProtectionResource _resources;
	}
}
