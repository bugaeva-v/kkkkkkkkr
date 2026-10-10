using System;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
	/// <summary>Представляет определенный способ разделения источника данных на несколько разделов.</summary>
	/// <typeparam name="TSource">Тип элементов коллекции.</typeparam>
	// Token: 0x02000A66 RID: 2662
	public abstract class Partitioner<TSource>
	{
		/// <summary>Делит базовую коллекцию на указанное число разделов.</summary>
		/// <param name="partitionCount">Число создаваемых разделов.</param>
		/// <returns>Список, содержащий перечислители <paramref name="partitionCount" />.</returns>
		// Token: 0x06005F90 RID: 24464
		public abstract IList<IEnumerator<TSource>> GetPartitions(int partitionCount);

		/// <summary>Получает значение, определяющее, могут ли быть динамически созданы дополнительные разделы.</summary>
		/// <returns>
		///   <see langword="true" /> Если <see cref="T:System.Collections.Concurrent.Partitioner`1" /> может динамически создавать разделы по запросу; <see langword="false" /> Если <see cref="T:System.Collections.Concurrent.Partitioner`1" /> может только статически выделять разделы.</returns>
		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005F91 RID: 24465 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool SupportsDynamicPartitions
		{
			get
			{
				return false;
			}
		}

		/// <summary>Создает объект, который может разделить базовую коллекцию на переменное число разделов.</summary>
		/// <returns>Объект, который может создать разделы в базовом источнике данных.</returns>
		/// <exception cref="T:System.NotSupportedException">Создание динамических разделов не поддерживается базовым классом. Это необходимо реализовать в производном классе.</exception>
		// Token: 0x06005F92 RID: 24466 RVA: 0x00140FF1 File Offset: 0x0013F1F1
		public virtual IEnumerable<TSource> GetDynamicPartitions()
		{
			throw new NotSupportedException("Dynamic partitions are not supported by this partitioner.");
		}
	}
}
