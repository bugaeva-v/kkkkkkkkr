using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола UDP.</summary>
	// Token: 0x02000708 RID: 1800
	public abstract class UdpStatistics
	{
		/// <summary>Возвращает число полученных UDP-датаграмм.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число датаграмм, доставленных пользователям UDP.</returns>
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060039AB RID: 14763
		public abstract long DatagramsReceived { get; }

		/// <summary>Возвращает число отправленных UDP-датаграмм.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число отправленных датаграмм.</returns>
		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060039AC RID: 14764
		public abstract long DatagramsSent { get; }

		/// <summary>Возвращает число полученных UDP-датаграмм, которые были удалены из-за ошибок порта.</summary>
		/// <returns>Число типа <see cref="T:System.Int64" />, указывающее общее число полученных UDP-датаграмм, которые были удалены из-за отсутствия приложения, прослушивающего порт назначения.</returns>
		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060039AD RID: 14765
		public abstract long IncomingDatagramsDiscarded { get; }

		/// <summary>Возвращает число полученных UDP-датаграмм, которые были удалены из-за ошибок, не связанных с портом.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, указывающее общее число полученных UDP-датаграмм, которые не удалось доставить по причинам, не связанным с отсутствием приложения, прослушивающего порт назначения.</returns>
		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060039AE RID: 14766
		public abstract long IncomingDatagramsWithErrors { get; }

		/// <summary>Возвращает число локальных конечных точек, прослушивающих UDP-датаграммы.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число сокетов, прослушивающих UDP-датаграммы.</returns>
		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060039AF RID: 14767
		public abstract int UdpListeners { get; }
	}
}
