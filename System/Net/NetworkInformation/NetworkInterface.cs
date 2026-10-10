using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет конфигурацию и статистические данные для сетевого интерфейса.</summary>
	// Token: 0x020006F8 RID: 1784
	public abstract class NetworkInterface
	{
		/// <summary>Возвращает объекты, описывающие сетевые интерфейсы локального компьютера.</summary>
		/// <returns>Массив <see cref="T:System.Net.NetworkInformation.NetworkInterface" />, который содержит объекты, описывающий доступные сетевые интерфейсы, или пустой массив, если интерфейсы не обнаружены.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова системной функции Windows.</exception>
		// Token: 0x06003958 RID: 14680 RVA: 0x000C87A3 File Offset: 0x000C69A3
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			return SystemNetworkInterface.GetNetworkInterfaces();
		}

		/// <summary>Указывает, доступно ли сетевое подключение.</summary>
		/// <returns>Значение <see langword="true" />, если доступно сетевое подключение; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003959 RID: 14681 RVA: 0x000C87AA File Offset: 0x000C69AA
		public static bool GetIsNetworkAvailable()
		{
			return SystemNetworkInterface.InternalGetIsNetworkAvailable();
		}

		/// <summary>Возвращает индекс интерфейса замыкания на себя IPv4.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее индекс интерфейса замыкания на себя IPv4.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Это свойство не поддерживается на компьютерах, работающих только по протоколу IPv6.</exception>
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x000C87B1 File Offset: 0x000C69B1
		public static int LoopbackInterfaceIndex
		{
			get
			{
				return SystemNetworkInterface.InternalLoopbackInterfaceIndex;
			}
		}

		/// <summary>Получает индекс интерфейса замыкания на себя IPv6.</summary>
		/// <returns>Индекс интерфейса замыкания на себя IPv6.</returns>
		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x000C87B8 File Offset: 0x000C69B8
		public static int IPv6LoopbackInterfaceIndex
		{
			get
			{
				return SystemNetworkInterface.InternalIPv6LoopbackInterfaceIndex;
			}
		}

		/// <summary>Возвращает идентификатор сетевого адаптера.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая идентификатор.</returns>
		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual string Id
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает имя сетевого адаптера.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит имя адаптера.</returns>
		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual string Name
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает описание интерфейса.</summary>
		/// <returns>Строка <see cref="T:System.String" />, описывающая интерфейс.</returns>
		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual string Description
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает объект, описывающий конфигурацию сетевого интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPInterfaceProperties" />, описывающий сетевой интерфейс.</returns>
		// Token: 0x0600395F RID: 14687 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual IPInterfaceProperties GetIPProperties()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает статистику IPv4 для этого экземпляра <see cref="T:System.Net.NetworkInformation.NetworkInterface" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPv4InterfaceStatistics" />.</returns>
		// Token: 0x06003960 RID: 14688 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual IPv4InterfaceStatistics GetIPv4Statistics()
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает статистику IP для этого экземпляра <see cref="T:System.Net.NetworkInformation.NetworkInterface" />.</summary>
		/// <returns>Статистика IP.</returns>
		// Token: 0x06003961 RID: 14689 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual IPInterfaceStatistics GetIPStatistics()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает текущее операционное состояние сетевого подключения.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.NetworkInformation.OperationalStatus" />.</returns>
		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual OperationalStatus OperationalStatus
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает скорость сетевого интерфейса.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее скорость в битах в секунду.</returns>
		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual long Speed
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, настроен ли сетевой интерфейс только на прием пакетов данных.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс только принимает сетевой трафик; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual bool IsReceiveOnly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешен ли сетевому интерфейсу прием пакетов многоадресной рассылки.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс принимает пакеты многоадресной рассылки; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual bool SupportsMulticast
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает МАС-адрес (физический адрес) данного адаптера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.PhysicalAddress" />, содержащий физический адрес.</returns>
		// Token: 0x06003966 RID: 14694 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual PhysicalAddress GetPhysicalAddress()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает тип интерфейса.</summary>
		/// <returns>Значение типа <see cref="T:System.Net.NetworkInformation.NetworkInterfaceType" />, указывающее тип сетевого интерфейса.</returns>
		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual NetworkInterfaceType NetworkInterfaceType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, поддерживает ли интерфейс заданный протокол.</summary>
		/// <param name="networkInterfaceComponent">Значение <see cref="T:System.Net.NetworkInformation.NetworkInterfaceComponent" />.</param>
		/// <returns>Значение <see langword="true" />, если заданный протокол поддерживается; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003968 RID: 14696 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			throw new NotImplementedException();
		}
	}
}
