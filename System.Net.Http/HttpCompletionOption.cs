using System;

namespace System.Net.Http
{
	/// <summary>Указывает, должны ли операции <see cref="T:System.Net.Http.HttpClient" /> считаться завершенными, как только имеется отклик, или после чтения всего сообщения отклика, включая содержимое.</summary>
	// Token: 0x0200001E RID: 30
	public enum HttpCompletionOption
	{
		/// <summary>Операция должна завершиться после считывания всего отклика, включая содержимое.</summary>
		// Token: 0x0400008D RID: 141
		ResponseContentRead,
		/// <summary>Операция должна завершиться сразу после того, как отклик станет доступен и будут считаны заголовки. Содержимое еще не прочитано.</summary>
		// Token: 0x0400008E RID: 142
		ResponseHeadersRead
	}
}
