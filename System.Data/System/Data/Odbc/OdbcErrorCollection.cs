using System;
using System.Collections;

namespace System.Data.Odbc
{
	/// <summary>Собирает все ошибки, создаваемые <see cref="T:System.Data.Odbc.OdbcDataAdapter" />. Этот класс не наследуется.</summary>
	// Token: 0x020002E8 RID: 744
	[Serializable]
	public sealed class OdbcErrorCollection : ICollection, IEnumerable
	{
		// Token: 0x06002102 RID: 8450 RVA: 0x0009A54A File Offset: 0x0009874A
		internal OdbcErrorCollection()
		{
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x00005696 File Offset: 0x00003896
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00006D64 File Offset: 0x00004F64
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает число ошибок в коллекции.</summary>
		/// <returns>Общее число ошибок в коллекции.</returns>
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0009A55D File Offset: 0x0009875D
		public int Count
		{
			get
			{
				return this._items.Count;
			}
		}

		/// <summary>Возвращает ошибку с указанным индексом.</summary>
		/// <param name="i">Начинающийся с нуля индекс извлекаемой ошибки.</param>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcError" />, содержащий ошибку с указанным индексом.</returns>
		// Token: 0x170005EA RID: 1514
		public OdbcError this[int i]
		{
			get
			{
				return (OdbcError)this._items[i];
			}
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0009A57D File Offset: 0x0009877D
		internal void Add(OdbcError error)
		{
			this._items.Add(error);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> в массив, начиная с заданного индекса внутри массива.</summary>
		/// <param name="array">Массив, в который копируются элементы.</param>
		/// <param name="i">Начальный индекс массива <paramref name="array" />.</param>
		/// <exception cref="T:System.ArgumentException">Сумма значений <paramref name="index" /> и количество элементов в коллекции <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> больше длины массива.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Индекс <paramref name="index" /> является недопустимым для массива <paramref name="array" />.</exception>
		// Token: 0x06002108 RID: 8456 RVA: 0x0009A58C File Offset: 0x0009878C
		public void CopyTo(Array array, int i)
		{
			this._items.CopyTo(array, i);
		}

		/// <summary>Копирует все элементы текущей коллекции <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> в указанную коллекцию <see cref="T:System.Data.Odbc.OdbcErrorCollection" />, начиная с указанного индекса в коллекции назначения.</summary>
		/// <param name="array">Коллекция <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> — назначение для элементов, копируемых из текущей коллекции <see cref="T:System.Data.Odbc.OdbcErrorCollection" />.</param>
		/// <param name="i">32-разрядное целое число, представляющее индекс в коллекции <see cref="T:System.Data.Odbc.OdbcErrorCollection" />, с которого начинается копирование.</param>
		// Token: 0x06002109 RID: 8457 RVA: 0x0009A58C File Offset: 0x0009878C
		public void CopyTo(OdbcError[] array, int i)
		{
			this._items.CopyTo(array, i);
		}

		/// <summary>Возвращает объект, который реализует интерфейс <see cref="T:System.Collections.IEnumerator" /> и который может выполнять итерацию объектов <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> в <see cref="T:System.Data.Odbc.OdbcErrorCollection" />.</summary>
		/// <returns>Объект, который реализует интерфейс <see cref="T:System.Collections.IEnumerator" /> и который может выполнять итерацию объектов <see cref="T:System.Data.Odbc.OdbcErrorCollection" /> в <see cref="T:System.Data.Odbc.OdbcErrorCollection" />.</returns>
		// Token: 0x0600210A RID: 8458 RVA: 0x0009A59B File Offset: 0x0009879B
		public IEnumerator GetEnumerator()
		{
			return this._items.GetEnumerator();
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0009A5A8 File Offset: 0x000987A8
		internal void SetSource(string Source)
		{
			foreach (object obj in this._items)
			{
				((OdbcError)obj).SetSource(Source);
			}
		}

		// Token: 0x040017BA RID: 6074
		private ArrayList _items = new ArrayList();
	}
}
