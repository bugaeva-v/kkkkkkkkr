using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения об адресе многоадресной рассылки сетевого интерфейса.</summary>
	// Token: 0x020006EE RID: 1774
	public abstract class MulticastIPAddressInformation : IPAddressInformation
	{
		/// <summary>Возвращает оставшееся время в секундах, в течение которого данный адрес является основным.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее оставшееся время в секундах, в течение которого данный адрес является основным.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06003925 RID: 14629
		public abstract long AddressPreferredLifetime { get; }

		/// <summary>Возвращает оставшееся время в секундах, в течение которого действителен данный адрес.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее оставшееся время в секундах, в течение которого сохраняется значение данного адреса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06003926 RID: 14630
		public abstract long AddressValidLifetime { get; }

		/// <summary>Указывает оставшееся время, в течение которого протокол DHCP предоставляет данный IP-адрес.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, которое содержит время, оставшееся до освобождения компьютером экземпляра объекта <see cref="T:System.Net.IPAddress" />, в секундах.</returns>
		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003927 RID: 14631
		public abstract long DhcpLeaseLifetime { get; }

		/// <summary>Возвращает значение, указывающее состояние алгоритма обнаружения повторяющихся адресов.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.DuplicateAddressDetectionState" />, обозначающее ход выполнения алгоритма определения уникальности IP-адреса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06003928 RID: 14632
		public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }

		/// <summary>Возвращает значение, указывающее источник префикса IP-адреса многоадресной рассылки.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.PrefixOrigin" />, указывающее способ получения сведений о префиксе.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003929 RID: 14633
		public abstract PrefixOrigin PrefixOrigin { get; }

		/// <summary>Возвращает значение, указывающее источник суффикса IP-адреса многоадресной рассылки.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.NetworkInformation.SuffixOrigin" />, указывающее способ получения сведений о суффиксе.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows XP.</exception>
		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600392A RID: 14634
		public abstract SuffixOrigin SuffixOrigin { get; }
	}
}
