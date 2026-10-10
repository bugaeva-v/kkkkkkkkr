using System;

namespace System.Net
{
	/// <summary>Представляет метод, указывающий локальный IP-адрес и номер порта для точки обслуживания <see cref="T:System.Net.ServicePoint" />.</summary>
	/// <param name="servicePoint">Точка обслуживания <see cref="T:System.Net.ServicePoint" />, связанная с создаваемым подключением.</param>
	/// <param name="remoteEndPoint">Удаленная точка <see cref="T:System.Net.IPEndPoint" />, указывающая удаленный узел.</param>
	/// <param name="retryCount">Количество вызовов этого делегата для определенного подключения.</param>
	/// <returns>Локальная точка <see cref="T:System.Net.IPEndPoint" />, с которой связана точка обслуживания <see cref="T:System.Net.ServicePoint" />.</returns>
	// Token: 0x0200066B RID: 1643
	// (Invoke) Token: 0x060033DC RID: 13276
	public delegate IPEndPoint BindIPEndPoint(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount);
}
