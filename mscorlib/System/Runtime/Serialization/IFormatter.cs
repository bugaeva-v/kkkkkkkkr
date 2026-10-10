using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Предоставляет функциональные возможности для форматирования сериализованных объектов.</summary>
	// Token: 0x0200065E RID: 1630
	[ComVisible(true)]
	public interface IFormatter
	{
		/// <summary>Десериализует данные в предоставленный поток и воспроизводит граф объектов.</summary>
		/// <param name="serializationStream">Поток, содержащий десериализуемые данные.</param>
		/// <returns>Верхний объект десериализованного графа.</returns>
		// Token: 0x06003CDA RID: 15578
		object Deserialize(Stream serializationStream);

		/// <summary>Сериализует объект или граф объектов с заданным корнем в предоставляемом потоке.</summary>
		/// <param name="serializationStream">Поток, в который модуль форматирования помещает сериализованные данные. Этот поток способен ссылаться на многочисленные резервные хранилища (файлы, сеть, память и т.д.).</param>
		/// <param name="graph">Объект или корень графа объекта для сериализации. Все дочерние объекты этого корневого объекта сериализуются автоматически.</param>
		// Token: 0x06003CDB RID: 15579
		void Serialize(Stream serializationStream, object graph);

		/// <summary>Возвращает или задает <see cref="T:System.Runtime.Serialization.SurrogateSelector" />, используемый текущим форматером.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Serialization.SurrogateSelector" />, используемый этим модулем форматирования.</returns>
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06003CDC RID: 15580
		// (set) Token: 0x06003CDD RID: 15581
		ISurrogateSelector SurrogateSelector { get; set; }

		/// <summary>Возвращает или задает <see cref="T:System.Runtime.Serialization.SerializationBinder" />, который выполняет поиск типа во время десериализации.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Serialization.SerializationBinder" />, который выполняет поиск типа во время десериализации.</returns>
		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06003CDE RID: 15582
		// (set) Token: 0x06003CDF RID: 15583
		SerializationBinder Binder { get; set; }

		/// <summary>Возвращает или задает <see cref="T:System.Runtime.Serialization.StreamingContext" />, используемый для сериализации и десериализации.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Serialization.StreamingContext" />, используемый для сериализации и десериализации.</returns>
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06003CE0 RID: 15584
		// (set) Token: 0x06003CE1 RID: 15585
		StreamingContext Context { get; set; }
	}
}
