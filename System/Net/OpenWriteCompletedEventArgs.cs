using System;
using System.ComponentModel;
using System.IO;
using Unity;

namespace System.Net
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Net.WebClient.OpenWriteCompleted" />.</summary>
	// Token: 0x020005B8 RID: 1464
	public class OpenWriteCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06002FB1 RID: 12209 RVA: 0x000A50A0 File Offset: 0x000A32A0
		internal OpenWriteCompletedEventArgs(Stream result, Exception exception, bool cancelled, object userToken) : base(exception, cancelled, userToken)
		{
			this._result = result;
		}

		/// <summary>Возвращает доступный для записи поток, который используется для отправки данных на сервер.</summary>
		/// <returns>Поток <see cref="T:System.IO.Stream" />, куда можно записывать выгружаемые данные.</returns>
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000A50B3 File Offset: 0x000A32B3
		public Stream Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal OpenWriteCompletedEventArgs()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001A46 RID: 6726
		private readonly Stream _result;
	}
}
