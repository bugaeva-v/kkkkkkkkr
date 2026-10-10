using System;
using System.ComponentModel;
using Unity;

namespace System.Net
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Net.WebClient.UploadProgressChanged" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x020005C0 RID: 1472
	public class UploadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x000A51B0 File Offset: 0x000A33B0
		internal UploadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive) : base(progressPercentage, userToken)
		{
			this.BytesReceived = bytesReceived;
			this.TotalBytesToReceive = totalBytesToReceive;
			this.BytesSent = bytesSent;
			this.TotalBytesToSend = totalBytesToSend;
		}

		/// <summary>Возвращает максимальное число полученных байтов.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество полученных байтов.</returns>
		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x000A51D9 File Offset: 0x000A33D9
		public long BytesReceived { get; }

		/// <summary>Возвращает общее количество байтов в операции по выгрузки данных посредством <see cref="T:System.Net.WebClient" />.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество байтов, которое будет получено.</returns>
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x000A51E1 File Offset: 0x000A33E1
		public long TotalBytesToReceive { get; }

		/// <summary>Возвращает максимальное число отправленных байтов.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество отправленных байтов.</returns>
		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002FCD RID: 12237 RVA: 0x000A51E9 File Offset: 0x000A33E9
		public long BytesSent { get; }

		/// <summary>Возвращает общее количество отправляемых байтов.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество байтов, которое будет отправлено.</returns>
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000A51F1 File Offset: 0x000A33F1
		public long TotalBytesToSend { get; }

		// Token: 0x06002FCF RID: 12239 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal UploadProgressChangedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
