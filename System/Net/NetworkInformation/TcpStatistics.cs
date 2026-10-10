using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола TCP.</summary>
	// Token: 0x02000707 RID: 1799
	public abstract class TcpStatistics
	{
		/// <summary>Получает число принятых TCP-запросов на подключение.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число принятых TCP-запросов на подключение.</returns>
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600399C RID: 14748
		public abstract long ConnectionsAccepted { get; }

		/// <summary>Получает число TCP-запросов на подключение, отправленных клиентами.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число подключений TCP, инициированных клиентами.</returns>
		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600399D RID: 14749
		public abstract long ConnectionsInitiated { get; }

		/// <summary>Указывает общее число установленных подключений TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число установленных подключений.</returns>
		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600399E RID: 14750
		public abstract long CumulativeConnections { get; }

		/// <summary>Получает число текущих подключений TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число текущих подключений TCP.</returns>
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600399F RID: 14751
		public abstract long CurrentConnections { get; }

		/// <summary>Получает число полученных ошибок TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число полученных ошибок TCP.</returns>
		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060039A0 RID: 14752
		public abstract long ErrorsReceived { get; }

		/// <summary>Получает число неудавшихся попыток подключений TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число неудавшихся попыток подключений TCP.</returns>
		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060039A1 RID: 14753
		public abstract long FailedConnectionAttempts { get; }

		/// <summary>Получает максимальное число поддерживаемых подключений TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число поддерживаемых подключений TCP.</returns>
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060039A2 RID: 14754
		public abstract long MaximumConnections { get; }

		/// <summary>Получает значение максимального времени ожидания при повторной отправке сегментов TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее максимальное время ожидания (в миллисекундах) при повторной отправке, разрешенное в реализации протокола TCP.</returns>
		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060039A3 RID: 14755
		public abstract long MaximumTransmissionTimeout { get; }

		/// <summary>Получает значение минимального времени ожидания при повторной отправке сегментов TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее минимальное время ожидания (в миллисекундах) при повторной отправке, разрешенное в реализации протокола TCP.</returns>
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060039A4 RID: 14756
		public abstract long MinimumTransmissionTimeout { get; }

		/// <summary>Получает число RST-пакетов, полученных подключениями TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число сбросов подключений TCP.</returns>
		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060039A5 RID: 14757
		public abstract long ResetConnections { get; }

		/// <summary>Получает число полученных сегментов TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число полученных сегментов TCP.</returns>
		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060039A6 RID: 14758
		public abstract long SegmentsReceived { get; }

		/// <summary>Получает число повторно отправленных сегментов TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число повторно отправленных сегментов TCP.</returns>
		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060039A7 RID: 14759
		public abstract long SegmentsResent { get; }

		/// <summary>Получает число отправленных сегментов TCP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число отправленных сегментов TCP.</returns>
		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060039A8 RID: 14760
		public abstract long SegmentsSent { get; }

		/// <summary>Получает число отправленных сегментов TCP с установленным флагом сброса.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число отправленных сегментов TCP с установленным флагом сброса.</returns>
		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060039A9 RID: 14761
		public abstract long ResetsSent { get; }
	}
}
