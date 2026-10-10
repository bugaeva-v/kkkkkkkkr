using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Управляет службами времени жизни удаленного взаимодействия .NET.</summary>
	// Token: 0x0200058A RID: 1418
	[ComVisible(true)]
	public sealed class LifetimeServices
	{
		// Token: 0x0600377E RID: 14206 RVA: 0x000C8044 File Offset: 0x000C6244
		static LifetimeServices()
		{
			LifetimeServices._leaseManagerPollTime = TimeSpan.FromSeconds(10.0);
			LifetimeServices._leaseTime = TimeSpan.FromMinutes(5.0);
			LifetimeServices._renewOnCallTime = TimeSpan.FromMinutes(2.0);
			LifetimeServices._sponsorshipTimeout = TimeSpan.FromMinutes(2.0);
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Runtime.Remoting.Lifetime.LifetimeServices" />.</summary>
		// Token: 0x0600377F RID: 14207 RVA: 0x0000259F File Offset: 0x0000079F
		[Obsolete("Call the static methods directly on this type instead", true)]
		public LifetimeServices()
		{
		}

		/// <summary>Возвращает или задает временной интервал между каждой активацией арендного диспетчера для очистки просроченной аренды.</summary>
		/// <returns>Заданное по умолчанию время бездействия арендного диспетчера после проверки на окончание срока действия аренды.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия. Это исключение создается только при настройке значения свойства.</exception>
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x000C80A7 File Offset: 0x000C62A7
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x000C80AE File Offset: 0x000C62AE
		public static TimeSpan LeaseManagerPollTime
		{
			get
			{
				return LifetimeServices._leaseManagerPollTime;
			}
			set
			{
				LifetimeServices._leaseManagerPollTime = value;
				LifetimeServices._leaseManager.SetPollTime(value);
			}
		}

		/// <summary>Возвращает или задает начальный период аренды для <see cref="T:System.AppDomain" />.</summary>
		/// <returns>Начальный срок аренды <see cref="T:System.TimeSpan" /> для объектов, которые могут иметь аренду в <see cref="T:System.AppDomain" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия. Это исключение создается только при настройке значения свойства.</exception>
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x000C80C1 File Offset: 0x000C62C1
		// (set) Token: 0x06003783 RID: 14211 RVA: 0x000C80C8 File Offset: 0x000C62C8
		public static TimeSpan LeaseTime
		{
			get
			{
				return LifetimeServices._leaseTime;
			}
			set
			{
				LifetimeServices._leaseTime = value;
			}
		}

		/// <summary>Возвращает или задает промежуток времени, на который увеличивается срок аренды после каждого вызова серверного объекта.</summary>
		/// <returns>
		///   <see cref="T:System.TimeSpan" />, на который увеличивается аренда времени жизни в текущем <see cref="T:System.AppDomain" /> после каждого вызова.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия. Это исключение создается только при настройке значения свойства.</exception>
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x000C80D0 File Offset: 0x000C62D0
		// (set) Token: 0x06003785 RID: 14213 RVA: 0x000C80D7 File Offset: 0x000C62D7
		public static TimeSpan RenewOnCallTime
		{
			get
			{
				return LifetimeServices._renewOnCallTime;
			}
			set
			{
				LifetimeServices._renewOnCallTime = value;
			}
		}

		/// <summary>Возвращает или задает время ожидания арендным диспетчером спонсора для возврата со временем продления срока аренды.</summary>
		/// <returns>Начальный тайм-аут для спонсорства.</returns>
		/// <exception cref="T:System.Security.SecurityException">По крайней мере у одного из вызывающих операторов, находящихся в верхней части стека вызовов, отсутствует разрешение на настройку типов и каналов удаленного взаимодействия. Это исключение создается только при настройке значения свойства.</exception>
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x000C80DF File Offset: 0x000C62DF
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x000C80E6 File Offset: 0x000C62E6
		public static TimeSpan SponsorshipTimeout
		{
			get
			{
				return LifetimeServices._sponsorshipTimeout;
			}
			set
			{
				LifetimeServices._sponsorshipTimeout = value;
			}
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000C80EE File Offset: 0x000C62EE
		internal static void TrackLifetime(ServerIdentity identity)
		{
			LifetimeServices._leaseManager.TrackLifetime(identity);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000C80FB File Offset: 0x000C62FB
		internal static void StopTrackingLifetime(ServerIdentity identity)
		{
			LifetimeServices._leaseManager.StopTrackingLifetime(identity);
		}

		// Token: 0x0400259A RID: 9626
		private static TimeSpan _leaseManagerPollTime;

		// Token: 0x0400259B RID: 9627
		private static TimeSpan _leaseTime;

		// Token: 0x0400259C RID: 9628
		private static TimeSpan _renewOnCallTime;

		// Token: 0x0400259D RID: 9629
		private static TimeSpan _sponsorshipTimeout;

		// Token: 0x0400259E RID: 9630
		private static LeaseManager _leaseManager = new LeaseManager();
	}
}
