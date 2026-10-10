using System;
using System.ComponentModel;
using Unity;

namespace System.Net
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> объекта <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x020005BF RID: 1471
	public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x06002FC6 RID: 12230 RVA: 0x000A5187 File Offset: 0x000A3387
		internal DownloadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesReceived, long totalBytesToReceive) : base(progressPercentage, userToken)
		{
			this.BytesReceived = bytesReceived;
			this.TotalBytesToReceive = totalBytesToReceive;
		}

		/// <summary>Возвращает максимальное число полученных байтов.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество полученных байтов.</returns>
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002FC7 RID: 12231 RVA: 0x000A51A0 File Offset: 0x000A33A0
		public long BytesReceived { get; }

		/// <summary>Возвращает общее количество байтов в операции по загрузке данных посредством <see cref="T:System.Net.WebClient" />.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое указывает количество байтов, которое будет получено.</returns>
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x000A51A8 File Offset: 0x000A33A8
		public long TotalBytesToReceive { get; }

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal DownloadProgressChangedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
