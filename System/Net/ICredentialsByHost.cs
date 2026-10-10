using System;

namespace System.Net
{
	/// <summary>Предоставляет интерфейс для извлечения учетных данных для узла, порта и типа проверки подлинности.</summary>
	// Token: 0x020005D7 RID: 1495
	public interface ICredentialsByHost
	{
		/// <summary>Возвращает учетные данные для указанного узла, порта и протокола проверки подлинности.</summary>
		/// <param name="host">узел, проверяющий подлинность клиента.</param>
		/// <param name="port">Порт на <paramref name="host" />, с которым клиент будет устанавливать связь.</param>
		/// <param name="authenticationType">Протокол проверки подлинности.</param>
		/// <returns>Учетные данные <see cref="T:System.Net.NetworkCredential" /> для указанного узла, порта и протокола проверки подлинности или значение <see langword="null" />, если для указанных узла, порта и протокола проверки подлинности не определены учетные данные.</returns>
		// Token: 0x0600302A RID: 12330
		NetworkCredential GetCredential(string host, int port, string authenticationType);
	}
}
