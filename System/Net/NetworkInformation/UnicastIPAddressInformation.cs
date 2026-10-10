using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения об адресе одноадресной рассылки сетевого интерфейса.</summary>
	// Token: 0x02000709 RID: 1801
	public abstract class UnicastIPAddressInformation : IPAddressInformation
	{
		/// <summary>Возвращает оставшееся время в секундах, в течение которого данный адрес является основным.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее оставшееся время в секундах, в течение которого данный адрес является основным.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060039B1 RID: 14769
		public abstract long AddressPreferredLifetime { get; }

		/// <summary>Возвращает оставшееся время в секундах, в течение которого действителен данный адрес.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее оставшееся время в секундах, в течение которого сохраняется значение данного адреса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060039B2 RID: 14770
		public abstract long AddressValidLifetime { get; }

		/// <summary>Указывает оставшееся время, в течение которого протокол DHCP предоставляет данный IP-адрес.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, которое содержит время, оставшееся до освобождения компьютером экземпляра объекта <see cref="T:System.Net.IPAddress" />, в секундах.</returns>
		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060039B3 RID: 14771
		public abstract long DhcpLeaseLifetime { get; }

		/// <summary>Возвращает значение, указывающее состояние алгоритма обнаружения повторяющихся адресов.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.DuplicateAddressDetectionState" />, обозначающее ход выполнения алгоритма определения уникальности IP-адреса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060039B4 RID: 14772
		public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }

		/// <summary>Возвращает значение, указывающее источник префикса IP-адреса одноадресной рассылки.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.PrefixOrigin" />, указывающее способ получения сведений о префиксе.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060039B5 RID: 14773
		public abstract PrefixOrigin PrefixOrigin { get; }

		/// <summary>Возвращает значение, указывающее источник суффикса IP-адреса одноадресной рассылки.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.SuffixOrigin" />, указывающее способ получения сведений о суффиксе.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060039B6 RID: 14774
		public abstract SuffixOrigin SuffixOrigin { get; }

		/// <summary>Возвращает IPv4-маску.</summary>
		/// <returns>Объект <see cref="T:System.Net.IPAddress" />, содержащий IPv4-маску.</returns>
		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060039B7 RID: 14775
		public abstract IPAddress IPv4Mask { get; }

		/// <summary>Получает длину в битах, префикса или сетевой части IP-адреса.</summary>
		/// <returns>Длина в битах, префикса или сетевой части IP-адрес.</returns>
		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x0000829A File Offset: 0x0000649A
		public virtual int PrefixLength
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
