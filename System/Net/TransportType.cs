using System;

namespace System.Net
{
	/// <summary>Определяет типы транспорта для классов <see cref="T:System.Net.SocketPermission" /> и <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x02000604 RID: 1540
	public enum TransportType
	{
		/// <summary>Транспорт UDP.</summary>
		// Token: 0x04001C3B RID: 7227
		Udp = 1,
		/// <summary>Тип транспорта без установления соединения, например UDP. Указание этого значения равнозначно указанию <see cref="F:System.Net.TransportType.Udp" />.</summary>
		// Token: 0x04001C3C RID: 7228
		Connectionless = 1,
		/// <summary>Транспорт TCP.</summary>
		// Token: 0x04001C3D RID: 7229
		Tcp,
		/// <summary>Тип транспорта ориентирован на установление подключения, например TCP. Указание этого значения равнозначно указанию <see cref="F:System.Net.TransportType.Tcp" />.</summary>
		// Token: 0x04001C3E RID: 7230
		ConnectionOriented = 2,
		/// <summary>Все типы транспорта.</summary>
		// Token: 0x04001C3F RID: 7231
		All
	}
}
