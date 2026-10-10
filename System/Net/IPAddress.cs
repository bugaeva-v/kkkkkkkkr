using System;
using System.Buffers.Binary;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net
{
	/// <summary>Предоставляет IP-адрес.</summary>
	// Token: 0x0200057C RID: 1404
	[Serializable]
	public class IPAddress
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x0009B3DF File Offset: 0x000995DF
		private bool IsIPv4
		{
			get
			{
				return this._numbers == null;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x0009B3EA File Offset: 0x000995EA
		private bool IsIPv6
		{
			get
			{
				return this._numbers != null;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x0009B3F5 File Offset: 0x000995F5
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0009B3FD File Offset: 0x000995FD
		private uint PrivateAddress
		{
			get
			{
				return this._addressOrScopeId;
			}
			set
			{
				this._toString = null;
				this._hashCode = 0;
				this._addressOrScopeId = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x0009B3F5 File Offset: 0x000995F5
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0009B3FD File Offset: 0x000995FD
		private uint PrivateScopeId
		{
			get
			{
				return this._addressOrScopeId;
			}
			set
			{
				this._toString = null;
				this._hashCode = 0;
				this._addressOrScopeId = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.IPAddress" /> с указанным адресом, заданным в виде массива <see cref="T:System.Int64" />.</summary>
		/// <param name="newAddress">Длинное целое значение IP-адреса. Например, значение 0x2414188f в формате обратного порядка байтов будет являться IP-адресом 143.24.20.36.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="newAddress" /> &lt; 0 или 
		///  <paramref name="newAddress" /> &gt; 0x00000000FFFFFFFF</exception>
		// Token: 0x06002D5B RID: 11611 RVA: 0x0009B414 File Offset: 0x00099614
		public IPAddress(long newAddress)
		{
			if (newAddress < 0L || newAddress > (long)((ulong)-1))
			{
				throw new ArgumentOutOfRangeException("newAddress");
			}
			this.PrivateAddress = (uint)newAddress;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.IPAddress" /> с адресом, указанным в виде массива <see cref="T:System.Byte" />, и указанным идентификатором области.</summary>
		/// <param name="address">Значение байтового массива IP-адреса.</param>
		/// <param name="scopeid">Длинное целое значение идентификатора области.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> содержит недопустимый IP-адрес.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="scopeid" /> &lt; 0 или 
		///  <paramref name="scopeid" /> &gt; 0x00000000FFFFFFFF</exception>
		// Token: 0x06002D5C RID: 11612 RVA: 0x0009B439 File Offset: 0x00099639
		public IPAddress(byte[] address, long scopeid) : this(new ReadOnlySpan<byte>(address ?? IPAddress.ThrowAddressNullException()), scopeid)
		{
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x0009B454 File Offset: 0x00099654
		public unsafe IPAddress(ReadOnlySpan<byte> address, long scopeid)
		{
			if (address.Length != 16)
			{
				throw new ArgumentException("An invalid IP address was specified.", "address");
			}
			if (scopeid < 0L || scopeid > (long)((ulong)-1))
			{
				throw new ArgumentOutOfRangeException("scopeid");
			}
			this._numbers = new ushort[8];
			for (int i = 0; i < 8; i++)
			{
				this._numbers[i] = (ushort)((int)(*address[i * 2]) * 256 + (int)(*address[i * 2 + 1]));
			}
			this.PrivateScopeId = (uint)scopeid;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x0009B4E0 File Offset: 0x000996E0
		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
		{
			ushort[] array = new ushort[8];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = numbers[i];
			}
			this._numbers = array;
			this.PrivateScopeId = scopeid;
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x0009B520 File Offset: 0x00099720
		private IPAddress(ushort[] numbers, uint scopeid)
		{
			this._numbers = numbers;
			this.PrivateScopeId = scopeid;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.IPAddress" /> с указанным адресом, заданным в виде массива <see cref="T:System.Byte" />.</summary>
		/// <param name="address">Значение байтового массива IP-адреса.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="address" /> содержит недопустимый IP-адрес.</exception>
		// Token: 0x06002D60 RID: 11616 RVA: 0x0009B536 File Offset: 0x00099736
		public IPAddress(byte[] address) : this(new ReadOnlySpan<byte>(address ?? IPAddress.ThrowAddressNullException()))
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0009B550 File Offset: 0x00099750
		public unsafe IPAddress(ReadOnlySpan<byte> address)
		{
			if (address.Length == 4)
			{
				this.PrivateAddress = (uint)((long)((int)(*address[3]) << 24 | (int)(*address[2]) << 16 | (int)(*address[1]) << 8 | (int)(*address[0])) & (long)((ulong)-1));
				return;
			}
			if (address.Length == 16)
			{
				this._numbers = new ushort[8];
				for (int i = 0; i < 8; i++)
				{
					this._numbers[i] = (ushort)((int)(*address[i * 2]) * 256 + (int)(*address[i * 2 + 1]));
				}
				return;
			}
			throw new ArgumentException("An invalid IP address was specified.", "address");
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0009B603 File Offset: 0x00099803
		internal IPAddress(int newAddress)
		{
			this.PrivateAddress = (uint)newAddress;
		}

		/// <summary>Определяет, является ли строка допустимым IP-адресом.</summary>
		/// <param name="ipString">Строка, которую следует проверить.</param>
		/// <param name="address">Возвращает версию строки <see cref="T:System.Net.IPAddress" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="ipString" /> мог быть проанализирован как IP-адрес; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="ipString" /> равно null.</exception>
		// Token: 0x06002D63 RID: 11619 RVA: 0x0009B612 File Offset: 0x00099812
		public static bool TryParse(string ipString, out IPAddress address)
		{
			if (ipString == null)
			{
				address = null;
				return false;
			}
			address = IPAddressParser.Parse(ipString.AsSpan(), true);
			return address != null;
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x0009B62F File Offset: 0x0009982F
		public static bool TryParse(ReadOnlySpan<char> ipSpan, out IPAddress address)
		{
			address = IPAddressParser.Parse(ipSpan, true);
			return address != null;
		}

		/// <summary>Преобразует строку IP-адреса в экземпляр класса <see cref="T:System.Net.IPAddress" />.</summary>
		/// <param name="ipString">Строка, содержащая IP-адрес, выраженный в случае протокола IPv4 в виде четырех чисел, разделенных точками, или представленный в системе записи "двоеточие-шестнадцатиричное число" в случае протокола IPv6.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.IPAddress" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="ipString" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="ipString" /> не является допустимым IP-адресом.</exception>
		// Token: 0x06002D65 RID: 11621 RVA: 0x0009B63F File Offset: 0x0009983F
		public static IPAddress Parse(string ipString)
		{
			if (ipString == null)
			{
				throw new ArgumentNullException("ipString");
			}
			return IPAddressParser.Parse(ipString.AsSpan(), false);
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x0009B65B File Offset: 0x0009985B
		public static IPAddress Parse(ReadOnlySpan<char> ipSpan)
		{
			return IPAddressParser.Parse(ipSpan, false);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x0009B664 File Offset: 0x00099864
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			if (this.IsIPv6)
			{
				if (destination.Length < 16)
				{
					bytesWritten = 0;
					return false;
				}
				this.WriteIPv6Bytes(destination);
				bytesWritten = 16;
			}
			else
			{
				if (destination.Length < 4)
				{
					bytesWritten = 0;
					return false;
				}
				this.WriteIPv4Bytes(destination);
				bytesWritten = 4;
			}
			return true;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x0009B6B0 File Offset: 0x000998B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteIPv6Bytes(Span<byte> destination)
		{
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				*destination[num++] = (byte)(this._numbers[i] >> 8 & 255);
				*destination[num++] = (byte)(this._numbers[i] & 255);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x0009B708 File Offset: 0x00099908
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void WriteIPv4Bytes(Span<byte> destination)
		{
			uint privateAddress = this.PrivateAddress;
			*destination[0] = (byte)privateAddress;
			*destination[1] = (byte)(privateAddress >> 8);
			*destination[2] = (byte)(privateAddress >> 16);
			*destination[3] = (byte)(privateAddress >> 24);
		}

		/// <summary>Предоставляет копию <see cref="T:System.Net.IPAddress" /> в виде массива байтов.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />.</returns>
		// Token: 0x06002D6A RID: 11626 RVA: 0x0009B750 File Offset: 0x00099950
		public byte[] GetAddressBytes()
		{
			if (this.IsIPv6)
			{
				byte[] array = new byte[16];
				this.WriteIPv6Bytes(array);
				return array;
			}
			byte[] array2 = new byte[4];
			this.WriteIPv4Bytes(array2);
			return array2;
		}

		/// <summary>Возвращает семейство адресов для IP-адреса.</summary>
		/// <returns>Возвращает <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> для протокола IPv4 или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" /> для протокола IPv6.</returns>
		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x0009B78F File Offset: 0x0009998F
		public AddressFamily AddressFamily
		{
			get
			{
				if (!this.IsIPv4)
				{
					return AddressFamily.InterNetworkV6;
				}
				return AddressFamily.InterNetwork;
			}
		}

		/// <summary>Возвращает или задает идентификатор области действия адреса, соответствующего протоколу IPv6.</summary>
		/// <returns>Длинное целое число, ограничивающее область действия адреса.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">
		///   <see langword="AddressFamily" /> = <see langword="InterNetwork" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="scopeId" /> &lt; 0 
		/// -или- 
		///
		/// <paramref name="scopeId" /> &gt; 0x00000000FFFFFFFF</exception>
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x0009B79D File Offset: 0x0009999D
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x0009B7B9 File Offset: 0x000999B9
		public long ScopeId
		{
			get
			{
				if (this.IsIPv4)
				{
					throw new SocketException(SocketError.OperationNotSupported);
				}
				return (long)((ulong)this.PrivateScopeId);
			}
			set
			{
				if (this.IsIPv4)
				{
					throw new SocketException(SocketError.OperationNotSupported);
				}
				if (value < 0L || value > (long)((ulong)-1))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.PrivateScopeId = (uint)value;
			}
		}

		/// <summary>Преобразует адрес в Интернете в его стандартный формат.</summary>
		/// <returns>Строка, содержащая IP-адрес, выраженный в формате четырех чисел, разделенных точками, согласно протоколу IPv4 или выраженный в системе "двоеточие-шестнадцатиричное число" согласно протоколу IPv6.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Семья адресов является <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />, используемый адрес недопустим.</exception>
		// Token: 0x06002D6E RID: 11630 RVA: 0x0009B7EB File Offset: 0x000999EB
		public override string ToString()
		{
			if (this._toString == null)
			{
				this._toString = (this.IsIPv4 ? IPAddressParser.IPv4AddressToString(this.PrivateAddress) : IPAddressParser.IPv6AddressToString(this._numbers, this.PrivateScopeId));
			}
			return this._toString;
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x0009B827 File Offset: 0x00099A27
		public bool TryFormat(Span<char> destination, out int charsWritten)
		{
			if (!this.IsIPv4)
			{
				return IPAddressParser.IPv6AddressToString(this._numbers, this.PrivateScopeId, destination, out charsWritten);
			}
			return IPAddressParser.IPv4AddressToString(this.PrivateAddress, destination, out charsWritten);
		}

		/// <summary>Преобразует длинное целое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="host">Преобразуемое число, представленное в байтовом формате узла.</param>
		/// <returns>Длинное целое значение, представленное в сетевом байтовом формате.</returns>
		// Token: 0x06002D70 RID: 11632 RVA: 0x0009B852 File Offset: 0x00099A52
		public static long HostToNetworkOrder(long host)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return host;
			}
			return BinaryPrimitives.ReverseEndianness(host);
		}

		/// <summary>Преобразует целое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="host">Преобразуемое число, представленное в байтовом формате узла.</param>
		/// <returns>Целое значение, представленное в сетевом байтовом формате.</returns>
		// Token: 0x06002D71 RID: 11633 RVA: 0x0009B863 File Offset: 0x00099A63
		public static int HostToNetworkOrder(int host)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return host;
			}
			return BinaryPrimitives.ReverseEndianness(host);
		}

		/// <summary>Преобразует короткое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="host">Преобразуемое число, представленное в байтовом формате узла.</param>
		/// <returns>Короткое значение, представленное в сетевом байтовом формате.</returns>
		// Token: 0x06002D72 RID: 11634 RVA: 0x0009B874 File Offset: 0x00099A74
		public static short HostToNetworkOrder(short host)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return host;
			}
			return BinaryPrimitives.ReverseEndianness(host);
		}

		/// <summary>Преобразует длинное целое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="network">Преобразуемое число, представленное в сетевом байтовом формате.</param>
		/// <returns>Длинное целое значение, представленное в байтовом формате узла.</returns>
		// Token: 0x06002D73 RID: 11635 RVA: 0x0009B885 File Offset: 0x00099A85
		public static long NetworkToHostOrder(long network)
		{
			return IPAddress.HostToNetworkOrder(network);
		}

		/// <summary>Преобразует целое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="network">Преобразуемое число, представленное в сетевом байтовом формате.</param>
		/// <returns>Целое значение, представленное в байтовом формате узла.</returns>
		// Token: 0x06002D74 RID: 11636 RVA: 0x0009B88D File Offset: 0x00099A8D
		public static int NetworkToHostOrder(int network)
		{
			return IPAddress.HostToNetworkOrder(network);
		}

		/// <summary>Преобразует короткое значение из байтового формата узла в сетевой байтовый формат.</summary>
		/// <param name="network">Преобразуемое число, представленное в сетевом байтовом формате.</param>
		/// <returns>Короткое значение, представленное в байтовом формате узла.</returns>
		// Token: 0x06002D75 RID: 11637 RVA: 0x0009B895 File Offset: 0x00099A95
		public static short NetworkToHostOrder(short network)
		{
			return IPAddress.HostToNetworkOrder(network);
		}

		/// <summary>Показывает, является ли IP-адрес адресом замыкания на себя.</summary>
		/// <param name="address">IP-адрес.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="address" /> является адресом замыкания на себя; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002D76 RID: 11638 RVA: 0x0009B8A0 File Offset: 0x00099AA0
		public static bool IsLoopback(IPAddress address)
		{
			if (address == null)
			{
				IPAddress.ThrowAddressNullException();
			}
			if (address.IsIPv6)
			{
				return address.Equals(IPAddress.IPv6Loopback);
			}
			return ((ulong)address.PrivateAddress & 255UL) == ((ulong)IPAddress.Loopback.PrivateAddress & 255UL);
		}

		/// <summary>Возвращает сведения о том, является ли IPv6-адрес многоадресным глобальным адресом.</summary>
		/// <returns>Значение <see langword="true" />, если IP-адрес является многоадресным глобальным IPv6-адресом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x0009B8EC File Offset: 0x00099AEC
		public bool IsIPv6Multicast
		{
			get
			{
				return this.IsIPv6 && (this._numbers[0] & 65280) == 65280;
			}
		}

		/// <summary>Возвращает сведения о том, является ли адрес локальным IPv6-адресом для канала связи.</summary>
		/// <returns>Значение <see langword="true" />, если IP-адрес является локальным IPv6 –адресом для канала связи; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x0009B90D File Offset: 0x00099B0D
		public bool IsIPv6LinkLocal
		{
			get
			{
				return this.IsIPv6 && (this._numbers[0] & 65472) == 65152;
			}
		}

		/// <summary>Возвращает сведения о том, является ли адрес локальным IPv6-адресом для веб-узла.</summary>
		/// <returns>Значение <see langword="true" />, если IP-адрес является локальным Ipv6-адресом веб-узла; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x0009B92E File Offset: 0x00099B2E
		public bool IsIPv6SiteLocal
		{
			get
			{
				return this.IsIPv6 && (this._numbers[0] & 65472) == 65216;
			}
		}

		/// <summary>Получает сведения о том, является ли адрес IPv6-адресом Teredo.</summary>
		/// <returns>Значение <see langword="true" />, если IP-адрес является IPv6-адресом Teredo; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x0009B94F File Offset: 0x00099B4F
		public bool IsIPv6Teredo
		{
			get
			{
				return this.IsIPv6 && this._numbers[0] == 8193 && this._numbers[1] == 0;
			}
		}

		/// <summary>Возвращает сведения о том, является ли IP-адрес адресом IPv6, сопоставленным с IPv4.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.  
		///  Значение <see langword="true" />, если IP-адрес является сопоставленным в IPv4 адресом IPv6; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0009B978 File Offset: 0x00099B78
		public bool IsIPv4MappedToIPv6
		{
			get
			{
				if (this.IsIPv4)
				{
					return false;
				}
				for (int i = 0; i < 5; i++)
				{
					if (this._numbers[i] != 0)
					{
						return false;
					}
				}
				return this._numbers[5] == ushort.MaxValue;
			}
		}

		/// <summary>IP-адрес.</summary>
		/// <returns>Длинное целое значение IP-адреса.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Семья адресов является <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0009B9B6 File Offset: 0x00099BB6
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x0009B9D4 File Offset: 0x00099BD4
		[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
		public long Address
		{
			get
			{
				if (this.AddressFamily == AddressFamily.InterNetworkV6)
				{
					throw new SocketException(SocketError.OperationNotSupported);
				}
				return (long)((ulong)this.PrivateAddress);
			}
			set
			{
				if (this.AddressFamily == AddressFamily.InterNetworkV6)
				{
					throw new SocketException(SocketError.OperationNotSupported);
				}
				if ((ulong)this.PrivateAddress != (ulong)value)
				{
					if (this is IPAddress.ReadOnlyIPAddress)
					{
						throw new SocketException(SocketError.OperationNotSupported);
					}
					this.PrivateAddress = (uint)value;
				}
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x0009BA10 File Offset: 0x00099C10
		internal bool Equals(object comparandObj, bool compareScopeId)
		{
			IPAddress ipaddress = comparandObj as IPAddress;
			if (ipaddress == null)
			{
				return false;
			}
			if (this.AddressFamily != ipaddress.AddressFamily)
			{
				return false;
			}
			if (this.IsIPv6)
			{
				for (int i = 0; i < 8; i++)
				{
					if (ipaddress._numbers[i] != this._numbers[i])
					{
						return false;
					}
				}
				return ipaddress.PrivateScopeId == this.PrivateScopeId || !compareScopeId;
			}
			return ipaddress.PrivateAddress == this.PrivateAddress;
		}

		/// <summary>Сравнивает два IP-адреса.</summary>
		/// <param name="comparand">Экземпляр класса <see cref="T:System.Net.IPAddress" />, используемый для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если два адреса совпадают; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002D7F RID: 11647 RVA: 0x0009BA84 File Offset: 0x00099C84
		public override bool Equals(object comparand)
		{
			return this.Equals(comparand, true);
		}

		/// <summary>Возвращает значение хэш-функции для IP-адреса.</summary>
		/// <returns>Целочисленное значение хэша.</returns>
		// Token: 0x06002D80 RID: 11648 RVA: 0x0009BA90 File Offset: 0x00099C90
		public unsafe override int GetHashCode()
		{
			if (this._hashCode != 0)
			{
				return this._hashCode;
			}
			int hashCode;
			if (this.IsIPv6)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
				MemoryMarshal.AsBytes<ushort>(new ReadOnlySpan<ushort>(this._numbers)).CopyTo(span);
				BitConverter.TryWriteBytes(span.Slice(16), this._addressOrScopeId);
				hashCode = Marvin.ComputeHash32(span, Marvin.DefaultSeed);
			}
			else
			{
				hashCode = Marvin.ComputeHash32(MemoryMarshal.AsBytes<uint>(MemoryMarshal.CreateReadOnlySpan<uint>(ref this._addressOrScopeId, 1)), Marvin.DefaultSeed);
			}
			this._hashCode = hashCode;
			return this._hashCode;
		}

		/// <summary>Сопоставляет объект <see cref="T:System.Net.IPAddress" /> с адресом IPv6.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.IPAddress" />.  
		/// Адрес IPv6.</returns>
		// Token: 0x06002D81 RID: 11649 RVA: 0x0009BB2C File Offset: 0x00099D2C
		public IPAddress MapToIPv6()
		{
			if (this.IsIPv6)
			{
				return this;
			}
			uint privateAddress = this.PrivateAddress;
			return new IPAddress(new ushort[]
			{
				0,
				0,
				0,
				0,
				0,
				ushort.MaxValue,
				(ushort)((privateAddress & 65280U) >> 8 | (privateAddress & 255U) << 8),
				(ushort)((privateAddress & 4278190080U) >> 24 | (privateAddress & 16711680U) >> 8)
			}, 0U);
		}

		/// <summary>Сопоставляет объект <see cref="T:System.Net.IPAddress" /> с адресом IPv4.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.IPAddress" />.  
		/// Адрес IPv4.</returns>
		// Token: 0x06002D82 RID: 11650 RVA: 0x0009BB90 File Offset: 0x00099D90
		public IPAddress MapToIPv4()
		{
			if (this.IsIPv4)
			{
				return this;
			}
			return new IPAddress((long)((ulong)((uint)(this._numbers[6] & 65280) >> 8 | (uint)((uint)(this._numbers[6] & 255) << 8) | ((uint)(this._numbers[7] & 65280) >> 8 | (uint)((uint)(this._numbers[7] & 255) << 8)) << 16)));
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x0009BBF3 File Offset: 0x00099DF3
		private static byte[] ThrowAddressNullException()
		{
			throw new ArgumentNullException("address");
		}

		/// <summary>Предоставляет IP-адрес, указывающий, что сервер должен контролировать действия клиентов на всех сетевых интерфейсах. Это поле доступно только для чтения.</summary>
		// Token: 0x040018E4 RID: 6372
		public static readonly IPAddress Any = new IPAddress.ReadOnlyIPAddress(0L);

		/// <summary>Предоставляет IP-адрес замыкания на себя. Это поле доступно только для чтения.</summary>
		// Token: 0x040018E5 RID: 6373
		public static readonly IPAddress Loopback = new IPAddress.ReadOnlyIPAddress(16777343L);

		/// <summary>Предоставляет широковещательный IP-адрес. Это поле доступно только для чтения.</summary>
		// Token: 0x040018E6 RID: 6374
		public static readonly IPAddress Broadcast = new IPAddress.ReadOnlyIPAddress((long)((ulong)-1));

		/// <summary>Предоставляет IP-адрес, указывающий, что сетевой интерфейс не должен использоваться. Это поле доступно только для чтения.</summary>
		// Token: 0x040018E7 RID: 6375
		public static readonly IPAddress None = IPAddress.Broadcast;

		// Token: 0x040018E8 RID: 6376
		internal const long LoopbackMask = 255L;

		/// <summary>Метод <see cref="M:System.Net.Sockets.Socket.Bind(System.Net.EndPoint)" /> использует поле <see cref="F:System.Net.IPAddress.IPv6Any" /> для указания того, что экземпляр класса <see cref="T:System.Net.Sockets.Socket" /> должен контролировать действия клиентов на всех сетевых интерфейсах.</summary>
		// Token: 0x040018E9 RID: 6377
		public static readonly IPAddress IPv6Any = new IPAddress(new byte[16], 0L);

		/// <summary>Предоставляет IP-адрес замыкания на себя. Это свойство доступно только для чтения.</summary>
		// Token: 0x040018EA RID: 6378
		public static readonly IPAddress IPv6Loopback = new IPAddress(new byte[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		}, 0L);

		/// <summary>Предоставляет IP-адрес, указывающий, что сетевой интерфейс не должен использоваться. Это свойство доступно только для чтения.</summary>
		// Token: 0x040018EB RID: 6379
		public static readonly IPAddress IPv6None = new IPAddress(new byte[16], 0L);

		// Token: 0x040018EC RID: 6380
		private uint _addressOrScopeId;

		// Token: 0x040018ED RID: 6381
		private readonly ushort[] _numbers;

		// Token: 0x040018EE RID: 6382
		private string _toString;

		// Token: 0x040018EF RID: 6383
		private int _hashCode;

		// Token: 0x040018F0 RID: 6384
		internal const int NumberOfLabels = 8;

		// Token: 0x0200057D RID: 1405
		private sealed class ReadOnlyIPAddress : IPAddress
		{
			// Token: 0x06002D85 RID: 11653 RVA: 0x0009BC7D File Offset: 0x00099E7D
			public ReadOnlyIPAddress(long newAddress) : base(newAddress)
			{
			}
		}
	}
}
