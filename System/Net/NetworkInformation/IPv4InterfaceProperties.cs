using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о сетевых интерфейсах, поддерживающих протокол IPv4.</summary>
	// Token: 0x020006EA RID: 1770
	public abstract class IPv4InterfaceProperties
	{
		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, использует ли интерфейс службу WINS.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейсом используется WINS; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x060038DD RID: 14557
		public abstract bool UsesWins { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, использует ли интерфейс DHCP-сервер для получения IP-адреса.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс получает IP-адрес у DHCP-сервера; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060038DE RID: 14558
		public abstract bool IsDhcpEnabled { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, имеет ли на данный интерфейс APIPA-адрес.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс использует APIPA-адрес; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060038DF RID: 14559
		public abstract bool IsAutomaticPrivateAddressingActive { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешено ли на интерфейсе автоматическое назначение частных IP-адресов (APIPA).</summary>
		/// <returns>Значение <see langword="true" />, если интерфейсом используется APIPA; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060038E0 RID: 14560
		public abstract bool IsAutomaticPrivateAddressingEnabled { get; }

		/// <summary>Возвращает индекс сетевого интерфейса, связанного с IPv4-адресом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int32" />, содержащее индекс IPv4-интерфейса.</returns>
		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060038E1 RID: 14561
		public abstract int Index { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, может ли интерфейс переадресовывать (маршрутизировать) пакеты.</summary>
		/// <returns>Значение <see langword="true" />, если данный интерфейс маршрутизирует пакеты; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060038E2 RID: 14562
		public abstract bool IsForwardingEnabled { get; }

		/// <summary>Возвращает MTU данного сетевого интерфейса.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, обозначающее MTU.</returns>
		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060038E3 RID: 14563
		public abstract int Mtu { get; }
	}
}
