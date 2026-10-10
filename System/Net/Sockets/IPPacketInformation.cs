using System;

namespace System.Net.Sockets
{
	/// <summary>Представляет сведения о пакете, получаемые при вызове метода <see cref="M:System.Net.Sockets.Socket.ReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> или <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" />.</summary>
	// Token: 0x020007A7 RID: 1959
	public struct IPPacketInformation
	{
		// Token: 0x06003E9F RID: 16031 RVA: 0x000D66C6 File Offset: 0x000D48C6
		internal IPPacketInformation(IPAddress address, int networkInterface)
		{
			this.address = address;
			this.networkInterface = networkInterface;
		}

		/// <summary>Получает сведения о происхождении пакета, получаемые в результате вызова метода <see cref="M:System.Net.Sockets.Socket.ReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> или <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, указывающий сведения о происхождении пакета, получаемые в результате вызова метода <see cref="M:System.Net.Sockets.Socket.ReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> или <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" />. Для пакетов, отправленные из адреса одноадресной передачи свойство <see cref="P:System.Net.Sockets.IPPacketInformation.Address" /> возвращает объект <see cref="T:System.Net.IPAddress" /> отправителя; для пакетов многоадресной рассылки или широковещательной передачи свойство <see cref="P:System.Net.Sockets.IPPacketInformation.Address" /> возвращает объект <see cref="T:System.Net.IPAddress" /> многоадресной рассылки или широковещательной передачи.</returns>
		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x000D66D6 File Offset: 0x000D48D6
		public IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		/// <summary>Получает сведения о сетевом интерфейсе, связанные с вызовом метода <see cref="M:System.Net.Sockets.Socket.ReceiveMessageFrom(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" /> или <see cref="M:System.Net.Sockets.Socket.EndReceiveMessageFrom(System.IAsyncResult,System.Net.Sockets.SocketFlags@,System.Net.EndPoint@,System.Net.Sockets.IPPacketInformation@)" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее индекс сетевого интерфейса. Можно использовать этот индекс с методом <see cref="M:System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces" />, чтобы получить дополнительные сведения о соответствующем интерфейсе.</returns>
		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x000D66DE File Offset: 0x000D48DE
		public int Interface
		{
			get
			{
				return this.networkInterface;
			}
		}

		/// <summary>Проверяет, эквивалентны ли два указанные экземпляра <see cref="T:System.Net.Sockets.IPPacketInformation" />.</summary>
		/// <param name="packetInformation1">Экземпляр <see cref="T:System.Net.Sockets.IPPacketInformation" />, который находится слева от оператора равенства.</param>
		/// <param name="packetInformation2">Экземпляр класса <see cref="T:System.Net.Sockets.IPPacketInformation" />, который находится справа от оператора равенства.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="packetInformation1" /> и <paramref name="packetInformation2" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003EA2 RID: 16034 RVA: 0x000D66E6 File Offset: 0x000D48E6
		public static bool operator ==(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2)
		{
			return packetInformation1.Equals(packetInformation2);
		}

		/// <summary>Проверяет, что два указанные экземпляра класса <see cref="T:System.Net.Sockets.IPPacketInformation" /> не являются равными.</summary>
		/// <param name="packetInformation1">Экземпляр <see cref="T:System.Net.Sockets.IPPacketInformation" />, который находится слева от оператора неравенства.</param>
		/// <param name="packetInformation2">Экземпляр класса <see cref="T:System.Net.Sockets.IPPacketInformation" />, который находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" /> если параметры <paramref name="packetInformation1" /> и <paramref name="packetInformation2" /> неравны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003EA3 RID: 16035 RVA: 0x000D66FB File Offset: 0x000D48FB
		public static bool operator !=(IPPacketInformation packetInformation1, IPPacketInformation packetInformation2)
		{
			return !packetInformation1.Equals(packetInformation2);
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="comparand">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="comparand" /> является экземпляром класса <see cref="T:System.Net.Sockets.IPPacketInformation" /> и равен значению этого экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003EA4 RID: 16036 RVA: 0x000D6714 File Offset: 0x000D4914
		public override bool Equals(object comparand)
		{
			if (comparand == null)
			{
				return false;
			}
			if (!(comparand is IPPacketInformation))
			{
				return false;
			}
			IPPacketInformation ippacketInformation = (IPPacketInformation)comparand;
			return this.address.Equals(ippacketInformation.address) && this.networkInterface == ippacketInformation.networkInterface;
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код Int32.</returns>
		// Token: 0x06003EA5 RID: 16037 RVA: 0x000D675B File Offset: 0x000D495B
		public override int GetHashCode()
		{
			return this.address.GetHashCode() + this.networkInterface.GetHashCode();
		}

		// Token: 0x040024D4 RID: 9428
		private IPAddress address;

		// Token: 0x040024D5 RID: 9429
		private int networkInterface;
	}
}
