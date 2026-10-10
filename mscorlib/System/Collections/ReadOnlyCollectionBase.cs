using System;

namespace System.Collections
{
	/// <summary>Предоставляет базовый класс <see langword="abstract" /> для строго типизированной неуниверсальной коллекции только для чтения.</summary>
	// Token: 0x02000A2B RID: 2603
	[Serializable]
	public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
	{
		/// <summary>Получает список элементов, содержащихся в экземпляре <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</summary>
		/// <returns>Класс <see cref="T:System.Collections.ArrayList" />, предоставляющий экземпляр класса <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</returns>
		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x00136633 File Offset: 0x00134833
		protected ArrayList InnerList
		{
			get
			{
				if (this._list == null)
				{
					this._list = new ArrayList();
				}
				return this._list;
			}
		}

		/// <summary>Получает число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</summary>
		/// <returns>Число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.ReadOnlyCollectionBase" />.  
		/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x0013664E File Offset: 0x0013484E
		public virtual int Count
		{
			get
			{
				return this.InnerList.Count;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, является ли доступ к объекту <see cref="T:System.Collections.ReadOnlyCollectionBase" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к объекту <see cref="T:System.Collections.ReadOnlyCollectionBase" /> является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x0013665B File Offset: 0x0013485B
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.InnerList.IsSynchronized;
			}
		}

		/// <summary>Получает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</returns>
		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x00136668 File Offset: 0x00134868
		object ICollection.SyncRoot
		{
			get
			{
				return this.InnerList.SyncRoot;
			}
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.ReadOnlyCollectionBase" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ReadOnlyCollectionBase" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.ReadOnlyCollectionBase" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.ReadOnlyCollectionBase" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005C42 RID: 23618 RVA: 0x000BCA71 File Offset: 0x000BAC71
		void ICollection.CopyTo(Array array, int index)
		{
			this.InnerList.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, перебирающий элементы экземпляра класса <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" /> для экземпляра класса <see cref="T:System.Collections.ReadOnlyCollectionBase" />.</returns>
		// Token: 0x06005C43 RID: 23619 RVA: 0x00136675 File Offset: 0x00134875
		public virtual IEnumerator GetEnumerator()
		{
			return this.InnerList.GetEnumerator();
		}

		// Token: 0x0400389A RID: 14490
		private ArrayList _list;
	}
}
