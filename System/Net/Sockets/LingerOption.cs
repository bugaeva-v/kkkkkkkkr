using System;

namespace System.Net.Sockets
{
	/// <summary>Указывает, будет ли оставаться подключенным объект <see cref="T:System.Net.Sockets.Socket" /> после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" /> или <see cref="M:System.Net.Sockets.TcpClient.Close" />, а также указывает продолжительность времени, в течение которого этот объект будет оставаться подключенным, если продолжается отправка данных.</summary>
	// Token: 0x020007A9 RID: 1961
	public class LingerOption
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.LingerOption" />.</summary>
		/// <param name="enable">Значение <see langword="true" />, чтобы объект оставался подключенным после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" />; в противном случае — значение <see langword="false" />.</param>
		/// <param name="seconds">Количество секунд, в течение которого сохраняется подключение после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" />.</param>
		// Token: 0x06003EA6 RID: 16038 RVA: 0x000D6774 File Offset: 0x000D4974
		public LingerOption(bool enable, int seconds)
		{
			this.Enabled = enable;
			this.LingerTime = seconds;
		}

		/// <summary>Получает или устанавливает значение, определяющее необходимость ожидания после закрытия объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.Socket" /> должен находится в состоянии ожидания после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003EA7 RID: 16039 RVA: 0x000D678A File Offset: 0x000D498A
		// (set) Token: 0x06003EA8 RID: 16040 RVA: 0x000D6792 File Offset: 0x000D4992
		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>Получает или задает интервал времени, в течение которого объект должен оставаться подключенным после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" />, если остались данные для отправки.</summary>
		/// <returns>Интервал времени, заданный в секундах, в течение которого объект остается подключенным после вызова метода <see cref="M:System.Net.Sockets.Socket.Close" />.</returns>
		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x000D679B File Offset: 0x000D499B
		// (set) Token: 0x06003EAA RID: 16042 RVA: 0x000D67A3 File Offset: 0x000D49A3
		public int LingerTime
		{
			get
			{
				return this.lingerTime;
			}
			set
			{
				this.lingerTime = value;
			}
		}

		// Token: 0x040024DB RID: 9435
		private bool enabled;

		// Token: 0x040024DC RID: 9436
		private int lingerTime;
	}
}
