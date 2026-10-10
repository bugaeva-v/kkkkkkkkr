using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Предоставляет механизм обратного вызова для преобразователя библиотеки типов, сообщающий вызывающему объекту состояние преобразования и вовлекающий вызывающий объект в процесс преобразования.</summary>
	// Token: 0x02000744 RID: 1860
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[Guid("f1c3bf76-c3e4-11d3-88e7-00902754c43a")]
	public interface ITypeLibImporterNotifySink
	{
		/// <summary>Сообщает вызывающему объекту о том, что в процессе преобразования библиотеки типов произошло событие.</summary>
		/// <param name="eventKind">Значение <see cref="T:System.Runtime.InteropServices.ImporterEventKind" />, показывающее тип события.</param>
		/// <param name="eventCode">Указывает дополнительные сведения о событии.</param>
		/// <param name="eventMsg">Сообщение, созданное событием.</param>
		// Token: 0x06004145 RID: 16709
		void ReportEvent(ImporterEventKind eventKind, int eventCode, string eventMsg);

		/// <summary>Запрашивает у пользователя разрешение ссылки на другую библиотеку типов.</summary>
		/// <param name="typeLib">Объект, реализующий интерфейс <see langword="ITypeLib" />, для которого необходимо выполнить разрешение.</param>
		/// <returns>Сборка, соответствующая <paramref name="typeLib" />.</returns>
		// Token: 0x06004146 RID: 16710
		Assembly ResolveRef([MarshalAs(UnmanagedType.Interface)] object typeLib);
	}
}
