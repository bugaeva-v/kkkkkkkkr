using System;

namespace System.Runtime.Serialization
{
	/// <summary>Указывает на необходимость уведомления класса о завершении десериализации всего графа объектов. Обратите внимание, что этот интерфейс не вызывается при десериализации с помощью XmlSerializer (System.Xml.Serialization.XmlSerializer).</summary>
	// Token: 0x02000647 RID: 1607
	public interface IDeserializationCallback
	{
		/// <summary>Выполняется, когда полностью десериализован граф объектов.</summary>
		/// <param name="sender">Объект, который инициализирует обратный вызов. Данная функциональная возможность для этого параметра в настоящее время не реализуется.</param>
		// Token: 0x06003C3B RID: 15419
		void OnDeserialization(object sender);
	}
}
