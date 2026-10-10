using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IConnectionPoint" />.</summary>
	// Token: 0x0200079C RID: 1948
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B286-BAB4-101A-B69C-00AA00341D07")]
	[ComImport]
	public interface IConnectionPoint
	{
		/// <summary>Возвращает IID выходящего интерфейса, управляемого с использованием этой точки подключения.</summary>
		/// <param name="pIID">При возвращении этого параметра содержит IID выходящего интерфейса, управляемого с использованием данной точки подключения. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044F4 RID: 17652
		void GetConnectionInterface(out Guid pIID);

		/// <summary>Извлекает указатель интерфейса <see langword="IConnectionPointContainer" /> на доступный для соединения объект, которому принадлежит эта точка подключения.</summary>
		/// <param name="ppCPC">При возвращении этого параметра содержит интерфейс <see langword="IConnectionPointContainer" /> объекта, доступного для соединения. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044F5 RID: 17653
		void GetConnectionPointContainer(out IConnectionPointContainer ppCPC);

		/// <summary>Устанавливает вспомогательное соединение между точкой подключения и объектом приемника вызывающего оператора.</summary>
		/// <param name="pUnkSink">Ссылка на приемник для получения вызовов выходящего интерфейса, управляемого с использованием этой точки подключения.</param>
		/// <param name="pdwCookie">При возвращении данного метода содержит файл cookie соединения. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044F6 RID: 17654
		void Advise([MarshalAs(UnmanagedType.Interface)] object pUnkSink, out int pdwCookie);

		/// <summary>Завершает вспомогательное соединение, установленное ранее при помощи метода <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		/// <param name="dwCookie">Файл cookie соединения, возвращенный ранее из метода <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" />.</param>
		// Token: 0x060044F7 RID: 17655
		void Unadvise(int dwCookie);

		/// <summary>Создает объект-перечислитель для итерации по соединениям, существующим для этой точки подключения.</summary>
		/// <param name="ppEnum">При возвращении данного метода содержит только что созданный перечислитель. Этот параметр передается неинициализированным.</param>
		// Token: 0x060044F8 RID: 17656
		void EnumConnections(out IEnumConnections ppEnum);
	}
}
