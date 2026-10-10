using System;

namespace System.Collections.Generic
{
	/// <summary>Определяет пару «ключ-значение», которая может быть задана или получена.</summary>
	/// <typeparam name="TKey">Тип ключа.</typeparam>
	/// <typeparam name="TValue">Тип значения.</typeparam>
	// Token: 0x02000AA2 RID: 2722
	[Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Collections.Generic.KeyValuePair`2" /> с использованием указанных ключа и значения.</summary>
		/// <param name="key">Объект, определенный в каждой паре "ключ-значение".</param>
		/// <param name="value">Описание, связанное с параметром <paramref name="key" />.</param>
		// Token: 0x0600613D RID: 24893 RVA: 0x0014527F File Offset: 0x0014347F
		public KeyValuePair(TKey key, TValue value)
		{
			this.key = key;
			this.value = value;
		}

		/// <summary>Возвращает ключ из пары "ключ-значение".</summary>
		/// <returns>
		///   <typeparamref name="TKey" /> — ключ из структуры <see cref="T:System.Collections.Generic.KeyValuePair`2" />.</returns>
		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600613E RID: 24894 RVA: 0x0014528F File Offset: 0x0014348F
		public TKey Key
		{
			get
			{
				return this.key;
			}
		}

		/// <summary>Возвращает значение из пары "ключ-значение".</summary>
		/// <returns>
		///   <typeparamref name="TValue" /> — значение из структуры <see cref="T:System.Collections.Generic.KeyValuePair`2" />.</returns>
		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x00145297 File Offset: 0x00143497
		public TValue Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Возвращает строковое представление структуры <see cref="T:System.Collections.Generic.KeyValuePair`2" />, используя строковые представления ключа и значения.</summary>
		/// <returns>Строковое представление структуры <see cref="T:System.Collections.Generic.KeyValuePair`2" />, включающее строковые представления ключа и значения.</returns>
		// Token: 0x06006140 RID: 24896 RVA: 0x0014529F File Offset: 0x0014349F
		public override string ToString()
		{
			return KeyValuePair.PairToString(this.Key, this.Value);
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x001452BC File Offset: 0x001434BC
		public void Deconstruct(out TKey key, out TValue value)
		{
			key = this.Key;
			value = this.Value;
		}

		// Token: 0x040039E6 RID: 14822
		private readonly TKey key;

		// Token: 0x040039E7 RID: 14823
		private readonly TValue value;
	}
}
