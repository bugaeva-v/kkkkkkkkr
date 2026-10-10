using System;
using System.Collections.Generic;

namespace System.Collections.Concurrent
{
	/// <summary>Представляет определенный способ разделения упорядочиваемого источника данных на несколько разделов.</summary>
	/// <typeparam name="TSource">Тип элементов коллекции.</typeparam>
	// Token: 0x02000A63 RID: 2659
	public abstract class OrderablePartitioner<TSource> : Partitioner<TSource>
	{
		/// <summary>Вызывается из конструкторов в производных классах для инициализации класса <see cref="T:System.Collections.Concurrent.OrderablePartitioner`1" /> заданными ограничениями ключей индекса.</summary>
		/// <param name="keysOrderedInEachPartition">Указывает, упорядочиваются ли элементы каждого раздела в порядке возрастания ключей.</param>
		/// <param name="keysOrderedAcrossPartitions">Указывает, располагаются ли элементы более раннего раздела всегда перед элементами более позднего раздела. Если значение данного параметра равно true, порядковый ключ каждого элемента раздела 0 меньше порядкового ключа любого элемента раздела 1, порядковый ключ каждого элемента раздела 1 меньше порядкового ключа любого элемента раздела 2 и т. д.</param>
		/// <param name="keysNormalized">Указывает, нормализованы ли ключи. Если значение этого параметра равно true, все порядковые ключи являются несовпадающими целыми числами в диапазоне [0 ... numberOfElements-1]. Если значение равно false, порядковые ключи по-прежнему не должны совпадать, однако учитывается лишь их относительных порядок, а не абсолютные значения.</param>
		// Token: 0x06005F7B RID: 24443 RVA: 0x00140FD4 File Offset: 0x0013F1D4
		protected OrderablePartitioner(bool keysOrderedInEachPartition, bool keysOrderedAcrossPartitions, bool keysNormalized)
		{
			this.KeysOrderedInEachPartition = keysOrderedInEachPartition;
			this.KeysOrderedAcrossPartitions = keysOrderedAcrossPartitions;
			this.KeysNormalized = keysNormalized;
		}

		/// <summary>Делит базовую коллекцию на указанное число упорядочиваемых разделов.</summary>
		/// <param name="partitionCount">Число создаваемых разделов.</param>
		/// <returns>Список, содержащий перечислители <paramref name="partitionCount" />.</returns>
		// Token: 0x06005F7C RID: 24444
		public abstract IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount);

		/// <summary>Создает объект, который может разделить базовую коллекцию на переменное число разделов.</summary>
		/// <returns>Объект, который может создать разделы в базовом источнике данных.</returns>
		/// <exception cref="T:System.NotSupportedException">Создание динамических разделов не поддерживается этим модулем разделения.</exception>
		// Token: 0x06005F7D RID: 24445 RVA: 0x00140FF1 File Offset: 0x0013F1F1
		public virtual IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
		{
			throw new NotSupportedException("Dynamic partitions are not supported by this partitioner.");
		}

		/// <summary>Получает значение, указывающее, упорядочиваются ли элементы каждого раздела в порядке возрастания ключей.</summary>
		/// <returns>
		///   <see langword="true" /> Если в каждом разделе элементы размещены в порядке возрастания ключей; в противном случае <see langword="false" />.</returns>
		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x00140FFD File Offset: 0x0013F1FD
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x00141005 File Offset: 0x0013F205
		public bool KeysOrderedInEachPartition { get; private set; }

		/// <summary>Получает значение, указывающее, располагаются ли элементы более раннего раздела всегда перед элементами более позднего раздела.</summary>
		/// <returns>
		///   <see langword="true" /> Если элементы более раннего раздела всегда находятся перед элементами более позднего раздела; в противном случае <see langword="false" />.</returns>
		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06005F80 RID: 24448 RVA: 0x0014100E File Offset: 0x0013F20E
		// (set) Token: 0x06005F81 RID: 24449 RVA: 0x00141016 File Offset: 0x0013F216
		public bool KeysOrderedAcrossPartitions { get; private set; }

		/// <summary>Получает значение, указывающее, нормализованы ли ключи.</summary>
		/// <returns>
		///   <see langword="true" /> Если ключи нормализованы; в противном случае <see langword="false" />.</returns>
		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x0014101F File Offset: 0x0013F21F
		// (set) Token: 0x06005F83 RID: 24451 RVA: 0x00141027 File Offset: 0x0013F227
		public bool KeysNormalized { get; private set; }

		/// <summary>Делит базовую коллекцию на указанное число упорядоченных разделов.</summary>
		/// <param name="partitionCount">Число создаваемых разделов.</param>
		/// <returns>Список, содержащий перечислители <paramref name="partitionCount" />.</returns>
		// Token: 0x06005F84 RID: 24452 RVA: 0x00141030 File Offset: 0x0013F230
		public override IList<IEnumerator<TSource>> GetPartitions(int partitionCount)
		{
			IList<IEnumerator<KeyValuePair<long, TSource>>> orderablePartitions = this.GetOrderablePartitions(partitionCount);
			if (orderablePartitions.Count != partitionCount)
			{
				throw new InvalidOperationException("GetPartitions returned an incorrect number of partitions.");
			}
			IEnumerator<TSource>[] array = new IEnumerator<TSource>[partitionCount];
			for (int i = 0; i < partitionCount; i++)
			{
				array[i] = new OrderablePartitioner<TSource>.EnumeratorDropIndices(orderablePartitions[i]);
			}
			return array;
		}

		/// <summary>Создает объект, который может разделить базовую коллекцию на переменное число разделов.</summary>
		/// <returns>Объект, который может создать разделы в базовом источнике данных.</returns>
		/// <exception cref="T:System.NotSupportedException">Создание динамических разделов не поддерживается базовым классом. Должен быть реализован в производных классах.</exception>
		// Token: 0x06005F85 RID: 24453 RVA: 0x0014107C File Offset: 0x0013F27C
		public override IEnumerable<TSource> GetDynamicPartitions()
		{
			return new OrderablePartitioner<TSource>.EnumerableDropIndices(this.GetOrderableDynamicPartitions());
		}

		// Token: 0x02000A64 RID: 2660
		private class EnumerableDropIndices : IEnumerable<!0>, IEnumerable, IDisposable
		{
			// Token: 0x06005F86 RID: 24454 RVA: 0x00141089 File Offset: 0x0013F289
			public EnumerableDropIndices(IEnumerable<KeyValuePair<long, TSource>> source)
			{
				this._source = source;
			}

			// Token: 0x06005F87 RID: 24455 RVA: 0x00141098 File Offset: 0x0013F298
			public IEnumerator<TSource> GetEnumerator()
			{
				return new OrderablePartitioner<TSource>.EnumeratorDropIndices(this._source.GetEnumerator());
			}

			// Token: 0x06005F88 RID: 24456 RVA: 0x001410AA File Offset: 0x0013F2AA
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06005F89 RID: 24457 RVA: 0x001410B4 File Offset: 0x0013F2B4
			public void Dispose()
			{
				IDisposable disposable = this._source as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}

			// Token: 0x04003962 RID: 14690
			private readonly IEnumerable<KeyValuePair<long, TSource>> _source;
		}

		// Token: 0x02000A65 RID: 2661
		private class EnumeratorDropIndices : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x06005F8A RID: 24458 RVA: 0x001410D6 File Offset: 0x0013F2D6
			public EnumeratorDropIndices(IEnumerator<KeyValuePair<long, TSource>> source)
			{
				this._source = source;
			}

			// Token: 0x06005F8B RID: 24459 RVA: 0x001410E5 File Offset: 0x0013F2E5
			public bool MoveNext()
			{
				return this._source.MoveNext();
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x06005F8C RID: 24460 RVA: 0x001410F4 File Offset: 0x0013F2F4
			public TSource Current
			{
				get
				{
					KeyValuePair<long, TSource> keyValuePair = this._source.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x06005F8D RID: 24461 RVA: 0x00141114 File Offset: 0x0013F314
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06005F8E RID: 24462 RVA: 0x00141121 File Offset: 0x0013F321
			public void Dispose()
			{
				this._source.Dispose();
			}

			// Token: 0x06005F8F RID: 24463 RVA: 0x0014112E File Offset: 0x0013F32E
			public void Reset()
			{
				this._source.Reset();
			}

			// Token: 0x04003963 RID: 14691
			private readonly IEnumerator<KeyValuePair<long, TSource>> _source;
		}
	}
}
