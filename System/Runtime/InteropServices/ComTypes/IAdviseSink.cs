using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Предоставляет управляемое определение интерфейса <see langword="IAdviseSink" />.</summary>
	// Token: 0x0200018B RID: 395
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010F-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IAdviseSink
	{
		/// <summary>Уведомляет все зарегистрированные приемники уведомлений о том, что объект перешел из состояния выполнения в состояние загруженности.  Этот метод вызывается сервером.</summary>
		// Token: 0x06000A70 RID: 2672
		[PreserveSig]
		void OnClose();

		/// <summary>Уведомляет все зарегистрированные в данный момент приемники уведомлений объектов данных, что объект изменился.</summary>
		/// <param name="format">
		///   <see cref="T:System.Runtime.InteropServices.ComTypes.FORMATETC" />, переданный ссылкой, который описывает формат, целевое устройство, отрисовку и сведения о хранении для вызывающего объекта данных.</param>
		/// <param name="stgmedium">
		///   <see cref="T:System.Runtime.InteropServices.ComTypes.STGMEDIUM" />, переданный ссылкой, который определяет среду хранения (глобальная память, файл на диске, объект хранилища, объект потока, объект интерфейса графических устройство (GDI) или неопределенная) и владение этой средой для вызывающего объекта данных.</param>
		// Token: 0x06000A71 RID: 2673
		[PreserveSig]
		void OnDataChange([In] ref FORMATETC format, [In] ref STGMEDIUM stgmedium);

		/// <summary>Уведомляет все зарегистрированные приемники уведомлений, что объект был переименован. Этот метод вызывается сервером.</summary>
		/// <param name="moniker">Указатель на интерфейс <see langword="IMoniker" /> на новом полном моникере объекта.</param>
		// Token: 0x06000A72 RID: 2674
		[PreserveSig]
		void OnRename(IMoniker moniker);

		/// <summary>Уведомляет все зарегистрированные приемники уведомлений, что объект был сохранен. Этот метод вызывается сервером.</summary>
		// Token: 0x06000A73 RID: 2675
		[PreserveSig]
		void OnSave();

		/// <summary>Уведомляет зарегистрированные приемники уведомлений объекта, что его представление изменилось. Этот метод вызывается сервером.</summary>
		/// <param name="aspect">Аспект, или представление, объекта. Содержит значение, взятое из перечисления <see cref="T:System.Runtime.InteropServices.ComTypes.DVASPECT" />.</param>
		/// <param name="index">Часть представления, которое изменилось. В настоящий момент действительно только значение -1.</param>
		// Token: 0x06000A74 RID: 2676
		[PreserveSig]
		void OnViewChange(int aspect, int index);
	}
}
