using System;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Представляет сетевую конечную точку в качестве имени узла или строкового представления IP-адреса и номера порта.</summary>
	// Token: 0x020005CA RID: 1482
	public class DnsEndPoint : EndPoint
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.DnsEndPoint" /> с именем узла или строковым представлением IP-адреса и номера порта.</summary>
		/// <param name="host">Имя узла или строковое представление IP-адреса.</param>
		/// <param name="port">Номер порта, связанный с адресом, или 0 для указания любого доступного порта. <paramref name="port" /> указывается в порядке основного приложения.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="host" /> содержит пустую строку.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="host" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="port" /> меньше <see cref="F:System.Net.IPEndPoint.MinPort" />.  
		///
		/// или - 
		/// Значение <paramref name="port" /> больше значения <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		// Token: 0x06002FFE RID: 12286 RVA: 0x000A5ADB File Offset: 0x000A3CDB
		public DnsEndPoint(string host, int port) : this(host, port, AddressFamily.Unspecified)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.DnsEndPoint" /> с именем узла или строковым представлением IP-адреса, номера порта и семейства адресов.</summary>
		/// <param name="host">Имя узла или строковое представление IP-адреса.</param>
		/// <param name="port">Номер порта, связанный с адресом, или 0 для указания любого доступного порта. <paramref name="port" /> указывается в порядке основного приложения.</param>
		/// <param name="addressFamily">Одно из значений перечисления <see cref="T:System.Net.Sockets.AddressFamily" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="host" /> содержит пустую строку.  
		///
		/// или - 
		/// Свойство <paramref name="addressFamily" /> имеет значение <see cref="F:System.Net.Sockets.AddressFamily.Unknown" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="host" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="port" /> меньше <see cref="F:System.Net.IPEndPoint.MinPort" />.  
		///
		/// или - 
		/// Значение <paramref name="port" /> больше значения <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		// Token: 0x06002FFF RID: 12287 RVA: 0x000A5AE8 File Offset: 0x000A3CE8
		public DnsEndPoint(string host, int port, AddressFamily addressFamily)
		{
			if (host == null)
			{
				throw new ArgumentNullException("host");
			}
			if (string.IsNullOrEmpty(host))
			{
				throw new ArgumentException(SR.GetString("The parameter '{0}' cannot be an empty string.", new object[]
				{
					"host"
				}));
			}
			if (port < 0 || port > 65535)
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (addressFamily != AddressFamily.InterNetwork && addressFamily != AddressFamily.InterNetworkV6 && addressFamily != AddressFamily.Unspecified)
			{
				throw new ArgumentException(SR.GetString("The specified value is not valid."), "addressFamily");
			}
			this.m_Host = host;
			this.m_Port = port;
			this.m_Family = addressFamily;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <param name="comparand">Экземпляр <see cref="T:System.Net.DnsEndPoint" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если два экземпляра <see cref="T:System.Net.DnsEndPoint" /> равны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003000 RID: 12288 RVA: 0x000A5B7C File Offset: 0x000A3D7C
		public override bool Equals(object comparand)
		{
			DnsEndPoint dnsEndPoint = comparand as DnsEndPoint;
			return dnsEndPoint != null && (this.m_Family == dnsEndPoint.m_Family && this.m_Port == dnsEndPoint.m_Port) && this.m_Host == dnsEndPoint.m_Host;
		}

		/// <summary>Возвращает значение хэша для объекта <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>Целочисленное значение хэша для объекта <see cref="T:System.Net.DnsEndPoint" />.</returns>
		// Token: 0x06003001 RID: 12289 RVA: 0x000A5BC4 File Offset: 0x000A3DC4
		public override int GetHashCode()
		{
			return StringComparer.InvariantCultureIgnoreCase.GetHashCode(this.ToString());
		}

		/// <summary>Возвращает имя узла или строковое представление IP-адреса и номера порта объекта <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>Строка, содержащая семейство адресов, имя узла или строку IP-адреса и номер порта указанного объекта <see cref="T:System.Net.DnsEndPoint" />.</returns>
		// Token: 0x06003002 RID: 12290 RVA: 0x000A5BD8 File Offset: 0x000A3DD8
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.m_Family.ToString(),
				"/",
				this.m_Host,
				":",
				this.m_Port.ToString()
			});
		}

		/// <summary>Получает имя узла или строковое представление IP-адреса узла.</summary>
		/// <returns>Имя узла или строковое представление IP-адреса.</returns>
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000A5C2B File Offset: 0x000A3E2B
		public string Host
		{
			get
			{
				return this.m_Host;
			}
		}

		/// <summary>Возвращает семейство IP-адресов.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.Sockets.AddressFamily" />.</returns>
		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000A5C33 File Offset: 0x000A3E33
		public override AddressFamily AddressFamily
		{
			get
			{
				return this.m_Family;
			}
		}

		/// <summary>Получает номер порта объекта <see cref="T:System.Net.DnsEndPoint" />.</summary>
		/// <returns>Целочисленное значение от 0 до 0xffff, показывающее номер порта объекта <see cref="T:System.Net.DnsEndPoint" />.</returns>
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x000A5C3B File Offset: 0x000A3E3B
		public int Port
		{
			get
			{
				return this.m_Port;
			}
		}

		// Token: 0x04001A74 RID: 6772
		private string m_Host;

		// Token: 0x04001A75 RID: 6773
		private int m_Port;

		// Token: 0x04001A76 RID: 6774
		private AddressFamily m_Family;
	}
}
