using System;
using System.ComponentModel;

namespace System.Net.Sockets
{
	/// <summary>Указывает метод для загрузки файла политики клиентского доступа.</summary>
	// Token: 0x020007B1 RID: 1969
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum SocketClientAccessPolicyProtocol
	{
		/// <summary>Файл политики сокетов загружается с помощью настраиваемого протокола TCP на TCP-порте 943.</summary>
		// Token: 0x04002531 RID: 9521
		Tcp,
		/// <summary>Файл политики сокетов загружается с помощью протокола HTTP на TCP-порте 943.</summary>
		// Token: 0x04002532 RID: 9522
		Http
	}
}
