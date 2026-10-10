using System;
using System.Globalization;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Представляет сетевую конечную точку в виде IP-адреса и номер порта.</summary>
	// Token: 0x0200057F RID: 1407
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		/// <summary>Возвращает семейство IP-адресов.</summary>
		/// <returns>Возвращает <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</returns>
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0009C126 File Offset: 0x0009A326
		public override AddressFamily AddressFamily
		{
			get
			{
				return this._address.AddressFamily;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.IPEndPoint" /> с заданными адресом и номером порта.</summary>
		/// <param name="address">IP-адрес узла в Интернете.</param>
		/// <param name="port">Номер порта, связанный с параметром <paramref name="address" />, или 0 для указания любого доступного порта. <paramref name="port" /> указывается в порядке основного приложения.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="port" /> меньше <see cref="F:System.Net.IPEndPoint.MinPort" />.  
		///
		/// или - 
		/// Значение <paramref name="port" /> больше значения <see cref="F:System.Net.IPEndPoint.MaxPort" />.  
		///
		/// или - 
		/// <paramref name="address" /> меньше 0 или больше 0x00000000FFFFFFFF.</exception>
		// Token: 0x06002D97 RID: 11671 RVA: 0x0009C133 File Offset: 0x0009A333
		public IPEndPoint(long address, int port)
		{
			if (!TcpValidationHelpers.ValidatePortNumber(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this._port = port;
			this._address = new IPAddress(address);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.IPEndPoint" /> с заданными адресом и номером порта.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.IPAddress" />.</param>
		/// <param name="port">Номер порта, связанный с параметром <paramref name="address" />, или 0 для указания любого доступного порта. <paramref name="port" /> указывается в порядке основного приложения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="address" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="port" /> меньше <see cref="F:System.Net.IPEndPoint.MinPort" />.  
		///
		/// или - 
		/// Значение <paramref name="port" /> больше значения <see cref="F:System.Net.IPEndPoint.MaxPort" />.  
		///
		/// или - 
		/// <paramref name="address" /> меньше 0 или больше 0x00000000FFFFFFFF.</exception>
		// Token: 0x06002D98 RID: 11672 RVA: 0x0009C161 File Offset: 0x0009A361
		public IPEndPoint(IPAddress address, int port)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!TcpValidationHelpers.ValidatePortNumber(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this._port = port;
			this._address = address;
		}

		/// <summary>Возвращает или задает IP-адрес конечной точки.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.IPAddress" />, содержащий IP-адрес конечной точки.</returns>
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0009C198 File Offset: 0x0009A398
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x0009C1A0 File Offset: 0x0009A3A0
		public IPAddress Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}

		/// <summary>Возвращает или задает номер порта конечной точки.</summary>
		/// <returns>Целое значение из диапазона от <see cref="F:System.Net.IPEndPoint.MinPort" /> до <see cref="F:System.Net.IPEndPoint.MaxPort" />, показывающее номер порта конечной точки.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, заданное для установленной операции, меньше <see cref="F:System.Net.IPEndPoint.MinPort" /> или больше <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x0009C1A9 File Offset: 0x0009A3A9
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x0009C1B1 File Offset: 0x0009A3B1
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				if (!TcpValidationHelpers.ValidatePortNumber(value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._port = value;
			}
		}

		/// <summary>Возвращает IP-адрес и номер порта заданной конечной точки.</summary>
		/// <returns>Строка, содержащая IP-адрес и номер порта заданной конечной точки (например, 192.168.1.2:80).</returns>
		// Token: 0x06002D9D RID: 11677 RVA: 0x0009C1D0 File Offset: 0x0009A3D0
		public override string ToString()
		{
			return string.Format((this._address.AddressFamily == AddressFamily.InterNetworkV6) ? "[{0}]:{1}" : "{0}:{1}", this._address.ToString(), this.Port.ToString(NumberFormatInfo.InvariantInfo));
		}

		/// <summary>Выводит в последовательном виде сведения о конечной точке в экземпляр класса <see cref="T:System.Net.SocketAddress" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Net.SocketAddress" />, содержащий адрес сокета для конечной точки.</returns>
		// Token: 0x06002D9E RID: 11678 RVA: 0x0009C21B File Offset: 0x0009A41B
		public override SocketAddress Serialize()
		{
			return new SocketAddress(this.Address, this.Port);
		}

		/// <summary>Создает конечную точка по адресу сокета.</summary>
		/// <param name="socketAddress">Параметр <see cref="T:System.Net.SocketAddress" />, используемый для создания конечной точки.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Net.EndPoint" />, использующий заданный адрес сокета.</returns>
		/// <exception cref="T:System.ArgumentException">Значение свойства AddressFamily для <paramref name="socketAddress" /> не равно значению свойства AddressFamily для текущего экземпляра класса.  
		///
		/// или - 
		/// <paramref name="socketAddress" />.Size &lt; 8.</exception>
		// Token: 0x06002D9F RID: 11679 RVA: 0x0009C230 File Offset: 0x0009A430
		public override EndPoint Create(SocketAddress socketAddress)
		{
			if (socketAddress.Family != this.AddressFamily)
			{
				throw new ArgumentException(SR.Format("The AddressFamily {0} is not valid for the {1} end point, use {2} instead.", socketAddress.Family.ToString(), base.GetType().FullName, this.AddressFamily.ToString()), "socketAddress");
			}
			if (socketAddress.Size < 8)
			{
				throw new ArgumentException(SR.Format("The supplied {0} is an invalid size for the {1} end point.", socketAddress.GetType().FullName, base.GetType().FullName), "socketAddress");
			}
			return socketAddress.GetIPEndPoint();
		}

		/// <summary>Определяет, равен ли указанный объект <see cref="T:System.Object" /> текущему объекту <see cref="T:System.Object" />.</summary>
		/// <param name="comparand">Объект <see cref="T:System.Object" />, с которым сравнивается текущий объект <see cref="T:System.Object" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.Object" /> равен текущему объекту <see cref="T:System.Object" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002DA0 RID: 11680 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
		public override bool Equals(object comparand)
		{
			IPEndPoint ipendPoint = comparand as IPEndPoint;
			return ipendPoint != null && ipendPoint._address.Equals(this._address) && ipendPoint._port == this._port;
		}

		/// <summary>Возвращает хэш-значение для экземпляра <see cref="T:System.Net.IPEndPoint" />.</summary>
		/// <returns>Целочисленное хэш-значение.</returns>
		// Token: 0x06002DA1 RID: 11681 RVA: 0x0009C30A File Offset: 0x0009A50A
		public override int GetHashCode()
		{
			return this._address.GetHashCode() ^ this._port;
		}

		/// <summary>Определяет минимальное значение, которое может присваиваться свойству <see cref="P:System.Net.IPEndPoint.Port" />. Это поле доступно только для чтения.</summary>
		// Token: 0x040018F2 RID: 6386
		public const int MinPort = 0;

		/// <summary>Определяет максимальное значение, которое может присваиваться свойству <see cref="P:System.Net.IPEndPoint.Port" />. Значение MaxPort установлено равным 0x0000FFFF. Это поле доступно только для чтения.</summary>
		// Token: 0x040018F3 RID: 6387
		public const int MaxPort = 65535;

		// Token: 0x040018F4 RID: 6388
		private IPAddress _address;

		// Token: 0x040018F5 RID: 6389
		private int _port;

		// Token: 0x040018F6 RID: 6390
		internal const int AnyPort = 0;

		// Token: 0x040018F7 RID: 6391
		internal static IPEndPoint Any = new IPEndPoint(IPAddress.Any, 0);

		// Token: 0x040018F8 RID: 6392
		internal static IPEndPoint IPv6Any = new IPEndPoint(IPAddress.IPv6Any, 0);
	}
}
