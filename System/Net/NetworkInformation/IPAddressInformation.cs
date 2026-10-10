using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения об адресе сетевого интерфейса.</summary>
	// Token: 0x020006E0 RID: 1760
	public abstract class IPAddressInformation
	{
		/// <summary>Возвращает IP-адрес.</summary>
		/// <returns>Экземпляр объекта <see cref="T:System.Net.IPAddress" />, содержащий IP-адрес интерфейса.</returns>
		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003878 RID: 14456
		public abstract IPAddress Address { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, является ли IP-адрес допустимым, чтобы попасть в базу данных DNS-сервера.</summary>
		/// <returns>Значение <see langword="true" />, если адрес может попасть в базу данных DNS; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003879 RID: 14457
		public abstract bool IsDnsEligible { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, является ли IP-адрес промежуточным (адресом кластера).</summary>
		/// <returns>Значение <see langword="true" />, если адрес является промежуточным; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600387A RID: 14458
		public abstract bool IsTransient { get; }
	}
}
