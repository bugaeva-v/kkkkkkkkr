using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer" />.</summary>
	// Token: 0x02000757 RID: 1879
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b196b284-bab4-101a-b69c-00aa00341d07")]
	[Obsolete]
	[ComImport]
	public interface UCOMIConnectionPointContainer
	{
		/// <summary>Создает перечислитель всех точек подключения, поддерживаемых в объекте, доступном для соединения, по одной точке подключения для каждого идентификатора IID.</summary>
		/// <param name="ppEnum">При удачном возвращении содержит указатель интерфейса на перечислитель.</param>
		// Token: 0x06004258 RID: 16984
		void EnumConnectionPoints(out UCOMIEnumConnectionPoints ppEnum);

		/// <summary>Запрашивает у доступного для соединения объекта наличие точки подключения для определенного IID, и, если она имеется, возвращает указатель интерфейса <see langword="IConnectionPoint" /> на эту точку подключения.</summary>
		/// <param name="riid">Ссылка на идентификатор IID исходящего интерфейса, для которого запрашивается точка подключения.</param>
		/// <param name="ppCP">При удачном возвращении содержит точку подключения, управляющую исходящим интерфейсом <paramref name="riid" />.</param>
		// Token: 0x06004259 RID: 16985
		void FindConnectionPoint(ref Guid riid, out UCOMIConnectionPoint ppCP);
	}
}
