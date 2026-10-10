using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет механизм обратного вызова для преобразователя сборок, сообщающий вызывающему объекту состояние преобразования и вовлекающий вызывающий объект в процесс преобразования.</summary>
	// Token: 0x02000743 RID: 1859
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f1c3bf77-c3e4-11d3-88e7-00902754c43a")]
	public interface ITypeLibExporterNotifySink
	{
		/// <summary>Сообщает вызывающему объекту о том, что в процессе преобразования сборки произошло событие.</summary>
		/// <param name="eventKind">Значение <see cref="T:System.Runtime.InteropServices.ExporterEventKind" />, указывающее тип события.</param>
		/// <param name="eventCode">Указывает дополнительные сведения о событии.</param>
		/// <param name="eventMsg">Сообщение, созданное событием.</param>
		// Token: 0x06004143 RID: 16707
		void ReportEvent(ExporterEventKind eventKind, int eventCode, string eventMsg);

		/// <summary>Запрашивает у пользователя разрешение ссылки на другую сборку.</summary>
		/// <param name="assembly">Сборка, которую необходимо разрешить.</param>
		/// <returns>Библиотека типов для <paramref name="assembly" />.</returns>
		// Token: 0x06004144 RID: 16708
		[return: MarshalAs(UnmanagedType.Interface)]
		object ResolveRef(Assembly assembly);
	}
}
