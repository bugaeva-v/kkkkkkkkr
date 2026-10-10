using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет коллекцию конструкторов.</summary>
	// Token: 0x02000450 RID: 1104
	public class DesignerCollection : ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerCollection" />, содержащий указанные конструкторы.</summary>
		/// <param name="designers">Сохраняемый массив объектов <see cref="T:System.ComponentModel.Design.IDesignerHost" />.</param>
		// Token: 0x060023E4 RID: 9188 RVA: 0x00081790 File Offset: 0x0007F990
		public DesignerCollection(IDesignerHost[] designers)
		{
			if (designers != null)
			{
				this._designers = new ArrayList(designers);
				return;
			}
			this._designers = new ArrayList();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.DesignerCollection" />, содержащий указанный набор конструкторов.</summary>
		/// <param name="designers">Список, содержащий добавляемую коллекцию конструкторов.</param>
		// Token: 0x060023E5 RID: 9189 RVA: 0x000817B3 File Offset: 0x0007F9B3
		public DesignerCollection(IList designers)
		{
			this._designers = designers;
		}

		/// <summary>Возвращает число конструкторов в коллекции.</summary>
		/// <returns>Число конструкторов в коллекции.</returns>
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000817C2 File Offset: 0x0007F9C2
		public int Count
		{
			get
			{
				return this._designers.Count;
			}
		}

		/// <summary>Возвращает конструктор по указанному индексу.</summary>
		/// <param name="index">Индекс возвращаемого конструктора.</param>
		/// <returns>Конструктор по указанному индексу.</returns>
		// Token: 0x17000744 RID: 1860
		public virtual IDesignerHost this[int index]
		{
			get
			{
				return (IDesignerHost)this._designers[index];
			}
		}

		/// <summary>Возвращает новый перечислитель для данной коллекции.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" />, обеспечивающий перечисление коллекции.</returns>
		// Token: 0x060023E8 RID: 9192 RVA: 0x000817E2 File Offset: 0x0007F9E2
		public IEnumerator GetEnumerator()
		{
			return this._designers.GetEnumerator();
		}

		/// <summary>Возвращает количество элементов, содержащихся в коллекции.</summary>
		/// <returns>Количество элементов в коллекции.</returns>
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000817EF File Offset: 0x0007F9EF
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00002F6A File Offset: 0x0000116A
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Копирует элементы коллекции в <see cref="T:System.Array" /> начиная с определенного индекса в <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является конечным массивом для элементов, скопированных из коллекции. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x060023EC RID: 9196 RVA: 0x000817F7 File Offset: 0x0007F9F7
		void ICollection.CopyTo(Array array, int index)
		{
			this._designers.CopyTo(array, index);
		}

		/// <summary>Возвращает новый перечислитель для данной коллекции.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" />, обеспечивающий перечисление коллекции.</returns>
		// Token: 0x060023ED RID: 9197 RVA: 0x00081806 File Offset: 0x0007FA06
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040010C4 RID: 4292
		private IList _designers;
	}
}
