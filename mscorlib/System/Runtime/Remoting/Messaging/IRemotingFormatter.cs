using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Предоставляет интерфейс удаленного вызова процедур (RPC) для всех модулей форматирования.</summary>
	// Token: 0x02000621 RID: 1569
	[ComVisible(true)]
	public interface IRemotingFormatter : IFormatter
	{
		/// <summary>Начинает процесс десериализации удаленного вызова процедуры (RPC).</summary>
		/// <param name="serializationStream">
		///   <see cref="T:System.IO.Stream" />, из которого десериализуются данные.</param>
		/// <param name="handler">Делегат, предназначенный для обработки объектов <see cref="T:System.Runtime.Remoting.Messaging.Header" />. Может иметь значение <see langword="null" />.</param>
		/// <returns>Корень десериализованного графа объектов.</returns>
		// Token: 0x06003B12 RID: 15122
		object Deserialize(Stream serializationStream, HeaderHandler handler);

		/// <summary>Запускает процесс сериализации удаленного вызова процедуры (RPC).</summary>
		/// <param name="serializationStream">
		///   <see cref="T:System.IO.Stream" />, в который сериализуется заданный граф.</param>
		/// <param name="graph">Корень сериализуемого графа объектов.</param>
		/// <param name="headers">Массив объектов <see cref="T:System.Runtime.Remoting.Messaging.Header" /> для передачи с графом, заданным параметром <paramref name="graph" />. Может иметь значение <see langword="null" />.</param>
		// Token: 0x06003B13 RID: 15123
		void Serialize(Stream serializationStream, object graph, Header[] headers);
	}
}
