using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.IConnectionPoint" />.</summary>
	// Token: 0x02000756 RID: 1878
	[Obsolete]
	[Guid("b196b286-bab4-101a-b69c-00aa00341d07")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface UCOMIConnectionPoint
	{
		/// <summary>Возвращает IID выходящего интерфейса, управляемого с использованием этой точки подключения.</summary>
		/// <param name="pIID">При удачном возвращении содержит IID исходящего интерфейса, управляемого при помощи этой точки подключения.</param>
		// Token: 0x06004253 RID: 16979
		void GetConnectionInterface(out Guid pIID);

		/// <summary>Извлекает указатель интерфейса <see langword="IConnectionPointContainer" /> на доступный для соединения объект, которому принадлежит эта точка подключения.</summary>
		/// <param name="ppCPC">При удачном возвращении содержит интерфейс <see langword="IConnectionPointContainer" /> объекта, доступного для подключения.</param>
		// Token: 0x06004254 RID: 16980
		void GetConnectionPointContainer(out UCOMIConnectionPointContainer ppCPC);

		/// <summary>Устанавливает вспомогательное соединение между точкой подключения и объектом приемника вызывающего оператора.</summary>
		/// <param name="pUnkSink">Ссылка на приемник для получения вызовов исходящего интерфейса, управляемого с использованием этой точки подключения.</param>
		/// <param name="pdwCookie">При удачном возвращении содержит файл Cookie подключения.</param>
		// Token: 0x06004255 RID: 16981
		void Advise([MarshalAs(UnmanagedType.Interface)] object pUnkSink, out int pdwCookie);

		/// <summary>Завершает вспомогательное подключение, установленное ранее при помощи <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		/// <param name="dwCookie">Файл Cookie подключения, возвращенный ранее из <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</param>
		// Token: 0x06004256 RID: 16982
		void Unadvise(int dwCookie);

		/// <summary>Создает объект-перечислитель для итерации по соединениям, существующим для этой точки подключения.</summary>
		/// <param name="ppEnum">При удачном возвращении содержит созданный перечислитель.</param>
		// Token: 0x06004257 RID: 16983
		void EnumConnections(out UCOMIEnumConnections ppEnum);
	}
}
