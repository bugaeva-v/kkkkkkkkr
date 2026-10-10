using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Работает в очередях компонентов при неправильной обработке серверных ошибок воспроизведения и ошибок клиентов в механизме доставки очереди сообщений.</summary>
	// Token: 0x02000021 RID: 33
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("51372AFD-CAE7-11CF-BE81-00AA00A2FA25")]
	[ComImport]
	public interface IPlaybackControl
	{
		/// <summary>Оповещает компонент обработчика исключений клиента о том, что все попытки очереди сообщений по доставке сообщения на сервер были отклонены, и сообщение оборвалось в очереди недоставленных сообщений об активных транзакциях клиента.</summary>
		// Token: 0x06000072 RID: 114
		void FinalClientRetry();

		/// <summary>Оповещает реализацию класса исключений сервера о том, что все попытки воспроизведения отложенной активации для сервера не были выполнены, и сообщение будет перемещено в очередь для окончательного хранения.</summary>
		// Token: 0x06000073 RID: 115
		void FinalServerRetry();
	}
}
