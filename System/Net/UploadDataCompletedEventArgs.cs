using System;
using System.ComponentModel;
using Unity;

namespace System.Net
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Net.WebClient.UploadDataCompleted" />.</summary>
	// Token: 0x020005BC RID: 1468
	public class UploadDataCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06002FBD RID: 12221 RVA: 0x000A5124 File Offset: 0x000A3324
		internal UploadDataCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken) : base(exception, cancelled, userToken)
		{
			this._result = result;
		}

		/// <summary>Возвращает ответ сервера на операцию отправки данных, начатую посредством вызова метода <see cref="Overload:System.Net.WebClient.UploadDataAsync" />.</summary>
		/// <returns>Массив <see cref="T:System.Byte" />, содержащий ответ сервера.</returns>
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000A5137 File Offset: 0x000A3337
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal UploadDataCompletedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001A4A RID: 6730
		private readonly byte[] _result;
	}
}
