using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IConnectionPointContainer" />.</summary>
	// Token: 0x0200079D RID: 1949
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
	[ComImport]
	public interface IConnectionPointContainer
	{
		/// <summary>Создает перечислитель всех точек подключения, поддерживаемых в объекте, доступном для соединения, по одной точке подключения для каждого идентификатора IID.</summary>
		/// <param name="ppEnum">При возвращении данного метода содержит указатель интерфейса перечислителя. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044F9 RID: 17657
		void EnumConnectionPoints(out IEnumConnectionPoints ppEnum);

		/// <summary>Запрашивает у доступного для соединения объекта наличие точки подключения для определенного IID, и, если она имеется, возвращает указатель интерфейса <see langword="IConnectionPoint" /> на эту точку подключения.</summary>
		/// <param name="riid">Ссылка на идентификатор IID исходящего интерфейса, для которого запрашивается точка подключения.</param>
		/// <param name="ppCP">При возвращении данного метода содержит точку подключения, управляющую <paramref name="riid" /> выходящего интерфейса. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044FA RID: 17658
		void FindConnectionPoint([In] ref Guid riid, out IConnectionPoint ppCP);
	}
}
